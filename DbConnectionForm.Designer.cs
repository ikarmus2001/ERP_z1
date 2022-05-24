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
            this.label_ServerName = new System.Windows.Forms.Label();
            this.label_Login = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_DatabaseName = new System.Windows.Forms.Label();
            this.comboBox_serverName = new System.Windows.Forms.ComboBox();
            this.comboBox_dbName = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(12, 128);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(211, 23);
            this.textBox_Login.TabIndex = 0;
            this.textBox_Login.Text = "user_1";
            this.textBox_Login.TextChanged += new System.EventHandler(this.Textbox_Credentials_TextChanged);
            // 
            // button_SignIn
            // 
            this.button_SignIn.Enabled = false;
            this.button_SignIn.Location = new System.Drawing.Point(80, 241);
            this.button_SignIn.Name = "button_SignIn";
            this.button_SignIn.Size = new System.Drawing.Size(75, 23);
            this.button_SignIn.TabIndex = 1;
            this.button_SignIn.Text = "Sign in";
            this.button_SignIn.UseVisualStyleBackColor = true;
            this.button_SignIn.Click += new System.EventHandler(this.Button_SignIn_Clicked);
            this.button_SignIn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Button_SignIn_KeyDown);
            // 
            // label_ServerName
            // 
            this.label_ServerName.AutoSize = true;
            this.label_ServerName.Enabled = false;
            this.label_ServerName.Location = new System.Drawing.Point(12, 9);
            this.label_ServerName.Name = "label_ServerName";
            this.label_ServerName.Size = new System.Drawing.Size(75, 15);
            this.label_ServerName.TabIndex = 0;
            this.label_ServerName.Text = "Server name:";
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Enabled = false;
            this.label_Login.Location = new System.Drawing.Point(12, 110);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(37, 15);
            this.label_Login.TabIndex = 3;
            this.label_Login.Text = "Login";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Enabled = false;
            this.label_Password.Location = new System.Drawing.Point(12, 161);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(57, 15);
            this.label_Password.TabIndex = 5;
            this.label_Password.Text = "Password";
            // 
            // textBox_Password
            // 
            this.textBox_Password.AllowDrop = true;
            this.textBox_Password.Location = new System.Drawing.Point(12, 179);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(211, 23);
            this.textBox_Password.TabIndex = 4;
            this.textBox_Password.Text = "user";
            this.textBox_Password.UseSystemPasswordChar = true;
            this.textBox_Password.TextChanged += new System.EventHandler(this.Textbox_Credentials_TextChanged);
            // 
            // label_DatabaseName
            // 
            this.label_DatabaseName.AutoSize = true;
            this.label_DatabaseName.Enabled = false;
            this.label_DatabaseName.Location = new System.Drawing.Point(12, 61);
            this.label_DatabaseName.Name = "label_DatabaseName";
            this.label_DatabaseName.Size = new System.Drawing.Size(91, 15);
            this.label_DatabaseName.TabIndex = 6;
            this.label_DatabaseName.Text = "Database name:";
            // 
            // comboBox_serverName
            // 
            this.comboBox_serverName.FormattingEnabled = true;
            this.comboBox_serverName.Location = new System.Drawing.Point(12, 27);
            this.comboBox_serverName.Name = "comboBox_serverName";
            this.comboBox_serverName.Size = new System.Drawing.Size(211, 23);
            this.comboBox_serverName.TabIndex = 9;
            // 
            // comboBox_dbName
            // 
            this.comboBox_dbName.FormattingEnabled = true;
            this.comboBox_dbName.Location = new System.Drawing.Point(12, 79);
            this.comboBox_dbName.Name = "comboBox_dbName";
            this.comboBox_dbName.Size = new System.Drawing.Size(211, 23);
            this.comboBox_dbName.TabIndex = 10;
            // 
            // DbConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 295);
            this.Controls.Add(this.comboBox_dbName);
            this.Controls.Add(this.comboBox_serverName);
            this.Controls.Add(this.label_DatabaseName);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.label_ServerName);
            this.Controls.Add(this.button_SignIn);
            this.Controls.Add(this.textBox_Login);
            this.MaximizeBox = false;
            this.Name = "DbConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect to database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_Login;
        private Button button_SignIn;
        private Label label_ServerName;
        private Label label_Login;
        private Label label_Password;
        private TextBox textBox_Password;
        private Label label_DatabaseName;
        private ComboBox comboBox_serverName;
        private ComboBox comboBox_dbName;
    }
}