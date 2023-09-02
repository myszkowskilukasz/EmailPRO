using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TestEmailPto.UserAPI;
using TestEmailPto.GeneralAPI;

namespace TestEmailPto
{
    public partial class UserForm : Form
    {
        private string _username = "";
        private readonly UserServiceClient _userApp;
        private readonly GeneralServiceClient _generalService;
        private UserAPI.Message _currentlyOpen;
        private List<UserAPI.Message> _receivedMessages = new List<UserAPI.Message>();
        private List<UserAPI.Message> _sentMessages = new List<UserAPI.Message>();

        public UserForm()
        {
            _userApp = new UserServiceClient();
            _generalService = new GeneralServiceClient();
            _currentlyOpen = new UserAPI.Message();
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            var starter = new LoginRegisterForm();
            starter.OnLogin += LoginOk;
            starter.ShowDialog();
        }
        private void ReadReceivedMessagesFromServer()
        {
            _receivedMessages = _userApp.GetReceivedMessages(_username).ToList();
        }
        private void ReadSentMessagesFromServer()
        {
            _sentMessages = _userApp.GetSentMessages(_username).ToList();
        }

        private void LoginOk(object sender, string username)
        {
            this._username = username;
            this.Text += $" {username}";

            ReadReceivedMessagesFromServer();
            ReadSentMessagesFromServer();

            ReloadMessageListBox(messageManager.SearchFilterText);
        }

        private void ReloadMessageListBox(string filter)
        {
            messageManager.MessageListBoxItems.Clear();


            ReadReceivedMessagesFromServer();
            ReadSentMessagesFromServer();
            if (messageManager.IsReceivedChecked) //receivedRadioButton.Checked
                foreach (var m in _receivedMessages)
                    messageManager.MessageListBoxItems.Add($"From: {m.From}, sent on {m.SentOn:R}\n");
            else
                foreach (var m in _sentMessages)
                    messageManager.MessageListBoxItems.Add($"To: {m.To}, sent on {m.SentOn:R}\n");
            var indexesToRemove = new List<int>();
            indexesToRemove.Clear();
            if (filter.Length > 0)
                for (var i = 0; i < messageManager.MessageListBoxItems.Count; i++) //messageListBox.Items
                    if (!messageManager.MessageListBoxItems[i].ToString().Contains(filter)) //!messageListBox.Items
                        indexesToRemove.Add(i);

            for (var i = indexesToRemove.Count - 1; i >= 0; i--)
            {
                messageManager.MessageListBoxItems.RemoveAt(indexesToRemove[i]);
                if (messageManager.IsReceivedChecked)
                    _receivedMessages.RemoveAt(indexesToRemove[i]);
                else
                    _sentMessages.RemoveAt(indexesToRemove[i]);
            }
            
            messageManager.MessageList.Invalidate();
        }


        private void MessageOk(object sender, string to, string content, DateTime dateTime)
        {
            _userApp.SendMessage(to, _username, content, dateTime);
        }

        private void ReadInfoTimer_Tick(object sender, EventArgs e)
        {
            if (messageManager.IsReceivedChecked && messageReader.MessageInfoText != "")
            {
                var isActive = _userApp.IsUserActive(_currentlyOpen.From);
                messageReader.StatusColor = isActive ? Color.Green : Color.Gray;
            }
            else if (messageManager.IsSentChecked && messageReader.MessageInfoText != "")
            {
                var isActive = _userApp.IsUserActive(_currentlyOpen.To);
                messageReader.StatusColor = isActive ? Color.Green : Color.Gray;
            }
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _generalService.Logout(_username);
        }

        private void MessageManager_RadioButtonsCheckedChanged(object sender, EventArgs e)
        {
            ReloadMessageListBox(messageManager.SearchFilterText);
            messageManager.SearchFilterText = string.Empty; //searchTextBox.Text = string.Empty;
            messageReader.MessageInfoText = string.Empty;
            messageReader.MessageContentText = string.Empty;
        }

        private void MessageManager_NewButtonPressed(object sender, EventArgs e)
        {
            var messageForm = new NewMessageForm();
            messageForm.MessageHandler += MessageOk;
            messageForm.Show();
        }

        private void MessageManager_DeleteButtonPressed(object sender, EventArgs e)
        {
            if (!messageManager.IsSentChecked) return;
            _userApp.DeleteMessageByID(_currentlyOpen.Id);
            ReadReceivedMessagesFromServer();
            ReadSentMessagesFromServer();
            ReloadMessageListBox(messageManager.SearchFilterText);
        }

        private void MessageManager_ListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            var index = messageManager.MessageList.SelectedIndex;//messageListBox.SelectedIndex;

            if (index < 0)
            {
                messageReader.StatusColor = messageReader.MessageInfoColor;
                return;
            }

            if (messageManager.IsReceivedChecked)
            {
                _currentlyOpen = _receivedMessages[index];
                messageReader.MessageInfoText = $"From: {_currentlyOpen.From}, sent on {_currentlyOpen.SentOn}. " +
                    $"User {_currentlyOpen.From} status: ";
            }
            else
            {
                _currentlyOpen = _sentMessages[index];
                var isRead = _currentlyOpen.IsRead ? "YES" : "NO";
                messageReader.MessageInfoText = $"To: {_currentlyOpen.To}, sent on {_currentlyOpen.SentOn}. Read: {isRead}. " +
                    $"User {_currentlyOpen.To} status: ";
            }

            messageReader.MessageContentText = _currentlyOpen.Content; //"\n\n" + ...

            if (messageManager.IsReceivedChecked)
                _userApp.ReadMessageByID(_currentlyOpen.Id);
        }

        private void MessageManager_RefreshButtonPressed(object sender, EventArgs e)
        {
            ReloadMessageListBox(messageManager.SearchFilterText);
        }

        private void MessageManager_SearchTextChanged(object sender, EventArgs e)
        {
            ReloadMessageListBox(messageManager.SearchFilterText);
        }
    }
}
