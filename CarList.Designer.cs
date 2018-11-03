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
            this.carTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(189, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 276);
            this.dataGridView1.TabIndex = 0;
            // 
            // CarList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 640);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CarList";
            this.Text = "CarList";
            this.Load += new System.EventHandler(this.CarList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.BindingSource carTypeBindingSource;
        private System.Windows.Forms.BindingSource carBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CarDealerApp.CarDealerDBDataSetTableAdapters.CarTableAdapter carTableAdapter;
        private CarDealerApp.CarDealerDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private CarDealerApp.CarDealerDBDataSetTableAdapters.CarTypeTableAdapter carTypeTableAdapter;
    }
}