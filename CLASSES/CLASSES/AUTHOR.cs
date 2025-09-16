using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Linq;

namespace Library_Management_System.CLASSES
{
    internal class AUTHOR
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();
        public Boolean addAuthor(string fname, string lname, string edu, string bio)
        {
            string query = "INSERT INTO `authors`(`first_name`, `last_name`, `education`, `bio`) VALUES (@fn, @ln, @edu, @bio)";


            MySqlParameter[] parameters = new MySqlParameter[4];
            parameters[0] = new MySqlParameter("@fn", MySqlDbType.VarChar);
            parameters[0].Value = fname;

            parameters[1] = new MySqlParameter("@ln", MySqlDbType.VarChar);
            parameters[1].Value = lname;

            parameters[2] = new MySqlParameter("@edu", MySqlDbType.VarChar);
            parameters[2].Value = edu;

            parameters[3] = new MySqlParameter("@bio", MySqlDbType.VarChar);
            parameters[3].Value = bio;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean editAuthor(int id, string fname, string lname, string edu, string bio)
        {
            string query = "UPDATE `authors` SET `first_name`=@fn,`last_name`=@ln,`education`=@edu,`bio`=@bio WHERE `id`=@id";


            MySqlParameter[] parameters = new MySqlParameter[5];
            parameters[0] = new MySqlParameter("@fn", MySqlDbType.VarChar);
            parameters[0].Value = fname;

            parameters[1] = new MySqlParameter("@ln", MySqlDbType.VarChar);
            parameters[1].Value = lname;

            parameters[2] = new MySqlParameter("@edu", MySqlDbType.VarChar);
            parameters[2].Value = edu;

            parameters[3] = new MySqlParameter("@bio", MySqlDbType.VarChar);
            parameters[3].Value = bio;
            
            parameters[4] = new MySqlParameter("@id", MySqlDbType.VarChar);
            parameters[4].Value = id;

            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean deleteAuthor(int id)
        {
            string query = "DELETE FROM `authors` WHERE `id`=@id";


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

        public DataTable AuthorsList(Boolean display_fullname)
        {
            string query = "SELECT * FROM `authors`";

            if (display_fullname)
            {
                query = "SELECT `id`, Concat(`first_name`,' ', `last_name`) as fullName, `education`, `bio` FROM `authors`";
            }
            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }
        //create a function to get authors by id
        public DataTable AuthorsById(int id)
        {
            string query = "SELECT * FROM `authors` WHERE `id` =@id";

            MySqlParameter[] parameters = new MySqlParameter[1];
            parameters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[0].Value = id;

            DataTable table = new DataTable();
            table = db.getData(query, parameters);
            return table;
        }
    }
}
