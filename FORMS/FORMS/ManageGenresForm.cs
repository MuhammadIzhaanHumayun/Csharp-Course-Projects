using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Library_Management_System.FORMS
{
    public partial class ManageGenresForm : Form
    {
        public ManageGenresForm()
        {
            InitializeComponent();
        }

        CLASSES.GENRES genre = new CLASSES.GENRES();

        private void ManageGenresForm_Load(object sender, EventArgs e)
        {
            pictureBox_Genre.Image = Image.FromFile("../../../IMAGES/genre_1.png");
            button_Add.Image = Image.FromFile("../../../IMAGES/plus.png");
            button_Edit.Image = Image.FromFile("../../../IMAGES/update.png");
            button_Delete.Image = Image.FromFile("../../../IMAGES/trash.png");

            dataGridView_genres.DataSource = genre.GenresList();
            dataGridView_genres.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
            dataGridView_genres.EnableHeadersVisualStyles = false;
            dataGridView_genres.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 14, FontStyle.Bold);
            dataGridView_genres.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;

            if (name.Trim().Equals(""))
            {
                MessageBox.Show("Enter the Genre name", "Empty Genre", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                 
            }
            else
            {
                if (genre.addGenre(name))
                {
                    MessageBox.Show("New Genre Added Successfully", "New Genre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    dataGridView_genres.DataSource = genre.GenresList();
                }
                else
                {
                    MessageBox.Show("Genre Not Added", "Add-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_id.Text);
                string name = textBox_name.Text;

                if (name.Trim().Equals(""))
                {
                    MessageBox.Show("Enter the Genre name", "Empty Genre", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    
                }
                else
                {
                    if (genre.editGenre(id, name))
                    {
                        MessageBox.Show("New Genre Updated Successfully", "Edit Genre", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dataGridView_genres.DataSource = genre.GenresList();
                    }
                    else
                    {
                        MessageBox.Show("Genre Not Updated", "Edit-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid ID");
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBox_id.Text);

                //show a confirmation message before deletion
                if (MessageBox.Show("Do You Really Want To Delete This Author", "Confirmation Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (genre.deleteGenre(id))
                    {
                        MessageBox.Show("New Deleted Successfully", "delete Genre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //clear fields
                        textBox_id.Text = "";
                        textBox_name.Text = "";

                        dataGridView_genres.DataSource = genre.GenresList();
                    }
                    else
                    {
                        MessageBox.Show("Genre Not Deleted", "delete-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid ID");
            }
        }
        //display the selected genre data in textboxes
        private void dataGridView_genres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = dataGridView_genres.CurrentRow.Cells[0].Value.ToString();
            textBox_name.Text = dataGridView_genres.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
