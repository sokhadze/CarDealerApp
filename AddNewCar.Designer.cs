namespace CarDealerApp
{
    partial class AddNewCar
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AddNewCarBtn = new System.Windows.Forms.Button();
            this.comboBoxCarManuf = new System.Windows.Forms.ComboBox();
            this.comboBoxCarModel = new System.Windows.Forms.ComboBox();
            this.comboBoxCarType = new System.Windows.Forms.ComboBox();
            this.comboBoxCondition = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "მწარმოებელი";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "მოდელი";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ტიპი";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "მდგომარეობა";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "გამოშვების წელი";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(137, 161);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 20);
            this.textBox6.TabIndex = 11;
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "გარბენი";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(137, 187);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(121, 20);
            this.textBox7.TabIndex = 13;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "ძრავის მოცულობა";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(137, 213);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(121, 20);
            this.textBox8.TabIndex = 15;
            this.textBox8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox8_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "ღირებულება";
            // 
            // AddNewCarBtn
            // 
            this.AddNewCarBtn.Location = new System.Drawing.Point(36, 259);
            this.AddNewCarBtn.Name = "AddNewCarBtn";
            this.AddNewCarBtn.Size = new System.Drawing.Size(225, 23);
            this.AddNewCarBtn.TabIndex = 16;
            this.AddNewCarBtn.Text = "Add New Car";
            this.AddNewCarBtn.UseVisualStyleBackColor = true;
            this.AddNewCarBtn.Click += new System.EventHandler(this.AddNewCarBtn_Click);
            // 
            // comboBoxCarManuf
            // 
            this.comboBoxCarManuf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCarManuf.FormattingEnabled = true;
            this.comboBoxCarManuf.Location = new System.Drawing.Point(137, 31);
            this.comboBoxCarManuf.Name = "comboBoxCarManuf";
            this.comboBoxCarManuf.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCarManuf.TabIndex = 17;
            // 
            // comboBoxCarModel
            // 
            this.comboBoxCarModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCarModel.FormattingEnabled = true;
            this.comboBoxCarModel.Location = new System.Drawing.Point(137, 57);
            this.comboBoxCarModel.Name = "comboBoxCarModel";
            this.comboBoxCarModel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCarModel.TabIndex = 18;
            // 
            // comboBoxCarType
            // 
            this.comboBoxCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCarType.FormattingEnabled = true;
            this.comboBoxCarType.Location = new System.Drawing.Point(137, 83);
            this.comboBoxCarType.Name = "comboBoxCarType";
            this.comboBoxCarType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCarType.TabIndex = 19;
            // 
            // comboBoxCondition
            // 
            this.comboBoxCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCondition.FormattingEnabled = true;
            this.comboBoxCondition.Location = new System.Drawing.Point(137, 108);
            this.comboBoxCondition.Name = "comboBoxCondition";
            this.comboBoxCondition.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCondition.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 135);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.Value = new System.DateTime(2018, 11, 11, 0, 0, 0, 0);
            // 
            // AddNewCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 304);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxCondition);
            this.Controls.Add(this.comboBoxCarType);
            this.Controls.Add(this.comboBoxCarModel);
            this.Controls.Add(this.comboBoxCarManuf);
            this.Controls.Add(this.AddNewCarBtn);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewCar";
            this.Text = "AddNewCar";
            this.Load += new System.EventHandler(this.AddNewCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddNewCarBtn;
        private System.Windows.Forms.ComboBox comboBoxCarManuf;
        private System.Windows.Forms.ComboBox comboBoxCarModel;
        private System.Windows.Forms.ComboBox comboBoxCarType;
        private System.Windows.Forms.ComboBox comboBoxCondition;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}