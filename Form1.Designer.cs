﻿namespace CarDealerApp
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.CarList = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCarTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCarTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carTypesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CarList
            // 
            this.CarList.BackColor = System.Drawing.SystemColors.Menu;
            this.CarList.BackgroundImage = global::CarDealerApp.Properties.Resources.if_red_64_67532;
            this.CarList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CarList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CarList.FlatAppearance.BorderSize = 0;
            this.CarList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CarList.Location = new System.Drawing.Point(30, 68);
            this.CarList.Name = "CarList";
            this.CarList.Size = new System.Drawing.Size(135, 121);
            this.CarList.TabIndex = 0;
            this.CarList.Text = "მანქანების სია";
            this.CarList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CarList.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.carToolStripMenuItem,
            this.userToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1204, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // carToolStripMenuItem
            // 
            this.carToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCarToolStripMenuItem,
            this.addNewCarTypeToolStripMenuItem});
            this.carToolStripMenuItem.Name = "carToolStripMenuItem";
            this.carToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.carToolStripMenuItem.Text = "Car";
            // 
            // addNewCarToolStripMenuItem
            // 
            this.addNewCarToolStripMenuItem.Name = "addNewCarToolStripMenuItem";
            this.addNewCarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewCarToolStripMenuItem.Text = "Add New Car";
            // 
            // addNewCarTypeToolStripMenuItem
            // 
            this.addNewCarTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCarTypesToolStripMenuItem,
            this.carTypesListToolStripMenuItem});
            this.addNewCarTypeToolStripMenuItem.Name = "addNewCarTypeToolStripMenuItem";
            this.addNewCarTypeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewCarTypeToolStripMenuItem.Text = "Car Types";
            this.addNewCarTypeToolStripMenuItem.Click += new System.EventHandler(this.addNewCarTypeToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // addNewCarTypesToolStripMenuItem
            // 
            this.addNewCarTypesToolStripMenuItem.Name = "addNewCarTypesToolStripMenuItem";
            this.addNewCarTypesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewCarTypesToolStripMenuItem.Text = "Add New Car Types";
            this.addNewCarTypesToolStripMenuItem.Click += new System.EventHandler(this.addNewCarTypesToolStripMenuItem_Click);
            // 
            // carTypesListToolStripMenuItem
            // 
            this.carTypesListToolStripMenuItem.Name = "carTypesListToolStripMenuItem";
            this.carTypesListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.carTypesListToolStripMenuItem.Text = "Car Types List";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 640);
            this.Controls.Add(this.CarList);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DashBoard";
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CarList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCarTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCarTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carTypesListToolStripMenuItem;
    }
}

