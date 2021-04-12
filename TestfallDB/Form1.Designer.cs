
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
            this.label1 = new System.Windows.Forms.Label();
            this.bauteileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataTable1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new TestfallDB.DataSet1();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new TestfallDB.DataSet1TableAdapters.DataTable1TableAdapter();
            this.tableAdapterManager1 = new TestfallDB.DataSet1TableAdapters.TableAdapterManager();
            this.dataTableTableAdapter = new TestfallDB.DataSet1TableAdapters.DataTableTableAdapter();
            this.testfallnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testfallnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bauteilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.erwartetesResultatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tatsaechlichesResultatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iOnODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rueckwaertsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ueberland50KmhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ueberland100kmhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stadtverkehrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durchgeführtamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bauteileBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(498, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TestfallDB";
            // 
            // testfallDBDataSet
           
            // 
            // bauteileBindingSource
            // 
          
            // 
            // bauteileTableAdapter
            // 
            // 
            // tableAdapterManager
            // 
           
            // 
            // dataTable1DataGridView
            // 
            this.dataTable1DataGridView.AutoGenerateColumns = false;
            this.dataTable1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.testfallnummerDataGridViewTextBoxColumn,
            this.testfallnameDataGridViewTextBoxColumn,
            this.bauteilDataGridViewTextBoxColumn,
            this.erwartetesResultatDataGridViewTextBoxColumn,
            this.tatsaechlichesResultatDataGridViewTextBoxColumn,
            this.iOnODataGridViewTextBoxColumn,
            this.standDataGridViewTextBoxColumn,
            this.rueckwaertsDataGridViewTextBoxColumn,
            this.ueberland50KmhDataGridViewTextBoxColumn,
            this.ueberland100kmhDataGridViewTextBoxColumn,
            this.stadtverkehrDataGridViewTextBoxColumn,
            this.durchgeführtamDataGridViewTextBoxColumn});
            this.dataTable1DataGridView.DataSource = this.dataTable1BindingSource2;
            this.dataTable1DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTable1DataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataTable1DataGridView.Name = "dataTable1DataGridView";
            this.dataTable1DataGridView.RowHeadersWidth = 62;
            this.dataTable1DataGridView.RowTemplate.Height = 28;
            this.dataTable1DataGridView.Size = new System.Drawing.Size(1200, 692);
            this.dataTable1DataGridView.TabIndex = 1;
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
            // testfallnummerDataGridViewTextBoxColumn
            // 
            this.testfallnummerDataGridViewTextBoxColumn.DataPropertyName = "Testfallnummer";
            this.testfallnummerDataGridViewTextBoxColumn.HeaderText = "Testfallnummer";
            this.testfallnummerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.testfallnummerDataGridViewTextBoxColumn.Name = "testfallnummerDataGridViewTextBoxColumn";
            this.testfallnummerDataGridViewTextBoxColumn.Width = 150;
            // 
            // testfallnameDataGridViewTextBoxColumn
            // 
            this.testfallnameDataGridViewTextBoxColumn.DataPropertyName = "Testfallname";
            this.testfallnameDataGridViewTextBoxColumn.HeaderText = "Testfallname";
            this.testfallnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.testfallnameDataGridViewTextBoxColumn.Name = "testfallnameDataGridViewTextBoxColumn";
            this.testfallnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // bauteilDataGridViewTextBoxColumn
            // 
            this.bauteilDataGridViewTextBoxColumn.DataPropertyName = "Bauteil";
            this.bauteilDataGridViewTextBoxColumn.HeaderText = "Bauteil";
            this.bauteilDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bauteilDataGridViewTextBoxColumn.Name = "bauteilDataGridViewTextBoxColumn";
            this.bauteilDataGridViewTextBoxColumn.Width = 150;
            // 
            // erwartetesResultatDataGridViewTextBoxColumn
            // 
            this.erwartetesResultatDataGridViewTextBoxColumn.DataPropertyName = "erwartetesResultat";
            this.erwartetesResultatDataGridViewTextBoxColumn.HeaderText = "erwartetesResultat";
            this.erwartetesResultatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.erwartetesResultatDataGridViewTextBoxColumn.Name = "erwartetesResultatDataGridViewTextBoxColumn";
            this.erwartetesResultatDataGridViewTextBoxColumn.Width = 150;
            // 
            // tatsaechlichesResultatDataGridViewTextBoxColumn
            // 
            this.tatsaechlichesResultatDataGridViewTextBoxColumn.DataPropertyName = "tatsaechlichesResultat";
            this.tatsaechlichesResultatDataGridViewTextBoxColumn.HeaderText = "tatsaechlichesResultat";
            this.tatsaechlichesResultatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tatsaechlichesResultatDataGridViewTextBoxColumn.Name = "tatsaechlichesResultatDataGridViewTextBoxColumn";
            this.tatsaechlichesResultatDataGridViewTextBoxColumn.Width = 150;
            // 
            // iOnODataGridViewTextBoxColumn
            // 
            this.iOnODataGridViewTextBoxColumn.DataPropertyName = "iO/nO";
            this.iOnODataGridViewTextBoxColumn.HeaderText = "iO/nO";
            this.iOnODataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iOnODataGridViewTextBoxColumn.Name = "iOnODataGridViewTextBoxColumn";
            this.iOnODataGridViewTextBoxColumn.Width = 150;
            // 
            // standDataGridViewTextBoxColumn
            // 
            this.standDataGridViewTextBoxColumn.DataPropertyName = "Stand";
            this.standDataGridViewTextBoxColumn.HeaderText = "Stand";
            this.standDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.standDataGridViewTextBoxColumn.Name = "standDataGridViewTextBoxColumn";
            this.standDataGridViewTextBoxColumn.Width = 150;
            // 
            // rueckwaertsDataGridViewTextBoxColumn
            // 
            this.rueckwaertsDataGridViewTextBoxColumn.DataPropertyName = "rueckwaerts";
            this.rueckwaertsDataGridViewTextBoxColumn.HeaderText = "rueckwaerts";
            this.rueckwaertsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.rueckwaertsDataGridViewTextBoxColumn.Name = "rueckwaertsDataGridViewTextBoxColumn";
            this.rueckwaertsDataGridViewTextBoxColumn.Width = 150;
            // 
            // ueberland50KmhDataGridViewTextBoxColumn
            // 
            this.ueberland50KmhDataGridViewTextBoxColumn.DataPropertyName = "Ueberland50 km/h";
            this.ueberland50KmhDataGridViewTextBoxColumn.HeaderText = "Ueberland50 km/h";
            this.ueberland50KmhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ueberland50KmhDataGridViewTextBoxColumn.Name = "ueberland50KmhDataGridViewTextBoxColumn";
            this.ueberland50KmhDataGridViewTextBoxColumn.Width = 150;
            // 
            // ueberland100kmhDataGridViewTextBoxColumn
            // 
            this.ueberland100kmhDataGridViewTextBoxColumn.DataPropertyName = "Ueberland100km/h";
            this.ueberland100kmhDataGridViewTextBoxColumn.HeaderText = "Ueberland100km/h";
            this.ueberland100kmhDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ueberland100kmhDataGridViewTextBoxColumn.Name = "ueberland100kmhDataGridViewTextBoxColumn";
            this.ueberland100kmhDataGridViewTextBoxColumn.Width = 150;
            // 
            // stadtverkehrDataGridViewTextBoxColumn
            // 
            this.stadtverkehrDataGridViewTextBoxColumn.DataPropertyName = "Stadtverkehr";
            this.stadtverkehrDataGridViewTextBoxColumn.HeaderText = "Stadtverkehr";
            this.stadtverkehrDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stadtverkehrDataGridViewTextBoxColumn.Name = "stadtverkehrDataGridViewTextBoxColumn";
            this.stadtverkehrDataGridViewTextBoxColumn.Width = 150;
            // 
            // durchgeführtamDataGridViewTextBoxColumn
            // 
            this.durchgeführtamDataGridViewTextBoxColumn.DataPropertyName = "durchgeführtam";
            this.durchgeführtamDataGridViewTextBoxColumn.HeaderText = "durchgeführtam";
            this.durchgeführtamDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.durchgeführtamDataGridViewTextBoxColumn.Name = "durchgeführtamDataGridViewTextBoxColumn";
            this.durchgeführtamDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dataTable1DataGridView);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bauteileBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource3)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bauteileBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private DataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView dataTable1DataGridView;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource2;
        private System.Windows.Forms.BindingSource dataTableBindingSource;
        private DataSet1TableAdapters.DataTableTableAdapter dataTableTableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn testfallnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testfallnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bauteilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn erwartetesResultatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tatsaechlichesResultatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iOnODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn standDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rueckwaertsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ueberland50KmhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ueberland100kmhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stadtverkehrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durchgeführtamDataGridViewTextBoxColumn;
    }
}

