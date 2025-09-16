namespace Library_Management_System.FORMS
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            panel1 = new Panel();
            btnLogin = new Button();
            textBox_password = new TextBox();
            textBox_username = new TextBox();
            pictureBox_Password = new PictureBox();
            pictureBox_User = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Password).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_User).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 24, 34);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(textBox_password);
            panel1.Controls.Add(textBox_username);
            panel1.Controls.Add(pictureBox_Password);
            panel1.Controls.Add(pictureBox_User);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(581, 447);
            panel1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Cyan;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(65, 356);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(454, 68);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // textBox_password
            // 
            textBox_password.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_password.Location = new Point(142, 256);
            textBox_password.Name = "textBox_password";
            textBox_password.PasswordChar = '*';
            textBox_password.PlaceholderText = "Password";
            textBox_password.Size = new Size(377, 37);
            textBox_password.TabIndex = 5;
            // 
            // textBox_username
            // 
            textBox_username.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox_username.Location = new Point(142, 165);
            textBox_username.Margin = new Padding(5, 4, 3, 3);
            textBox_username.Name = "textBox_username";
            textBox_username.PlaceholderText = "Username";
            textBox_username.Size = new Size(377, 37);
            textBox_username.TabIndex = 4;
            // 
            // pictureBox_Password
            // 
            pictureBox_Password.BackColor = Color.Transparent;
            pictureBox_Password.Image = (Image)resources.GetObject("pictureBox_Password.Image");
            pictureBox_Password.InitialImage = (Image)resources.GetObject("pictureBox_Password.InitialImage");
            pictureBox_Password.Location = new Point(65, 249);
            pictureBox_Password.Name = "pictureBox_Password";
            pictureBox_Password.Size = new Size(50, 50);
            pictureBox_Password.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox_Password.TabIndex = 3;
            pictureBox_Password.TabStop = false;
            // 
            // pictureBox_User
            // 
            pictureBox_User.BackColor = Color.Transparent;
            pictureBox_User.Image = (Image)resources.GetObject("pictureBox_User.Image");
            pictureBox_User.Location = new Point(65, 158);
            pictureBox_User.Name = "pictureBox_User";
            pictureBox_User.Size = new Size(50, 50);
            pictureBox_User.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox_User.TabIndex = 2;
            pictureBox_User.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.Yellow;
            label2.Cursor = Cursors.Hand;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(540, 2);
            label2.Name = "label2";
            label2.Size = new Size(38, 34);
            label2.TabIndex = 1;
            label2.Text = "X";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            label2.MouseEnter += label2_MouseEnter;
            label2.MouseLeave += label2_MouseLeave;
            // 
            // label1
            // 
            label1.BackColor = Color.Yellow;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Comic Sans MS", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(17, 24, 34);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(581, 120);
            label1.TabIndex = 0;
            label1.Text = "USER LOGIN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 447);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login_Form";
            Load += Login_Form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Password).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_User).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox_Password;
        private PictureBox pictureBox_User;
        private Button btnLogin;
        private TextBox textBox_password;
        private TextBox textBox_username;
    }
}