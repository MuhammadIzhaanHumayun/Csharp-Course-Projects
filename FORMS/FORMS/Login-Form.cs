using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_Management_System.FORMS
{
    public partial class Login_Form : Form
    {
        private Dashboard_Form dashF = null;
        public Login_Form(Dashboard_Form Source_Form)
        {
            dashF = Source_Form as Dashboard_Form;
            InitializeComponent();
        }

       

        private void Login_Form_Load(object sender, EventArgs e)
        {
            pictureBox_User.Image = Image.FromFile("../../../IMAGES/user.png");
            pictureBox_Password.Image = Image.FromFile("../../../IMAGES/lock.png");
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            THE_DATABASE.MYDB db = new THE_DATABASE.MYDB();
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `app_users` WHERE `username` = @usn AND `password` = @pass;", db.getConnection());
            command.Parameters.Add("@usn",MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                dashF.Enabled = true;
                this.Close();
            }
            else
            {
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your username to login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your password to login", "Empty password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("No username or password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
