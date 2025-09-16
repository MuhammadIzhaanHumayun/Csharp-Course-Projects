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
    public partial class AuthorListForm : Form
    {
        private ManageBooksForm mngBooks = null;
        public AuthorListForm(ManageBooksForm sourceForm)
        {
            mngBooks = sourceForm as ManageBooksForm;
            InitializeComponent();
        }

        

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AuthorListForm_Load(object sender, EventArgs e)
        {
            CLASSES.AUTHOR author = new CLASSES.AUTHOR();
            listBox_authors.DataSource = author.AuthorsList(true);
            listBox_authors.DisplayMember = "fullName";
            listBox_authors.ValueMember = "id";

        }

        // to set the selected author id into managed books
        // and close this form
        private void button_SelectAndClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBox_authors.SelectedItem == null)
                {
                    MessageBox.Show("No Author Selected.");
                    return;
                }

                // Get the author full name and id
                //the fullname will be displayed in the panel add and AddPanel
                DataRowView drv = (DataRowView)listBox_authors.SelectedItem;
                string fullname = drv["fullname"].ToString();
                string id = drv["id"].ToString();

                // for add panel
                mngBooks.textBox_authorfullname.Text = fullname;
                mngBooks.label_author_id.Text = id;

                //for AddPanel panel
                mngBooks.textBox_author_Edit.Text = fullname;
                mngBooks.label_authorid_Edit.Text = id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Author Selected" + ex.Message);
            }

            // Close the form
            this.Close();
        }

    }
}
