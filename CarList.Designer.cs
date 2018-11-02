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
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carDealerDBDataSet = new CarDealerApp.CarDealerDBDataSet();
            this.carTableAdapter = new CarDealerApp.CarDealerDBDataSetTableAdapters.CarTableAdapter();
            this.tableAdapterManager = new CarDealerApp.CarDealerDBDataSetTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTypeTableAdapter = new CarDealerApp.CarDealerDBDataSetTableAdapters.CarTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealerDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.carDealerDBDataSet;
            // 
            // carDealerDBDataSet
            // 
            this.carDealerDBDataSet.DataSetName = "CarDealerDBDataSet";
            this.carDealerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.carTypeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(833, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // carBindingSource1
            // 
            this.carBindingSource1.DataMember = "Car";
            this.carBindingSource1.DataSource = this.carDealerDBDataSet;
            // 
            // carTypeBindingSource
            // 
            this.carTypeBindingSource.DataMember = "CarType";
            this.carTypeBindingSource.DataSource = this.carDealerDBDataSet;
            // 
            // carTypeTableAdapter
            // 
            this.carTypeTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealerDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CarDealerDBDataSet carDealerDBDataSet;
        private System.Windows.Forms.BindingSource carBindingSource;
        private CarDealerDBDataSetTableAdapters.CarTableAdapter carTableAdapter;
        private CarDealerDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource carBindingSource1;
        private System.Windows.Forms.BindingSource carTypeBindingSource;
        private CarDealerDBDataSetTableAdapters.CarTypeTableAdapter carTypeTableAdapter;
    }
}