namespace Custom.UIControls
{
    partial class LoginRegisterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.registerButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.registerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(237, 261);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(117, 34);
            this.registerButton.TabIndex = 13;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(16, 261);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(117, 34);
            this.loginButton.TabIndex = 12;
            this.loginButton.Text = "Log in";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordTextBox.Location = new System.Drawing.Point(129, 80);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(225, 26);
            this.passwordTextBox.TabIndex = 11;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameTextBox.Location = new System.Drawing.Point(129, 43);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(225, 26);
            this.usernameTextBox.TabIndex = 10;
            // 
            // passwordLabel
            // 
            this.passwordLabel.BackColor = System.Drawing.Color.DimGray;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Location = new System.Drawing.Point(12, 83);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(111, 20);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.BackColor = System.Drawing.Color.DimGray;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameLabel.ForeColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Location = new System.Drawing.Point(12, 46);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(111, 20);
            this.usernameLabel.TabIndex = 8;
            this.usernameLabel.Text = "Username:";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.DimGray;
            this.welcomeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Location = new System.Drawing.Point(0, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(364, 23);
            this.welcomeLabel.TabIndex = 7;
            this.welcomeLabel.Text = "Welcome";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // messageLabel
            // 
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.messageLabel.ForeColor = System.Drawing.Color.Red;
            this.messageLabel.Location = new System.Drawing.Point(12, 112);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(325, 146);
            this.messageLabel.TabIndex = 14;
            this.messageLabel.Text = "Message here";
            // 
            // LoginRegisterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "LoginRegisterControl";
            this.Size = new System.Drawing.Size(364, 314);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label messageLabel;
    }
}
