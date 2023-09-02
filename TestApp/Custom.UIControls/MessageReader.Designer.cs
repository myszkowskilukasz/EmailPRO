namespace Custom.UIControls
{
    partial class MessageReader
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contentTextBox = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(702, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.contentTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(692, 400);
            this.panel3.TabIndex = 4;
            // 
            // contentTextBox
            // 
            this.contentTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.contentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTextBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.contentTextBox.ForeColor = System.Drawing.Color.Snow;
            this.contentTextBox.Location = new System.Drawing.Point(0, 0);
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.ReadOnly = true;
            this.contentTextBox.Size = new System.Drawing.Size(692, 400);
            this.contentTextBox.TabIndex = 1;
            this.contentTextBox.Text = "Message\nHERE\n:)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label);
            this.panel2.Controls.Add(this.status);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(692, 40);
            this.panel2.TabIndex = 3;
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label.Location = new System.Drawing.Point(2, 2);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(652, 36);
            this.label.TabIndex = 0;
            this.label.Text = "MessageInfo here";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.Green;
            this.status.Dock = System.Windows.Forms.DockStyle.Right;
            this.status.Location = new System.Drawing.Point(654, 2);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(36, 36);
            this.status.TabIndex = 2;
            // 
            // MessageReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "MessageReader";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(706, 454);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox contentTextBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
