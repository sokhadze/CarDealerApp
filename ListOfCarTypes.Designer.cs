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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.carTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carDealerDBDataSet1 = new CarDealerApp.CarDealerDBDataSet();
            this.carTypeTableAdapter = new CarDealerApp.CarDealerDBDataSetTableAdapters.CarTypeTableAdapter();
            this.tableAdapterManager = new CarDealerApp.CarDealerDBDataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataSet1 = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealerDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(99, 217);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(522, 253);
            this.dataGridView1.TabIndex = 0;
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(650, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // ListOfCarTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 613);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListOfCarTypes";
            this.Text = "ListOfCarTypes";
            this.Load += new System.EventHandler(this.ListOfCarTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carDealerDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CarDealerDBDataSet carDealerDBDataSet1;
        private System.Windows.Forms.BindingSource carTypeBindingSource;
        private CarDealerDBDataSetTableAdapters.CarTypeTableAdapter carTypeTableAdapter;
        private CarDealerDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Data.DataSet dataSet1;
    }
}