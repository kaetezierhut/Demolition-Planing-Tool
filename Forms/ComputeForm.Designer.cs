namespace Demolition_Planing_Tool
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
            this.ExportPDFButton = new System.Windows.Forms.Button();
            this.FloorCheckBox = new System.Windows.Forms.CheckBox();
            this.RoomCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComputeTotalCost = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalCost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ViewBilling = new System.Windows.Forms.Button();
            this.EditBuildingInfoButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
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
            this.WasteIDComboBox.DropDown += new System.EventHandler(this.WasteIDComboBox_DropDown);
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
            this.SaveDocumentButton.Location = new System.Drawing.Point(843, 401);
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(269, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(715, 238);
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
            // ExportPDFButton
            // 
            this.ExportPDFButton.Location = new System.Drawing.Point(843, 343);
            this.ExportPDFButton.Name = "ExportPDFButton";
            this.ExportPDFButton.Size = new System.Drawing.Size(141, 23);
            this.ExportPDFButton.TabIndex = 20;
            this.ExportPDFButton.Text = "Export PDF";
            this.ExportPDFButton.UseVisualStyleBackColor = true;
            this.ExportPDFButton.Click += new System.EventHandler(this.ExportPDFButton_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Floor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(459, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Room";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(537, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Quantities";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(635, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Billing/Unit (€)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(745, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Unit";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(266, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "WasteID";
            // 
            // ViewBilling
            // 
            this.ViewBilling.Location = new System.Drawing.Point(12, 401);
            this.ViewBilling.Name = "ViewBilling";
            this.ViewBilling.Size = new System.Drawing.Size(141, 23);
            this.ViewBilling.TabIndex = 33;
            this.ViewBilling.Text = "View Waste";
            this.ViewBilling.UseVisualStyleBackColor = true;
            this.ViewBilling.Click += new System.EventHandler(this.ViewWaste_Click);
            // 
            // EditBuildingInfoButton
            // 
            this.EditBuildingInfoButton.Location = new System.Drawing.Point(269, 401);
            this.EditBuildingInfoButton.Name = "EditBuildingInfoButton";
            this.EditBuildingInfoButton.Size = new System.Drawing.Size(131, 23);
            this.EditBuildingInfoButton.TabIndex = 34;
            this.EditBuildingInfoButton.Text = "Edit Building Info";
            this.EditBuildingInfoButton.UseVisualStyleBackColor = true;
            this.EditBuildingInfoButton.Click += new System.EventHandler(this.EditBuildingInfoButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(935, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Billing (€)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(825, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Hazardous";
            // 
            // ComputeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 450);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.EditBuildingInfoButton);
            this.Controls.Add(this.ViewBilling);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ComputeTotalCost);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExportPDFButton);
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
        private System.Windows.Forms.Button ExportPDFButton;
        private System.Windows.Forms.CheckBox FloorCheckBox;
        private System.Windows.Forms.CheckBox RoomCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ComputeTotalCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TotalCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ViewBilling;
        private System.Windows.Forms.Button EditBuildingInfoButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

