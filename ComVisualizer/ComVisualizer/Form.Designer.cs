namespace ComVisualizer
{
    partial class MainForm
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
            this.comCommands = new System.Windows.Forms.TextBox();
            this.bttnClear = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.g1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.width1 = new System.Windows.Forms.Label();
            this.height1 = new System.Windows.Forms.Label();
            this.rotation1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.g1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // comCommands
            // 
            this.comCommands.Location = new System.Drawing.Point(392, 12);
            this.comCommands.Multiline = true;
            this.comCommands.Name = "comCommands";
            this.comCommands.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.comCommands.Size = new System.Drawing.Size(127, 305);
            this.comCommands.TabIndex = 0;
            // 
            // bttnClear
            // 
            this.bttnClear.Location = new System.Drawing.Point(447, 323);
            this.bttnClear.Name = "bttnClear";
            this.bttnClear.Size = new System.Drawing.Size(75, 23);
            this.bttnClear.TabIndex = 1;
            this.bttnClear.Text = "Clear";
            this.bttnClear.UseVisualStyleBackColor = true;
            // 
            // g1
            // 
            this.g1.Location = new System.Drawing.Point(12, 12);
            this.g1.Name = "g1";
            this.g1.Size = new System.Drawing.Size(100, 100);
            this.g1.TabIndex = 2;
            this.g1.TabStop = false;
            this.g1.Click += new System.EventHandler(this.g1_Click);
            this.g1.Paint += new System.Windows.Forms.PaintEventHandler(this.g1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(118, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(224, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // width1
            // 
            this.width1.AutoSize = true;
            this.width1.Location = new System.Drawing.Point(12, 125);
            this.width1.Name = "width1";
            this.width1.Size = new System.Drawing.Size(64, 15);
            this.width1.TabIndex = 5;
            this.width1.Text = "Width: 0px";
            // 
            // height1
            // 
            this.height1.AutoSize = true;
            this.height1.Location = new System.Drawing.Point(12, 151);
            this.height1.Name = "height1";
            this.height1.Size = new System.Drawing.Size(68, 15);
            this.height1.TabIndex = 6;
            this.height1.Text = "Height: 0px";
            // 
            // rotation1
            // 
            this.rotation1.AutoSize = true;
            this.rotation1.Location = new System.Drawing.Point(12, 176);
            this.rotation1.Name = "rotation1";
            this.rotation1.Size = new System.Drawing.Size(78, 15);
            this.rotation1.TabIndex = 7;
            this.rotation1.Text = "Rotation: 0.0°";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 356);
            this.Controls.Add(this.rotation1);
            this.Controls.Add(this.height1);
            this.Controls.Add(this.width1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.g1);
            this.Controls.Add(this.bttnClear);
            this.Controls.Add(this.comCommands);
            this.Name = "MainForm";
            this.Text = "Application";
            ((System.ComponentModel.ISupportInitialize)(this.g1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox comCommands;
        public Button bttnClear;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox g1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label width1;
        private Label height1;
        private Label rotation1;
    }
}