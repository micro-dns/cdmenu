namespace CDMenu.SubForms
{
    partial class Message
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
            this.MessageBox_Message = new System.Windows.Forms.Label();
            this.OK_button = new System.Windows.Forms.Label();
            this.MessageBox_Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MessageBox_Message
            // 
            this.MessageBox_Message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MessageBox_Message.AutoSize = true;
            this.MessageBox_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageBox_Message.Location = new System.Drawing.Point(12, 41);
            this.MessageBox_Message.Margin = new System.Windows.Forms.Padding(0);
            this.MessageBox_Message.MaximumSize = new System.Drawing.Size(335, 0);
            this.MessageBox_Message.Name = "MessageBox_Message";
            this.MessageBox_Message.Size = new System.Drawing.Size(152, 16);
            this.MessageBox_Message.TabIndex = 0;
            this.MessageBox_Message.Text = "MessageBox_Message";
            // 
            // OK_button
            // 
            this.OK_button.BackColor = System.Drawing.Color.Silver;
            this.OK_button.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK_button.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.OK_button.Location = new System.Drawing.Point(104, 179);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(129, 29);
            this.OK_button.TabIndex = 9;
            this.OK_button.Text = "OK";
            this.OK_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            this.OK_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OK_button_MouseDown);
            this.OK_button.MouseEnter += new System.EventHandler(this.OK_button_MouseEnter);
            this.OK_button.MouseLeave += new System.EventHandler(this.OK_button_MouseLeave);
            this.OK_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OK_button_MouseUp);
            // 
            // MessageBox_Title
            // 
            this.MessageBox_Title.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageBox_Title.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MessageBox_Title.Location = new System.Drawing.Point(10, 9);
            this.MessageBox_Title.Name = "MessageBox_Title";
            this.MessageBox_Title.Size = new System.Drawing.Size(318, 32);
            this.MessageBox_Title.TabIndex = 10;
            this.MessageBox_Title.Text = "MessageBox_Title";
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(340, 217);
            this.Controls.Add(this.MessageBox_Title);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.MessageBox_Message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Message";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Message_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageBox_Message;
        private System.Windows.Forms.Label OK_button;
        private System.Windows.Forms.Label MessageBox_Title;
    }
}