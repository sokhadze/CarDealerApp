namespace CarDealerApp
{
    partial class CarList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carDealerDBDataSet = new CarDealerApp.CarDealerDBDataSet();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new CarDealerApp.CarDealerDBDataSetTableAdapters.CarTableAdapter();
            this.tableAdapterManager = new CarDealerApp.CarDealerDBDataSetTableAdapters.TableAdapterManager();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odoMeterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.manufacturerIDDataGridViewTextBoxColumn,
            this.modelIDDataGridViewTextBoxColumn,
            this.carTypeIDDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn,
            this.odoMeterDataGridViewTextBoxColumn,
            this.engineDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(846, 385);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // carDealerDBDataSet
            // 
            this.carDealerDBDataSet.DataSetName = "CarDealerDBDataSet";
            this.carDealerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.carDealerDBDataSet;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarTableAdapter = this.carTableAdapter;
            this.tableAdapterManager.CarTypeTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.ModelTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CarDealerApp.CarDealerDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 20F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturerIDDataGridViewTextBoxColumn
            // 
            this.manufacturerIDDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer_ID";
            this.manufacturerIDDataGridViewTextBoxColumn.HeaderText = "Manufacturer_ID";
            this.manufacturerIDDataGridViewTextBoxColumn.Name = "manufacturerIDDataGridViewTextBoxColumn";
            this.manufacturerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelIDDataGridViewTextBoxColumn
            // 
            this.modelIDDataGridViewTextBoxColumn.DataPropertyName = "Model_ID";
            this.modelIDDataGridViewTextBoxColumn.HeaderText = "Model_ID";
            this.modelIDDataGridViewTextBoxColumn.Name = "modelIDDataGridViewTextBoxColumn";
            this.modelIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carTypeIDDataGridViewTextBoxColumn
            // 
            this.carTypeIDDataGridViewTextBoxColumn.DataPropertyName = "CarType_ID";
            this.carTypeIDDataGridViewTextBoxColumn.HeaderText = "CarType_ID";
            this.carTypeIDDataGridViewTextBoxColumn.Name = "carTypeIDDataGridViewTextBoxColumn";
            this.carTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "Condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "Condition";
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            this.conditionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // odoMeterDataGridViewTextBoxColumn
            // 
            this.odoMeterDataGridViewTextBoxColumn.DataPropertyName = "OdoMeter";
            this.odoMeterDataGridViewTextBoxColumn.HeaderText = "OdoMeter";
            this.odoMeterDataGridViewTextBoxColumn.Name = "odoMeterDataGridViewTextBoxColumn";
            this.odoMeterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // engineDataGridViewTextBoxColumn
            // 
            this.engineDataGridViewTextBoxColumn.DataPropertyName = "Engine";
            this.engineDataGridViewTextBoxColumn.HeaderText = "Engine";
            this.engineDataGridViewTextBoxColumn.Name = "engineDataGridViewTextBoxColumn";
            this.engineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 487);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CarList";
            this.Text = "CarList";
            this.Load += new System.EventHandler(this.CarList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CarDealerDBDataSet carDealerDBDataSet;
        private System.Windows.Forms.BindingSource carBindingSource;
        private CarDealerDBDataSetTableAdapters.CarTableAdapter carTableAdapter;
        private CarDealerDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odoMeterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineDataGridViewTextBoxColumn;
    }
}