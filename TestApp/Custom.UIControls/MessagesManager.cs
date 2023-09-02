using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom.UIControls
{
    public partial class MessagesManager : UserControl
    {
        public event EventHandler RadioButtonsCheckedChanged;
        public event EventHandler NewButtonPressed;
        public event EventHandler DeleteButtonPressed;
        public event EventHandler RefreshButtonPressed;
        public event EventHandler SearchTextChanged;
        public event EventHandler ListBoxSelectedIndexChanged;
        public bool IsReceivedChecked { get => ReceivedRadioButton.Checked;
            set => ReceivedRadioButton.Checked = value;
        }
        public bool IsSentChecked { get => sentRadioButton.Checked;
            set => sentRadioButton.Checked = value;
        }
        public string SearchFilterText { get => searchTextBox.Text;
            set => searchTextBox.Text = value;
        }
        public ListBox.ObjectCollection MessageListBoxItems => messageListBox.Items;
        public ListBox MessageList => messageListBox;

        public MessagesManager()
        {
            InitializeComponent();
        }

        private void ReceivedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonsCheckedChanged?.Invoke(this, EventArgs.Empty);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            NewButtonPressed?.Invoke(this, EventArgs.Empty);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteButtonPressed?.Invoke(this, EventArgs.Empty);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RefreshButtonPressed?.Invoke(this, EventArgs.Empty);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchTextChanged?.Invoke(this, EventArgs.Empty);
        }

        private void messageListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBoxSelectedIndexChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
