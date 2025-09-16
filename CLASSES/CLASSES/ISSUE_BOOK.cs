using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Management_System.CLASSES
{
    internal class ISSUE_BOOK
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();
        CLASSES.BOOKS book = new CLASSES.BOOKS();

        //create a function to issue book
        public Boolean Issue(int bookId, int memberId, string status, DateTime issueDate, DateTime returnDate, string note)
        {
            string query = "INSERT INTO `issue_book`(`book_id`, `member_id`, `status`, `issue_date`, `return_date`, `note`) VALUES (@bookId, @memberid, @status, @issueDate, @returnDate, @note)";


            MySqlParameter[] parameters = new MySqlParameter[6];
            parameters[0] = new MySqlParameter("@bookId", MySqlDbType.Int32);
            parameters[0].Value = bookId;

            parameters[1] = new MySqlParameter("@memberId", MySqlDbType.Int32);
            parameters[1].Value = memberId;

            parameters[2] = new MySqlParameter("@status", MySqlDbType.VarChar);
            parameters[2].Value = status;

            parameters[3] = new MySqlParameter("@issueDate", MySqlDbType.Date);
            parameters[3].Value = issueDate;

            parameters[4] = new MySqlParameter("@returnDate", MySqlDbType.Date);
            parameters[4].Value = returnDate;

            parameters[5] = new MySqlParameter("@note", MySqlDbType.Text);
            parameters[5].Value = note;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //function to count  the issued books
        public int CountIssuedCopiesOfThisBook(int bookId)
        {
            string query = "SELECT * FROM `issue_book` WHERE `book_id`= @id and status = 'issued'";


            MySqlParameter[] parameters = new MySqlParameter[1];

            parameters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[0].Value = bookId;

            return db.getData(query, parameters).Rows.Count;

        }

        public Boolean CheckBookAvailability(int bookId)
        {
            Boolean availability;

            //get the book quantity
            int bookquantity = Convert.ToInt32(book.getBookInfo(bookId)["quantity"].ToString());

            //get the number of copies of the same books are issued
            int issuedCopies = CountIssuedCopiesOfThisBook(bookId);
            
            //now check if this  id available  or not
            //if the quantity  is  bigger  than the number  of issued copies
            if(bookquantity > issuedCopies)
            {
                
                availability = true;
            }
            else
            {
                availability = false;
            }
                

            return availability;
        }

        //create a function to return data from table issue_books
        public DataTable IssueList(string status)
        {
            string query = "SELECT `book_id` as book, `member_id` as member, `status`, `issue_date` issued, `return_date` returned, `note` FROM `issue_book`";

            if (!status.Equals(""))
            {
                query = "SELECT `book_id` as book, `member_id` as member, `status`, `issue_date` issued, `return_date` returned, `note` FROM `issue_book` WHERE status='"+status+"'";
            }
            
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }

        //this function allows the user to edit the status of book
        public Boolean returnBook(int bookId, int memberId, string status, DateTime issueDate, DateTime returnDate, string note)
        {
            string query = "UPDATE `issue_book` SET `status`=@status,`return_date`=@returnDate,`note`=@note WHERE `book_id`=@bookId AND `member_id`=@memberId AND `issue_date`=@issueDate";


            MySqlParameter[] parameters = new MySqlParameter[6];
            parameters[0] = new MySqlParameter("@status", MySqlDbType.VarChar);
            parameters[0].Value = status;

            parameters[1] = new MySqlParameter("@returnDate", MySqlDbType.Date);
            parameters[1].Value = returnDate;
            
            parameters[2] = new MySqlParameter("@note", MySqlDbType.Text);
            parameters[2].Value = note;

            parameters[3] = new MySqlParameter("@bookId", MySqlDbType.Int32);
            parameters[3].Value = bookId;

            parameters[4] = new MySqlParameter("@memberId", MySqlDbType.Int32);
            parameters[4].Value = memberId;

            parameters[5] = new MySqlParameter("@issueDate", MySqlDbType.Date);
            parameters[5].Value = issueDate;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //delete issued book
        public Boolean deleteIssuedBook(int bookId, int memberId, DateTime issueDate)
        {
            string query = "DELETE FROM `issue_book` WHERE `book_id`=@bid AND `member_id`=@mid AND `issue_date`=@isd";


            MySqlParameter[] parameters = new MySqlParameter[3];

            parameters[0] = new MySqlParameter("@bid", MySqlDbType.Int32);
            parameters[0].Value = bookId;

            parameters[1] = new MySqlParameter("@mid", MySqlDbType.Int32);
            parameters[1].Value = memberId;

            parameters[2] = new MySqlParameter("@isd", MySqlDbType.Date);
            parameters[2].Value = issueDate;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //create a function to check if the book is already issued by a member
        //while trying to issue a new book
        public Boolean isBookStillIssuedByMember(int memberId, int bookId)
        {
            string query = "SELECT * FROM `issue_book` WHERE `status`= 'issued' AND `book_id`=@bid AND `member_id`=@mid";


            MySqlParameter[] parameters = new MySqlParameter[2];

            parameters[0] = new MySqlParameter("@bid", MySqlDbType.Int32);
            parameters[0].Value = bookId;

            parameters[1] = new MySqlParameter("@mid", MySqlDbType.Int32);
            parameters[1].Value = memberId;

            DataTable table = db.getData(query, parameters);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
