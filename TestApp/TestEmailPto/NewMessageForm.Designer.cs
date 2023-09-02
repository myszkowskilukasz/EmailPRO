namespace TestEmailPto
{
    partial class NewMessageForm
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
            this.messageViewPanel = new System.Windows.Forms.Panel();
            this.messageWriter = new Custom.UIControls.MessageWriter();
            this.messageViewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageViewPanel
            // 
            this.messageViewPanel.Controls.Add(this.messageWriter);
            this.messageViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageViewPanel.Location = new System.Drawing.Point(0, 0);
            this.messageViewPanel.Name = "messageViewPanel";
            this.messageViewPanel.Size = new System.Drawing.Size(684, 652);
            this.messageViewPanel.TabIndex = 2;
            // 
            // messageWriter
            // 
            this.messageWriter.ContentText = "";
            this.messageWriter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageWriter.Location = new System.Drawing.Point(0, 0);
            this.messageWriter.Name = "messageWriter";
            this.messageWriter.Padding = new System.Windows.Forms.Padding(2);
            this.messageWriter.Size = new System.Drawing.Size(684, 652);
            this.messageWriter.TabIndex = 5;
            this.messageWriter.ToTextBoxBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.messageWriter.ToTextBoxText = "";
            this.messageWriter.SendButtonClick += new System.EventHandler(this.messageWriter1_SendButtonClick);
            // 
            // NewMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 652);
            this.Controls.Add(this.messageViewPanel);
            this.MinimumSize = new System.Drawing.Size(683, 693);
            this.Name = "NewMessageForm";
            this.Text = "NewMessageForm";
            this.messageViewPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel messageViewPanel;
        private Custom.UIControls.MessageWriter messageWriter;
    }
}