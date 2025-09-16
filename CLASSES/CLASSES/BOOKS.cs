using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Reflection.Metadata.BlobBuilder;
using System.Diagnostics;
using System.Security.Policy;
using System.Reflection.Metadata.Ecma335;
using System.Net;

namespace Library_Management_System.CLASSES
{
    internal class BOOKS
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();

        //create a function to add new books
        //
        public Boolean addBook(string isbn, string title, int author_id, int genre_id, int quantity, double price, string publisher, DateTime date_recieved, string description, byte[] cover)
        {
            string query = "INSERT INTO `books`(`isbn`, `title`, `author_id`, `genre_id`, `quantity`, `price`, `publisher`, `date_recieved`, `description`, `cover`) VALUES (@isbn, @title,@author, @genre, @quantity, @price, @publisher, @date_recieved, @description, @img)";


            MySqlParameter[] parameters = new MySqlParameter[10];
            
            parameters[0] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
            parameters[0].Value = isbn;

            parameters[1] = new MySqlParameter("@title", MySqlDbType.VarChar);
            parameters[1].Value = title;

            parameters[2] = new MySqlParameter("@author", MySqlDbType.Int32);
            parameters[2].Value = author_id;

            parameters[3] = new MySqlParameter("@genre", MySqlDbType.Int32);
            parameters[3].Value = genre_id;

            parameters[4] = new MySqlParameter("@quantity", MySqlDbType.Int32);
            parameters[4].Value = quantity;

            parameters[5] = new MySqlParameter("@price", MySqlDbType.Double);
            parameters[5].Value = price;

            parameters[6] = new MySqlParameter("@publisher", MySqlDbType.VarChar);
            parameters[6].Value = publisher;

            parameters[7] = new MySqlParameter("@date_recieved", MySqlDbType.Date);
            parameters[7].Value = date_recieved;

            parameters[8] = new MySqlParameter("@description", MySqlDbType.VarChar);
            parameters[8].Value = description;
            
            parameters[9] = new MySqlParameter("img", MySqlDbType.Blob);
            parameters[9].Value = cover;


            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //create a function to edit books
        public Boolean editBook(int id, string isbn, string title, int author_id, int genre_id, int quantity, double price, string publisher, DateTime date_recieved, string description, byte[] cover)
        {
            string query = "UPDATE `books` SET `isbn`=@isbn,`title`=@title,`author_id`=@author,`genre_id`=@genre,`quantity`=@quantity,`price`=@price,`publisher`=@publisher,`date_recieved`=@date_recieved,`description`=@description,`cover`=@img WHERE `id`=@id";


            MySqlParameter[] parameters = new MySqlParameter[11];
            
            parameters[0] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
            parameters[0].Value = isbn;

            parameters[1] = new MySqlParameter("@title", MySqlDbType.VarChar);
            parameters[1].Value = title;

            parameters[2] = new MySqlParameter("@author", MySqlDbType.Int32);
            parameters[2].Value = author_id;

            parameters[3] = new MySqlParameter("@genre", MySqlDbType.Int32);
            parameters[3].Value = genre_id;

            parameters[4] = new MySqlParameter("@quantity", MySqlDbType.Int32);
            parameters[4].Value = quantity;

            parameters[5] = new MySqlParameter("@price", MySqlDbType.Double);
            parameters[5].Value = price;

            parameters[6] = new MySqlParameter("@publisher", MySqlDbType.VarChar);
            parameters[6].Value = publisher;

            parameters[7] = new MySqlParameter("@date_recieved", MySqlDbType.Date);
            parameters[7].Value = date_recieved;

            parameters[8] = new MySqlParameter("@description", MySqlDbType.VarChar);
            parameters[8].Value = description;

            parameters[9] = new MySqlParameter("img", MySqlDbType.Blob);
            parameters[9].Value = cover;

            parameters[10] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[10].Value = id;


            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //create a function to delete  the selected book
        public Boolean deleteBook( int id )
        {
            string query = "DELETE FROM `books` WHERE `id`=@id";


            MySqlParameter[] parameters = new MySqlParameter[1];

            parameters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[0].Value = id;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //created a function  to return the books
        public DataTable BookList()
        {
            string query = "SELECT * FROM `books` ORDER BY id DESC";

            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }

        //created a function  to return the books by selected Author books
        public DataTable AuthorBooks(int authorId)
        {
            string query = "SELECT * FROM `books` WHERE `author_id`=@author_id";

            MySqlParameter[] parameters = new MySqlParameter[1];
            parameters[0] = new MySqlParameter("@author_id", MySqlDbType.Int32);
            parameters[0].Value = authorId;

            DataTable table = new DataTable();
            table = db.getData(query, parameters);
            return table;
        }

        //check if the book isbn exist
        public Boolean isIsbnExists(string isbn, int id)
        {
            string query = "SELECT* FROM `books` WHERE `isbn`= @isbn AND id <> @id";

            MySqlParameter[] parameters = new MySqlParameter[2];
            parameters[0] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
            parameters[0].Value = isbn;
            
            parameters[1] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[1].Value = id;

            DataTable table = new DataTable();
            table = db.getData(query, parameters);
            if(table.Rows.Count > 0)
            {
                return true;  
            }
            else
            {
                return false;
            }
        }

        //check if the book title exist
        public Boolean isTitleExists(string title, int id)
        {
            string query = "SELECT* FROM `books` WHERE `title`= @title AND id <> @id";

            MySqlParameter[] parameters = new MySqlParameter[2];
            parameters[0] = new MySqlParameter("@title", MySqlDbType.VarChar);
            parameters[0].Value = title;

            parameters[1] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[1].Value = id;

            DataTable table = new DataTable();
            table = db.getData(query, parameters);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //search book by id or isbn
        public DataTable searchBookBy_IDorISBN(string id_or_isbn, int id, string isbn)
        {
            string query;
            MySqlParameter[] parameters = new MySqlParameter[1];

            if (id_or_isbn.Equals("id"))
            {
                query = "SELECT* FROM `books` WHERE `id`= @id";
                parameters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
                parameters[0].Value = id;
            }
            else
            {
                query = "SELECT* FROM `books` WHERE `isbn`= @isbn";
                parameters[0] = new MySqlParameter("@isbn", MySqlDbType.VarChar);
                parameters[0].Value = isbn;
            }

            DataTable table = new DataTable();
            table = db.getData(query, parameters);
            return table;
            
        }

        public DataRow getBookInfo(int bookId)
        {
            string query = "SELECT b.id, `isbn`, `title`, concat(a.first_name,' ', a.last_name) as author, g.name as genre, `quantity`, `price`, `publisher`, `date_recieved`, `description`, `cover` FROM `books` b ,authors a, genres g WHERE b.author_id = a.id and b.genre_id = g.id and b.id =@id";

            MySqlParameter[] parameters = new MySqlParameter[1];

            parameters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[0].Value = bookId;

            DataTable table = new DataTable();
            table= db.getData(query, parameters);
            return table.Rows[0];
        }

        //create a function to edit the book quantity
        //this function will be used  when we set an issued copy of this book to losted 
        //the new book quatity = book quantity - lost book copy

        public Boolean bookQuantityMinusLosted(int bookId)
        {
            string query = "UPDATE `books` SET `quantity`=quantity-1 WHERE `id`=@bid";


            MySqlParameter[] parameters = new MySqlParameter[1];

            parameters[0] = new MySqlParameter("@bid", MySqlDbType.Int32);
            parameters[0].Value = bookId;

            if (db.setData(query, parameters) == 1)
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
