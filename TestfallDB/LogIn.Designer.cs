
namespace TestfallDB
{
    partial class Login
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
            this.pnl_Logo = new System.Windows.Forms.Panel();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_Pas = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pnl_Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Logo
            // 
            this.pnl_Logo.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Logo.Controls.Add(this.pictureBox_Logo);
            this.pnl_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Logo.Name = "pnl_Logo";
            this.pnl_Logo.Size = new System.Drawing.Size(394, 76);
            this.pnl_Logo.TabIndex = 0;
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_Logo.Image = global::TestfallDB.Properties.Resources.Ostfalia_German_png_230952558;
            this.pictureBox_Logo.Location = new System.Drawing.Point(72, 12);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(255, 50);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Logo.TabIndex = 0;
            this.pictureBox_Logo.TabStop = false;
            // 
            // textBox_User
            // 
            this.textBox_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBox_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_User.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_User.ForeColor = System.Drawing.Color.White;
            this.textBox_User.Location = new System.Drawing.Point(98, 113);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(226, 19);
            this.textBox_User.TabIndex = 10;
            this.textBox_User.Text = "User";
            this.textBox_User.Click += new System.EventHandler(this.textBox_User_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(28, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(339, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sign In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(64, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 1);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(64, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 1);
            this.panel2.TabIndex = 16;
            // 
            // textBox_Pas
            // 
            this.textBox_Pas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBox_Pas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Pas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Pas.ForeColor = System.Drawing.Color.White;
            this.textBox_Pas.Location = new System.Drawing.Point(98, 164);
            this.textBox_Pas.Name = "textBox_Pas";
            this.textBox_Pas.PasswordChar = '*';
            this.textBox_Pas.Size = new System.Drawing.Size(226, 19);
            this.textBox_Pas.TabIndex = 15;
            this.textBox_Pas.Text = "Password";
            this.textBox_Pas.Click += new System.EventHandler(this.textBox_Pas_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TestfallDB.Properties.Resources.images__1_;
            this.pictureBox2.Location = new System.Drawing.Point(63, 162);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TestfallDB.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(63, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Lavender;
            this.button2.Location = new System.Drawing.Point(28, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(339, 42);
            this.button2.TabIndex = 18;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(394, 377);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox_Pas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Logo);
            this.Controls.Add(this.textBox_User);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.pnl_Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Logo;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_Pas;
        private System.Windows.Forms.Button button2;
    }
}