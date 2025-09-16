namespace Library_Management_System.FORMS
{
    partial class ManageAuthorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAuthorsForm));
            panel1 = new Panel();
            panel7 = new Panel();
            richTextBox_bio = new RichTextBox();
            dataGridView_authors = new DataGridView();
            label5 = new Label();
            textBox_education = new TextBox();
            label4 = new Label();
            textBox_lname = new TextBox();
            label3 = new Label();
            textBox_fname = new TextBox();
            textBox_id = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel5 = new Panel();
            button_export = new Button();
            label_authorsCount = new Label();
            button_Show_Author_Books = new Button();
            button_Delete = new Button();
            button_Edit = new Button();
            button_Add = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            panel3 = new Panel();
            label_close = new Label();
            pictureBox_Author = new PictureBox();
            label_genres = new Label();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_authors).BeginInit();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Author).BeginInit();
            SuspendLayout();
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
            panel1.Size = new Size(1469, 681);
            panel1.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(richTextBox_bio);
            panel7.Controls.Add(dataGridView_authors);
            panel7.Controls.Add(label5);
            panel7.Controls.Add(textBox_education);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(textBox_lname);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(textBox_fname);
            panel7.Controls.Add(textBox_id);
            panel7.Controls.Add(label2);
            panel7.Controls.Add(label1);
            panel7.Location = new Point(241, 115);
            panel7.Name = "panel7";
            panel7.Size = new Size(1216, 554);
            panel7.TabIndex = 7;
            // 
            // richTextBox_bio
            // 
            richTextBox_bio.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox_bio.Location = new Point(181, 341);
            richTextBox_bio.Name = "richTextBox_bio";
            richTextBox_bio.Size = new Size(301, 194);
            richTextBox_bio.TabIndex = 15;
            richTextBox_bio.Text = "";
            // 
            // dataGridView_authors
            // 
            dataGridView_authors.AllowUserToAddRows = false;
            dataGridView_authors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_authors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_authors.Location = new Point(514, 39);
            dataGridView_authors.Name = "dataGridView_authors";
            dataGridView_authors.RowHeadersWidth = 62;
            dataGridView_authors.Size = new Size(686, 496);
            dataGridView_authors.TabIndex = 14;
            dataGridView_authors.CellClick += dataGridView_authors_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(101, 341);
            label5.Name = "label5";
            label5.Size = new Size(64, 32);
            label5.TabIndex = 12;
            label5.Text = "Bio:";
            // 
            // textBox_education
            // 
            textBox_education.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_education.Location = new Point(181, 270);
            textBox_education.Name = "textBox_education";
            textBox_education.Size = new Size(301, 37);
            textBox_education.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 267);
            label4.Name = "label4";
            label4.Size = new Size(150, 32);
            label4.TabIndex = 10;
            label4.Text = "Education:";
            // 
            // textBox_lname
            // 
            textBox_lname.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_lname.Location = new Point(181, 203);
            textBox_lname.Name = "textBox_lname";
            textBox_lname.Size = new Size(301, 37);
            textBox_lname.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 200);
            label3.Name = "label3";
            label3.Size = new Size(158, 32);
            label3.TabIndex = 8;
            label3.Text = "Last Name:";
            // 
            // textBox_fname
            // 
            textBox_fname.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_fname.Location = new Point(181, 131);
            textBox_fname.Name = "textBox_fname";
            textBox_fname.Size = new Size(301, 37);
            textBox_fname.TabIndex = 7;
            // 
            // textBox_id
            // 
            textBox_id.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_id.Location = new Point(181, 57);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(213, 37);
            textBox_id.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 128);
            label2.Name = "label2";
            label2.Size = new Size(159, 32);
            label2.TabIndex = 5;
            label2.Text = "First Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(126, 54);
            label1.Name = "label1";
            label1.Size = new Size(49, 32);
            label1.TabIndex = 4;
            label1.Text = "ID:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(1, 50, 67);
            panel5.Controls.Add(button_export);
            panel5.Controls.Add(label_authorsCount);
            panel5.Controls.Add(button_Show_Author_Books);
            panel5.Controls.Add(button_Delete);
            panel5.Controls.Add(button_Edit);
            panel5.Controls.Add(button_Add);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 109);
            panel5.Name = "panel5";
            panel5.Size = new Size(235, 572);
            panel5.TabIndex = 6;
            // 
            // button_export
            // 
            button_export.BackColor = Color.White;
            button_export.FlatAppearance.BorderColor = Color.Black;
            button_export.FlatStyle = FlatStyle.Flat;
            button_export.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_export.Image = (Image)resources.GetObject("button_export.Image");
            button_export.Location = new Point(12, 423);
            button_export.Name = "button_export";
            button_export.Size = new Size(214, 82);
            button_export.TabIndex = 54;
            button_export.Text = "Export Authors To Txt File";
            button_export.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_export.UseVisualStyleBackColor = false;
            button_export.Click += button_export_Click;
            // 
            // label_authorsCount
            // 
            label_authorsCount.BackColor = Color.Transparent;
            label_authorsCount.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_authorsCount.ForeColor = Color.Yellow;
            label_authorsCount.Location = new Point(12, 508);
            label_authorsCount.Name = "label_authorsCount";
            label_authorsCount.Size = new Size(220, 64);
            label_authorsCount.TabIndex = 53;
            label_authorsCount.Text = "9999 Authors";
            label_authorsCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Show_Author_Books
            // 
            button_Show_Author_Books.BackColor = Color.White;
            button_Show_Author_Books.FlatAppearance.BorderColor = Color.Black;
            button_Show_Author_Books.FlatStyle = FlatStyle.Flat;
            button_Show_Author_Books.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Show_Author_Books.Image = (Image)resources.GetObject("button_Show_Author_Books.Image");
            button_Show_Author_Books.Location = new Point(12, 326);
            button_Show_Author_Books.Name = "button_Show_Author_Books";
            button_Show_Author_Books.Size = new Size(214, 71);
            button_Show_Author_Books.TabIndex = 9;
            button_Show_Author_Books.Text = "Show Author Books";
            button_Show_Author_Books.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Show_Author_Books.UseVisualStyleBackColor = false;
            button_Show_Author_Books.Click += button_Show_Author_Books_Click;
            // 
            // button_Delete
            // 
            button_Delete.BackColor = Color.White;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(249, 180, 45);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label_close);
            panel2.Controls.Add(pictureBox_Author);
            panel2.Controls.Add(label_genres);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1469, 109);
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
            label_close.BackColor = Color.FromArgb(249, 180, 45);
            label_close.Cursor = Cursors.Hand;
            label_close.FlatStyle = FlatStyle.Flat;
            label_close.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_close.ForeColor = Color.Red;
            label_close.Location = new Point(1431, 0);
            label_close.Name = "label_close";
            label_close.Size = new Size(38, 34);
            label_close.TabIndex = 3;
            label_close.Text = "X";
            label_close.TextAlign = ContentAlignment.MiddleCenter;
            label_close.Click += label_close_Click;
            // 
            // pictureBox_Author
            // 
            pictureBox_Author.Image = (Image)resources.GetObject("pictureBox_Author.Image");
            pictureBox_Author.ImageLocation = "";
            pictureBox_Author.Location = new Point(0, 0);
            pictureBox_Author.Name = "pictureBox_Author";
            pictureBox_Author.Size = new Size(117, 109);
            pictureBox_Author.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Author.TabIndex = 2;
            pictureBox_Author.TabStop = false;
            // 
            // label_genres
            // 
            label_genres.BackColor = Color.FromArgb(249, 180, 45);
            label_genres.Font = new Font("Comic Sans MS", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_genres.ForeColor = Color.White;
            label_genres.Location = new Point(123, 3);
            label_genres.Name = "label_genres";
            label_genres.Size = new Size(336, 106);
            label_genres.TabIndex = 1;
            label_genres.Text = "Authors";
            label_genres.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ManageAuthorsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 681);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageAuthorsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageAuthorsForm";
            Load += ManageAuthorsForm_Load;
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_authors).EndInit();
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Author).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label_close;
        private PictureBox pictureBox_Author;
        private Label label_genres;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Button button_Delete;
        private Button button_Edit;
        private Button button_Add;
        private TextBox textBox_lname;
        private Label label3;
        private TextBox textBox_fname;
        private TextBox textBox_id;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox textBox_education;
        private Label label4;
        private DataGridView dataGridView_authors;
        private RichTextBox richTextBox_bio;
        private Button button_Show_Author_Books;
        private Label label_authorsCount;
        private Button button_export;
    }
}