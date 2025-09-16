using Library_Management_System.CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System.FORMS
{
    public partial class Dashboard_Form : Form
    {
        public Dashboard_Form()
        {
            InitializeComponent();
        }

        private void Dashboard_Form_Load(object sender, EventArgs e)
        {
            pictureBox_Logo.Image = Image.FromFile("../../../IMAGES/bookshelf.png");
            button_Close.Image = Image.FromFile("../../../IMAGES/CloseButton.png");
            button_Books.Image = Image.FromFile("../../../IMAGES/book.png");
            button_Genres.Image = Image.FromFile("../../../IMAGES/genre.png");
            button_Authors.Image = Image.FromFile("../../../IMAGES/author.png");
            button_members.Image = Image.FromFile("../../../IMAGES/member.png");
            button_Circulation.Image = Image.FromFile("../../../IMAGES/circulation.png");
            //button_Users.Image = Image.FromFile("../../../IMAGES/users.png");

            //now display the last 5 books images
            //get 5 rows from the books datatable
            DataTable bookData = books.BookList();

            //create a loop to display the 5 books
            byte[] img;
            MemoryStream ms;
            int i = 0;//index for the loop

            //using foreach loop to do that
            foreach (var PanelControl in panel_displayBooks.Controls)
            {
                if (PanelControl.GetType() == typeof(Panel))
                {
                    //display the book image
                    Panel panel = (Panel)PanelControl;
                    img = (byte[])bookData.Rows[i][10];
                    ms = new MemoryStream(img);
                    panel.BackgroundImage = Image.FromStream(ms);
                    panel.BackgroundImageLayout = ImageLayout.Stretch;

                    //display the book price
                    foreach (var labelControl in panel.Controls)
                    {
                        if (labelControl.GetType() == typeof(Label))
                        {
                            Label label = (Label)labelControl;
                            label.Text = "Rs " + bookData.Rows[i][6].ToString();
                        }
                    }
                    i++;
                }
            }

        }

        CLASSES.MEMBERS members = new CLASSES.MEMBERS();
        CLASSES.BOOKS books = new CLASSES.BOOKS();
        CLASSES.AUTHOR author = new CLASSES.AUTHOR();
        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Form_Shown(object sender, EventArgs e)
        {
            this.Enabled = false;
            Login_Form lgf = new Login_Form(this);
            lgf.Show();

            //Show the number of books/authors/members
            label_authorsCount.Text = author.AuthorsList(false).Rows.Count.ToString();
            label_booksCount.Text = books.BookList().Rows.Count.ToString();
            label_membersCount.Text = members.MembersList(false).Rows.Count.ToString();


        }

        private void button_Genres_Click(object sender, EventArgs e)
        {
            ManageGenresForm mgf = new ManageGenresForm();
            mgf.Show();
        }

        private void button_Authors_Click(object sender, EventArgs e)
        {
            ManageAuthorsForm maf = new ManageAuthorsForm();
            maf.Show();
        }

        private void button_Books_Click(object sender, EventArgs e)
        {
            ManageBooksForm mbf = new ManageBooksForm();
            mbf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageMembersForm mmf = new ManageMembersForm();
            mmf.Show();
        }

        private void button_Circulation_Click(object sender, EventArgs e)
        {
            ManageCirculationForm mcf = new ManageCirculationForm();
            mcf.Show();
        }
    }
}
