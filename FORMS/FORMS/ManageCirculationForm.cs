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
using Library_Management_System.CLASSES;
using System.Net;


namespace Library_Management_System.FORMS
{
    public partial class ManageCirculationForm : Form
    {
        public ManageCirculationForm()
        {
            InitializeComponent();
        }

        CLASSES.BOOKS books = new CLASSES.BOOKS();
        CLASSES.MEMBERS member = new CLASSES.MEMBERS();
        CLASSES.ISSUE_BOOK issueBOOK = new CLASSES.ISSUE_BOOK();

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageCirculationForm_Load(object sender, EventArgs e)
        {
            pictureBox_circulation.Image = Image.FromFile("../../../IMAGES/circulation1.png");
            button__issue.Image = Image.FromFile("../../../IMAGES/buy.png");
            button_Return.Image = Image.FromFile("../../../IMAGES/return.png");

            //customize datagridview
            dataGridView_issuedBooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue;
            dataGridView_issuedBooks.EnableHeadersVisualStyles = false;
            dataGridView_issuedBooks.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            dataGridView_issuedBooks.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            panel_issue.BringToFront();
        }


        private void button__issue_Click(object sender, EventArgs e)
        {
            //show the panel issue
            panel_issue.BringToFront();

        }

        //show the panel return
        //populate the datagridview 
        private void button_Return_Click(object sender, EventArgs e)
        {

            panel_return.BringToFront();

            dataGridView_issuedBooks.DataSource = issueBOOK.IssueList("");

        }

