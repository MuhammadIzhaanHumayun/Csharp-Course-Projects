using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Library_Management_System.CLASSES;
using System.Reflection.Emit;
using System.Runtime.ExceptionServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
//using static System.Net.Mime.MediaTypeNames;

namespace Library_Management_System.FORMS
{
    public partial class ManageBooksForm : Form
    {
        public ManageBooksForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        CLASSES.BOOKS book = new CLASSES.BOOKS();
        CLASSES.GENRES genre = new CLASSES.GENRES();
        CLASSES.AUTHOR author = new CLASSES.AUTHOR();
        private void ManageBooksForm_Load(object sender, EventArgs e)
        {
            pictureBox_Books.Image = Image.FromFile("../../../IMAGES/books.png");
            button_Add.Image = Image.FromFile("../../../IMAGES/plus.png");
            button_Edit.Image = Image.FromFile("../../../IMAGES/update.png");
            button_Select_Cover.Image = Image.FromFile("../../../IMAGES/upload.png");//in add panel
            button_selectCover_Edit.Image = Image.FromFile("../../../IMAGES/upload.png");//in AddPanel
            button_ShowBooksList.Image = Image.FromFile("../../../IMAGES/list.png");
            button_export.Image = Image.FromFile("../../../IMAGES/activity_feed.png");

            //populate combobox with genres (in the add panel)
            CLASSES.GENRES genre = new CLASSES.GENRES();
            comboBox_genre.DataSource = genre.GenresList();
            comboBox_genre.DisplayMember = "name";
            comboBox_genre.ValueMember = "id";



            //show the number of books
            label_booksCount.Text = book.BookList().Rows.Count.ToString() + " Books";

            //show the panel AddPanel
            panel_add.BringToFront();
        }

        private void button_Select_Cover_Click(object sender, EventArgs e)
        {
            //open and browse file
            OpenFileDialog opf = new OpenFileDialog();
            //image types
            opf.Filter = "Choose Image(*.jpg, *.png, *.gif) | *.jpg, *.png, *.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                //display image in picturebox
                pictureBox_cover.Image = Image.FromFile(opf.FileName);
            }
        }

        //show authors list ina  new form
        private void button_SelectAuthor_Click(object sender, EventArgs e)
        {
            AuthorListForm athlsform = new AuthorListForm(this);
            athlsform.Show();
        }

