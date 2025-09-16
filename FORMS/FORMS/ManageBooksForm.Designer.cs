namespace Library_Management_System.FORMS
{
    partial class ManageBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBooksForm));
            panel2 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            panel6 = new Panel();
            panel3 = new Panel();
            pictureBox_Books = new PictureBox();
            label_genres = new Label();
            panel5 = new Panel();
            button_export = new Button();
            button_ShowBooksList = new Button();
            label_booksCount = new Label();
            button_Delete = new Button();
            button_Edit = new Button();
            button_Add = new Button();
            panel_add = new Panel();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            button_clearfields = new Button();
            button_addBook = new Button();
            button_SelectAuthor = new Button();
            label_author_id = new Label();
            textBox_authorfullname = new TextBox();
            numericUpDown_quantity = new NumericUpDown();
            comboBox_genre = new ComboBox();
            button_Select_Cover = new Button();
            label_cover = new Label();
            pictureBox_cover = new PictureBox();
            textBox_publisher = new TextBox();
            label11 = new Label();
            dateTimePicker_dateRecieved = new DateTimePicker();
            label10 = new Label();
            textBox_price = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            richTextBox_description = new RichTextBox();
            label5 = new Label();
            label4 = new Label();
            textBox_title = new TextBox();
            label3 = new Label();
            textBox_isbn = new TextBox();
            textBox_id = new TextBox();
            label2 = new Label();
            label6 = new Label();
            panel_AddPanel = new Panel();
            button_ByISBN = new Button();
            button_SearchById = new Button();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            button_editBook = new Button();
            button_selectAuthor_Edit = new Button();
            label_authorid_Edit = new Label();
            textBox_author_Edit = new TextBox();
            numericUpDown_quantity_Edit = new NumericUpDown();
            comboBox_genre_Edit = new ComboBox();
            button_selectCover_Edit = new Button();
            label25 = new Label();
            pictureBox_cover_Edit = new PictureBox();
            textBox_publisher_Edit = new TextBox();
            label26 = new Label();
            dateTimePicker_daterecieved_Edit = new DateTimePicker();
            label27 = new Label();
            textBox_price_Edit = new TextBox();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            richTextBox_description_Edit = new RichTextBox();
            label31 = new Label();
            label32 = new Label();
            textBox_title_Edit = new TextBox();
            label33 = new Label();
            textBox_isbn_Edit = new TextBox();
            textBox_id_Edit = new TextBox();
            label34 = new Label();
            label35 = new Label();
            panel_ShowBooks = new Panel();
            button_RemoveThisBook = new Button();
            button_EditThisBook = new Button();
            dataGridView_Books = new DataGridView();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Books).BeginInit();
            panel5.SuspendLayout();
            panel_add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_cover).BeginInit();
            panel_AddPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_quantity_Edit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_cover_Edit).BeginInit();
            panel_ShowBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Books).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(242, 120, 75);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(pictureBox_Books);
            panel2.Controls.Add(label_genres);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1718, 109);
            panel2.TabIndex = 8;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(242, 120, 75);
            label1.Cursor = Cursors.Hand;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1680, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 34);
            label1.TabIndex = 7;
            label1.Text = "X";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
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
            // pictureBox_Books
            // 
            pictureBox_Books.Image = (Image)resources.GetObject("pictureBox_Books.Image");
            pictureBox_Books.ImageLocation = "";
            pictureBox_Books.Location = new Point(3, 3);
            pictureBox_Books.Name = "pictureBox_Books";
            pictureBox_Books.Size = new Size(114, 103);
            pictureBox_Books.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Books.TabIndex = 2;
            pictureBox_Books.TabStop = false;
            // 
            // label_genres
            // 
            label_genres.BackColor = Color.FromArgb(242, 120, 75);
            label_genres.Font = new Font("Comic Sans MS", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_genres.ForeColor = Color.White;
            label_genres.Location = new Point(123, 3);
            label_genres.Name = "label_genres";
            label_genres.Size = new Size(336, 106);
            label_genres.TabIndex = 1;
            label_genres.Text = "Books";
            label_genres.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(1, 50, 67);
            panel5.Controls.Add(button_export);
            panel5.Controls.Add(button_ShowBooksList);
            panel5.Controls.Add(label_booksCount);
            panel5.Controls.Add(button_Delete);
            panel5.Controls.Add(button_Edit);
            panel5.Controls.Add(button_Add);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 109);
            panel5.Name = "panel5";
            panel5.Size = new Size(235, 616);
            panel5.TabIndex = 9;
            // 
            // button_export
            // 
            button_export.BackColor = Color.White;
            button_export.FlatAppearance.BorderColor = Color.Black;
            button_export.FlatStyle = FlatStyle.Flat;
            button_export.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_export.Image = (Image)resources.GetObject("button_export.Image");
            button_export.Location = new Point(12, 416);
            button_export.Name = "button_export";
            button_export.Size = new Size(214, 82);
            button_export.TabIndex = 55;
            button_export.Text = "Export Books To Txt File";
            button_export.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_export.UseVisualStyleBackColor = false;
            button_export.Click += button_export_Click;
            // 
            // button_ShowBooksList
            // 
            button_ShowBooksList.BackColor = Color.White;
            button_ShowBooksList.FlatAppearance.BorderColor = Color.Black;
            button_ShowBooksList.FlatStyle = FlatStyle.Flat;
            button_ShowBooksList.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_ShowBooksList.Image = (Image)resources.GetObject("button_ShowBooksList.Image");
            button_ShowBooksList.Location = new Point(12, 231);
            button_ShowBooksList.Name = "button_ShowBooksList";
            button_ShowBooksList.Size = new Size(214, 71);
            button_ShowBooksList.TabIndex = 53;
            button_ShowBooksList.Text = "Books List";
            button_ShowBooksList.TextAlign = ContentAlignment.MiddleRight;
            button_ShowBooksList.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_ShowBooksList.UseVisualStyleBackColor = false;
            button_ShowBooksList.Click += button_ShowBooksList_Click;
            // 
            // label_booksCount
            // 
            label_booksCount.BackColor = Color.Transparent;
            label_booksCount.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_booksCount.ForeColor = Color.Yellow;
            label_booksCount.Location = new Point(0, 563);
            label_booksCount.Name = "label_booksCount";
            label_booksCount.Size = new Size(235, 32);
            label_booksCount.TabIndex = 52;
            label_booksCount.Text = "999999 Books";
            label_booksCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Delete
            // 
            button_Delete.BackColor = Color.White;
            button_Delete.FlatAppearance.BorderColor = Color.Black;
            button_Delete.FlatStyle = FlatStyle.Flat;
            button_Delete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Delete.Image = (Image)resources.GetObject("button_Delete.Image");
            button_Delete.Location = new Point(12, 324);
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
            // panel_add
            // 
            panel_add.BackColor = Color.Gainsboro;
            panel_add.Controls.Add(label17);
            panel_add.Controls.Add(label16);
            panel_add.Controls.Add(label15);
            panel_add.Controls.Add(label14);
            panel_add.Controls.Add(label13);
            panel_add.Controls.Add(label12);
            panel_add.Controls.Add(button_clearfields);
            panel_add.Controls.Add(button_addBook);
            panel_add.Controls.Add(button_SelectAuthor);
            panel_add.Controls.Add(label_author_id);
            panel_add.Controls.Add(textBox_authorfullname);
            panel_add.Controls.Add(numericUpDown_quantity);
            panel_add.Controls.Add(comboBox_genre);
            panel_add.Controls.Add(button_Select_Cover);
            panel_add.Controls.Add(label_cover);
            panel_add.Controls.Add(pictureBox_cover);
            panel_add.Controls.Add(textBox_publisher);
            panel_add.Controls.Add(label11);
            panel_add.Controls.Add(dateTimePicker_dateRecieved);
            panel_add.Controls.Add(label10);
            panel_add.Controls.Add(textBox_price);
            panel_add.Controls.Add(label9);
            panel_add.Controls.Add(label8);
            panel_add.Controls.Add(label7);
            panel_add.Controls.Add(richTextBox_description);
            panel_add.Controls.Add(label5);
            panel_add.Controls.Add(label4);
            panel_add.Controls.Add(textBox_title);
            panel_add.Controls.Add(label3);
            panel_add.Controls.Add(textBox_isbn);
            panel_add.Controls.Add(textBox_id);
            panel_add.Controls.Add(label2);
            panel_add.Controls.Add(label6);
            panel_add.Location = new Point(241, 118);
            panel_add.Name = "panel_add";
            panel_add.Size = new Size(1465, 595);
            panel_add.TabIndex = 10;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(270, 45);
            label17.Name = "label17";
            label17.Size = new Size(237, 22);
            label17.TabIndex = 52;
            label17.Text = "Click Clear Field To Generate ID";
            // 
            // label16
            // 
            label16.BackColor = Color.White;
            label16.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(481, 187);
            label16.Name = "label16";
            label16.Size = new Size(25, 17);
            label16.TabIndex = 51;
            label16.Text = "*";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            label15.BackColor = Color.White;
            label15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Red;
            label15.Location = new Point(477, 457);
            label15.Name = "label15";
            label15.Size = new Size(25, 17);
            label15.TabIndex = 50;
            label15.Text = "*";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            label14.BackColor = Color.White;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Red;
            label14.Location = new Point(312, 253);
            label14.Name = "label14";
            label14.Size = new Size(25, 17);
            label14.TabIndex = 49;
            label14.Text = "*";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.BackColor = Color.White;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(481, 114);
            label13.Name = "label13";
            label13.Size = new Size(25, 17);
            label13.TabIndex = 48;
            label13.Text = "*";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.BackColor = Color.White;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(242, 40);
            label12.Name = "label12";
            label12.Size = new Size(25, 17);
            label12.TabIndex = 47;
            label12.Text = "*";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button_clearfields
            // 
            button_clearfields.BackColor = Color.FromArgb(255, 128, 0);
            button_clearfields.Cursor = Cursors.Hand;
            button_clearfields.FlatAppearance.BorderColor = Color.Black;
            button_clearfields.FlatStyle = FlatStyle.Flat;
            button_clearfields.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_clearfields.ForeColor = Color.White;
            button_clearfields.Location = new Point(763, 510);
            button_clearfields.Name = "button_clearfields";
            button_clearfields.Size = new Size(635, 56);
            button_clearfields.TabIndex = 46;
            button_clearfields.Text = "Clear Fields";
            button_clearfields.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_clearfields.UseVisualStyleBackColor = false;
            button_clearfields.Click += button_clearfields_Click;
            // 
            // button_addBook
            // 
            button_addBook.BackColor = Color.FromArgb(35, 203, 167);
            button_addBook.Cursor = Cursors.Hand;
            button_addBook.FlatAppearance.BorderColor = Color.Black;
            button_addBook.FlatStyle = FlatStyle.Flat;
            button_addBook.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_addBook.ForeColor = Color.White;
            button_addBook.Location = new Point(70, 510);
            button_addBook.Name = "button_addBook";
            button_addBook.Size = new Size(635, 56);
            button_addBook.TabIndex = 45;
            button_addBook.Text = "Add Book";
            button_addBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_addBook.UseVisualStyleBackColor = false;
            button_addBook.Click += button_addBook_Click;
            // 
            // button_SelectAuthor
            // 
            button_SelectAuthor.BackColor = Color.White;
            button_SelectAuthor.Cursor = Cursors.Hand;
            button_SelectAuthor.FlatAppearance.BorderColor = Color.Black;
            button_SelectAuthor.FlatStyle = FlatStyle.Flat;
            button_SelectAuthor.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_SelectAuthor.Location = new Point(390, 249);
            button_SelectAuthor.Name = "button_SelectAuthor";
            button_SelectAuthor.Size = new Size(117, 37);
            button_SelectAuthor.TabIndex = 43;
            button_SelectAuthor.Text = "Select Author";
            button_SelectAuthor.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_SelectAuthor.UseVisualStyleBackColor = false;
            button_SelectAuthor.Click += button_SelectAuthor_Click;
            // 
            // label_author_id
            // 
            label_author_id.AutoSize = true;
            label_author_id.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_author_id.Location = new Point(344, 249);
            label_author_id.Name = "label_author_id";
            label_author_id.Size = new Size(49, 32);
            label_author_id.TabIndex = 44;
            label_author_id.Text = "ID:";
            // 
            // textBox_authorfullname
            // 
            textBox_authorfullname.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_authorfullname.Location = new Point(163, 249);
            textBox_authorfullname.Name = "textBox_authorfullname";
            textBox_authorfullname.Size = new Size(177, 37);
            textBox_authorfullname.TabIndex = 42;
            // 
            // numericUpDown_quantity
            // 
            numericUpDown_quantity.Cursor = Cursors.IBeam;
            numericUpDown_quantity.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown_quantity.Location = new Point(163, 384);
            numericUpDown_quantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown_quantity.Name = "numericUpDown_quantity";
            numericUpDown_quantity.Size = new Size(100, 37);
            numericUpDown_quantity.TabIndex = 41;
            // 
            // comboBox_genre
            // 
            comboBox_genre.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_genre.FormattingEnabled = true;
            comboBox_genre.Location = new Point(163, 315);
            comboBox_genre.Name = "comboBox_genre";
            comboBox_genre.Size = new Size(344, 37);
            comboBox_genre.TabIndex = 40;
            // 
            // button_Select_Cover
            // 
            button_Select_Cover.BackColor = Color.White;
            button_Select_Cover.Cursor = Cursors.Hand;
            button_Select_Cover.FlatAppearance.BorderColor = Color.Black;
            button_Select_Cover.FlatStyle = FlatStyle.Flat;
            button_Select_Cover.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Select_Cover.Image = (Image)resources.GetObject("button_Select_Cover.Image");
            button_Select_Cover.Location = new Point(1149, 438);
            button_Select_Cover.Name = "button_Select_Cover";
            button_Select_Cover.Size = new Size(267, 46);
            button_Select_Cover.TabIndex = 38;
            button_Select_Cover.Text = "Select Cover";
            button_Select_Cover.TextAlign = ContentAlignment.MiddleRight;
            button_Select_Cover.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Select_Cover.UseVisualStyleBackColor = false;
            button_Select_Cover.Click += button_Select_Cover_Click;
            // 
            // label_cover
            // 
            label_cover.AutoSize = true;
            label_cover.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_cover.Location = new Point(1234, 65);
            label_cover.Name = "label_cover";
            label_cover.Size = new Size(97, 32);
            label_cover.TabIndex = 37;
            label_cover.Text = "Cover:";
            // 
            // pictureBox_cover
            // 
            pictureBox_cover.BackColor = Color.Gray;
            pictureBox_cover.Image = Properties.Resources.Book1;
            pictureBox_cover.ImageLocation = "";
            pictureBox_cover.Location = new Point(1149, 110);
            pictureBox_cover.Name = "pictureBox_cover";
            pictureBox_cover.Size = new Size(267, 322);
            pictureBox_cover.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_cover.TabIndex = 36;
            pictureBox_cover.TabStop = false;
            // 
            // textBox_publisher
            // 
            textBox_publisher.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_publisher.Location = new Point(763, 31);
            textBox_publisher.Name = "textBox_publisher";
            textBox_publisher.Size = new Size(301, 37);
            textBox_publisher.TabIndex = 35;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(615, 36);
            label11.Name = "label11";
            label11.Size = new Size(142, 32);
            label11.TabIndex = 34;
            label11.Text = "Publisher:";
            // 
            // dateTimePicker_dateRecieved
            // 
            dateTimePicker_dateRecieved.Cursor = Cursors.Hand;
            dateTimePicker_dateRecieved.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker_dateRecieved.Format = DateTimePickerFormat.Short;
            dateTimePicker_dateRecieved.Location = new Point(763, 110);
            dateTimePicker_dateRecieved.Name = "dateTimePicker_dateRecieved";
            dateTimePicker_dateRecieved.Size = new Size(301, 39);
            dateTimePicker_dateRecieved.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(549, 110);
            label10.Name = "label10";
            label10.Size = new Size(208, 32);
            label10.TabIndex = 32;
            label10.Text = "Data Recieved:";
            // 
            // textBox_price
            // 
            textBox_price.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_price.Location = new Point(163, 452);
            textBox_price.Name = "textBox_price";
            textBox_price.Size = new Size(344, 37);
            textBox_price.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(70, 452);
            label9.Name = "label9";
            label9.Size = new Size(87, 32);
            label9.TabIndex = 30;
            label9.Text = "Price:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(28, 380);
            label8.Name = "label8";
            label8.Size = new Size(129, 32);
            label8.TabIndex = 28;
            label8.Text = "Quantity:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(56, 315);
            label7.Name = "label7";
            label7.Size = new Size(101, 32);
            label7.TabIndex = 26;
            label7.Text = "Genre:";
            // 
            // richTextBox_description
            // 
            richTextBox_description.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox_description.Location = new Point(763, 178);
            richTextBox_description.Name = "richTextBox_description";
            richTextBox_description.Size = new Size(301, 306);
            richTextBox_description.TabIndex = 25;
            richTextBox_description.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(592, 182);
            label5.Name = "label5";
            label5.Size = new Size(165, 32);
            label5.TabIndex = 24;
            label5.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(51, 249);
            label4.Name = "label4";
            label4.Size = new Size(106, 32);
            label4.TabIndex = 22;
            label4.Text = "Author:";
            // 
            // textBox_title
            // 
            textBox_title.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_title.Location = new Point(163, 182);
            textBox_title.Name = "textBox_title";
            textBox_title.Size = new Size(344, 37);
            textBox_title.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(80, 182);
            label3.Name = "label3";
            label3.Size = new Size(77, 32);
            label3.TabIndex = 20;
            label3.Text = "Title:";
            // 
            // textBox_isbn
            // 
            textBox_isbn.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_isbn.Location = new Point(163, 110);
            textBox_isbn.Name = "textBox_isbn";
            textBox_isbn.Size = new Size(344, 37);
            textBox_isbn.TabIndex = 19;
            // 
            // textBox_id
            // 
            textBox_id.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_id.Location = new Point(163, 36);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(107, 37);
            textBox_id.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 110);
            label2.Name = "label2";
            label2.Size = new Size(87, 32);
            label2.TabIndex = 17;
            label2.Text = "ISBN:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(108, 36);
            label6.Name = "label6";
            label6.Size = new Size(49, 32);
            label6.TabIndex = 16;
            label6.Text = "ID:";
            // 
            // panel_AddPanel
            // 
            panel_AddPanel.BackColor = Color.AntiqueWhite;
            panel_AddPanel.Controls.Add(button_ByISBN);
            panel_AddPanel.Controls.Add(button_SearchById);
            panel_AddPanel.Controls.Add(label19);
            panel_AddPanel.Controls.Add(label20);
            panel_AddPanel.Controls.Add(label21);
            panel_AddPanel.Controls.Add(label22);
            panel_AddPanel.Controls.Add(label23);
            panel_AddPanel.Controls.Add(button_editBook);
            panel_AddPanel.Controls.Add(button_selectAuthor_Edit);
            panel_AddPanel.Controls.Add(label_authorid_Edit);
            panel_AddPanel.Controls.Add(textBox_author_Edit);
            panel_AddPanel.Controls.Add(numericUpDown_quantity_Edit);
            panel_AddPanel.Controls.Add(comboBox_genre_Edit);
            panel_AddPanel.Controls.Add(button_selectCover_Edit);
            panel_AddPanel.Controls.Add(label25);
            panel_AddPanel.Controls.Add(pictureBox_cover_Edit);
            panel_AddPanel.Controls.Add(textBox_publisher_Edit);
            panel_AddPanel.Controls.Add(label26);
            panel_AddPanel.Controls.Add(dateTimePicker_daterecieved_Edit);
            panel_AddPanel.Controls.Add(label27);
            panel_AddPanel.Controls.Add(textBox_price_Edit);
            panel_AddPanel.Controls.Add(label28);
            panel_AddPanel.Controls.Add(label29);
            panel_AddPanel.Controls.Add(label30);
            panel_AddPanel.Controls.Add(richTextBox_description_Edit);
            panel_AddPanel.Controls.Add(label31);
            panel_AddPanel.Controls.Add(label32);
            panel_AddPanel.Controls.Add(textBox_title_Edit);
            panel_AddPanel.Controls.Add(label33);
            panel_AddPanel.Controls.Add(textBox_isbn_Edit);
            panel_AddPanel.Controls.Add(textBox_id_Edit);
            panel_AddPanel.Controls.Add(label34);
            panel_AddPanel.Controls.Add(label35);
            panel_AddPanel.Location = new Point(241, 118);
            panel_AddPanel.Name = "panel_AddPanel";
            panel_AddPanel.Size = new Size(1465, 595);
            panel_AddPanel.TabIndex = 53;
            // 
            // button_ByISBN
            // 
            button_ByISBN.BackColor = Color.White;
            button_ByISBN.Cursor = Cursors.Hand;
            button_ByISBN.FlatAppearance.BorderColor = Color.Black;
            button_ByISBN.FlatStyle = FlatStyle.Flat;
            button_ByISBN.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_ByISBN.Location = new Point(312, 110);
            button_ByISBN.Name = "button_ByISBN";
            button_ByISBN.Size = new Size(195, 37);
            button_ByISBN.TabIndex = 53;
            button_ByISBN.Text = "Search Book By ISBN";
            button_ByISBN.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_ByISBN.UseVisualStyleBackColor = false;
            button_ByISBN.Click += button_ByISBN_Click;
            // 
            // button_SearchById
            // 
            button_SearchById.BackColor = Color.White;
            button_SearchById.Cursor = Cursors.Hand;
            button_SearchById.FlatAppearance.BorderColor = Color.Black;
            button_SearchById.FlatStyle = FlatStyle.Flat;
            button_SearchById.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_SearchById.Location = new Point(312, 36);
            button_SearchById.Name = "button_SearchById";
            button_SearchById.Size = new Size(195, 37);
            button_SearchById.TabIndex = 52;
            button_SearchById.Text = "Search Book By ID";
            button_SearchById.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_SearchById.UseVisualStyleBackColor = false;
            button_SearchById.Click += button_SearchById_Click;
            // 
            // label19
            // 
            label19.BackColor = Color.White;
            label19.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Red;
            label19.Location = new Point(481, 187);
            label19.Name = "label19";
            label19.Size = new Size(25, 17);
            label19.TabIndex = 51;
            label19.Text = "*";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            label20.BackColor = Color.White;
            label20.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.Red;
            label20.Location = new Point(477, 457);
            label20.Name = "label20";
            label20.Size = new Size(25, 17);
            label20.TabIndex = 50;
            label20.Text = "*";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            label21.BackColor = Color.White;
            label21.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.Red;
            label21.Location = new Point(312, 253);
            label21.Name = "label21";
            label21.Size = new Size(25, 17);
            label21.TabIndex = 49;
            label21.Text = "*";
            label21.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            label22.BackColor = Color.White;
            label22.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.Red;
            label22.Location = new Point(268, 114);
            label22.Name = "label22";
            label22.Size = new Size(23, 17);
            label22.TabIndex = 48;
            label22.Text = "*";
            label22.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            label23.BackColor = Color.White;
            label23.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.Red;
            label23.Location = new Point(268, 39);
            label23.Name = "label23";
            label23.Size = new Size(23, 18);
            label23.TabIndex = 47;
            label23.Text = "*";
            label23.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button_editBook
            // 
            button_editBook.BackColor = Color.FromArgb(34, 167, 240);
            button_editBook.Cursor = Cursors.Hand;
            button_editBook.FlatAppearance.BorderColor = Color.Black;
            button_editBook.FlatStyle = FlatStyle.Flat;
            button_editBook.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_editBook.ForeColor = Color.White;
            button_editBook.Location = new Point(163, 510);
            button_editBook.Name = "button_editBook";
            button_editBook.Size = new Size(1092, 56);
            button_editBook.TabIndex = 45;
            button_editBook.Text = "Edit Book";
            button_editBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_editBook.UseVisualStyleBackColor = false;
            button_editBook.Click += button_editBook_Click;
            // 
            // button_selectAuthor_Edit
            // 
            button_selectAuthor_Edit.BackColor = Color.White;
            button_selectAuthor_Edit.Cursor = Cursors.Hand;
            button_selectAuthor_Edit.FlatAppearance.BorderColor = Color.Black;
            button_selectAuthor_Edit.FlatStyle = FlatStyle.Flat;
            button_selectAuthor_Edit.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_selectAuthor_Edit.Location = new Point(390, 249);
            button_selectAuthor_Edit.Name = "button_selectAuthor_Edit";
            button_selectAuthor_Edit.Size = new Size(117, 37);
            button_selectAuthor_Edit.TabIndex = 43;
            button_selectAuthor_Edit.Text = "Select Author";
            button_selectAuthor_Edit.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_selectAuthor_Edit.UseVisualStyleBackColor = false;
            button_selectAuthor_Edit.Click += button_selectAuthor_Edit_Click;
            // 
            // label_authorid_Edit
            // 
            label_authorid_Edit.AutoSize = true;
            label_authorid_Edit.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_authorid_Edit.Location = new Point(344, 249);
            label_authorid_Edit.Name = "label_authorid_Edit";
            label_authorid_Edit.Size = new Size(49, 32);
            label_authorid_Edit.TabIndex = 44;
            label_authorid_Edit.Text = "ID:";
            // 
            // textBox_author_Edit
            // 
            textBox_author_Edit.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_author_Edit.Location = new Point(163, 249);
            textBox_author_Edit.Name = "textBox_author_Edit";
            textBox_author_Edit.Size = new Size(177, 37);
            textBox_author_Edit.TabIndex = 42;
            // 
            // numericUpDown_quantity_Edit
            // 
            numericUpDown_quantity_Edit.Cursor = Cursors.IBeam;
            numericUpDown_quantity_Edit.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown_quantity_Edit.Location = new Point(163, 384);
            numericUpDown_quantity_Edit.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            numericUpDown_quantity_Edit.Name = "numericUpDown_quantity_Edit";
            numericUpDown_quantity_Edit.Size = new Size(100, 37);
            numericUpDown_quantity_Edit.TabIndex = 41;
            // 
            // comboBox_genre_Edit
            // 
            comboBox_genre_Edit.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox_genre_Edit.FormattingEnabled = true;
            comboBox_genre_Edit.Location = new Point(163, 315);
            comboBox_genre_Edit.Name = "comboBox_genre_Edit";
            comboBox_genre_Edit.Size = new Size(344, 37);
            comboBox_genre_Edit.TabIndex = 40;
            // 
            // button_selectCover_Edit
            // 
            button_selectCover_Edit.BackColor = Color.White;
            button_selectCover_Edit.Cursor = Cursors.Hand;
            button_selectCover_Edit.FlatAppearance.BorderColor = Color.Black;
            button_selectCover_Edit.FlatStyle = FlatStyle.Flat;
            button_selectCover_Edit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_selectCover_Edit.Image = (Image)resources.GetObject("button_selectCover_Edit.Image");
            button_selectCover_Edit.Location = new Point(1149, 438);
            button_selectCover_Edit.Name = "button_selectCover_Edit";
            button_selectCover_Edit.Size = new Size(267, 46);
            button_selectCover_Edit.TabIndex = 38;
            button_selectCover_Edit.Text = "Select Cover";
            button_selectCover_Edit.TextAlign = ContentAlignment.MiddleRight;
            button_selectCover_Edit.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_selectCover_Edit.UseVisualStyleBackColor = false;
            button_selectCover_Edit.Click += button_selectCover_Edit_Click;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.Location = new Point(1234, 65);
            label25.Name = "label25";
            label25.Size = new Size(97, 32);
            label25.TabIndex = 37;
            label25.Text = "Cover:";
            // 
            // pictureBox_cover_Edit
            // 
            pictureBox_cover_Edit.BackColor = Color.Gray;
            pictureBox_cover_Edit.Image = Properties.Resources.Book1;
            pictureBox_cover_Edit.ImageLocation = "";
            pictureBox_cover_Edit.Location = new Point(1149, 110);
            pictureBox_cover_Edit.Name = "pictureBox_cover_Edit";
            pictureBox_cover_Edit.Size = new Size(267, 322);
            pictureBox_cover_Edit.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_cover_Edit.TabIndex = 36;
            pictureBox_cover_Edit.TabStop = false;
            // 
            // textBox_publisher_Edit
            // 
            textBox_publisher_Edit.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_publisher_Edit.Location = new Point(763, 31);
            textBox_publisher_Edit.Name = "textBox_publisher_Edit";
            textBox_publisher_Edit.Size = new Size(301, 37);
            textBox_publisher_Edit.TabIndex = 35;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.Location = new Point(615, 36);
            label26.Name = "label26";
            label26.Size = new Size(142, 32);
            label26.TabIndex = 34;
            label26.Text = "Publisher:";
            // 
            // dateTimePicker_daterecieved_Edit
            // 
            dateTimePicker_daterecieved_Edit.Cursor = Cursors.Hand;
            dateTimePicker_daterecieved_Edit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker_daterecieved_Edit.Format = DateTimePickerFormat.Short;
            dateTimePicker_daterecieved_Edit.Location = new Point(763, 110);
            dateTimePicker_daterecieved_Edit.Name = "dateTimePicker_daterecieved_Edit";
            dateTimePicker_daterecieved_Edit.Size = new Size(301, 39);
            dateTimePicker_daterecieved_Edit.TabIndex = 33;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label27.Location = new Point(549, 110);
            label27.Name = "label27";
            label27.Size = new Size(208, 32);
            label27.TabIndex = 32;
            label27.Text = "Data Recieved:";
            // 
            // textBox_price_Edit
            // 
            textBox_price_Edit.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_price_Edit.Location = new Point(163, 452);
            textBox_price_Edit.Name = "textBox_price_Edit";
            textBox_price_Edit.Size = new Size(344, 37);
            textBox_price_Edit.TabIndex = 31;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label28.Location = new Point(70, 452);
            label28.Name = "label28";
            label28.Size = new Size(87, 32);
            label28.TabIndex = 30;
            label28.Text = "Price:";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label29.Location = new Point(28, 380);
            label29.Name = "label29";
            label29.Size = new Size(129, 32);
            label29.TabIndex = 28;
            label29.Text = "Quantity:";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label30.Location = new Point(56, 315);
            label30.Name = "label30";
            label30.Size = new Size(101, 32);
            label30.TabIndex = 26;
            label30.Text = "Genre:";
            // 
            // richTextBox_description_Edit
            // 
            richTextBox_description_Edit.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox_description_Edit.Location = new Point(763, 178);
            richTextBox_description_Edit.Name = "richTextBox_description_Edit";
            richTextBox_description_Edit.Size = new Size(301, 306);
            richTextBox_description_Edit.TabIndex = 25;
            richTextBox_description_Edit.Text = "";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label31.Location = new Point(592, 182);
            label31.Name = "label31";
            label31.Size = new Size(165, 32);
            label31.TabIndex = 24;
            label31.Text = "Description:";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label32.Location = new Point(51, 249);
            label32.Name = "label32";
            label32.Size = new Size(106, 32);
            label32.TabIndex = 22;
            label32.Text = "Author:";
            // 
            // textBox_title_Edit
            // 
            textBox_title_Edit.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_title_Edit.Location = new Point(163, 182);
            textBox_title_Edit.Name = "textBox_title_Edit";
            textBox_title_Edit.Size = new Size(344, 37);
            textBox_title_Edit.TabIndex = 21;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label33.Location = new Point(80, 182);
            label33.Name = "label33";
            label33.Size = new Size(77, 32);
            label33.TabIndex = 20;
            label33.Text = "Title:";
            // 
            // textBox_isbn_Edit
            // 
            textBox_isbn_Edit.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_isbn_Edit.Location = new Point(163, 110);
            textBox_isbn_Edit.Name = "textBox_isbn_Edit";
            textBox_isbn_Edit.Size = new Size(130, 37);
            textBox_isbn_Edit.TabIndex = 19;
            // 
            // textBox_id_Edit
            // 
            textBox_id_Edit.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_id_Edit.Location = new Point(163, 36);
            textBox_id_Edit.Name = "textBox_id_Edit";
            textBox_id_Edit.Size = new Size(130, 37);
            textBox_id_Edit.TabIndex = 18;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label34.Location = new Point(70, 110);
            label34.Name = "label34";
            label34.Size = new Size(87, 32);
            label34.TabIndex = 17;
            label34.Text = "ISBN:";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label35.Location = new Point(108, 36);
            label35.Name = "label35";
            label35.Size = new Size(49, 32);
            label35.TabIndex = 16;
            label35.Text = "ID:";
            // 
            // panel_ShowBooks
            // 
            panel_ShowBooks.BackColor = Color.Tan;
            panel_ShowBooks.Controls.Add(button_RemoveThisBook);
            panel_ShowBooks.Controls.Add(button_EditThisBook);
            panel_ShowBooks.Controls.Add(dataGridView_Books);
            panel_ShowBooks.Location = new Point(241, 118);
            panel_ShowBooks.Name = "panel_ShowBooks";
            panel_ShowBooks.Size = new Size(1465, 593);
            panel_ShowBooks.TabIndex = 54;
            // 
            // button_RemoveThisBook
            // 
            button_RemoveThisBook.BackColor = Color.Red;
            button_RemoveThisBook.Cursor = Cursors.Hand;
            button_RemoveThisBook.FlatAppearance.BorderColor = Color.Black;
            button_RemoveThisBook.FlatStyle = FlatStyle.Flat;
            button_RemoveThisBook.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_RemoveThisBook.ForeColor = Color.White;
            button_RemoveThisBook.Location = new Point(763, 521);
            button_RemoveThisBook.Name = "button_RemoveThisBook";
            button_RemoveThisBook.Size = new Size(690, 56);
            button_RemoveThisBook.TabIndex = 47;
            button_RemoveThisBook.Text = "Remove This Book";
            button_RemoveThisBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_RemoveThisBook.UseVisualStyleBackColor = false;
            button_RemoveThisBook.Click += button_RemoveThisBook_Click;
            // 
            // button_EditThisBook
            // 
            button_EditThisBook.BackColor = Color.DodgerBlue;
            button_EditThisBook.Cursor = Cursors.Hand;
            button_EditThisBook.FlatAppearance.BorderColor = Color.Black;
            button_EditThisBook.FlatStyle = FlatStyle.Flat;
            button_EditThisBook.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button_EditThisBook.ForeColor = Color.White;
            button_EditThisBook.Location = new Point(11, 521);
            button_EditThisBook.Name = "button_EditThisBook";
            button_EditThisBook.Size = new Size(746, 56);
            button_EditThisBook.TabIndex = 46;
            button_EditThisBook.Text = "Edit This Book";
            button_EditThisBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_EditThisBook.UseVisualStyleBackColor = false;
            button_EditThisBook.Click += button_EditThisBook_Click;
            // 
            // dataGridView_Books
            // 
            dataGridView_Books.AllowUserToAddRows = false;
            dataGridView_Books.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Books.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Books.Location = new Point(11, 12);
            dataGridView_Books.Name = "dataGridView_Books";
            dataGridView_Books.RowHeadersWidth = 62;
            dataGridView_Books.Size = new Size(1442, 491);
            dataGridView_Books.TabIndex = 0;
            // 
            // ManageBooksForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(1, 50, 67);
            ClientSize = new Size(1718, 725);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel_ShowBooks);
            Controls.Add(panel_AddPanel);
            Controls.Add(panel_add);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageBooksForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageBooksForm";
            Load += ManageBooksForm_Load;
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Books).EndInit();
            panel5.ResumeLayout(false);
            panel_add.ResumeLayout(false);
            panel_add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_cover).EndInit();
            panel_AddPanel.ResumeLayout(false);
            panel_AddPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_quantity_Edit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_cover_Edit).EndInit();
            panel_ShowBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Books).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel4;
        private Panel panel6;
        private Panel panel3;
        private PictureBox pictureBox_Books;
        private Label label_genres;
        private Label label1;
        private Panel panel5;
        private Button button_Delete;
        private Button button_Edit;
        private Button button_Add;
        private Panel panel_add;
        private RichTextBox richTextBox_description;
        private Label label5;
        private Label label4;
        private TextBox textBox_title;
        private Label label3;
        private TextBox textBox_isbn;
        private TextBox textBox_id;
        private Label label2;
        private Label label6;
        private TextBox textBox_price;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox textBox_publisher;
        private Label label11;
        private DateTimePicker dateTimePicker_dateRecieved;
        private Label label10;
        private Button button_Select_Cover;
        private Label label_cover;
        private PictureBox pictureBox_cover;
        private ComboBox comboBox_genre;
        private NumericUpDown numericUpDown_quantity;
        private Button button_SelectAuthor;
        private Button button_addBook;
        public TextBox textBox_authorfullname;
        public Label label_author_id;
        private Button button_clearfields;
        private Label label12;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label16;
        private Label label_booksCount;
        private Label label17;
        private Panel panel_AddPanel;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Button button_EditThisBook;
        private Button button_editBook;
        private Button button_selectAuthor_Edit;
        public Label label_authorid_Edit;
        public TextBox textBox_author_Edit;
        private NumericUpDown numericUpDown_quantity_Edit;
        private ComboBox comboBox_genre_Edit;
        private Button button_selectCover_Edit;
        private Label label25;
        private PictureBox pictureBox_cover_Edit;
        private TextBox textBox_publisher_Edit;
        private Label label26;
        private DateTimePicker dateTimePicker_daterecieved_Edit;
        private Label label27;
        private TextBox textBox_price_Edit;
        private Label label28;
        private Label label29;
        private Label label30;
        private RichTextBox richTextBox_description_Edit;
        private Label label31;
        private Label label32;
        private TextBox textBox_title_Edit;
        private Label label33;
        private TextBox textBox_isbn_Edit;
        private TextBox textBox_id_Edit;
        private Label label34;
        private Label label35;
        private Button button_SearchById;
        private Button button_ByISBN;
        private Button button_ShowBooksList;
        private Panel panel_ShowBooks;
        private Button button_RemoveThisBook;
        private DataGridView dataGridView_Books;
        private Button button_export;
    }
}