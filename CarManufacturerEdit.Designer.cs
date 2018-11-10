namespace CarDealerApp
{
    partial class CarManufacturerEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.textBoxManName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "მწარმოებლის სახელი";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBoxID
            // 
            this.TextBoxID.Location = new System.Drawing.Point(48, 22);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.ReadOnly = true;
            this.TextBoxID.Size = new System.Drawing.Size(104, 20);
            this.TextBoxID.TabIndex = 3;
            // 
            // textBoxManName
            // 
            this.textBoxManName.Location = new System.Drawing.Point(22, 72);
            this.textBoxManName.Name = "textBoxManName";
            this.textBoxManName.Size = new System.Drawing.Size(130, 20);
            this.textBoxManName.TabIndex = 4;
            // 
            // CarManufacturerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 145);
            this.Controls.Add(this.textBoxManName);
            this.Controls.Add(this.TextBoxID);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CarManufacturerEdit";
            this.Text = "CarManufacturerEdit";
            this.Load += new System.EventHandler(this.CarManufacturerEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.TextBox textBoxManName;
    }
}