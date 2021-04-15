
namespace TestfallDB
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bauteileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.benutzerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.benutzerWechselnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Jerry = new System.Windows.Forms.ToolStripMenuItem();
            this.Chef = new System.Windows.Forms.ToolStripMenuItem();
            this.Grubelix = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bauteileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable1BindingSource2
            // 
            this.dataTable1BindingSource2.DataMember = "DataTable1";
            this.dataTable1BindingSource2.DataSource = this.dataSet1BindingSource;
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataMember = "DataTable";
            this.dataTableBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataTable1BindingSource3
            // 
            this.dataTable1BindingSource3.DataMember = "DataTable1";
            this.dataTable1BindingSource3.DataSource = this.dataSet1BindingSource;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.benutzerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // benutzerToolStripMenuItem
            // 
            this.benutzerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.benutzerWechselnToolStripMenuItem});
            this.benutzerToolStripMenuItem.Name = "benutzerToolStripMenuItem";
            this.benutzerToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.benutzerToolStripMenuItem.Text = "Benutzer";
            this.benutzerToolStripMenuItem.Click += new System.EventHandler(this.benutzerToolStripMenuItem_Click);
            // 
            // benutzerWechselnToolStripMenuItem
            // 
            this.benutzerWechselnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Jerry,
            this.Chef,
            this.Grubelix});
            this.benutzerWechselnToolStripMenuItem.Name = "benutzerWechselnToolStripMenuItem";
            this.benutzerWechselnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.benutzerWechselnToolStripMenuItem.Text = "Benutzer wechseln";
            // 
            // Jerry
            // 
            this.Jerry.Name = "Jerry";
            this.Jerry.Size = new System.Drawing.Size(147, 26);
            this.Jerry.Text = "Jerry";
            this.Jerry.Click += new System.EventHandler(this.Jerry_Click);
            // 
            // Chef
            // 
            this.Chef.Name = "Chef";
            this.Chef.Size = new System.Drawing.Size(147, 26);
            this.Chef.Text = "Chef";
            this.Chef.Click += new System.EventHandler(this.Chef_Click);
            // 
            // Grubelix
            // 
            this.Grubelix.Name = "Grubelix";
            this.Grubelix.Size = new System.Drawing.Size(147, 26);
            this.Grubelix.Text = "Grubelix";
            this.Grubelix.Click += new System.EventHandler(this.Grubelix_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bauteileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private System.Windows.Forms.BindingSource bauteileBindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource2;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem benutzerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem benutzerWechselnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Jerry;
        private System.Windows.Forms.ToolStripMenuItem Chef;
        private System.Windows.Forms.ToolStripMenuItem Grubelix;
    }
}

