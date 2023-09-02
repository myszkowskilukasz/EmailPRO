namespace Custom.UIControls
{
    partial class MessageWriter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageWriter));
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.contentTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toTextBox
            // 
            this.toTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toTextBox.ForeColor = System.Drawing.Color.Snow;
            this.toTextBox.Location = new System.Drawing.Point(174, 16);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(434, 24);
            this.toTextBox.TabIndex = 3;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sendButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sendButton.Image = ((System.Drawing.Image)(resources.GetObject("sendButton.Image")));
            this.sendButton.Location = new System.Drawing.Point(614, 0);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(61, 59);
            this.sendButton.TabIndex = 4;
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label.Dock = System.Windows.Forms.DockStyle.Left;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.Location = new System.Drawing.Point(0, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(168, 59);
            this.label.TabIndex = 5;
            this.label.Text = "You are writing to:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contentTextBox
            // 
            this.contentTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.contentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTextBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.contentTextBox.ForeColor = System.Drawing.Color.Snow;
            this.contentTextBox.Location = new System.Drawing.Point(0, 0);
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(675, 610);
            this.contentTextBox.TabIndex = 6;
            this.contentTextBox.Text = "Message here :)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toTextBox);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.sendButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.panel1.Size = new System.Drawing.Size(675, 61);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.contentTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(675, 610);
            this.panel2.TabIndex = 8;
            // 
            // MessageWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MessageWriter";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(679, 675);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.RichTextBox contentTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
