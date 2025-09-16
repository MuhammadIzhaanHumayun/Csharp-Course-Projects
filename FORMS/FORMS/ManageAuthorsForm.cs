using Library_Management_System.CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.FORMS
{
    public partial class ManageAuthorsForm : Form
    {
        CLASSES.AUTHOR author = new CLASSES.AUTHOR();
        public ManageAuthorsForm()
        {
            InitializeComponent();
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageAuthorsForm_Load(object sender, EventArgs e)
        {
            pictureBox_Author.Image = Image.FromFile("../../../IMAGES/typewriter.png");
            button_Add.Image = Image.FromFile("../../../IMAGES/plus.png");
            button_Edit.Image = Image.FromFile("../../../IMAGES/update.png");
            button_Delete.Image = Image.FromFile("../../../IMAGES/trash.png");
            button_export.Image = Image.FromFile("../../../IMAGES/activity_feed.png");
            button_Show_Author_Books.Image = Image.FromFile("../../../IMAGES/book_stack.png");

            //populate datagridview with authors
            dataGridView_authors.DataSource = author.AuthorsList(false);

            dataGridView_authors.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
            dataGridView_authors.EnableHeadersVisualStyles = false;
            dataGridView_authors.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            dataGridView_authors.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //show the number of Authors
            label_authorsCount.Text = author.AuthorsList(false).Rows.Count.ToString() + " Authors";
        }


        //add new author
        private void button_Add_Click(object sender, EventArgs e)
        {
            string first_name = textBox_fname.Text;
            string last_name = textBox_lname.Text;
            string education = textBox_education.Text;
            string bio = richTextBox_bio.Text;

            //check if the first and last name is empty.
            if (first_name.Trim().Equals("") || last_name.Trim().Equals(""))
            {
                MessageBox.Show("You Need to Enter The Author's First and Last Name", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (author.addAuthor(first_name, last_name, education, bio))
                {
                    MessageBox.Show("New Author Added Successfully", "New Author", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //refresh datagridview
                    dataGridView_authors.DataSource = author.AuthorsList(false);

                    //update the number of Authors
                    label_authorsCount.Text = author.AuthorsList(false).Rows.Count.ToString() + " Authors";
                }
                else
                {
                    MessageBox.Show("Author Not Added", "Add-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }
        //edit author button
        private void button_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_id.Text);
                string first_name = textBox_fname.Text;
                string last_name = textBox_lname.Text;
                string education = textBox_education.Text;
                string bio = richTextBox_bio.Text;

                //check if the first and last name is empty.
                if (first_name.Trim().Equals("") || last_name.Trim().Equals(""))
                {
                    MessageBox.Show("You Need to Enter The Author's First and Last Name", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (author.editAuthor(id, first_name, last_name, education, bio))
                    {
                        MessageBox.Show("The Author Data Has Been Updated Successfully", "Edit Author", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridView_authors.DataSource = author.AuthorsList(false);
                    }
                    else
                    {
                        MessageBox.Show("Author Data Not Updated", "Update-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Author ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView_authors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = dataGridView_authors.CurrentRow.Cells[0].Value.ToString();
            textBox_fname.Text = dataGridView_authors.CurrentRow.Cells[1].Value.ToString();
            textBox_lname.Text = dataGridView_authors.CurrentRow.Cells[2].Value.ToString();
            textBox_education.Text = dataGridView_authors.CurrentRow.Cells[3].Value.ToString();
            richTextBox_bio.Text = dataGridView_authors.CurrentRow.Cells[4].Value.ToString();
        }

        //delete author
        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_id.Text);

                //show a confirmation message before deletion
                if (MessageBox.Show("Do You Really Want To Delete This Genre", "Confirmation Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    if (author.deleteAuthor(id))
                    {
                        MessageBox.Show("The Author Data Has Been Deleted Successfully", "Delete Author", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //clear fields
                        textBox_id.Text = "";
                        textBox_fname.Text = "";
                        textBox_lname.Text = "";
                        textBox_education.Text = "";
                        richTextBox_bio.Text = "";

                        //refresh the authors
                        dataGridView_authors.DataSource = author.AuthorsList(false);
                        //update the number of Authors
                        label_authorsCount.Text = author.AuthorsList(false).Rows.Count.ToString() + " Authors";
                    }
                    else
                    {
                        MessageBox.Show("Author Data Not Deleted", "Delete-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Author ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_Show_Author_Books_Click(object sender, EventArgs e)
        {
            int authorId = Convert.ToInt32(dataGridView_authors.CurrentRow.Cells[0].Value.ToString());
            string fname = dataGridView_authors.CurrentRow.Cells[1].Value.ToString();
            string lname = dataGridView_authors.CurrentRow.Cells[2].Value.ToString();
            string fullname = fname + " " + lname;
            BooksListForm blf = new BooksListForm(authorId, fullname);
            blf.Show();
        }

        //button export authors from  datagridview  to a text file
        private void button_export_Click(object sender, EventArgs e)
        {
            //we will create a folder first
            if (!Directory.Exists(@"C:\authors"))
            {
                Directory.CreateDirectory(@"C:\authors");
            }
            string filePath = @"C:\authors\list.txt";
            if (!File.Exists(filePath))//check if this file exists
            {
                File.Create(filePath);//create the file 
                //MessageBox.Show("File Created");
            }

            //now we need to populate the text file with
            //the authors id and fullname
            TextWriter writer = new StreamWriter(filePath);

            string id;
            string fname;
            string lname;
            string fullname;

            for (int i= 0; i< dataGridView_authors.Rows.Count; i++)// for rows
            {
                /*for(int j = 0; j< dataGridView_authors.Columns.Count; j++)//for columns
                {
                    writer.Write(dataGridView_authors.Rows[i].Cells[j].Value.ToString());
                    writer.Write(" ");
                }*/
                id = dataGridView_authors.Rows[i].Cells[0].Value.ToString();
                fname = dataGridView_authors.Rows[i].Cells[1].Value.ToString();
                lname = dataGridView_authors.Rows[i].Cells[2].Value.ToString();
                fullname = fname+ " " + lname;
                writer.Write(id+ " - "+ fullname);
                writer.WriteLine("");//create a new line
                writer.WriteLine("----------------------------");
            }
            writer.Close();
            MessageBox.Show("Data Exported");
        }
    }
}
