namespace CarDealerApp
{
    partial class ListOfCarTypes
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
            this.components = new System.ComponentModel.Container();
            this.carTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carDealerDBDataSet1 = new CarDealerApp.CarDealerDBDataSet();
            this.carTypeTableAdapter = new CarDealerApp.CarDealerDBDataSetTableAdapters.CarTypeTableAdapter();
            this.tableAdapterManager = new CarDealerApp.CarDealerDBDataSetTableAdapters.TableAdapterManager();
            this.carTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.carTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealerDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTypeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // carTypeBindingSource
            // 
            this.carTypeBindingSource.DataMember = "CarType";
            this.carTypeBindingSource.DataSource = this.carDealerDBDataSet1;
            // 
            // carDealerDBDataSet1
            // 
            this.carDealerDBDataSet1.DataSetName = "CarDealerDBDataSet";
            this.carDealerDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carTypeTableAdapter
            // 
            this.carTypeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarTableAdapter = null;
            this.tableAdapterManager.CarTypeTableAdapter = this.carTypeTableAdapter;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CarDealerApp.CarDealerDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // carTypeDataGridView
            // 
            this.carTypeDataGridView.AllowUserToAddRows = false;
            this.carTypeDataGridView.AllowUserToDeleteRows = false;
            this.carTypeDataGridView.AutoGenerateColumns = false;
            this.carTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carTypeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewImageColumn1});
            this.carTypeDataGridView.DataSource = this.carTypeBindingSource;
            this.carTypeDataGridView.Location = new System.Drawing.Point(12, 12);
            this.carTypeDataGridView.Name = "carTypeDataGridView";
            this.carTypeDataGridView.ReadOnly = true;
            this.carTypeDataGridView.Size = new System.Drawing.Size(345, 321);
            this.carTypeDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 22;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CarTypeName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CarTypeName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 180;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "CarTypeImg";
            this.dataGridViewImageColumn1.HeaderText = "CarTypeImg";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // ListOfCarTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 345);
            this.Controls.Add(this.carTypeDataGridView);
            this.Name = "ListOfCarTypes";
            this.Text = "ListOfCarTypes";
            this.Load += new System.EventHandler(this.ListOfCarTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealerDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTypeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CarDealerDBDataSet carDealerDBDataSet1;
        private System.Windows.Forms.BindingSource carTypeBindingSource;
        private CarDealerDBDataSetTableAdapters.CarTypeTableAdapter carTypeTableAdapter;
        private CarDealerDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView carTypeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}