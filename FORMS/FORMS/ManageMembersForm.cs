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
using System.IO;

namespace Library_Management_System.FORMS
{
    public partial class ManageMembersForm : Form
    {
        public ManageMembersForm()
        {
            InitializeComponent();
        }

        CLASSES.MEMBERS member = new CLASSES.MEMBERS();
        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageMembersForm_Load(object sender, EventArgs e)
        {
            pictureBox_Members.Image = Image.FromFile("../../../IMAGES/member2.png");
            pictureBox_picture.Image = Image.FromFile("../../../IMAGES/photo.png");
            button_Add.Image = Image.FromFile("../../../IMAGES/plus.png");
            button_Edit.Image = Image.FromFile("../../../IMAGES/update.png");
            button_Delete.Image = Image.FromFile("../../../IMAGES/trash.png");
            button_Select_Picture.Image = Image.FromFile("../../../IMAGES/upload.png");
            button_Clear.Image = Image.FromFile("../../../IMAGES/circle.png");


            //customize datagridview rows height
            dataGridView_members.RowTemplate.Height = 75;

            dataGridView_members.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
            dataGridView_members.EnableHeadersVisualStyles = false;
            dataGridView_members.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            dataGridView_members.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //customize datagridview headers
            dataGridView_members.ColumnHeadersDefaultCellStyle.ForeColor = Color.Red;
            dataGridView_members.EnableHeadersVisualStyles = false;
            dataGridView_members.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
            dataGridView_members.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //populate datagridview with authors
            dataGridView_members.DataSource = member.MembersList(true);

            //customize datagridview image column
            DataGridViewImageColumn dgvimgcol = new DataGridViewImageColumn();
            dgvimgcol = (DataGridViewImageColumn)dataGridView_members.Columns[5];
            dgvimgcol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            //update the number of Authors
            label_membersCount.Text = member.MembersList(true).Rows.Count.ToString() + " Members";
        }

        //browse and select the picture 
        private void button_Select_Picture_Click(object sender, EventArgs e)
        {
            //open and browse file
            OpenFileDialog opf = new OpenFileDialog();
            //image types
            opf.Filter = "Choose Image(*.jpg, *.png, *.gif) | *.jpg, *.png, *.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                //display image in picturebox
                pictureBox_picture.Image = Image.FromFile(opf.FileName);
            }
        }

        //button add a new member
        private void button_Add_Click(object sender, EventArgs e)
        {
            string first_name = textBox_fname.Text;
            string last_name = textBox_lname.Text;
            string gender = "Male"; //by default
            string phone = textBox_phone.Text;
            string email = textBox_email.Text;

            if (radioButton_female.Checked)
            {
                gender = "Female";
            }

            MemoryStream ms = new MemoryStream();
            pictureBox_picture.Image.Save(ms, pictureBox_picture.Image.RawFormat);
            byte[] profile_picture = ms.ToArray();

            //check if the first and last name is empty.
            if (first_name.Trim().Equals("") || last_name.Trim().Equals("") || phone.Trim().Equals(""))
            {
                MessageBox.Show("You Need to Enter The Member's Required Fields", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (member.addMember(first_name, last_name, gender, phone, email, profile_picture))
                {
                    MessageBox.Show("New Member Added Successfully", "New Member", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //refresh datagridview
                    dataGridView_members.DataSource = member.MembersList(true);

                    //update the number of Authors
                    label_membersCount.Text = member.MembersList(true).Rows.Count.ToString() + " Members";
                }
                else
                {
                    MessageBox.Show("Memeber Not Added", "Add-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        //button edit the selected member
        private void button_Edit_Click(object sender, EventArgs e)
        {
            int id;
            string first_name = textBox_fname.Text;
            string last_name = textBox_lname.Text;
            string gender = "Male"; //by default
            string phone = textBox_phone.Text;
            string email = textBox_email.Text;

            if (radioButton_female.Checked)
            {
                gender = "Female";
            }

            MemoryStream ms = new MemoryStream();
            pictureBox_picture.Image.Save(ms, pictureBox_picture.Image.RawFormat);
            byte[] profile_picture = ms.ToArray();

            if (!textBox_id.Text.Trim().Equals(""))
            {
                //check if the first and last name is empty.
                if (first_name.Trim().Equals("") || last_name.Trim().Equals("") || phone.Trim().Equals(""))
                {
                    MessageBox.Show("You Need to Enter The Member's Required Fields", "Empty Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    id = Convert.ToInt32(textBox_id.Text);
                    if (member.editMember(id, first_name, last_name, gender, phone, email, profile_picture))
                    {
                        MessageBox.Show("Member Data Updated Successfully", "Member Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //refresh datagridview
                        dataGridView_members.DataSource = member.MembersList(true);

                        //update the number of Authors
                        label_membersCount.Text = member.MembersList(true).Rows.Count.ToString() + " Members";
                    }
                    else
                    {
                        MessageBox.Show("Memeber Data Not Updated", "Edit-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            else
            {
                MessageBox.Show("Select The Memebr From Table First", "Empty ID", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }

        //button delete the selected member
        private void button_Delete_Click(object sender, EventArgs e)
        {
            int id;
            //show a confirmation message before deletion
            if (MessageBox.Show("Do You Really Want To Delete This Member", "Confirmation Box", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!textBox_id.Text.Trim().Equals(""))
                {
                    id = Convert.ToInt32(textBox_id.Text);

                    if (member.deleteMember(id))
                    {
                        MessageBox.Show("Member Data Deleted Successfully", "Member Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                        //refresh datagridview
                        dataGridView_members.DataSource = member.MembersList(true);

                        //update the number of Authors
                        label_membersCount.Text = member.MembersList(true).Rows.Count.ToString() + " Members";

                        //we need to clear the field after deletion
                        //just call the button clear
                        button_Clear.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Memeber Data Not Deleted, Check If This ID Exists", "Delete-Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Select The Memebr From Table First", "Empty ID", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }

        private void dataGridView_members_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = dataGridView_members.CurrentRow.Cells[0].Value.ToString();

            //get the first and last name from fullname column
            string fullname = dataGridView_members.CurrentRow.Cells[1].Value.ToString();
            var first_and_last_name = fullname.Split('-');
            textBox_fname.Text = first_and_last_name[0];
            textBox_lname.Text = first_and_last_name[1];
            string gender = dataGridView_members.CurrentRow.Cells[2].Value.ToString();
            if (gender.Equals("Male"))
            {
                radioButton_male.Checked = true;
            }
            else
            {
                radioButton_female.Checked = true;
            }
            textBox_phone.Text = dataGridView_members.CurrentRow.Cells[3].Value.ToString();
            textBox_email.Text = dataGridView_members.CurrentRow.Cells[4].Value.ToString();
            byte[] picture = (byte[])dataGridView_members.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(picture);
            pictureBox_picture.Image = Image.FromStream(ms);
        }

        //button clear fields
        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_id.Text = "";
            textBox_fname.Text = "";
            textBox_lname.Text = "";
            textBox_phone.Text = "";
            textBox_email.Text = "";
            radioButton_male.Checked = true;
            radioButton_female.Checked = false;
            pictureBox_picture.ImageLocation = "../../../IMAGES/photo.png";
        }
    }
}
