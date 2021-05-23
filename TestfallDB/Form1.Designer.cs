
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.benutzerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.benutzerWechselnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bauteileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.speichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ladenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bauteileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.benutzerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(990, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // benutzerToolStripMenuItem
            // 
            this.benutzerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.benutzerWechselnToolStripMenuItem});
            this.benutzerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.benutzerToolStripMenuItem.Name = "benutzerToolStripMenuItem";
            this.benutzerToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.benutzerToolStripMenuItem.Text = "Datenbank";
            this.benutzerToolStripMenuItem.Click += new System.EventHandler(this.benutzerToolStripMenuItem_Click);
            // 
            // benutzerWechselnToolStripMenuItem
            // 
            this.benutzerWechselnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speichernToolStripMenuItem,
            this.ladenToolStripMenuItem1});
            this.benutzerWechselnToolStripMenuItem.Name = "benutzerWechselnToolStripMenuItem";
            this.benutzerWechselnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.benutzerWechselnToolStripMenuItem.Text = "Synchronisieren";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(698, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(280, 426);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nr.";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Bauteil";
            this.columnHeader2.Width = 424;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(228, 62);
            this.listView2.Margin = new System.Windows.Forms.Padding(2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(467, 426);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nr";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Testname";
            this.columnHeader4.Width = 134;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Vorbedingung";
            this.columnHeader5.Width = 133;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Geschwindigkeit";
            this.columnHeader6.Width = 158;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Erwartetes Resultat";
            this.columnHeader7.Width = 189;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 525);
            this.panel1.TabIndex = 3;
            // 
            // dataTable1BindingSource2
            // 
            this.dataTable1BindingSource2.DataSource = this.dataSet1BindingSource;
            // 
            // dataTableBindingSource
            // 
            this.dataTableBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataTable1BindingSource3
            // 
            this.dataTable1BindingSource3.DataSource = this.dataSet1BindingSource;
            // 
            // speichernToolStripMenuItem
            // 
            this.speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
            this.speichernToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.speichernToolStripMenuItem.Text = "Speichern";
            this.speichernToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // ladenToolStripMenuItem1
            // 
            this.ladenToolStripMenuItem1.Name = "ladenToolStripMenuItem1";
            this.ladenToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ladenToolStripMenuItem1.Text = "Laden";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bauteileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource3)).EndInit();
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem speichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ladenToolStripMenuItem1;
    }
}

