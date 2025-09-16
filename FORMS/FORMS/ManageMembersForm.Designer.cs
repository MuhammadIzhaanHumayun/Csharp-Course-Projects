namespace Library_Management_System.FORMS
{
    partial class ManageMembersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageMembersForm));
            pictureBox_picture = new PictureBox();
            panel1 = new Panel();
            panel7 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label13 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            radioButton_female = new RadioButton();
            radioButton_male = new RadioButton();
            button_Select_Picture = new Button();
            textBox_email = new TextBox();
            label6 = new Label();
            textBox_phone = new TextBox();
            label5 = new Label();
            dataGridView_members = new DataGridView();
            label4 = new Label();
            textBox_lname = new TextBox();
            label3 = new Label();
            textBox_fname = new TextBox();
            textBox_id = new TextBox();
            label2 = new Label();
            label_id = new Label();
            panel5 = new Panel();
            label_membersCount = new Label();
            button_Clear = new Button();
            button_Delete = new Button();
            button_Edit = new Button();
            button_Add = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            panel3 = new Panel();
            label_close = new Label();
            pictureBox_Members = new PictureBox();
            label_genres = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_picture).BeginInit();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_members).BeginInit();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Members).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_picture
            // 
            pictureBox_picture.BackColor = Color.Gray;
            pictureBox_picture.Image = (Image)resources.GetObject("pictureBox_picture.Image");
            pictureBox_picture.ImageLocation = "";
            pictureBox_picture.Location = new Point(182, 396);
            pictureBox_picture.Name = "pictureBox_picture";
            pictureBox_picture.Size = new Size(300, 317);
            pictureBox_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_picture.TabIndex = 37;
            pictureBox_picture.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(1, 50, 67);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1555, 921);
            panel1.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(label8);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(label13);
            panel7.Controls.Add(label1);
            panel7.Controls.Add(groupBox1);
            panel7.Controls.Add(button_Select_Picture);
            panel7.Controls.Add(pictureBox_picture);
            panel7.Controls.Add(textBox_email);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(textBox_phone);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(dataGridView_members);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(textBox_lname);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(textBox_fname);
            panel7.Controls.Add(textBox_id);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(label_id);
            panel7.Location = new Point(241, 115);
            panel7.Name = "panel7";
            panel7.Size = new Size(1302, 794);
            panel7.TabIndex = 7;
            // 
            // label8
            // 
            label8.BackColor = Color.White;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(456, 278);
            label8.Name = "label8";
            label8.Size = new Size(22, 21);
            label8.TabIndex = 51;
            label8.Text = "*";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.BackColor = Color.White;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(456, 165);
            label7.Name = "label7";
            label7.Size = new Size(22, 21);
            label7.TabIndex = 50;
            label7.Text = "*";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.BackColor = Color.White;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(456, 111);
            label13.Name = "label13";
            label13.Size = new Size(25, 17);
            label13.TabIndex = 49;
            label13.Text = "*";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 537);
            label1.Name = "label1";
            label1.Size = new Size(111, 32);
            label1.TabIndex = 41;
            label1.Text = "Picture:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton_female);
            groupBox1.Controls.Add(radioButton_male);
            groupBox1.Location = new Point(182, 207);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 53);
            groupBox1.TabIndex = 40;
            groupBox1.TabStop = false;
            // 
            // radioButton_female
            // 
            radioButton_female.AutoSize = true;
            radioButton_female.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton_female.Location = new Point(140, 14);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(120, 33);
            radioButton_female.TabIndex = 1;
            radioButton_female.Text = "Female";
            radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            radioButton_male.AutoSize = true;
            radioButton_male.Checked = true;
            radioButton_male.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton_male.ForeColor = SystemColors.ControlText;
            radioButton_male.Location = new Point(6, 14);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(91, 33);
            radioButton_male.TabIndex = 0;
            radioButton_male.TabStop = true;
            radioButton_male.Text = "Male";
            radioButton_male.UseVisualStyleBackColor = true;
            // 
            // button_Select_Picture
            // 
            button_Select_Picture.BackColor = Color.White;
            button_Select_Picture.Cursor = Cursors.Hand;
            button_Select_Picture.FlatAppearance.BorderColor = Color.Black;
            button_Select_Picture.FlatStyle = FlatStyle.Flat;
            button_Select_Picture.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Select_Picture.Image = (Image)resources.GetObject("button_Select_Picture.Image");
            button_Select_Picture.Location = new Point(181, 732);
            button_Select_Picture.Name = "button_Select_Picture";
            button_Select_Picture.Size = new Size(301, 46);
            button_Select_Picture.TabIndex = 39;
            button_Select_Picture.Text = "Select Picture";
            button_Select_Picture.TextAlign = ContentAlignment.MiddleRight;
            button_Select_Picture.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Select_Picture.UseVisualStyleBackColor = false;
            button_Select_Picture.Click += button_Select_Picture_Click;
            // 
            // textBox_email
            // 
            textBox_email.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_email.Location = new Point(181, 336);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(301, 37);
            textBox_email.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(82, 336);
            label6.Name = "label6";
            label6.Size = new Size(94, 32);
            label6.TabIndex = 17;
            label6.Text = "Email:";
            // 
            // textBox_phone
            // 
            textBox_phone.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_phone.Location = new Point(181, 277);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(301, 37);
            textBox_phone.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(69, 277);
            label5.Name = "label5";
            label5.Size = new Size(105, 32);
            label5.TabIndex = 15;
            label5.Text = "Phone:";
            // 
            // dataGridView_members
            // 
            dataGridView_members.AllowUserToAddRows = false;
            dataGridView_members.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_members.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_members.Location = new Point(514, 17);
            dataGridView_members.Name = "dataGridView_members";
            dataGridView_members.RowHeadersWidth = 62;
            dataGridView_members.Size = new Size(771, 761);
            dataGridView_members.TabIndex = 14;
            dataGridView_members.CellClick += dataGridView_members_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(58, 219);
            label4.Name = "label4";
            label4.Size = new Size(117, 32);
            label4.TabIndex = 10;
            label4.Text = "Gender:";
            // 
            // textBox_lname
            // 
            textBox_lname.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_lname.Location = new Point(181, 164);
            textBox_lname.Name = "textBox_lname";
            textBox_lname.Size = new Size(301, 37);
            textBox_lname.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 164);
            label3.Name = "label3";
            label3.Size = new Size(158, 32);
            label3.TabIndex = 8;
            label3.Text = "Last Name:";
            // 
            // textBox_fname
            // 
            textBox_fname.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_fname.Location = new Point(181, 110);
            textBox_fname.Name = "textBox_fname";
            textBox_fname.Size = new Size(301, 37);
            textBox_fname.TabIndex = 7;
            // 
            // textBox_id
            // 
            textBox_id.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_id.Location = new Point(181, 57);
            textBox_id.Name = "textBox_id";
            textBox_id.ReadOnly = true;
            textBox_id.Size = new Size(145, 37);
            textBox_id.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 110);
            label2.Name = "label2";
            label2.Size = new Size(159, 32);
            label2.TabIndex = 5;
            label2.Text = "First Name:";
            // 
            // label_id
            // 
            label_id.AutoSize = true;
            label_id.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_id.Location = new Point(126, 54);
            label_id.Name = "label_id";
            label_id.Size = new Size(49, 32);
            label_id.TabIndex = 4;
            label_id.Text = "ID:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(1, 50, 67);
            panel5.Controls.Add(label_membersCount);
            panel5.Controls.Add(button_Clear);
            panel5.Controls.Add(button_Delete);
            panel5.Controls.Add(button_Edit);
            panel5.Controls.Add(button_Add);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 109);
            panel5.Name = "panel5";
            panel5.Size = new Size(235, 812);
            panel5.TabIndex = 6;
            // 
            // label_membersCount
            // 
            label_membersCount.BackColor = Color.Transparent;
            label_membersCount.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_membersCount.ForeColor = Color.Yellow;
            label_membersCount.Location = new Point(0, 748);
            label_membersCount.Name = "label_membersCount";
            label_membersCount.Size = new Size(235, 64);
            label_membersCount.TabIndex = 53;
            label_membersCount.Text = "9999 Members";
            label_membersCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Clear
            // 
            button_Clear.BackColor = Color.White;
            button_Clear.Cursor = Cursors.Hand;
            button_Clear.FlatAppearance.BorderColor = Color.Black;
            button_Clear.FlatStyle = FlatStyle.Flat;
            button_Clear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Clear.Image = (Image)resources.GetObject("button_Clear.Image");
            button_Clear.Location = new Point(12, 326);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(214, 71);
            button_Clear.TabIndex = 9;
            button_Clear.Text = "Clear";
            button_Clear.TextAlign = ContentAlignment.MiddleRight;
            button_Clear.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Clear.UseVisualStyleBackColor = false;
            button_Clear.Click += button_Clear_Click;
            // 
            // button_Delete
            // 
            button_Delete.BackColor = Color.White;
            button_Delete.Cursor = Cursors.Hand;
            button_Delete.FlatAppearance.BorderColor = Color.Black;
            button_Delete.FlatStyle = FlatStyle.Flat;
            button_Delete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Delete.Image = (Image)resources.GetObject("button_Delete.Image");
            button_Delete.Location = new Point(12, 231);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(214, 71);
            button_Delete.TabIndex = 8;
            button_Delete.Text = "Delete";
            button_Delete.TextAlign = ContentAlignment.MiddleRight;
            button_Delete.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Delete.UseVisualStyleBackColor = false;
            button_Delete.Click += button_Delete_Click;
            // 
            // button_Edit
            // 
            button_Edit.BackColor = Color.White;
            button_Edit.Cursor = Cursors.Hand;
            button_Edit.FlatAppearance.BorderColor = Color.Black;
            button_Edit.FlatStyle = FlatStyle.Flat;
            button_Edit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Edit.Image = (Image)resources.GetObject("button_Edit.Image");
            button_Edit.Location = new Point(12, 137);
            button_Edit.Name = "button_Edit";
            button_Edit.Size = new Size(214, 71);
            button_Edit.TabIndex = 7;
            button_Edit.Text = "Edit";
            button_Edit.TextAlign = ContentAlignment.MiddleRight;
            button_Edit.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Edit.UseVisualStyleBackColor = false;
            button_Edit.Click += button_Edit_Click;
            // 
            // button_Add
            // 
            button_Add.BackColor = Color.White;
            button_Add.Cursor = Cursors.Hand;
            button_Add.FlatAppearance.BorderColor = Color.Black;
            button_Add.FlatStyle = FlatStyle.Flat;
            button_Add.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Add.Image = (Image)resources.GetObject("button_Add.Image");
            button_Add.Location = new Point(12, 45);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(214, 71);
            button_Add.TabIndex = 6;
            button_Add.Text = "Add";
            button_Add.TextAlign = ContentAlignment.MiddleRight;
            button_Add.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Add.UseVisualStyleBackColor = false;
            button_Add.Click += button_Add_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.OldLace;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label_close);
            panel2.Controls.Add(pictureBox_Members);
            panel2.Controls.Add(label_genres);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1555, 109);
            panel2.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Location = new Point(0, 108);
            panel4.Name = "panel4";
            panel4.Size = new Size(309, 576);
            panel4.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.Location = new Point(303, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(1041, 576);
            panel6.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 108);
            panel3.Name = "panel3";
            panel3.Size = new Size(312, 576);
            panel3.TabIndex = 6;
            // 
            // label_close
            // 
            label_close.BackColor = Color.OldLace;
            label_close.Cursor = Cursors.Hand;
            label_close.FlatStyle = FlatStyle.Flat;
            label_close.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_close.ForeColor = Color.Red;
            label_close.Location = new Point(1517, 0);
            label_close.Name = "label_close";
            label_close.Size = new Size(38, 34);
            label_close.TabIndex = 3;
            label_close.Text = "X";
            label_close.TextAlign = ContentAlignment.MiddleCenter;
            label_close.Click += label_close_Click;
            // 
            // pictureBox_Members
            // 
            pictureBox_Members.Image = (Image)resources.GetObject("pictureBox_Members.Image");
            pictureBox_Members.ImageLocation = "";
            pictureBox_Members.Location = new Point(0, 0);
            pictureBox_Members.Name = "pictureBox_Members";
            pictureBox_Members.Size = new Size(160, 109);
            pictureBox_Members.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Members.TabIndex = 2;
            pictureBox_Members.TabStop = false;
            // 
            // label_genres
            // 
            label_genres.BackColor = Color.OldLace;
            label_genres.Font = new Font("Comic Sans MS", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_genres.ForeColor = Color.Orange;
            label_genres.Location = new Point(161, 3);
            label_genres.Name = "label_genres";
            label_genres.Size = new Size(336, 106);
            label_genres.TabIndex = 1;
            label_genres.Text = "Members";
            label_genres.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ManageMembersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1555, 921);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageMembersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageMembersForm";
            Load += ManageMembersForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_picture).EndInit();
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_members).EndInit();
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Members).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel7;
        private DataGridView dataGridView_members;
        private Label label4;
        private TextBox textBox_lname;
        private Label label3;
        private TextBox textBox_fname;
        private TextBox textBox_id;
        private Label label2;
        private Label label_id;
        private Panel panel5;
        private Label label_membersCount;
        private Button button_Clear;
        private Button button_Delete;
        private Button button_Edit;
        private Button button_Add;
        private Panel panel2;
        private Panel panel4;
        private Panel panel6;
        private Panel panel3;
        private Label label_close;
        private PictureBox pictureBox_Members;
        private Label label_genres;
        private TextBox textBox_email;
        private Label label6;
        private TextBox textBox_phone;
        private Label label5;
        private PictureBox pictureBox_picture;
        private Button button_Select_Picture;
        private GroupBox groupBox1;
        private RadioButton radioButton_female;
        private RadioButton radioButton_male;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label13;
    }
}