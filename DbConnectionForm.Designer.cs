namespace Halaczkiewicz_z1
{
    partial class DbConnectionForm
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
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.button_SignIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Login = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Server = new System.Windows.Forms.TextBox();
            this.textBox_DatabaseName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(88, 175);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(100, 23);
            this.textBox_Login.TabIndex = 0;
            this.textBox_Login.TextChanged += new System.EventHandler(this.Textbox_Credentials_TextChanged);
            // 
            // button_SignIn
            // 
            this.button_SignIn.Enabled = false;
            this.button_SignIn.Location = new System.Drawing.Point(100, 291);
            this.button_SignIn.Name = "button_SignIn";
            this.button_SignIn.Size = new System.Drawing.Size(75, 23);
            this.button_SignIn.TabIndex = 1;
            this.button_SignIn.Text = "Sign in";
            this.button_SignIn.UseVisualStyleBackColor = true;
            this.button_SignIn.Click += new System.EventHandler(this.Button_SignIn_Clicked);
            this.button_SignIn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Button_SignIn_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Location = new System.Drawing.Point(86, 157);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(37, 15);
            this.label_Login.TabIndex = 3;
            this.label_Login.Text = "Login";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(90, 213);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(57, 15);
            this.label_Password.TabIndex = 5;
            this.label_Password.Text = "Password";
            // 
            // textBox_Password
            // 
            this.textBox_Password.AllowDrop = true;
            this.textBox_Password.Location = new System.Drawing.Point(88, 235);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(100, 23);
            this.textBox_Password.TabIndex = 4;
            this.textBox_Password.UseSystemPasswordChar = true;
            this.textBox_Password.TextChanged += new System.EventHandler(this.Textbox_Credentials_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // textBox_Server
            // 
            this.textBox_Server.Location = new System.Drawing.Point(49, 39);
            this.textBox_Server.Name = "textBox_Server";
            this.textBox_Server.Size = new System.Drawing.Size(205, 23);
            this.textBox_Server.TabIndex = 7;
            this.textBox_Server.Text = "LENOVOTHINKPAD-\\SQLEXPRESS";
            // 
            // textBox_DatabaseName
            // 
            this.textBox_DatabaseName.Location = new System.Drawing.Point(88, 104);
            this.textBox_DatabaseName.Name = "textBox_DatabaseName";
            this.textBox_DatabaseName.Size = new System.Drawing.Size(100, 23);
            this.textBox_DatabaseName.TabIndex = 8;
            this.textBox_DatabaseName.Text = "master";
            // 
            // DbConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 450);
            this.Controls.Add(this.textBox_DatabaseName);
            this.Controls.Add(this.textBox_Server);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_SignIn);
            this.Controls.Add(this.textBox_Login);
            this.Name = "DbConnectionForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_Login;
        private Button button_SignIn;
        private Label label1;
        private Label label_Login;
        private Label label_Password;
        private TextBox textBox_Password;
        private Label label4;
        private TextBox textBox_Server;
        private TextBox textBox_DatabaseName;
    }
}