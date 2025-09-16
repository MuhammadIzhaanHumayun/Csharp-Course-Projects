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
    public partial class BooksListForm : Form
    {
        int author_id;
        string fullname;
        public BooksListForm(int id, string fullName)
        {
            InitializeComponent();
            this.author_id = id;
            this.fullname = fullName;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BooksListForm_Load(object sender, EventArgs e)
        {

            //display the selected  author fullname 
            label_author.Text = "books by: "+fullname;

            //display the author books in listview
            CLASSES.BOOKS books = new CLASSES.BOOKS();
            DataTable bookList = books.AuthorBooks(author_id);

            ListViewItem[] items = new ListViewItem[bookList.Rows.Count];
            String[] titles = new String[bookList.Rows.Count];

            //loop  to populate the  titles & images
            for(int i=0; i < bookList.Rows.Count;i++)
            {
                byte[] img = (byte[])bookList.Rows[i][10];
                MemoryStream ms = new MemoryStream(img);

                //add images to the image list
                imageList_BookCovers.Images.Add(Image.FromStream(ms));

                //add title to the titles array
                titles[i] = bookList.Rows[i][2].ToString();
            }

            listView_books.View = View.LargeIcon;
            imageList_BookCovers.ImageSize = new Size(300, 380);
            listView_books.LargeImageList = imageList_BookCovers;
            //loop to display the data in the list view
            for (int j=0; j < imageList_BookCovers.Images.Count; j++)
            {
                listView_books.Items.Add(new ListViewItem() { Text = titles[j], ImageIndex = j });
            }
        }
    }
}
