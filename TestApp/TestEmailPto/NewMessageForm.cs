using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestEmailPto.GeneralAPI;
namespace TestEmailPto
{
    public delegate void MessageHandler(object sender, string to, string content, DateTime dateTime);
    public partial class NewMessageForm : Form
    {
        public event MessageHandler MessageHandler;
        private readonly GeneralServiceClient _generalService;
        public NewMessageForm()
        {
            _generalService= new GeneralServiceClient();
            InitializeComponent();
        }
        private async void messageWriter1_SendButtonClick(object sender, EventArgs e)
        {
            if (!await _generalService.IsThereAUserAsync(messageWriter.ToTextBoxText))
            {
                var color = messageWriter.ToTextBoxBackColor;
                messageWriter.ToTextBoxBackColor = Color.Red;
                await Task.Delay(2000);
                messageWriter.ToTextBoxBackColor = color;
                return;
            }
            MessageHandler?.Invoke(this, messageWriter.ToTextBoxText, messageWriter.ContentText, DateTime.Now);
            Close();
        }
    }
}
