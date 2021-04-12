
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
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.benutzerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.benutzerWechselnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Jerry = new System.Windows.Forms.ToolStripMenuItem();
            this.Chef = new System.Windows.Forms.ToolStripMenuItem();
            this.Grubelix = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new TestfallDB.DataSet1();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new TestfallDB.DataSet1TableAdapters.DataTable1TableAdapter();
            this.tableAdapterManager1 = new TestfallDB.DataSet1TableAdapters.TableAdapterManager();
            this.dataTableTableAdapter = new TestfallDB.DataSet1TableAdapters.DataTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bauteileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource3)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
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
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.benutzerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // benutzerToolStripMenuItem
            // 
            this.benutzerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.benutzerWechselnToolStripMenuItem});
            this.benutzerToolStripMenuItem.Name = "benutzerToolStripMenuItem";
            this.benutzerToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.benutzerToolStripMenuItem.Text = "Benutzer";
            // 
            // benutzerWechselnToolStripMenuItem
            // 
            this.benutzerWechselnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Jerry,
            this.Chef,
            this.Grubelix});
            this.benutzerWechselnToolStripMenuItem.Name = "benutzerWechselnToolStripMenuItem";
            this.benutzerWechselnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.benutzerWechselnToolStripMenuItem.Text = "Benutzer wechseln";
            // 
            // Jerry
            // 
            this.Jerry.Name = "Jerry";
            this.Jerry.Size = new System.Drawing.Size(180, 22);
            this.Jerry.Text = "Jerry";
            this.Jerry.Click += new System.EventHandler(this.Jerry_Click);
            // 
            // Chef
            // 
            this.Chef.Name = "Chef";
            this.Chef.Size = new System.Drawing.Size(180, 22);
            this.Chef.Text = "Chef";
            this.Chef.Click += new System.EventHandler(this.Chef_Click);
            // 
            // Grubelix
            // 
            this.Grubelix.Name = "Grubelix";
            this.Grubelix.Size = new System.Drawing.Size(180, 22);
            this.Grubelix.Text = "Grubelix";
            this.Grubelix.Click += new System.EventHandler(this.Grubelix_Click);
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.dataSet1;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = TestfallDB.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataTableTableAdapter
            // 
            this.dataTableTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.BindingSource bauteileBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private DataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource2;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private DataSet1TableAdapters.DataTableTableAdapter dataTableTableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem benutzerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem benutzerWechselnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Jerry;
        private System.Windows.Forms.ToolStripMenuItem Chef;
        private System.Windows.Forms.ToolStripMenuItem Grubelix;
    }
}

