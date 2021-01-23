
namespace VideoPlayer
{
    partial class login
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tab_login = new System.Windows.Forms.TabPage();
            this.btn_login = new MetroFramework.Controls.MetroButton();
            this.txt_room = new MetroFramework.Controls.MetroTextBox();
            this.txt_password = new MetroFramework.Controls.MetroTextBox();
            this.txt_username = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tab_sign = new System.Windows.Forms.TabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.lbl_confirmpassword_signup = new MetroFramework.Controls.MetroTextBox();
            this.lbl_password_signup = new MetroFramework.Controls.MetroTextBox();
            this.lbl_username_singup = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lbl_result_login = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_result_signup = new System.Windows.Forms.Label();
            this.metroTabControl1.SuspendLayout();
            this.tab_login.SuspendLayout();
            this.tab_sign.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tab_login);
            this.metroTabControl1.Controls.Add(this.tab_sign);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(536, 238);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tab_login
            // 
            this.tab_login.BackColor = System.Drawing.Color.Transparent;
            this.tab_login.Controls.Add(this.lbl_result_login);
            this.tab_login.Controls.Add(this.btn_login);
            this.tab_login.Controls.Add(this.txt_room);
            this.tab_login.Controls.Add(this.txt_password);
            this.tab_login.Controls.Add(this.txt_username);
            this.tab_login.Controls.Add(this.metroLabel3);
            this.tab_login.Controls.Add(this.metroLabel2);
            this.tab_login.Controls.Add(this.metroLabel1);
            this.tab_login.Location = new System.Drawing.Point(4, 38);
            this.tab_login.Name = "tab_login";
            this.tab_login.Size = new System.Drawing.Size(528, 196);
            this.tab_login.TabIndex = 0;
            this.tab_login.Text = "Login";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_login.Location = new System.Drawing.Point(342, 138);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(143, 34);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "Login";
            this.btn_login.UseSelectable = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_room
            // 
            // 
            // 
            // 
            this.txt_room.CustomButton.Image = null;
            this.txt_room.CustomButton.Location = new System.Drawing.Point(49, 2);
            this.txt_room.CustomButton.Name = "";
            this.txt_room.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_room.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_room.CustomButton.TabIndex = 1;
            this.txt_room.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_room.CustomButton.UseSelectable = true;
            this.txt_room.CustomButton.Visible = false;
            this.txt_room.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_room.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt_room.Lines = new string[0];
            this.txt_room.Location = new System.Drawing.Point(120, 100);
            this.txt_room.MaxLength = 32767;
            this.txt_room.Name = "txt_room";
            this.txt_room.PasswordChar = '\0';
            this.txt_room.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_room.SelectedText = "";
            this.txt_room.SelectionLength = 0;
            this.txt_room.SelectionStart = 0;
            this.txt_room.ShortcutsEnabled = true;
            this.txt_room.Size = new System.Drawing.Size(77, 30);
            this.txt_room.TabIndex = 5;
            this.txt_room.UseSelectable = true;
            this.txt_room.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_room.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_password
            // 
            // 
            // 
            // 
            this.txt_password.CustomButton.Image = null;
            this.txt_password.CustomButton.Location = new System.Drawing.Point(337, 2);
            this.txt_password.CustomButton.Name = "";
            this.txt_password.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_password.CustomButton.TabIndex = 1;
            this.txt_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_password.CustomButton.UseSelectable = true;
            this.txt_password.CustomButton.Visible = false;
            this.txt_password.Lines = new string[0];
            this.txt_password.Location = new System.Drawing.Point(120, 60);
            this.txt_password.MaxLength = 32767;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.ShortcutsEnabled = true;
            this.txt_password.Size = new System.Drawing.Size(365, 30);
            this.txt_password.TabIndex = 4;
            this.txt_password.UseSelectable = true;
            this.txt_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_username
            // 
            // 
            // 
            // 
            this.txt_username.CustomButton.Image = null;
            this.txt_username.CustomButton.Location = new System.Drawing.Point(337, 2);
            this.txt_username.CustomButton.Name = "";
            this.txt_username.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_username.CustomButton.TabIndex = 1;
            this.txt_username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_username.CustomButton.UseSelectable = true;
            this.txt_username.CustomButton.Visible = false;
            this.txt_username.Lines = new string[0];
            this.txt_username.Location = new System.Drawing.Point(120, 20);
            this.txt_username.MaxLength = 32767;
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_username.SelectedText = "";
            this.txt_username.SelectionLength = 0;
            this.txt_username.SelectionStart = 0;
            this.txt_username.ShortcutsEnabled = true;
            this.txt_username.Size = new System.Drawing.Size(365, 30);
            this.txt_username.TabIndex = 3;
            this.txt_username.UseSelectable = true;
            this.txt_username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(25, 100);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 20);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Room";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(25, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 20);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Password";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(25, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Username";
            // 
            // tab_sign
            // 
            this.tab_sign.Controls.Add(this.lbl_result_signup);
            this.tab_sign.Controls.Add(this.label4);
            this.tab_sign.Controls.Add(this.metroButton1);
            this.tab_sign.Controls.Add(this.lbl_confirmpassword_signup);
            this.tab_sign.Controls.Add(this.lbl_password_signup);
            this.tab_sign.Controls.Add(this.lbl_username_singup);
            this.tab_sign.Controls.Add(this.label3);
            this.tab_sign.Controls.Add(this.label2);
            this.tab_sign.Controls.Add(this.label1);
            this.tab_sign.Location = new System.Drawing.Point(4, 38);
            this.tab_sign.Name = "tab_sign";
            this.tab_sign.Size = new System.Drawing.Size(528, 196);
            this.tab_sign.TabIndex = 1;
            this.tab_sign.Text = "Sign up";
            this.tab_sign.Click += new System.EventHandler(this.tab_sign_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.metroButton1.Location = new System.Drawing.Point(342, 138);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(143, 34);
            this.metroButton1.TabIndex = 7;
            this.metroButton1.Text = "Sign up";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // lbl_confirmpassword_signup
            // 
            // 
            // 
            // 
            this.lbl_confirmpassword_signup.CustomButton.Image = null;
            this.lbl_confirmpassword_signup.CustomButton.Location = new System.Drawing.Point(292, 2);
            this.lbl_confirmpassword_signup.CustomButton.Name = "";
            this.lbl_confirmpassword_signup.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.lbl_confirmpassword_signup.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lbl_confirmpassword_signup.CustomButton.TabIndex = 1;
            this.lbl_confirmpassword_signup.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lbl_confirmpassword_signup.CustomButton.UseSelectable = true;
            this.lbl_confirmpassword_signup.CustomButton.Visible = false;
            this.lbl_confirmpassword_signup.Lines = new string[0];
            this.lbl_confirmpassword_signup.Location = new System.Drawing.Point(170, 100);
            this.lbl_confirmpassword_signup.MaxLength = 32767;
            this.lbl_confirmpassword_signup.Name = "lbl_confirmpassword_signup";
            this.lbl_confirmpassword_signup.PasswordChar = '*';
            this.lbl_confirmpassword_signup.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lbl_confirmpassword_signup.SelectedText = "";
            this.lbl_confirmpassword_signup.SelectionLength = 0;
            this.lbl_confirmpassword_signup.SelectionStart = 0;
            this.lbl_confirmpassword_signup.ShortcutsEnabled = true;
            this.lbl_confirmpassword_signup.Size = new System.Drawing.Size(320, 30);
            this.lbl_confirmpassword_signup.TabIndex = 6;
            this.lbl_confirmpassword_signup.UseSelectable = true;
            this.lbl_confirmpassword_signup.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lbl_confirmpassword_signup.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_password_signup
            // 
            // 
            // 
            // 
            this.lbl_password_signup.CustomButton.Image = null;
            this.lbl_password_signup.CustomButton.Location = new System.Drawing.Point(292, 2);
            this.lbl_password_signup.CustomButton.Name = "";
            this.lbl_password_signup.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.lbl_password_signup.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lbl_password_signup.CustomButton.TabIndex = 1;
            this.lbl_password_signup.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lbl_password_signup.CustomButton.UseSelectable = true;
            this.lbl_password_signup.CustomButton.Visible = false;
            this.lbl_password_signup.Lines = new string[0];
            this.lbl_password_signup.Location = new System.Drawing.Point(170, 60);
            this.lbl_password_signup.MaxLength = 32767;
            this.lbl_password_signup.Name = "lbl_password_signup";
            this.lbl_password_signup.PasswordChar = '*';
            this.lbl_password_signup.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lbl_password_signup.SelectedText = "";
            this.lbl_password_signup.SelectionLength = 0;
            this.lbl_password_signup.SelectionStart = 0;
            this.lbl_password_signup.ShortcutsEnabled = true;
            this.lbl_password_signup.Size = new System.Drawing.Size(320, 30);
            this.lbl_password_signup.TabIndex = 5;
            this.lbl_password_signup.UseSelectable = true;
            this.lbl_password_signup.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lbl_password_signup.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_username_singup
            // 
            // 
            // 
            // 
            this.lbl_username_singup.CustomButton.Image = null;
            this.lbl_username_singup.CustomButton.Location = new System.Drawing.Point(292, 2);
            this.lbl_username_singup.CustomButton.Name = "";
            this.lbl_username_singup.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.lbl_username_singup.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lbl_username_singup.CustomButton.TabIndex = 1;
            this.lbl_username_singup.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lbl_username_singup.CustomButton.UseSelectable = true;
            this.lbl_username_singup.CustomButton.Visible = false;
            this.lbl_username_singup.Lines = new string[0];
            this.lbl_username_singup.Location = new System.Drawing.Point(170, 20);
            this.lbl_username_singup.MaxLength = 32767;
            this.lbl_username_singup.Name = "lbl_username_singup";
            this.lbl_username_singup.PasswordChar = '\0';
            this.lbl_username_singup.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lbl_username_singup.SelectedText = "";
            this.lbl_username_singup.SelectionLength = 0;
            this.lbl_username_singup.SelectionStart = 0;
            this.lbl_username_singup.ShortcutsEnabled = true;
            this.lbl_username_singup.Size = new System.Drawing.Size(320, 30);
            this.lbl_username_singup.TabIndex = 4;
            this.lbl_username_singup.UseSelectable = true;
            this.lbl_username_singup.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lbl_username_singup.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Confirm Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(27, 316);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(180, 20);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "WoodenSpoon player v1.0.2";
            // 
            // lbl_result_login
            // 
            this.lbl_result_login.AutoSize = true;
            this.lbl_result_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result_login.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_result_login.Location = new System.Drawing.Point(30, 154);
            this.lbl_result_login.Name = "lbl_result_login";
            this.lbl_result_login.Size = new System.Drawing.Size(0, 17);
            this.lbl_result_login.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(264, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 10;
            // 
            // lbl_result_signup
            // 
            this.lbl_result_signup.AutoSize = true;
            this.lbl_result_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result_signup.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_result_signup.Location = new System.Drawing.Point(30, 154);
            this.lbl_result_signup.Name = "lbl_result_signup";
            this.lbl_result_signup.Size = new System.Drawing.Size(0, 17);
            this.lbl_result_signup.TabIndex = 11;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 354);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.Resizable = false;
            this.Text = "Welcome  💕";
            this.Load += new System.EventHandler(this.login_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tab_login.ResumeLayout(false);
            this.tab_login.PerformLayout();
            this.tab_sign.ResumeLayout(false);
            this.tab_sign.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tab_login;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TabPage tab_sign;
        private MetroFramework.Controls.MetroTextBox txt_username;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txt_room;
        private MetroFramework.Controls.MetroTextBox txt_password;
        private MetroFramework.Controls.MetroButton btn_login;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox lbl_confirmpassword_signup;
        private MetroFramework.Controls.MetroTextBox lbl_password_signup;
        private MetroFramework.Controls.MetroTextBox lbl_username_singup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Label lbl_result_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_result_signup;
    }
}