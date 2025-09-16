namespace Library_Management_System.FORMS
{
    partial class ManageCirculationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCirculationForm));
            panel2 = new Panel();
            label1 = new Label();
            pictureBox_circulation = new PictureBox();
            label_circulation = new Label();
            panel5 = new Panel();
            button_Return = new Button();
            button__issue = new Button();
            panel_return = new Panel();
            button_losted = new Button();
            button_returned = new Button();
            button_issued = new Button();
            dataGridView_issuedBooks = new DataGridView();
            button_lostBook = new Button();
            button_returnBook = new Button();
            button_delete = new Button();
            richTextBox_note1 = new RichTextBox();
            dateTimePicker_return1 = new DateTimePicker();
            dateTimePicker_issue1 = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label_memberFullname1 = new Label();
            label_bookTitle1 = new Label();
            numericUpDown_memberId1 = new NumericUpDown();
            numericUpDown_bookId1 = new NumericUpDown();
            label2 = new Label();
            label6 = new Label();
            panel_issue = new Panel();
            button_issueBook = new Button();
            button_searchMember = new Button();
            button_searchbook = new Button();
            richTextBox_note = new RichTextBox();
            dateTimePicker_return = new DateTimePicker();
            dateTimePicker_issue = new DateTimePicker();
            label4 = new Label();
            label9 = new Label();
            label10 = new Label();
            label_availability = new Label();
            label12 = new Label();
            label_MemberFullname = new Label();
            label_bookTitle = new Label();
            numericUpDown_memberId = new NumericUpDown();
            numericUpDown_bookId = new NumericUpDown();
            label15 = new Label();
            label16 = new Label();
            button_showAll = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_circulation).BeginInit();
            panel5.SuspendLayout();
            panel_return.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_issuedBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_memberId1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_bookId1).BeginInit();
            panel_issue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_memberId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_bookId).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(108, 122, 137);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox_circulation);
            panel2.Controls.Add(label_circulation);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1344, 109);
            panel2.TabIndex = 9;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(108, 122, 137);
            label1.Cursor = Cursors.Hand;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1306, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 34);
            label1.TabIndex = 7;
            label1.Text = "X";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // pictureBox_circulation
            // 
            pictureBox_circulation.Image = (Image)resources.GetObject("pictureBox_circulation.Image");
            pictureBox_circulation.ImageLocation = "";
            pictureBox_circulation.Location = new Point(0, 0);
            pictureBox_circulation.Name = "pictureBox_circulation";
            pictureBox_circulation.Size = new Size(122, 109);
            pictureBox_circulation.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_circulation.TabIndex = 2;
            pictureBox_circulation.TabStop = false;
            // 
            // label_circulation
            // 
            label_circulation.BackColor = Color.FromArgb(108, 122, 137);
            label_circulation.Font = new Font("Comic Sans MS", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_circulation.ForeColor = Color.White;
            label_circulation.Location = new Point(123, 3);
            label_circulation.Name = "label_circulation";
            label_circulation.Size = new Size(336, 106);
            label_circulation.TabIndex = 1;
            label_circulation.Text = "Circulation";
            label_circulation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(1, 50, 67);
            panel5.Controls.Add(button_Return);
            panel5.Controls.Add(button__issue);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 109);
            panel5.Name = "panel5";
            panel5.Size = new Size(235, 698);
            panel5.TabIndex = 10;
            // 
            // button_Return
            // 
            button_Return.BackColor = Color.White;
            button_Return.FlatAppearance.BorderColor = Color.Black;
            button_Return.FlatStyle = FlatStyle.Flat;
            button_Return.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Return.Image = (Image)resources.GetObject("button_Return.Image");
            button_Return.Location = new Point(12, 136);
            button_Return.Name = "button_Return";
            button_Return.Size = new Size(214, 71);
            button_Return.TabIndex = 7;
            button_Return.Text = "Return";
            button_Return.TextAlign = ContentAlignment.MiddleRight;
            button_Return.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Return.UseVisualStyleBackColor = false;
            button_Return.Click += button_Return_Click;
            // 
            // button__issue
            // 
            button__issue.BackColor = Color.White;
            button__issue.FlatAppearance.BorderColor = Color.Black;
            button__issue.FlatStyle = FlatStyle.Flat;
            button__issue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button__issue.Image = (Image)resources.GetObject("button__issue.Image");
            button__issue.Location = new Point(12, 45);
            button__issue.Name = "button__issue";
            button__issue.Size = new Size(214, 71);
            button__issue.TabIndex = 6;
            button__issue.Text = "Issue";
            button__issue.TextAlign = ContentAlignment.MiddleRight;
            button__issue.TextImageRelation = TextImageRelation.ImageBeforeText;
            button__issue.UseVisualStyleBackColor = false;
            button__issue.Click += button__issue_Click;
            // 
            // panel_return
            // 
            panel_return.BackColor = Color.Ivory;
            panel_return.Controls.Add(button_showAll);
            panel_return.Controls.Add(button_losted);
            panel_return.Controls.Add(button_returned);
            panel_return.Controls.Add(button_issued);
            panel_return.Controls.Add(dataGridView_issuedBooks);
            panel_return.Controls.Add(button_lostBook);
            panel_return.Controls.Add(button_returnBook);
            panel_return.Controls.Add(button_delete);
            panel_return.Controls.Add(richTextBox_note1);
            panel_return.Controls.Add(dateTimePicker_return1);
            panel_return.Controls.Add(dateTimePicker_issue1);
            panel_return.Controls.Add(label8);
            panel_return.Controls.Add(label7);
            panel_return.Controls.Add(label5);
            panel_return.Controls.Add(label_memberFullname1);
            panel_return.Controls.Add(label_bookTitle1);
            panel_return.Controls.Add(numericUpDown_memberId1);
            panel_return.Controls.Add(numericUpDown_bookId1);
            panel_return.Controls.Add(label2);
            panel_return.Controls.Add(label6);
            panel_return.Location = new Point(242, 116);
            panel_return.Name = "panel_return";
            panel_return.Size = new Size(1096, 683);
            panel_return.TabIndex = 11;
            // 
            // button_losted
            // 
            button_losted.BackColor = Color.White;
            button_losted.FlatAppearance.BorderColor = Color.Black;
            button_losted.FlatStyle = FlatStyle.Flat;
            button_losted.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_losted.Location = new Point(788, 13);
            button_losted.Name = "button_losted";
            button_losted.Size = new Size(175, 43);
            button_losted.TabIndex = 61;
            button_losted.Text = "Losted";
            button_losted.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_losted.UseVisualStyleBackColor = false;
            button_losted.Click += button_losted_Click;
            // 
            // button_returned
            // 
            button_returned.BackColor = Color.White;
            button_returned.FlatAppearance.BorderColor = Color.Black;
            button_returned.FlatStyle = FlatStyle.Flat;
            button_returned.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_returned.Location = new Point(597, 13);
            button_returned.Name = "button_returned";
            button_returned.Size = new Size(175, 43);
            button_returned.TabIndex = 60;
            button_returned.Text = "Returned";
            button_returned.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_returned.UseVisualStyleBackColor = false;
            button_returned.Click += button_returned_Click;
            // 
            // button_issued
            // 
            button_issued.BackColor = Color.White;
            button_issued.FlatAppearance.BorderColor = Color.Black;
            button_issued.FlatStyle = FlatStyle.Flat;
            button_issued.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_issued.Location = new Point(406, 13);
            button_issued.Name = "button_issued";
            button_issued.Size = new Size(175, 43);
            button_issued.TabIndex = 8;
            button_issued.Text = "Issue";
            button_issued.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_issued.UseVisualStyleBackColor = false;
            button_issued.Click += button_issued_Click;
            // 
            // dataGridView_issuedBooks
            // 
            dataGridView_issuedBooks.AllowUserToAddRows = false;
            dataGridView_issuedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_issuedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_issuedBooks.Location = new Point(406, 62);
            dataGridView_issuedBooks.Name = "dataGridView_issuedBooks";
            dataGridView_issuedBooks.RowHeadersWidth = 62;
            dataGridView_issuedBooks.Size = new Size(658, 460);
            dataGridView_issuedBooks.TabIndex = 59;
            dataGridView_issuedBooks.CellClick += dataGridView_issuedBooks_CellClick;
            // 
            // button_lostBook
            // 
            button_lostBook.BackColor = Color.FromArgb(255, 128, 0);
            button_lostBook.Cursor = Cursors.Hand;
            button_lostBook.FlatAppearance.BorderColor = Color.Black;
            button_lostBook.FlatStyle = FlatStyle.Flat;
            button_lostBook.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_lostBook.ForeColor = Color.White;
            button_lostBook.Location = new Point(555, 541);
            button_lostBook.Name = "button_lostBook";
            button_lostBook.Size = new Size(509, 54);
            button_lostBook.TabIndex = 58;
            button_lostBook.Text = "Lost Book";
            button_lostBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_lostBook.UseVisualStyleBackColor = false;
            button_lostBook.Click += button_lostBook_Click;
            // 
            // button_returnBook
            // 
            button_returnBook.BackColor = Color.FromArgb(0, 192, 0);
            button_returnBook.Cursor = Cursors.Hand;
            button_returnBook.FlatAppearance.BorderColor = Color.Black;
            button_returnBook.FlatStyle = FlatStyle.Flat;
            button_returnBook.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_returnBook.ForeColor = Color.White;
            button_returnBook.Location = new Point(34, 541);
            button_returnBook.Name = "button_returnBook";
            button_returnBook.Size = new Size(508, 54);
            button_returnBook.TabIndex = 57;
            button_returnBook.Text = "Return Book";
            button_returnBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_returnBook.UseVisualStyleBackColor = false;
            button_returnBook.Click += button_returnBook_Click;
            // 
            // button_delete
            // 
            button_delete.BackColor = Color.FromArgb(192, 0, 0);
            button_delete.Cursor = Cursors.Hand;
            button_delete.FlatAppearance.BorderColor = Color.Black;
            button_delete.FlatStyle = FlatStyle.Flat;
            button_delete.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_delete.ForeColor = Color.White;
            button_delete.Location = new Point(34, 610);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(1030, 54);
            button_delete.TabIndex = 56;
            button_delete.Text = "Delete";
            button_delete.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_delete.UseVisualStyleBackColor = false;
            button_delete.Click += button_delete_Click;
            // 
            // richTextBox_note1
            // 
            richTextBox_note1.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox_note1.Location = new Point(93, 345);
            richTextBox_note1.Name = "richTextBox_note1";
            richTextBox_note1.Size = new Size(269, 177);
            richTextBox_note1.TabIndex = 53;
            richTextBox_note1.Text = "";
            // 
            // dateTimePicker_return1
            // 
            dateTimePicker_return1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker_return1.Format = DateTimePickerFormat.Short;
            dateTimePicker_return1.Location = new Point(160, 273);
            dateTimePicker_return1.Name = "dateTimePicker_return1";
            dateTimePicker_return1.Size = new Size(202, 39);
            dateTimePicker_return1.TabIndex = 52;
            // 
            // dateTimePicker_issue1
            // 
            dateTimePicker_issue1.Enabled = false;
            dateTimePicker_issue1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker_issue1.Format = DateTimePickerFormat.Short;
            dateTimePicker_issue1.Location = new Point(160, 206);
            dateTimePicker_issue1.Name = "dateTimePicker_issue1";
            dateTimePicker_issue1.Size = new Size(202, 39);
            dateTimePicker_issue1.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F);
            label8.Location = new Point(16, 360);
            label8.Name = "label8";
            label8.Size = new Size(71, 29);
            label8.TabIndex = 50;
            label8.Text = "Note:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.Location = new Point(8, 281);
            label7.Name = "label7";
            label7.Size = new Size(146, 29);
            label7.TabIndex = 49;
            label7.Text = "Return Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(22, 208);
            label5.Name = "label5";
            label5.Size = new Size(132, 29);
            label5.TabIndex = 48;
            label5.Text = "Issue Date:";
            // 
            // label_memberFullname1
            // 
            label_memberFullname1.AutoSize = true;
            label_memberFullname1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_memberFullname1.ForeColor = Color.DeepSkyBlue;
            label_memberFullname1.Location = new Point(160, 163);
            label_memberFullname1.Name = "label_memberFullname1";
            label_memberFullname1.Size = new Size(169, 25);
            label_memberFullname1.TabIndex = 45;
            label_memberFullname1.Text = "Member Fullname";
            // 
            // label_bookTitle1
            // 
            label_bookTitle1.AutoSize = true;
            label_bookTitle1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_bookTitle1.ForeColor = Color.DeepSkyBlue;
            label_bookTitle1.Location = new Point(160, 80);
            label_bookTitle1.Name = "label_bookTitle1";
            label_bookTitle1.Size = new Size(99, 25);
            label_bookTitle1.TabIndex = 44;
            label_bookTitle1.Text = "Book Title";
            // 
            // numericUpDown_memberId1
            // 
            numericUpDown_memberId1.Cursor = Cursors.IBeam;
            numericUpDown_memberId1.Enabled = false;
            numericUpDown_memberId1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown_memberId1.Location = new Point(160, 123);
            numericUpDown_memberId1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown_memberId1.Name = "numericUpDown_memberId1";
            numericUpDown_memberId1.Size = new Size(169, 37);
            numericUpDown_memberId1.TabIndex = 43;
            // 
            // numericUpDown_bookId1
            // 
            numericUpDown_bookId1.Cursor = Cursors.IBeam;
            numericUpDown_bookId1.Enabled = false;
            numericUpDown_bookId1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown_bookId1.Location = new Point(160, 40);
            numericUpDown_bookId1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown_bookId1.Name = "numericUpDown_bookId1";
            numericUpDown_bookId1.Size = new Size(169, 37);
            numericUpDown_bookId1.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F);
            label2.Location = new Point(16, 125);
            label2.Name = "label2";
            label2.Size = new Size(138, 29);
            label2.TabIndex = 21;
            label2.Text = "Member ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(50, 42);
            label6.Name = "label6";
            label6.Size = new Size(104, 29);
            label6.TabIndex = 19;
            label6.Text = "Book ID:";
            // 
            // panel_issue
            // 
            panel_issue.BackColor = Color.OldLace;
            panel_issue.Controls.Add(button_issueBook);
            panel_issue.Controls.Add(button_searchMember);
            panel_issue.Controls.Add(button_searchbook);
            panel_issue.Controls.Add(richTextBox_note);
            panel_issue.Controls.Add(dateTimePicker_return);
            panel_issue.Controls.Add(dateTimePicker_issue);
            panel_issue.Controls.Add(label4);
            panel_issue.Controls.Add(label9);
            panel_issue.Controls.Add(label10);
            panel_issue.Controls.Add(label_availability);
            panel_issue.Controls.Add(label12);
            panel_issue.Controls.Add(label_MemberFullname);
            panel_issue.Controls.Add(label_bookTitle);
            panel_issue.Controls.Add(numericUpDown_memberId);
            panel_issue.Controls.Add(numericUpDown_bookId);
            panel_issue.Controls.Add(label15);
            panel_issue.Controls.Add(label16);
            panel_issue.Location = new Point(242, 116);
            panel_issue.Name = "panel_issue";
            panel_issue.Size = new Size(1096, 683);
            panel_issue.TabIndex = 57;
            // 
            // button_issueBook
            // 
            button_issueBook.BackColor = Color.FromArgb(35, 203, 167);
            button_issueBook.Cursor = Cursors.Hand;
            button_issueBook.FlatAppearance.BorderColor = Color.Black;
            button_issueBook.FlatStyle = FlatStyle.Flat;
            button_issueBook.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_issueBook.ForeColor = Color.White;
            button_issueBook.Location = new Point(34, 610);
            button_issueBook.Name = "button_issueBook";
            button_issueBook.Size = new Size(1030, 54);
            button_issueBook.TabIndex = 56;
            button_issueBook.Text = "Issue Book";
            button_issueBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_issueBook.UseVisualStyleBackColor = false;
            button_issueBook.Click += button_issueBook_Click_1;
            // 
            // button_searchMember
            // 
            button_searchMember.BackColor = Color.White;
            button_searchMember.Cursor = Cursors.Hand;
            button_searchMember.FlatAppearance.BorderColor = Color.Black;
            button_searchMember.FlatStyle = FlatStyle.Flat;
            button_searchMember.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_searchMember.Location = new Point(686, 121);
            button_searchMember.Name = "button_searchMember";
            button_searchMember.Size = new Size(139, 37);
            button_searchMember.TabIndex = 55;
            button_searchMember.Text = "Search Member";
            button_searchMember.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_searchMember.UseVisualStyleBackColor = false;
            button_searchMember.Click += button_searchMember_Click_1;
            // 
            // button_searchbook
            // 
            button_searchbook.BackColor = Color.White;
            button_searchbook.Cursor = Cursors.Hand;
            button_searchbook.FlatAppearance.BorderColor = Color.Black;
            button_searchbook.FlatStyle = FlatStyle.Flat;
            button_searchbook.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_searchbook.Location = new Point(686, 38);
            button_searchbook.Name = "button_searchbook";
            button_searchbook.Size = new Size(139, 37);
            button_searchbook.TabIndex = 54;
            button_searchbook.Text = "Search Book";
            button_searchbook.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_searchbook.UseVisualStyleBackColor = false;
            button_searchbook.Click += button_searchbook_Click_1;
            // 
            // richTextBox_note
            // 
            richTextBox_note.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox_note.Location = new Point(326, 411);
            richTextBox_note.Name = "richTextBox_note";
            richTextBox_note.Size = new Size(419, 171);
            richTextBox_note.TabIndex = 53;
            richTextBox_note.Text = "";
            // 
            // dateTimePicker_return
            // 
            dateTimePicker_return.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker_return.Format = DateTimePickerFormat.Short;
            dateTimePicker_return.Location = new Point(511, 338);
            dateTimePicker_return.Name = "dateTimePicker_return";
            dateTimePicker_return.Size = new Size(202, 39);
            dateTimePicker_return.TabIndex = 52;
            // 
            // dateTimePicker_issue
            // 
            dateTimePicker_issue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker_issue.Format = DateTimePickerFormat.Short;
            dateTimePicker_issue.Location = new Point(511, 271);
            dateTimePicker_issue.Name = "dateTimePicker_issue";
            dateTimePicker_issue.Size = new Size(202, 39);
            dateTimePicker_issue.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(249, 426);
            label4.Name = "label4";
            label4.Size = new Size(71, 29);
            label4.TabIndex = 50;
            label4.Text = "Note:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F);
            label9.Location = new Point(359, 346);
            label9.Name = "label9";
            label9.Size = new Size(146, 29);
            label9.TabIndex = 49;
            label9.Text = "Return Date:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F);
            label10.Location = new Point(373, 273);
            label10.Name = "label10";
            label10.Size = new Size(132, 29);
            label10.TabIndex = 48;
            label10.Text = "Issue Date:";
            // 
            // label_availability
            // 
            label_availability.AutoSize = true;
            label_availability.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_availability.ForeColor = Color.DeepSkyBlue;
            label_availability.Location = new Point(511, 204);
            label_availability.Name = "label_availability";
            label_availability.Size = new Size(170, 37);
            label_availability.TabIndex = 47;
            label_availability.Text = "Yes or No";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F);
            label12.Location = new Point(249, 207);
            label12.Name = "label12";
            label12.Size = new Size(256, 29);
            label12.TabIndex = 46;
            label12.Text = "Is This Book Available:";
            // 
            // label_MemberFullname
            // 
            label_MemberFullname.AutoSize = true;
            label_MemberFullname.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_MemberFullname.ForeColor = Color.DeepSkyBlue;
            label_MemberFullname.Location = new Point(511, 161);
            label_MemberFullname.Name = "label_MemberFullname";
            label_MemberFullname.Size = new Size(169, 25);
            label_MemberFullname.TabIndex = 45;
            label_MemberFullname.Text = "Member Fullname";
            // 
            // label_bookTitle
            // 
            label_bookTitle.AutoSize = true;
            label_bookTitle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_bookTitle.ForeColor = Color.DeepSkyBlue;
            label_bookTitle.Location = new Point(511, 78);
            label_bookTitle.Name = "label_bookTitle";
            label_bookTitle.Size = new Size(99, 25);
            label_bookTitle.TabIndex = 44;
            label_bookTitle.Text = "Book Title";
            // 
            // numericUpDown_memberId
            // 
            numericUpDown_memberId.Cursor = Cursors.IBeam;
            numericUpDown_memberId.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown_memberId.Location = new Point(511, 121);
            numericUpDown_memberId.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown_memberId.Name = "numericUpDown_memberId";
            numericUpDown_memberId.Size = new Size(169, 37);
            numericUpDown_memberId.TabIndex = 43;
            // 
            // numericUpDown_bookId
            // 
            numericUpDown_bookId.Cursor = Cursors.IBeam;
            numericUpDown_bookId.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown_bookId.Location = new Point(511, 38);
            numericUpDown_bookId.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown_bookId.Name = "numericUpDown_bookId";
            numericUpDown_bookId.Size = new Size(169, 37);
            numericUpDown_bookId.TabIndex = 42;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 12F);
            label15.Location = new Point(255, 123);
            label15.Name = "label15";
            label15.Size = new Size(250, 29);
            label15.TabIndex = 21;
            label15.Text = "Enter The Member ID:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 12F);
            label16.Location = new Point(289, 40);
            label16.Name = "label16";
            label16.Size = new Size(216, 29);
            label16.TabIndex = 19;
            label16.Text = "Enter The Book ID:";
            // 
            // button_showAll
            // 
            button_showAll.BackColor = Color.White;
            button_showAll.FlatAppearance.BorderColor = Color.Black;
            button_showAll.FlatStyle = FlatStyle.Flat;
            button_showAll.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_showAll.Location = new Point(978, 13);
            button_showAll.Name = "button_showAll";
            button_showAll.Size = new Size(86, 43);
            button_showAll.TabIndex = 62;
            button_showAll.Text = "All";
            button_showAll.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_showAll.UseVisualStyleBackColor = false;
            button_showAll.Click += button_showAll_Click;
            // 
            // ManageCirculationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(1344, 807);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel_return);
            Controls.Add(panel_issue);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCirculationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCirculationForm";
            Load += ManageCirculationForm_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_circulation).EndInit();
            panel5.ResumeLayout(false);
            panel_return.ResumeLayout(false);
            panel_return.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_issuedBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_memberId1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_bookId1).EndInit();
            panel_issue.ResumeLayout(false);
            panel_issue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_memberId).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_bookId).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox_circulation;
        private Label label_circulation;
        private Panel panel5;
        
        
        
        private Button button__issue;
        private Panel panel_return;
        private Button button_Return;
        private Label label2;
        private Label label6;
        private NumericUpDown numericUpDown_memberId1;
        private NumericUpDown numericUpDown_bookId1;
        private Label label_bookTitle1;
        private Label label_memberFullname1;
        private Label label5;
        private Label label8;
        private Label label7;
        private DateTimePicker dateTimePicker_issue1;
        private RichTextBox richTextBox_note1;
        private DateTimePicker dateTimePicker_return1;
        private Button button_delete;
        private Panel panel_issue;
        private Button button_issueBook;
        private Button button_searchMember;
        private Button button_searchbook;
        private RichTextBox richTextBox_note;
        private DateTimePicker dateTimePicker_return;
        private DateTimePicker dateTimePicker_issue;
        private Label label4;
        private Label label9;
        private Label label10;
        private Label label_availability;
        private Label label12;
        private Label label_MemberFullname;
        private Label label_bookTitle;
        private NumericUpDown numericUpDown_memberId;
        private NumericUpDown numericUpDown_bookId;
        private Label label15;
        private Label label16;
        private Button button_lostBook;
        private Button button_returnBook;
        private DataGridView dataGridView_issuedBooks;
        private Button button_losted;
        private Button button_returned;
        private Button button_issued;
        private Button button_showAll;
    }
}