        //button to issue book
        private void button_issueBook_Click_1(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(numericUpDown_bookId.Value);
            int memberId = Convert.ToInt32(numericUpDown_memberId.Value);
            DateTime issueDate = dateTimePicker_issue.Value;
            DateTime returnDate = dateTimePicker_return.Value;
            string note = richTextBox_note.Text;

            //we need to check if the book is available first
            //issue date shouldn't be before the issue date
            //check if a copy of this book is still issued to this member
            if (issueBOOK.isBookStillIssuedByMember(memberId, bookId))
            {
                MessageBox.Show("a copy of this book is still issued to this member", "Issued Book", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (issueBOOK.CheckBookAvailability(bookId))
                {
                    if (issueDate < returnDate)
                    {
                        if (issueBOOK.Issue(bookId, memberId, "issued", issueDate, returnDate, note))
                        {
                            MessageBox.Show("Book Issued", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            //refresh datagridview
                            dataGridView_issuedBooks.DataSource = issueBOOK.IssueList("");
                        }

                    }
                    else
                    {
                        MessageBox.Show("the return date shouldn't be before the issue date");
                    }
                }
                else
                {
                    MessageBox.Show("This Book Is Not Available Right Now", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        //search book by id and display the book title
        private void button_searchbook_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(numericUpDown_bookId.Value);
            DataTable table = books.searchBookBy_IDorISBN("id", id, "");


            //check if the book exists
            if (table.Rows.Count > 0)
            {
                label_bookTitle.Text = table.Rows[0][2].ToString();
                label_bookTitle.ForeColor = Color.LimeGreen;

                //check the book availability
                if (issueBOOK.CheckBookAvailability(id))
                {
                    label_availability.ForeColor = Color.Green;
                    label_availability.Text = "Yes";
                }
                else
                {
                    label_availability.ForeColor = Color.Red;
                    label_availability.Text = "No";
                }
            }
            else
            {
                label_bookTitle.Text = "This Book Doesn't Exist";
                label_bookTitle.ForeColor = Color.OrangeRed;

            }
        }

        //search member by id and display the member fullname
        private void button_searchMember_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(numericUpDown_memberId.Value);
            DataRow row = member.getmemberbyid(id);

            if (row != null)
            {
                label_MemberFullname.Text = row["first_name"] + " " + row["last_name"];
                label_MemberFullname.ForeColor = Color.LimeGreen;
            }
            else
            {
                label_MemberFullname.Text = "This Member Doesn't Exist";
                label_MemberFullname.ForeColor = Color.OrangeRed;

            }
        }


        //display the selected row data
        private void dataGridView_issuedBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numericUpDown_bookId1.Value = (int)dataGridView_issuedBooks.CurrentRow.Cells[0].Value;
            numericUpDown_memberId1.Value = (int)dataGridView_issuedBooks.CurrentRow.Cells[1].Value;
            dateTimePicker_issue1.Value = (DateTime)dataGridView_issuedBooks.CurrentRow.Cells[3].Value;
            dateTimePicker_return1.Value = (DateTime)dataGridView_issuedBooks.CurrentRow.Cells[4].Value;
            richTextBox_note1.Text = dataGridView_issuedBooks.CurrentRow.Cells[5].Value.ToString();

            //display the book title
            int bkId = Convert.ToInt32(numericUpDown_bookId1.Value);
            DataRow bookData = books.getBookInfo(bkId);
            label_bookTitle1.Text = bookData["title"].ToString();

            //display the member name
            int mId = Convert.ToInt32(numericUpDown_memberId1.Value);
            DataRow row = member.getmemberbyid(mId);
            label_memberFullname1.Text = row["first_name"] + " " + row["last_name"];

        }

        //return book
        private void button_returnBook_Click(object sender, EventArgs e)
        {

            //the user can only edit the status (to returned), return date and note
            int bookId = Convert.ToInt32(numericUpDown_bookId1.Value);
            int memberId = Convert.ToInt32(numericUpDown_memberId1.Value);
            DateTime issueDate = dateTimePicker_issue1.Value;
            DateTime returnDate = dateTimePicker_return1.Value;
            string note = richTextBox_note1.Text;


            if (issueDate < returnDate)
            {
                if (issueBOOK.returnBook(bookId, memberId, "returned", issueDate, returnDate, note))
                {
                    MessageBox.Show("Book Returned", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //refresh datagridview
                    dataGridView_issuedBooks.DataSource = issueBOOK.IssueList("");
                }

            }
            else
            {
                MessageBox.Show("the return date shouldn't be before the issue date");
            }

        }

        //the book is lost
        private void button_lostBook_Click(object sender, EventArgs e)
        {
            //Change the status to losted
            int bookId = Convert.ToInt32(numericUpDown_bookId1.Value);
            int memberId = Convert.ToInt32(numericUpDown_memberId1.Value);
            DateTime issueDate = dateTimePicker_issue1.Value;
            DateTime returnDate = dateTimePicker_return1.Value;
            string note = richTextBox_note1.Text;

            if (issueBOOK.returnBook(bookId, memberId, "losted", issueDate, returnDate, note))
            {
                MessageBox.Show("Book Losted", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //we need to edit the book quantity (-1 lost book)
                if (books.bookQuantityMinusLosted(bookId))
                {
                    MessageBox.Show("Book Quantity Updated", "New Quantity Set", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //refresh datagridview
                dataGridView_issuedBooks.DataSource = issueBOOK.IssueList("");
            }

            else
            {
                MessageBox.Show("the return date shouldn't be before the issue date");
            }
        }
    


        //delete this data
        private void button_delete_Click(object sender, EventArgs e)
        {
            int bookId = Convert.ToInt32(numericUpDown_bookId1.Value);
            int memberId = Convert.ToInt32(numericUpDown_memberId1.Value);
            DateTime issueDate = dateTimePicker_issue1.Value;
            if (issueBOOK.deleteIssuedBook(bookId, memberId, issueDate))
            {
                MessageBox.Show("Data Deleted", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //refresh datagridview
                dataGridView_issuedBooks.DataSource = issueBOOK.IssueList("");
            }
            else
            {
                MessageBox.Show("Data Not Deleted", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //display the issued book only
        private void button_issued_Click(object sender, EventArgs e)
        {
            dataGridView_issuedBooks.DataSource = issueBOOK.IssueList("issued");
        }

        //show the returned books only
        private void button_returned_Click(object sender, EventArgs e)
        {
            dataGridView_issuedBooks.DataSource = issueBOOK.IssueList("returned");
        }

        //show the losted books only
        private void button_losted_Click(object sender, EventArgs e)
        {
            dataGridView_issuedBooks.DataSource = issueBOOK.IssueList("losted");
        }

        private void button_showAll_Click(object sender, EventArgs e)
        {
            dataGridView_issuedBooks.DataSource = issueBOOK.IssueList("");
        }
    }
}
