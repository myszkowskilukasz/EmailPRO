namespace TestEmailPto
{
    partial class LoginRegisterForm
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
            this.loginRegisterControl = new Custom.UIControls.LoginRegisterControl();
            this.SuspendLayout();
            // 
            // loginRegisterControl
            // 
            this.loginRegisterControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginRegisterControl.LPLabelBgColor = System.Drawing.Color.DimGray;
            this.loginRegisterControl.LPLabelForeColor = System.Drawing.Color.Transparent;
            this.loginRegisterControl.LRButtonBgColor = System.Drawing.Color.DarkSlateGray;
            this.loginRegisterControl.LRButtonForeColor = System.Drawing.Color.White;
            this.loginRegisterControl.Location = new System.Drawing.Point(0, 0);
            this.loginRegisterControl.MessageColor = System.Drawing.Color.Red;
            this.loginRegisterControl.MessageText = "";
            this.loginRegisterControl.Name = "loginRegisterControl";
            this.loginRegisterControl.Password = "";
            this.loginRegisterControl.Size = new System.Drawing.Size(368, 312);
            this.loginRegisterControl.TabIndex = 8;
            this.loginRegisterControl.Username = "";
            this.loginRegisterControl.WelcomeText = "Welcome to EmailPRO!!";
            this.loginRegisterControl.LoginPressed += new System.EventHandler(this.loginRegisterControl_LoginPressed);
            this.loginRegisterControl.RegisterPressed += new System.EventHandler(this.loginRegisterControl_RegisterPressed);
            // 
            // StarterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 312);
            this.Controls.Add(this.loginRegisterControl);
            this.MaximumSize = new System.Drawing.Size(386, 359);
            this.MinimumSize = new System.Drawing.Size(386, 359);
            this.Name = "StarterForm";
            this.Text = "EMAIL PROOOOOOO";
            this.ResumeLayout(false);

        }

        #endregion
        private Custom.UIControls.LoginRegisterControl loginRegisterControl;
    }
}

