
namespace TestfallDB
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.benutzerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chefToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jerryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grubelixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.benutzerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // benutzerToolStripMenuItem
            // 
            this.benutzerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chefToolStripMenuItem,
            this.jerryToolStripMenuItem,
            this.grubelixToolStripMenuItem});
            this.benutzerToolStripMenuItem.Name = "benutzerToolStripMenuItem";
            this.benutzerToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.benutzerToolStripMenuItem.Text = "Benutzer";
            this.benutzerToolStripMenuItem.Click += new System.EventHandler(this.benutzerToolStripMenuItem_Click);
            // 
            // chefToolStripMenuItem
            // 
            this.chefToolStripMenuItem.Name = "chefToolStripMenuItem";
            this.chefToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.chefToolStripMenuItem.Text = "Chef";
            this.chefToolStripMenuItem.Click += new System.EventHandler(this.chefToolStripMenuItem_Click);
            // 
            // jerryToolStripMenuItem
            // 
            this.jerryToolStripMenuItem.Name = "jerryToolStripMenuItem";
            this.jerryToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.jerryToolStripMenuItem.Text = "Jerry";
            this.jerryToolStripMenuItem.Click += new System.EventHandler(this.jerryToolStripMenuItem_Click);
            // 
            // grubelixToolStripMenuItem
            // 
            this.grubelixToolStripMenuItem.Name = "grubelixToolStripMenuItem";
            this.grubelixToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.grubelixToolStripMenuItem.Text = "Grubelix";
            this.grubelixToolStripMenuItem.Click += new System.EventHandler(this.grubelixToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(732, 402);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem benutzerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chefToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jerryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grubelixToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}