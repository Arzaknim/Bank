namespace AquaBank
{
    partial class Form1
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

        public void TextBox_Placeholder(System.Windows.Forms.TextBox textbox, string str) 
        {
            textbox.Text = str;

        }

        public void TextBox_Click(System.Windows.Forms.TextBox TextBox, string str)
        {
            if (TextBox.Text == "")
                TextBox.Text = str;

        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.TextID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextPassword
            // 
            this.TextPassword.Location = new System.Drawing.Point(200, 290);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(200, 20);
            this.TextPassword.TabIndex = 0;
            this.TextPassword.Enter += new System.EventHandler(this.TextPassword_Enter);
            this.TextPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginCreds_PressEnter);
            this.TextPassword.Leave += new System.EventHandler(this.TextPassword_Leave);
            // 
            // TextID
            // 
            this.TextID.Location = new System.Drawing.Point(200, 235);
            this.TextID.Name = "TextID";
            this.TextID.Size = new System.Drawing.Size(200, 20);
            this.TextID.TabIndex = 1;
            this.TextID.Enter += new System.EventHandler(this.TextID_Enter);
            this.TextID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoginCreds_PressEnter);
            this.TextID.Leave += new System.EventHandler(this.TextID_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(225, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 100);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TextID);
            this.Controls.Add(this.TextPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.TextBox TextID;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

