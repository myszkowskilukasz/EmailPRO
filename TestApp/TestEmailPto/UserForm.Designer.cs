namespace TestEmailPto
{
    partial class UserForm
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
            this.components = new System.ComponentModel.Container();
            this.messageReaderPanel = new System.Windows.Forms.Panel();
            this.readInfoTimer = new System.Windows.Forms.Timer(this.components);
            this.messageManagerPanel = new System.Windows.Forms.Panel();
            this.messageManager = new Custom.UIControls.MessagesManager();
            this.messageReader = new Custom.UIControls.MessageReader();
            this.messageReaderPanel.SuspendLayout();
            this.messageManagerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageReaderPanel
            // 
            this.messageReaderPanel.Controls.Add(this.messageReader);
            this.messageReaderPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.messageReaderPanel.Location = new System.Drawing.Point(484, 0);
            this.messageReaderPanel.Name = "messageReaderPanel";
            this.messageReaderPanel.Size = new System.Drawing.Size(737, 709);
            this.messageReaderPanel.TabIndex = 1;
            // 
            // readInfoTimer
            // 
            this.readInfoTimer.Enabled = true;
            this.readInfoTimer.Interval = 3000;
            this.readInfoTimer.Tick += new System.EventHandler(this.ReadInfoTimer_Tick);
            // 
            // messageManagerPanel
            // 
            this.messageManagerPanel.Controls.Add(this.messageManager);
            this.messageManagerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageManagerPanel.Location = new System.Drawing.Point(0, 0);
            this.messageManagerPanel.Name = "messageManagerPanel";
            this.messageManagerPanel.Size = new System.Drawing.Size(484, 709);
            this.messageManagerPanel.TabIndex = 3;
            // 
            // messageManager
            // 
            this.messageManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageManager.IsReceivedChecked = true;
            this.messageManager.IsSentChecked = false;
            this.messageManager.Location = new System.Drawing.Point(0, 0);
            this.messageManager.Name = "messageManager";
            this.messageManager.Padding = new System.Windows.Forms.Padding(5);
            this.messageManager.SearchFilterText = "";
            this.messageManager.Size = new System.Drawing.Size(484, 709);
            this.messageManager.TabIndex = 0;
            this.messageManager.RadioButtonsCheckedChanged += new System.EventHandler(this.MessageManager_RadioButtonsCheckedChanged);
            this.messageManager.NewButtonPressed += new System.EventHandler(this.MessageManager_NewButtonPressed);
            this.messageManager.DeleteButtonPressed += new System.EventHandler(this.MessageManager_DeleteButtonPressed);
            this.messageManager.RefreshButtonPressed += new System.EventHandler(this.MessageManager_RefreshButtonPressed);
            this.messageManager.SearchTextChanged += new System.EventHandler(this.MessageManager_SearchTextChanged);
            this.messageManager.ListBoxSelectedIndexChanged += new System.EventHandler(this.MessageManager_ListBoxSelectedIndexChanged);
            // 
            // messageReader
            // 
            this.messageReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageReader.Location = new System.Drawing.Point(0, 0);
            this.messageReader.MessageContentText = "";
            this.messageReader.MessageInfoColor = System.Drawing.Color.LightSteelBlue;
            this.messageReader.MessageInfoText = "";
            this.messageReader.Name = "messageReader";
            this.messageReader.Padding = new System.Windows.Forms.Padding(5);
            this.messageReader.Size = new System.Drawing.Size(737, 709);
            this.messageReader.StatusColor = System.Drawing.Color.Gray;
            this.messageReader.TabIndex = 11;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 709);
            this.Controls.Add(this.messageManagerPanel);
            this.Controls.Add(this.messageReaderPanel);
            this.MinimumSize = new System.Drawing.Size(1239, 756);
            this.Name = "UserForm";
            this.Text = "Welcome,";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserForm_FormClosing);
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.messageReaderPanel.ResumeLayout(false);
            this.messageManagerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel messageReaderPanel;
        private System.Windows.Forms.Timer readInfoTimer;
        private Custom.UIControls.MessageReader messageReader;
        private System.Windows.Forms.Panel messageManagerPanel;
        private Custom.UIControls.MessagesManager messageManager;
    }
}