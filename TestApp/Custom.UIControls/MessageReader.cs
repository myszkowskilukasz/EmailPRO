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
    public partial class MessageReader : UserControl
    {
        public string MessageInfoText { get => label.Text;
            set => label.Text = value;
        }
        public string MessageContentText { get => contentTextBox.Text;
            set => contentTextBox.Text = value;
        }
        public Color StatusColor { get => status.BackColor;
            set => status.BackColor = value;
        }
        public Color MessageInfoColor { get => label.BackColor;
            set => label.BackColor = value;
        }
        public MessageReader()
        {
            InitializeComponent();
        }
    }
}
