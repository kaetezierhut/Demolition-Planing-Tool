﻿namespace Demolition_Planing_Tool
{
    partial class ComputeForm
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
            this.QuantitiesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WasteIDComboBox = new System.Windows.Forms.ComboBox();
            this.AddQuantitiesButton = new System.Windows.Forms.Button();
            this.SaveDocumentButton = new System.Windows.Forms.Button();
            this.PlaceHolderName = new System.Windows.Forms.Label();
            this.FloorNumberComboBox = new System.Windows.Forms.ComboBox();
            this.RoomNumberComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.FloorCheckBox = new System.Windows.Forms.CheckBox();
            this.RoomCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComputeTotalCost = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalCost = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuantitiesTextBox
            // 
            this.QuantitiesTextBox.Location = new System.Drawing.Point(103, 150);
            this.QuantitiesTextBox.Name = "QuantitiesTextBox";
            this.QuantitiesTextBox.Size = new System.Drawing.Size(121, 20);
            this.QuantitiesTextBox.TabIndex = 0;
            this.QuantitiesTextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantities";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "WasteID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Overview Current Quantities";
            // 
            // WasteIDComboBox
            // 
            this.WasteIDComboBox.FormattingEnabled = true;
            this.WasteIDComboBox.Location = new System.Drawing.Point(103, 116);
            this.WasteIDComboBox.Name = "WasteIDComboBox";
            this.WasteIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.WasteIDComboBox.TabIndex = 9;
            // 
            // AddQuantitiesButton
            // 
            this.AddQuantitiesButton.Location = new System.Drawing.Point(6, 181);
            this.AddQuantitiesButton.Name = "AddQuantitiesButton";
            this.AddQuantitiesButton.Size = new System.Drawing.Size(117, 23);
            this.AddQuantitiesButton.TabIndex = 11;
            this.AddQuantitiesButton.Text = "Add Quantities";
            this.AddQuantitiesButton.UseVisualStyleBackColor = true;
            this.AddQuantitiesButton.Click += new System.EventHandler(this.AddQuantitiesButton_Click);
            // 
            // SaveDocumentButton
            // 
            this.SaveDocumentButton.Location = new System.Drawing.Point(647, 401);
            this.SaveDocumentButton.Name = "SaveDocumentButton";
            this.SaveDocumentButton.Size = new System.Drawing.Size(141, 23);
            this.SaveDocumentButton.TabIndex = 12;
            this.SaveDocumentButton.Text = "Save Document";
            this.SaveDocumentButton.UseVisualStyleBackColor = true;
            this.SaveDocumentButton.Click += new System.EventHandler(this.SaveDocumentButton_Click);
            // 
            // PlaceHolderName
            // 
            this.PlaceHolderName.AutoSize = true;
            this.PlaceHolderName.Location = new System.Drawing.Point(15, 9);
            this.PlaceHolderName.Name = "PlaceHolderName";
            this.PlaceHolderName.Size = new System.Drawing.Size(149, 13);
            this.PlaceHolderName.TabIndex = 13;
            this.PlaceHolderName.Text = "PlaceHolder for Bulding Name";
            // 
            // FloorNumberComboBox
            // 
            this.FloorNumberComboBox.FormattingEnabled = true;
            this.FloorNumberComboBox.Location = new System.Drawing.Point(103, 46);
            this.FloorNumberComboBox.Name = "FloorNumberComboBox";
            this.FloorNumberComboBox.Size = new System.Drawing.Size(121, 21);
            this.FloorNumberComboBox.TabIndex = 14;
            // 
            // RoomNumberComboBox
            // 
            this.RoomNumberComboBox.FormattingEnabled = true;
            this.RoomNumberComboBox.Location = new System.Drawing.Point(103, 81);
            this.RoomNumberComboBox.Name = "RoomNumberComboBox";
            this.RoomNumberComboBox.Size = new System.Drawing.Size(121, 21);
            this.RoomNumberComboBox.TabIndex = 15;
            this.RoomNumberComboBox.DropDown += new System.EventHandler(this.RoomNumberComboBox_DropDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Room Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Floor Number";
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog_FileOk);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(269, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(519, 251);
            this.listBox1.TabIndex = 18;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(269, 343);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(134, 24);
            this.DeleteButton.TabIndex = 19;
            this.DeleteButton.Text = "Delete Item";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(647, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Export PDF";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // FloorCheckBox
            // 
            this.FloorCheckBox.AutoSize = true;
            this.FloorCheckBox.Checked = true;
            this.FloorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FloorCheckBox.Location = new System.Drawing.Point(6, 19);
            this.FloorCheckBox.Name = "FloorCheckBox";
            this.FloorCheckBox.Size = new System.Drawing.Size(49, 17);
            this.FloorCheckBox.TabIndex = 21;
            this.FloorCheckBox.Text = "Floor";
            this.FloorCheckBox.UseVisualStyleBackColor = true;
            this.FloorCheckBox.CheckedChanged += new System.EventHandler(this.FloorCheckBox_CheckedChanged);
            // 
            // RoomCheckBox
            // 
            this.RoomCheckBox.AutoSize = true;
            this.RoomCheckBox.Location = new System.Drawing.Point(170, 19);
            this.RoomCheckBox.Name = "RoomCheckBox";
            this.RoomCheckBox.Size = new System.Drawing.Size(54, 17);
            this.RoomCheckBox.TabIndex = 22;
            this.RoomCheckBox.Text = "Room";
            this.RoomCheckBox.UseVisualStyleBackColor = true;
            this.RoomCheckBox.CheckedChanged += new System.EventHandler(this.RoomCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.RoomCheckBox);
            this.groupBox1.Controls.Add(this.FloorNumberComboBox);
            this.groupBox1.Controls.Add(this.FloorCheckBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.RoomNumberComboBox);
            this.groupBox1.Controls.Add(this.AddQuantitiesButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.WasteIDComboBox);
            this.groupBox1.Controls.Add(this.QuantitiesTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 210);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Waste Input";
            // 
            // ComputeTotalCost
            // 
            this.ComputeTotalCost.Location = new System.Drawing.Point(18, 282);
            this.ComputeTotalCost.Name = "ComputeTotalCost";
            this.ComputeTotalCost.Size = new System.Drawing.Size(117, 27);
            this.ComputeTotalCost.TabIndex = 24;
            this.ComputeTotalCost.Text = "Compute Total Cost";
            this.ComputeTotalCost.UseVisualStyleBackColor = true;
            this.ComputeTotalCost.Click += new System.EventHandler(this.ComputeTotalCost_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Total Cost:";
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSize = true;
            this.TotalCost.Location = new System.Drawing.Point(115, 332);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(19, 13);
            this.TotalCost.TabIndex = 26;
            this.TotalCost.Text = "0€";
            // 
            // ComputeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TotalCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComputeTotalCost);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.PlaceHolderName);
            this.Controls.Add(this.SaveDocumentButton);
            this.Controls.Add(this.label3);
            this.Name = "ComputeForm";
            this.Text = "Demolition Planning Tool";
            this.Load += new System.EventHandler(this.ComputeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox QuantitiesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox WasteIDComboBox;
        private System.Windows.Forms.Button AddQuantitiesButton;
        private System.Windows.Forms.Button SaveDocumentButton;
        private System.Windows.Forms.Label PlaceHolderName;
        private System.Windows.Forms.ComboBox FloorNumberComboBox;
        private System.Windows.Forms.ComboBox RoomNumberComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox FloorCheckBox;
        private System.Windows.Forms.CheckBox RoomCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ComputeTotalCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TotalCost;
    }
}

