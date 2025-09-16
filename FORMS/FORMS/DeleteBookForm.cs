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
    public partial class DeleteBookForm : Form
    {
        public DeleteBookForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //button delete book
        CLASSES.BOOKS books = new CLASSES.BOOKS();
        private void button_DeleteBook_Click(object sender, EventArgs e)
        {
            int bookId = (int)numericUpDown_BookId.Value;

            //show a confirmation message before deletion
            if (MessageBox.Show("Do You Really Want To Delete This Book", "Confirmation Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (books.deleteBook(bookId))
                {
                    MessageBox.Show("The Book Has Been Deleted Successfully", "Delete Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Book Not Deleted", "Delete-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }



        }

        private void numericUpDown_BookId_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
