namespace Custom.UIControls
{
    partial class MessagesManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessagesManager));
            this.ReceivedRadioButton = new System.Windows.Forms.RadioButton();
            this.sentRadioButton = new System.Windows.Forms.RadioButton();
            this.newButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.messageListBox = new System.Windows.Forms.ListBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReceivedRadioButton
            // 
            this.ReceivedRadioButton.AutoSize = true;
            this.ReceivedRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReceivedRadioButton.Location = new System.Drawing.Point(3, 3);
            this.ReceivedRadioButton.Name = "ReceivedRadioButton";
            this.ReceivedRadioButton.Size = new System.Drawing.Size(95, 20);
            this.ReceivedRadioButton.TabIndex = 0;
            this.ReceivedRadioButton.TabStop = true;
            this.ReceivedRadioButton.Text = "Received";
            this.ReceivedRadioButton.UseVisualStyleBackColor = true;
            this.ReceivedRadioButton.CheckedChanged += new System.EventHandler(this.ReceivedRadioButton_CheckedChanged);
            // 
            // sentRadioButton
            // 
            this.sentRadioButton.AutoSize = true;
            this.sentRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sentRadioButton.Location = new System.Drawing.Point(3, 29);
            this.sentRadioButton.Name = "sentRadioButton";
            this.sentRadioButton.Size = new System.Drawing.Size(59, 20);
            this.sentRadioButton.TabIndex = 1;
            this.sentRadioButton.TabStop = true;
            this.sentRadioButton.Text = "Sent";
            this.sentRadioButton.UseVisualStyleBackColor = true;
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.newButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.newButton.Location = new System.Drawing.Point(132, 3);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(89, 46);
            this.newButton.TabIndex = 2;
            this.newButton.Text = "New";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.ReceivedRadioButton);
            this.panel1.Controls.Add(this.sentRadioButton);
            this.panel1.Controls.Add(this.newButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 57);
            this.panel1.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(378, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 57);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteButton.Location = new System.Drawing.Point(227, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(89, 46);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // messageListBox
            // 
            this.messageListBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.messageListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.messageListBox.ForeColor = System.Drawing.Color.Snow;
            this.messageListBox.FormattingEnabled = true;
            this.messageListBox.ItemHeight = 18;
            this.messageListBox.Location = new System.Drawing.Point(0, 0);
            this.messageListBox.Name = "messageListBox";
            this.messageListBox.Size = new System.Drawing.Size(435, 567);
            this.messageListBox.TabIndex = 6;
            this.messageListBox.SelectedIndexChanged += new System.EventHandler(this.messageListBox_SelectedIndexChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchTextBox.ForeColor = System.Drawing.Color.Snow;
            this.searchTextBox.Location = new System.Drawing.Point(38, 3);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(394, 24);
            this.searchTextBox.TabIndex = 1;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchLabel.Image = ((System.Drawing.Image)(resources.GetObject("searchLabel.Image")));
            this.searchLabel.Location = new System.Drawing.Point(6, 3);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(20, 20);
            this.searchLabel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.searchTextBox);
            this.panel2.Controls.Add(this.searchLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 59);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(435, 39);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.messageListBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 567);
            this.panel3.TabIndex = 8;
            // 
            // MessagesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MessagesManager";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(439, 667);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton ReceivedRadioButton;
        private System.Windows.Forms.RadioButton sentRadioButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ListBox messageListBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