        private void button_addBook_Click(object sender, EventArgs e)
        {
            // add a new book
            int author_id;
            int genre_id;
            int quantity;
            string isbn = textBox_isbn.Text;
            string title = textBox_title.Text;
            double price;
            string publisher = textBox_publisher.Text;
            DateTime date_recieved = dateTimePicker_dateRecieved.Value;
            string description = richTextBox_description.Text;


            MemoryStream ms = new MemoryStream();
            pictureBox_cover.Image.Save(ms, pictureBox_cover.Image.RawFormat);
            byte[] book_cover = ms.ToArray();

            try
            {

                author_id = Convert.ToInt32(label_author_id.Text);
                genre_id = Convert.ToInt32(comboBox_genre.SelectedValue);
                quantity = Convert.ToInt32(numericUpDown_quantity.Value);
                price = Convert.ToInt32(textBox_price.Text);

                if (!book.isIsbnExists(isbn, 0))
                {
                    if (!book.isTitleExists(title, 0))
                    {
                        if (book.addBook(isbn, title, author_id, genre_id, quantity, price, publisher, date_recieved, description, book_cover))
                        {
                            MessageBox.Show("New Book Added Successfully", "New Book", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //refresh the books counter
                            label_booksCount.Text = book.BookList().Rows.Count.ToString() + " Books";
                        }
                        else
                        {
                            MessageBox.Show("Book Not Added", "Add-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This Book Title Already Exist, Enetr A New One", "Duplicate Title", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("This Book ISBN Already Exist, Enetr A New One", "Duplicate ISBN", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data-Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }



        private void button_clearfields_Click(object sender, EventArgs e)
        {
            foreach (var control in panel_add.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    TextBox tb = (TextBox)control;
                    tb.Text = "";
                }
            }

            //set the id into textbox_id
            //we will count the number of books
            int numberOfBooks = book.BookList().Rows.Count;
            int theLastBookId = 0; // not the real value that will be inserted
            if (numberOfBooks > 0)
            {
                theLastBookId = Convert.ToInt32(book.BookList().Rows[numberOfBooks - 1][0].ToString()) + 1;

            }


            textBox_id.Text = Convert.ToString(theLastBookId);

            richTextBox_description.Text = "";
            label_author_id.Text = "ID";
            comboBox_genre.SelectedIndex = 0;
            numericUpDown_quantity.Value = 0;
            dateTimePicker_dateRecieved.Value = DateTime.Now;
            pictureBox_cover.ImageLocation = "../../../IMAGES/Book1.png";
        }
        //show the add panel 
        private void button_Add_Click(object sender, EventArgs e)
        {
            panel_add.BringToFront();

            //clear the author id and textbox
            textBox_authorfullname.Text = "";
            label_author_id.Text = "ID";
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            panel_AddPanel.BringToFront();

            //populate combobox with genres (in the AddPanel panel)
            comboBox_genre_Edit.DataSource = genre.GenresList();
            comboBox_genre_Edit.DisplayMember = "name";
            comboBox_genre_Edit.ValueMember = "id";

            //clear the author id and textbox
            textBox_author_Edit.Text = "";
            label_authorid_Edit.Text = "ID";
        }

        // button select cover for AddPanel
        private void button_selectCover_Edit_Click(object sender, EventArgs e)
        {
            //open and browse file
            OpenFileDialog opf = new OpenFileDialog();
            //image types
            opf.Filter = "Choose Image(*.jpg, *.png, *.gif) | *.jpg, *.png, *.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                //display image in picturebox
                pictureBox_cover_Edit.Image = Image.FromFile(opf.FileName);
            }
        }

        //search by book id(AddPanel)
        private void button_SearchById_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_id_Edit.Text);
            DataTable data = book.searchBookBy_IDorISBN("id", id, "");
            if (data.Rows.Count > 0)
            {

                displayData(data);
            }
            else
            {
                MessageBox.Show("This Book ID Doesn't Exist, Select a Different ID", "ID Not Found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        //search by book isbn (AddPanel)
        private void button_ByISBN_Click(object sender, EventArgs e)
        {
            string isbn = textBox_isbn_Edit.Text;
            DataTable data = book.searchBookBy_IDorISBN("isbn", 00, isbn);
            if (data.Rows.Count > 0)
            {

                displayData(data);

            }
            else
            {
                MessageBox.Show("This Book ISBN Doesn't Exist, Select a Different ISBN", "ISBN Not Found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        //show author list ina new form-edit (AddPanel)
        private void button_selectAuthor_Edit_Click(object sender, EventArgs e)
        {
            AuthorListForm athlsform = new AuthorListForm(this);
            athlsform.Show();
        }


        // button edit book (AddPanel)
        private void button_editBook_Click(object sender, EventArgs e)
        {
            // add a new book
            int id;
            int author_id;
            int genre_id;
            int quantity;
            string isbn = textBox_isbn_Edit.Text;
            string title = textBox_title_Edit.Text;
            double price;
            string publisher = textBox_publisher_Edit.Text;
            DateTime date_recieved = dateTimePicker_daterecieved_Edit.Value;
            string description = richTextBox_description_Edit.Text;


            MemoryStream ms = new MemoryStream();
            pictureBox_cover_Edit.Image.Save(ms, pictureBox_cover_Edit.Image.RawFormat);
            byte[] book_cover = ms.ToArray();

            try
            {
                id = Convert.ToInt32(textBox_id_Edit.Text);
                author_id = Convert.ToInt32(label_authorid_Edit.Text);
                genre_id = Convert.ToInt32(comboBox_genre_Edit.SelectedValue);
                quantity = Convert.ToInt32(numericUpDown_quantity_Edit.Value);
                price = Convert.ToInt32(textBox_price_Edit.Text);

                if (!book.isIsbnExists(isbn, id))
                {
                    if (!book.isTitleExists(title, id))
                    {
                        if (book.editBook(id, isbn, title, author_id, genre_id, quantity, price, publisher, date_recieved, description, book_cover))
                        {
                            MessageBox.Show("Book Data Updated Successfully", "Edit Book", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Book Data Not Updated", "Edit-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This Book Title Already Exist, Enetr A New One", "Duplicate Title", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else
                {
                    MessageBox.Show("This Book ISBN Already Exist, Enetr A New One", "Duplicate ISBN", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Data-Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //create a function to display data in the fields
        public void displayData(DataTable data)
        {
            //display book data
            textBox_id_Edit.Text = data.Rows[0][0].ToString();
            textBox_isbn_Edit.Text = data.Rows[0][1].ToString();
            textBox_title_Edit.Text = data.Rows[0][2].ToString();

            //get author data
            int author_id = Convert.ToInt32(data.Rows[0][3].ToString());
            DataTable authorData = author.AuthorsById(author_id);
            //first name                    //last name
            textBox_author_Edit.Text = authorData.Rows[0][1].ToString() + " " + authorData.Rows[0][2].ToString();
            label_authorid_Edit.Text = data.Rows[0][3].ToString();
            textBox_publisher_Edit.Text = data.Rows[0][7].ToString();
            textBox_price_Edit.Text = data.Rows[0][6].ToString();
            richTextBox_description_Edit.Text = data.Rows[0][9].ToString();
            numericUpDown_quantity_Edit.Value = Convert.ToInt32(data.Rows[0][5].ToString());
            comboBox_genre_Edit.SelectedValue = data.Rows[0][4].ToString();
            dateTimePicker_daterecieved_Edit.Value = (DateTime)data.Rows[0][8];

            //display  the book cover
            byte[] cover = (byte[])data.Rows[0][10];
            MemoryStream ms = new MemoryStream(cover);
            pictureBox_cover_Edit.Image = Image.FromStream(ms);
        }

        // show the books list
        private void button_ShowBooksList_Click(object sender, EventArgs e)
        {
            panel_ShowBooks.BringToFront();

            //customize datagridview rows height
            dataGridView_Books.RowTemplate.Height = 100;

            //display books in datagridview
            dataGridView_Books.DataSource = book.BookList();

            //customize datagridview headers
            dataGridView_Books.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
            dataGridView_Books.EnableHeadersVisualStyles = false;
            dataGridView_Books.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            dataGridView_Books.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //customize datagridview image column
            DataGridViewImageColumn dgvimgcol = new DataGridViewImageColumn();
            dgvimgcol = (DataGridViewImageColumn)dataGridView_Books.Columns[10];
            dgvimgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;

        }

        //remove the selected book
        private void button_Delete_Click(object sender, EventArgs e)
        {
            //show the deletebook form
            DeleteBookForm dbk = new DeleteBookForm();
            dbk.Show();
        }

        //button edit book - in books list panel
        private void button_EditThisBook_Click(object sender, EventArgs e)
        {
            //show the panel AddPanel
            //and  display the selected book  (from datagridview) data
            panel_AddPanel.BringToFront();

            //populate combobox with genres (in the books panel)
            comboBox_genre_Edit.DataSource = genre.GenresList();
            comboBox_genre_Edit.DisplayMember = "name";
            comboBox_genre_Edit.ValueMember = "id";

            int id = Convert.ToInt32(dataGridView_Books.CurrentRow.Cells[0].Value);
            DataTable data = book.searchBookBy_IDorISBN("id", id, "");
            if (data.Rows.Count > 0)
            {

                displayData(data);
            }
            else
            {
                MessageBox.Show("This Book ID Doesn't Exist, Select a Different ID", "ID Not Found", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            //call show booklist button so we dont need to click on it on runtime
            button_ShowBooksList.PerformClick();

            //we will create a folder first
            if (!Directory.Exists(@"C:\books"))
            {
                Directory.CreateDirectory(@"C:\books");
            }
            string filePath = @"C:\books\list.txt";
            if (!File.Exists(filePath))//check if this file exists
            {
                File.Create(filePath).Close();//create the file 
                //MessageBox.Show("File Created");
            }

            //now we need to populate the text file with
            //the authors id and fullname
            TextWriter writer = new StreamWriter(filePath);

            string id;
            string isbn;
            string title;

            for (int i = 0; i < dataGridView_Books.Rows.Count; i++)// for rows
            {

                id = dataGridView_Books.Rows[i].Cells[0].Value.ToString();
                isbn = dataGridView_Books.Rows[i].Cells[1].Value.ToString();
                title = dataGridView_Books.Rows[i].Cells[2].Value.ToString();

                writer.Write(id + " - " + isbn + " - " + title);
                writer.WriteLine("");//create a new line
                writer.WriteLine("----------------------------");
            }
            writer.Close();
            MessageBox.Show("Data Exported");
        }

        private void button_RemoveThisBook_Click(object sender, EventArgs e)
        {
            button_Delete.PerformClick();
        }
    }
}
