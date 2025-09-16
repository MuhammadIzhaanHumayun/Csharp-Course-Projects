namespace Library_Management_System.FORMS
{
    partial class BooksListForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label_author = new Label();
            listView_books = new ListView();
            label2 = new Label();
            label1 = new Label();
            imageList_BookCovers = new ImageList(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 24, 34);
            panel1.Controls.Add(label_author);
            panel1.Controls.Add(listView_books);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 647);
            panel1.TabIndex = 1;
            // 
            // label_author
            // 
            label_author.AutoSize = true;
            label_author.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_author.ForeColor = Color.White;
            label_author.Location = new Point(12, 110);
            label_author.Name = "label_author";
            label_author.Size = new Size(393, 32);
            label_author.TabIndex = 3;
            label_author.Text = "books by: the author full name";
            // 
            // listView_books
            // 
            listView_books.BackColor = Color.Gray;
            listView_books.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView_books.ForeColor = Color.White;
            listView_books.Location = new Point(12, 150);
            listView_books.Name = "listView_books";
            listView_books.Size = new Size(407, 485);
            listView_books.TabIndex = 2;
            listView_books.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.BackColor = Color.Yellow;
            label2.Cursor = Cursors.Hand;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(393, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 34);
            label2.TabIndex = 1;
            label2.Text = "X";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Yellow;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(17, 24, 34);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(431, 77);
            label1.TabIndex = 0;
            label1.Text = "Author Books";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imageList_BookCovers
            // 
            imageList_BookCovers.ColorDepth = ColorDepth.Depth32Bit;
            imageList_BookCovers.ImageSize = new Size(16, 16);
            imageList_BookCovers.TransparentColor = Color.Transparent;
            // 
            // BooksListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 647);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BooksListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BooksListForm";
            Load += BooksListForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label_author;
        private ListView listView_books;
        private ImageList imageList_BookCovers;
    }
}