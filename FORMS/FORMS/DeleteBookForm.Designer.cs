namespace Library_Management_System.FORMS
{
    partial class DeleteBookForm
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
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            numericUpDown_BookId = new NumericUpDown();
            button_DeleteBook = new Button();
            label35 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_BookId).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(235, 150, 14);
            label2.Cursor = Cursors.Hand;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(644, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 34);
            label2.TabIndex = 3;
            label2.Text = "X";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(235, 150, 14);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Comic Sans MS", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(17, 24, 34);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(682, 79);
            label1.TabIndex = 2;
            label1.Text = "Delete Book";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(numericUpDown_BookId);
            panel1.Controls.Add(button_DeleteBook);
            panel1.Controls.Add(label35);
            panel1.Location = new Point(5, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(674, 184);
            panel1.TabIndex = 4;
            // 
            // numericUpDown_BookId
            // 
            numericUpDown_BookId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown_BookId.Location = new Point(359, 35);
            numericUpDown_BookId.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown_BookId.Name = "numericUpDown_BookId";
            numericUpDown_BookId.Size = new Size(208, 39);
            numericUpDown_BookId.TabIndex = 54;
            numericUpDown_BookId.ValueChanged += numericUpDown_BookId_ValueChanged;
            // 
            // button_DeleteBook
            // 
            button_DeleteBook.BackColor = Color.Red;
            button_DeleteBook.Cursor = Cursors.Hand;
            button_DeleteBook.FlatAppearance.BorderColor = Color.White;
            button_DeleteBook.FlatStyle = FlatStyle.Flat;
            button_DeleteBook.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_DeleteBook.ForeColor = Color.White;
            button_DeleteBook.Location = new Point(101, 110);
            button_DeleteBook.Name = "button_DeleteBook";
            button_DeleteBook.Size = new Size(466, 46);
            button_DeleteBook.TabIndex = 53;
            button_DeleteBook.Text = "Delete This Book";
            button_DeleteBook.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_DeleteBook.UseVisualStyleBackColor = false;
            button_DeleteBook.Click += button_DeleteBook_Click;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label35.ForeColor = Color.Yellow;
            label35.Location = new Point(101, 37);
            label35.Name = "label35";
            label35.Size = new Size(252, 32);
            label35.TabIndex = 19;
            label35.Text = "Enter The Book ID:";
            label35.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DeleteBookForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(682, 270);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteBookForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_BookId).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label35;
        private NumericUpDown numericUpDown_BookId;
        private Button button_DeleteBook;
    }
}