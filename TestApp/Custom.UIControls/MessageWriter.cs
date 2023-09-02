using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom.UIControls
{
    public partial class MessageWriter : UserControl
    {
        public event EventHandler SendButtonClick;
        public Color ToTextBoxBackColor { get => toTextBox.BackColor;
            set => toTextBox.BackColor = value;
        }
        public string ToTextBoxText { get => toTextBox.Text;
            set => toTextBox.Text = value;
        }
        public string ContentText { get => contentTextBox.Text;
            set => contentTextBox.Text = value;
        }
        public MessageWriter()
        {
            InitializeComponent();
        }
        private void sendButton_Click(object sender, EventArgs e)
        {
            SendButtonClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
