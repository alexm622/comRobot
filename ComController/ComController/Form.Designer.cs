namespace ComController
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sentText = new System.Windows.Forms.TextBox();
            this.command = new System.Windows.Forms.TextBox();
            this.bttnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sentText
            // 
            this.sentText.AcceptsReturn = true;
            this.sentText.Location = new System.Drawing.Point(12, 12);
            this.sentText.Multiline = true;
            this.sentText.Name = "sentText";
            this.sentText.ReadOnly = true;
            this.sentText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sentText.Size = new System.Drawing.Size(460, 251);
            this.sentText.TabIndex = 0;
            // 
            // command
            // 
            this.command.Location = new System.Drawing.Point(12, 269);
            this.command.Name = "command";
            this.command.Size = new System.Drawing.Size(379, 23);
            this.command.TabIndex = 1;
            this.command.KeyDown += new System.Windows.Forms.KeyEventHandler(this.command_KeyDown);
            // 
            // bttnSend
            // 
            this.bttnSend.Location = new System.Drawing.Point(397, 269);
            this.bttnSend.Name = "bttnSend";
            this.bttnSend.Size = new System.Drawing.Size(75, 23);
            this.bttnSend.TabIndex = 2;
            this.bttnSend.Text = "send";
            this.bttnSend.UseVisualStyleBackColor = true;
            this.bttnSend.Click += new System.EventHandler(this.bttnSend_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 298);
            this.Controls.Add(this.bttnSend);
            this.Controls.Add(this.command);
            this.Controls.Add(this.sentText);
            this.Name = "mainForm";
            this.Text = "Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox sentText;
        private TextBox command;
        private Button bttnSend;
    }
}