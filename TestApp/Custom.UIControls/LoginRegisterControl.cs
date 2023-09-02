using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace Custom.UIControls
{
    public partial class LoginRegisterControl : UserControl
    {
        public event EventHandler LoginPressed;
        public event EventHandler RegisterPressed;

        public string WelcomeText 
        { 
            get => welcomeLabel.Text;
            set => welcomeLabel.Text = value;
        }

        public string Username 
        {
            get => usernameTextBox.Text;
            set => usernameTextBox.Text = value;
        }

        public string Password
        {
            get => passwordTextBox.Text;
            set => passwordTextBox.Text = value;
        }

        public string MessageText
        {
            get => messageLabel.Text;
            set => messageLabel.Text = value;
        }
        public Color MessageColor
        {
            get => messageLabel.ForeColor;
            set => messageLabel.ForeColor = value;
        }
        public Color LPLabelBgColor
        {
            get => usernameLabel.BackColor;
            set { usernameLabel.BackColor = value; passwordLabel.BackColor = value; }
        }
        public Color LPLabelForeColor
        {
            get => usernameLabel.ForeColor;
            set { usernameLabel.ForeColor = value; passwordLabel.ForeColor = value; }
        }
        public Color LRButtonBgColor
        {
            get => loginButton.BackColor;
            set { loginButton.BackColor = value; registerButton.BackColor = value; }
        }
        public Color LRButtonForeColor
        {
            get => loginButton.ForeColor;
            set { loginButton.ForeColor = value; registerButton.ForeColor = value; }
        }

        public LoginRegisterControl()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginPressed?.Invoke(this, EventArgs.Empty);
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterPressed?.Invoke(this, EventArgs.Empty);
        }
    }
}
