namespace Library_Management_System.FORMS
{
    partial class Dashboard_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Form));
            panel1 = new Panel();
            button_members = new Button();
            button_Circulation = new Button();
            button_Genres = new Button();
            button_Authors = new Button();
            button_Books = new Button();
            pictureBox_Logo = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel_displayBooks = new Panel();
            panel_book5 = new Panel();
            label_price5 = new Label();
            panel_book4 = new Panel();
            label_price4 = new Label();
            panel_book3 = new Panel();
            label_price3 = new Label();
            panel_book2 = new Panel();
            label_price2 = new Label();
            panel_book1 = new Panel();
            label_price1 = new Label();
            label_latestbooks = new Label();
            panel6 = new Panel();
            label_members = new Label();
            label_membersCount = new Label();
            panel5 = new Panel();
            label_authorsCount = new Label();
            label_authors = new Label();
            panel4 = new Panel();
            label_booksCount = new Label();
            label_books = new Label();
            button_Close = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Logo).BeginInit();
            panel3.SuspendLayout();
            panel_displayBooks.SuspendLayout();
            panel_book5.SuspendLayout();
            panel_book4.SuspendLayout();
            panel_book3.SuspendLayout();
            panel_book2.SuspendLayout();
            panel_book1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 37, 42);
            panel1.Controls.Add(button_members);
            panel1.Controls.Add(button_Circulation);
            panel1.Controls.Add(button_Genres);
            panel1.Controls.Add(button_Authors);
            panel1.Controls.Add(button_Books);
            panel1.Controls.Add(pictureBox_Logo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 756);
            panel1.TabIndex = 0;
            // 
            // button_members
            // 
            button_members.BackColor = Color.FromArgb(36, 37, 42);
            button_members.Cursor = Cursors.Hand;
            button_members.FlatAppearance.BorderSize = 0;
            button_members.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            button_members.FlatAppearance.MouseOverBackColor = Color.LawnGreen;
            button_members.FlatStyle = FlatStyle.Flat;
            button_members.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_members.ForeColor = Color.White;
            button_members.Image = (Image)resources.GetObject("button_members.Image");
            button_members.Location = new Point(1, 525);
            button_members.Name = "button_members";
            button_members.Size = new Size(339, 80);
            button_members.TabIndex = 8;
            button_members.Text = "Members";
            button_members.TextAlign = ContentAlignment.MiddleLeft;
            button_members.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_members.UseVisualStyleBackColor = false;
            button_members.Click += button1_Click;
            // 
            // button_Circulation
            // 
            button_Circulation.BackColor = Color.FromArgb(36, 37, 42);
            button_Circulation.Cursor = Cursors.Hand;
            button_Circulation.FlatAppearance.BorderSize = 0;
            button_Circulation.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            button_Circulation.FlatAppearance.MouseOverBackColor = Color.LawnGreen;
            button_Circulation.FlatStyle = FlatStyle.Flat;
            button_Circulation.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Circulation.ForeColor = Color.White;
            button_Circulation.Image = (Image)resources.GetObject("button_Circulation.Image");
            button_Circulation.Location = new Point(-1, 637);
            button_Circulation.Name = "button_Circulation";
            button_Circulation.Size = new Size(342, 80);
            button_Circulation.TabIndex = 6;
            button_Circulation.Text = "Circulation";
            button_Circulation.TextAlign = ContentAlignment.MiddleLeft;
            button_Circulation.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Circulation.UseVisualStyleBackColor = false;
            button_Circulation.Click += button_Circulation_Click;
            // 
            // button_Genres
            // 
            button_Genres.BackColor = Color.FromArgb(36, 37, 42);
            button_Genres.Cursor = Cursors.Hand;
            button_Genres.FlatAppearance.BorderSize = 0;
            button_Genres.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            button_Genres.FlatAppearance.MouseOverBackColor = Color.LawnGreen;
            button_Genres.FlatStyle = FlatStyle.Flat;
            button_Genres.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Genres.ForeColor = Color.White;
            button_Genres.Image = (Image)resources.GetObject("button_Genres.Image");
            button_Genres.Location = new Point(-1, 413);
            button_Genres.Name = "button_Genres";
            button_Genres.Size = new Size(342, 80);
            button_Genres.TabIndex = 5;
            button_Genres.Text = "Genres";
            button_Genres.TextAlign = ContentAlignment.MiddleLeft;
            button_Genres.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Genres.UseVisualStyleBackColor = false;
            button_Genres.Click += button_Genres_Click;
            // 
            // button_Authors
            // 
            button_Authors.BackColor = Color.FromArgb(36, 37, 42);
            button_Authors.Cursor = Cursors.Hand;
            button_Authors.FlatAppearance.BorderSize = 0;
            button_Authors.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            button_Authors.FlatAppearance.MouseOverBackColor = Color.LawnGreen;
            button_Authors.FlatStyle = FlatStyle.Flat;
            button_Authors.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Authors.ForeColor = Color.White;
            button_Authors.Image = (Image)resources.GetObject("button_Authors.Image");
            button_Authors.Location = new Point(-1, 301);
            button_Authors.Name = "button_Authors";
            button_Authors.Size = new Size(342, 80);
            button_Authors.TabIndex = 4;
            button_Authors.Text = "Authors";
            button_Authors.TextAlign = ContentAlignment.MiddleLeft;
            button_Authors.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Authors.UseVisualStyleBackColor = false;
            button_Authors.Click += button_Authors_Click;
            // 
            // button_Books
            // 
            button_Books.BackColor = Color.FromArgb(36, 37, 42);
            button_Books.Cursor = Cursors.Hand;
            button_Books.FlatAppearance.BorderSize = 0;
            button_Books.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 0);
            button_Books.FlatAppearance.MouseOverBackColor = Color.LawnGreen;
            button_Books.FlatStyle = FlatStyle.Flat;
            button_Books.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Books.ForeColor = Color.White;
            button_Books.Image = (Image)resources.GetObject("button_Books.Image");
            button_Books.Location = new Point(-1, 189);
            button_Books.Name = "button_Books";
            button_Books.Size = new Size(342, 80);
            button_Books.TabIndex = 3;
            button_Books.Text = "Books";
            button_Books.TextAlign = ContentAlignment.MiddleLeft;
            button_Books.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Books.UseVisualStyleBackColor = false;
            button_Books.Click += button_Books_Click;
            // 
            // pictureBox_Logo
            // 
            pictureBox_Logo.BackColor = Color.Peru;
            pictureBox_Logo.Image = (Image)resources.GetObject("pictureBox_Logo.Image");
            pictureBox_Logo.Location = new Point(12, 27);
            pictureBox_Logo.Name = "pictureBox_Logo";
            pictureBox_Logo.Size = new Size(146, 96);
            pictureBox_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Logo.TabIndex = 0;
            pictureBox_Logo.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Peru;
            label1.Font = new Font("Segoe Print", 33F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(152, 15);
            label1.Name = "label1";
            label1.Size = new Size(209, 121);
            label1.TabIndex = 1;
            label1.Text = "LMS";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Peru;
            panel2.Location = new Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(342, 151);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gainsboro;
            panel3.Controls.Add(panel_displayBooks);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(button_Close);
            panel3.Location = new Point(341, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(1273, 732);
            panel3.TabIndex = 1;
            // 
            // panel_displayBooks
            // 
            panel_displayBooks.BackColor = Color.ForestGreen;
            panel_displayBooks.Controls.Add(panel_book5);
            panel_displayBooks.Controls.Add(panel_book4);
            panel_displayBooks.Controls.Add(panel_book3);
            panel_displayBooks.Controls.Add(panel_book2);
            panel_displayBooks.Controls.Add(panel_book1);
            panel_displayBooks.Controls.Add(label_latestbooks);
            panel_displayBooks.Location = new Point(26, 292);
            panel_displayBooks.Name = "panel_displayBooks";
            panel_displayBooks.Size = new Size(1213, 416);
            panel_displayBooks.TabIndex = 3;
            // 
            // panel_book5
            // 
            panel_book5.BackColor = Color.RoyalBlue;
            panel_book5.Controls.Add(label_price5);
            panel_book5.Location = new Point(975, 87);
            panel_book5.Name = "panel_book5";
            panel_book5.Size = new Size(207, 294);
            panel_book5.TabIndex = 4;
            // 
            // label_price5
            // 
            label_price5.BackColor = Color.DarkOrange;
            label_price5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_price5.ForeColor = Color.White;
            label_price5.Location = new Point(127, 0);
            label_price5.Name = "label_price5";
            label_price5.Size = new Size(80, 32);
            label_price5.TabIndex = 1;
            label_price5.Text = "$9999";
            label_price5.TextAlign = ContentAlignment.TopRight;
            // 
            // panel_book4
            // 
            panel_book4.BackColor = Color.RoyalBlue;
            panel_book4.Controls.Add(label_price4);
            panel_book4.Location = new Point(742, 87);
            panel_book4.Name = "panel_book4";
            panel_book4.Size = new Size(207, 294);
            panel_book4.TabIndex = 4;
            // 
            // label_price4
            // 
            label_price4.BackColor = Color.DarkOrange;
            label_price4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_price4.ForeColor = Color.White;
            label_price4.Location = new Point(127, 0);
            label_price4.Name = "label_price4";
            label_price4.Size = new Size(80, 32);
            label_price4.TabIndex = 1;
            label_price4.Text = "$9999";
            label_price4.TextAlign = ContentAlignment.TopRight;
            // 
            // panel_book3
            // 
            panel_book3.BackColor = Color.RoyalBlue;
            panel_book3.Controls.Add(label_price3);
            panel_book3.Location = new Point(503, 87);
            panel_book3.Name = "panel_book3";
            panel_book3.Size = new Size(207, 294);
            panel_book3.TabIndex = 4;
            // 
            // label_price3
            // 
            label_price3.BackColor = Color.DarkOrange;
            label_price3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_price3.ForeColor = Color.White;
            label_price3.Location = new Point(127, 0);
            label_price3.Name = "label_price3";
            label_price3.Size = new Size(80, 32);
            label_price3.TabIndex = 1;
            label_price3.Text = "$9999";
            label_price3.TextAlign = ContentAlignment.TopRight;
            // 
            // panel_book2
            // 
            panel_book2.BackColor = Color.RoyalBlue;
            panel_book2.Controls.Add(label_price2);
            panel_book2.Location = new Point(264, 87);
            panel_book2.Name = "panel_book2";
            panel_book2.Size = new Size(207, 294);
            panel_book2.TabIndex = 4;
            // 
            // label_price2
            // 
            label_price2.BackColor = Color.DarkOrange;
            label_price2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_price2.ForeColor = Color.White;
            label_price2.Location = new Point(127, 0);
            label_price2.Name = "label_price2";
            label_price2.Size = new Size(80, 32);
            label_price2.TabIndex = 1;
            label_price2.Text = "$9999";
            label_price2.TextAlign = ContentAlignment.TopRight;
            // 
            // panel_book1
            // 
            panel_book1.BackColor = Color.RoyalBlue;
            panel_book1.Controls.Add(label_price1);
            panel_book1.Location = new Point(30, 87);
            panel_book1.Name = "panel_book1";
            panel_book1.Size = new Size(207, 294);
            panel_book1.TabIndex = 3;
            // 
            // label_price1
            // 
            label_price1.BackColor = Color.DarkOrange;
            label_price1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_price1.ForeColor = Color.White;
            label_price1.Location = new Point(127, 0);
            label_price1.Name = "label_price1";
            label_price1.Size = new Size(80, 32);
            label_price1.TabIndex = 0;
            label_price1.Text = "$9999";
            label_price1.TextAlign = ContentAlignment.TopRight;
            // 
            // label_latestbooks
            // 
            label_latestbooks.BackColor = Color.DarkGreen;
            label_latestbooks.Dock = DockStyle.Top;
            label_latestbooks.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_latestbooks.ForeColor = Color.White;
            label_latestbooks.Location = new Point(0, 0);
            label_latestbooks.Name = "label_latestbooks";
            label_latestbooks.Size = new Size(1213, 56);
            label_latestbooks.TabIndex = 2;
            label_latestbooks.Text = "Latest Books";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(249, 105, 14);
            panel6.Controls.Add(label_members);
            panel6.Controls.Add(label_membersCount);
            panel6.Location = new Point(855, 48);
            panel6.Name = "panel6";
            panel6.Size = new Size(384, 209);
            panel6.TabIndex = 2;
            // 
            // label_members
            // 
            label_members.BackColor = Color.FromArgb(211, 84, 0);
            label_members.Dock = DockStyle.Top;
            label_members.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_members.ForeColor = Color.White;
            label_members.Location = new Point(0, 0);
            label_members.Name = "label_members";
            label_members.Size = new Size(384, 57);
            label_members.TabIndex = 3;
            label_members.Text = "Members";
            // 
            // label_membersCount
            // 
            label_membersCount.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_membersCount.ForeColor = Color.White;
            label_membersCount.Location = new Point(0, 110);
            label_membersCount.Name = "label_membersCount";
            label_membersCount.Size = new Size(378, 46);
            label_membersCount.TabIndex = 2;
            label_membersCount.Text = "999";
            label_membersCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(45, 85, 255);
            panel5.Controls.Add(label_authorsCount);
            panel5.Controls.Add(label_authors);
            panel5.Location = new Point(445, 48);
            panel5.Name = "panel5";
            panel5.Size = new Size(384, 209);
            panel5.TabIndex = 2;
            // 
            // label_authorsCount
            // 
            label_authorsCount.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_authorsCount.ForeColor = Color.White;
            label_authorsCount.Location = new Point(0, 110);
            label_authorsCount.Name = "label_authorsCount";
            label_authorsCount.Size = new Size(378, 46);
            label_authorsCount.TabIndex = 2;
            label_authorsCount.Text = "999";
            label_authorsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_authors
            // 
            label_authors.BackColor = Color.FromArgb(30, 81, 123);
            label_authors.Dock = DockStyle.Top;
            label_authors.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_authors.ForeColor = Color.White;
            label_authors.Location = new Point(0, 0);
            label_authors.Name = "label_authors";
            label_authors.Size = new Size(384, 57);
            label_authors.TabIndex = 1;
            label_authors.Text = "Authors";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(240, 52, 52);
            panel4.Controls.Add(label_booksCount);
            panel4.Controls.Add(label_books);
            panel4.Location = new Point(26, 48);
            panel4.Name = "panel4";
            panel4.Size = new Size(384, 209);
            panel4.TabIndex = 1;
            // 
            // label_booksCount
            // 
            label_booksCount.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_booksCount.ForeColor = Color.White;
            label_booksCount.Location = new Point(0, 110);
            label_booksCount.Name = "label_booksCount";
            label_booksCount.Size = new Size(384, 46);
            label_booksCount.TabIndex = 1;
            label_booksCount.Text = "999";
            label_booksCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label_books
            // 
            label_books.BackColor = Color.FromArgb(217, 30, 24);
            label_books.Dock = DockStyle.Top;
            label_books.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_books.ForeColor = Color.White;
            label_books.Location = new Point(0, 0);
            label_books.Name = "label_books";
            label_books.Size = new Size(384, 57);
            label_books.TabIndex = 0;
            label_books.Text = "Books";
            // 
            // button_Close
            // 
            button_Close.BackColor = Color.Gainsboro;
            button_Close.Cursor = Cursors.Hand;
            button_Close.FlatAppearance.BorderColor = Color.White;
            button_Close.FlatAppearance.BorderSize = 0;
            button_Close.FlatStyle = FlatStyle.Flat;
            button_Close.Image = (Image)resources.GetObject("button_Close.Image");
            button_Close.Location = new Point(1229, 3);
            button_Close.Name = "button_Close";
            button_Close.Size = new Size(41, 41);
            button_Close.TabIndex = 0;
            button_Close.UseVisualStyleBackColor = false;
            button_Close.Click += button_Close_Click;
            // 
            // Dashboard_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 37, 42);
            ClientSize = new Size(1626, 756);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard_Form";
            Load += Dashboard_Form_Load;
            Shown += Dashboard_Form_Shown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Logo).EndInit();
            panel3.ResumeLayout(false);
            panel_displayBooks.ResumeLayout(false);
            panel_book5.ResumeLayout(false);
            panel_book4.ResumeLayout(false);
            panel_book3.ResumeLayout(false);
            panel_book2.ResumeLayout(false);
            panel_book1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox_Logo;
        private Panel panel2;
        private Panel panel3;
        private Button button_Close;
        private Panel panel4;
        private Panel panel_displayBooks;
        private Panel panel6;
        private Panel panel5;
        private Label label_books;
        private Label label_latestbooks;
        private Label label_members;
        private Label label_membersCount;
        private Label label_authorsCount;
        private Label label_authors;
        private Label label_booksCount;
        private Panel panel_book1;
        private Panel panel_book5;
        private Panel panel_book4;
        private Panel panel_book3;
        private Panel panel_book2;
        private Label label_price5;
        private Label label_price4;
        private Label label_price3;
        private Label label_price2;
        private Label label_price1;
        private Button button_Books;
        private Button button_Circulation;
        private Button button_Genres;
        private Button button_Authors;
        private Button button_members;
    }
}