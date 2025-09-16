namespace Library_Management_System.FORMS
{
    partial class ManageGenresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageGenresForm));
            label_genres = new Label();
            panel1 = new Panel();
            button_Delete = new Button();
            button_Edit = new Button();
            button_Add = new Button();
            dataGridView_genres = new DataGridView();
            textBox_name = new TextBox();
            textBox_id = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label_close = new Label();
            panel2 = new Panel();
            pictureBox_Genre = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_genres).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Genre).BeginInit();
            SuspendLayout();
            // 
            // label_genres
            // 
            label_genres.BackColor = Color.DarkOrange;
            label_genres.Font = new Font("Comic Sans MS", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_genres.ForeColor = Color.Cyan;
            label_genres.Location = new Point(123, 3);
            label_genres.Name = "label_genres";
            label_genres.Size = new Size(336, 109);
            label_genres.TabIndex = 1;
            label_genres.Text = "Genres";
            label_genres.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LemonChiffon;
            panel1.Controls.Add(button_Delete);
            panel1.Controls.Add(button_Edit);
            panel1.Controls.Add(button_Add);
            panel1.Controls.Add(dataGridView_genres);
            panel1.Controls.Add(textBox_name);
            panel1.Controls.Add(textBox_id);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(1059, 391);
            panel1.TabIndex = 2;
            // 
            // button_Delete
            // 
            button_Delete.BackColor = Color.White;
            button_Delete.FlatAppearance.BorderColor = Color.Black;
            button_Delete.FlatStyle = FlatStyle.Flat;
            button_Delete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_Delete.Image = (Image)resources.GetObject("button_Delete.Image");
            button_Delete.Location = new Point(326, 327);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(127, 47);
            button_Delete.TabIndex = 7;
            button_Delete.Text = "Delete";
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
            button_Edit.Location = new Point(174, 327);
            button_Edit.Name = "button_Edit";
            button_Edit.Size = new Size(127, 47);
            button_Edit.TabIndex = 6;
            button_Edit.Text = "Edit";
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
            button_Add.Location = new Point(20, 327);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(127, 47);
            button_Add.TabIndex = 5;
            button_Add.Text = "Add";
            button_Add.TextImageRelation = TextImageRelation.ImageBeforeText;
            button_Add.UseVisualStyleBackColor = false;
            button_Add.Click += button_Add_Click;
            // 
            // dataGridView_genres
            // 
            dataGridView_genres.AllowUserToAddRows = false;
            dataGridView_genres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_genres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_genres.Location = new Point(479, 31);
            dataGridView_genres.Name = "dataGridView_genres";
            dataGridView_genres.RowHeadersWidth = 62;
            dataGridView_genres.Size = new Size(562, 343);
            dataGridView_genres.TabIndex = 4;
            dataGridView_genres.CellClick += dataGridView_genres_CellClick;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(137, 169);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(301, 31);
            textBox_name.TabIndex = 3;
            // 
            // textBox_id
            // 
            textBox_id.Location = new Point(137, 80);
            textBox_id.Name = "textBox_id";
            textBox_id.Size = new Size(213, 31);
            textBox_id.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 166);
            label2.Name = "label2";
            label2.Size = new Size(97, 32);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 77);
            label1.Name = "label1";
            label1.Size = new Size(49, 32);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label_close
            // 
            label_close.BackColor = Color.DarkOrange;
            label_close.Cursor = Cursors.Hand;
            label_close.FlatStyle = FlatStyle.Flat;
            label_close.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_close.ForeColor = Color.Red;
            label_close.Location = new Point(1032, 0);
            label_close.Name = "label_close";
            label_close.Size = new Size(38, 34);
            label_close.TabIndex = 3;
            label_close.Text = "X";
            label_close.TextAlign = ContentAlignment.MiddleCenter;
            label_close.Click += label_close_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOrange;
            panel2.Controls.Add(label_close);
            panel2.Controls.Add(pictureBox_Genre);
            panel2.Controls.Add(label_genres);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1070, 109);
            panel2.TabIndex = 4;
            // 
            // pictureBox_Genre
            // 
            pictureBox_Genre.Image = (Image)resources.GetObject("pictureBox_Genre.Image");
            pictureBox_Genre.Location = new Point(0, 0);
            pictureBox_Genre.Name = "pictureBox_Genre";
            pictureBox_Genre.Size = new Size(117, 109);
            pictureBox_Genre.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Genre.TabIndex = 2;
            pictureBox_Genre.TabStop = false;
            // 
            // ManageGenresForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1070, 511);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageGenresForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageGenresForm";
            Load += ManageGenresForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_genres).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Genre).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label_genres;
        private Panel panel1;
        private Label label_close;
        private Panel panel2;
        private PictureBox pictureBox_Genre;
        private TextBox textBox_id;
        private Label label2;
        private Label label1;
        private TextBox textBox_name;
        private DataGridView dataGridView_genres;
        private Button button_Add;
        private Button button_Delete;
        private Button button_Edit;
    }
}