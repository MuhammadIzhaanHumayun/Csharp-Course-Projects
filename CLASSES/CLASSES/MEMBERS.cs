using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Library_Management_System.CLASSES
{
    internal class MEMBERS
    {
        THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();

        //create a function to add new member
        public Boolean addMember(string fname, string lname, string gender, string phone, string email, byte[] picture)
        {
            string query = "INSERT INTO `members`(`first_name`, `last_name`, `gender`, `phone`, `email`, `picture`) VALUES (@fn, @ln, @gender, @phone, @email, @pic)";

            MySqlParameter[] parameters = new MySqlParameter[6];
            parameters[0] = new MySqlParameter("@fn", MySqlDbType.VarChar);
            parameters[0].Value = fname;

            parameters[1] = new MySqlParameter("@ln", MySqlDbType.VarChar);
            parameters[1].Value = lname;

            parameters[2] = new MySqlParameter("@gender", MySqlDbType.VarChar);
            parameters[2].Value = gender;

            parameters[3] = new MySqlParameter("@phone", MySqlDbType.VarChar);
            parameters[3].Value = phone;

            parameters[4] = new MySqlParameter("@email", MySqlDbType.VarChar);
            parameters[4].Value = email;

            parameters[5] = new MySqlParameter("@pic", MySqlDbType.Blob);
            parameters[5].Value = picture;


            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean editMember(int id, string fname, string lname, string gender, string phone, string email, byte[] picture)
        {
            string query = "UPDATE `members` SET `first_name`=@fn,`last_name`=@ln,`gender`=@gender,`phone`=@phone,`email`=@email,`picture`=@pic WHERE `id`=@id";

            MySqlParameter[] parameters = new MySqlParameter[7];
            parameters[0] = new MySqlParameter("@fn", MySqlDbType.VarChar);
            parameters[0].Value = fname;

            parameters[1] = new MySqlParameter("@ln", MySqlDbType.VarChar);
            parameters[1].Value = lname;

            parameters[2] = new MySqlParameter("@gender", MySqlDbType.VarChar);
            parameters[2].Value = gender;

            parameters[3] = new MySqlParameter("@phone", MySqlDbType.VarChar);
            parameters[3].Value = phone;

            parameters[4] = new MySqlParameter("@email", MySqlDbType.VarChar);
            parameters[4].Value = email;

            parameters[5] = new MySqlParameter("@pic", MySqlDbType.Blob);
            parameters[5].Value = picture;

            parameters[6] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[6].Value = id;


            if (db.setData(query, parameters) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean deleteMember(int id)
        {
            string query = "DELETE FROM `members` WHERE `id`=@id";


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

        public DataTable MembersList(Boolean display_fullname)
        {
            string query = "SELECT * FROM `members`";
            if (display_fullname)
            {
                query = "SELECT `id`, Concat(`first_name`,'-', `last_name`) as fullName, `gender`, `phone`, `email`, `picture` FROM `members`";
            }

            DataTable table = new DataTable();
            table = db.getData(query, null);
            return table;
        }

        //create a function to get member by id
        public DataRow getmemberbyid(int memberID)
        {
            string query = "SELECT * FROM `members` Where `id`=@id";

            MySqlParameter[] parameters = new MySqlParameter[1];

            parameters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[0].Value = memberID;

            DataTable table = new DataTable();
            table = db.getData(query, parameters);

            DataRow dr = null;
            if (table.Rows.Count > 0)
            {
                dr = table.Rows[0];
            }

            return dr;
        }
    }
}
