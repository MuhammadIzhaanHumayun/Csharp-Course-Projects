namespace Library_Management_System.FORMS
{
    partial class AuthorListForm
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
            label1 = new Label();
            label2 = new Label();
            listBox_authors = new ListBox();
            button_SelectAndClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Yellow;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Comic Sans MS", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(17, 24, 34);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(432, 94);
            label1.TabIndex = 1;
            label1.Text = "Author List";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Yellow;
            label2.Cursor = Cursors.Hand;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(394, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 34);
            label2.TabIndex = 2;
            label2.Text = "X";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // listBox_authors
            // 
            listBox_authors.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox_authors.FormattingEnabled = true;
            listBox_authors.ItemHeight = 29;
            listBox_authors.Location = new Point(8, 104);
            listBox_authors.Name = "listBox_authors";
            listBox_authors.Size = new Size(415, 381);
            listBox_authors.TabIndex = 3;
            // 
            // button_SelectAndClose
            // 
            button_SelectAndClose.BackColor = Color.White;
            button_SelectAndClose.Cursor = Cursors.Hand;
            button_SelectAndClose.FlatAppearance.BorderColor = Color.Black;
            button_SelectAndClose.FlatStyle = FlatStyle.Flat;
            button_SelectAndClose.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_SelectAndClose.Location = new Point(8, 498);
            button_SelectAndClose.Name = "button_SelectAndClose";
            button_SelectAndClose.Size = new Size(412, 40);
            button_SelectAndClose.TabIndex = 44;
            button_SelectAndClose.Text = "Select & Author";
            button_SelectAndClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_SelectAndClose.UseVisualStyleBackColor = false;
            button_SelectAndClose.Click += button_SelectAndClose_Click;
            // 
            // AuthorListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 163, 156);
            ClientSize = new Size(432, 552);
            Controls.Add(button_SelectAndClose);
            Controls.Add(listBox_authors);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AuthorListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AuthorListForm";
            Load += AuthorListForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox listBox_authors;
        private Button button_SelectAndClose;
    }
}