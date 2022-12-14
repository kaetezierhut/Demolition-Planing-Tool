namespace Demolition_Planing_Tool
{
    partial class ViewWasteForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.ViewBillingWasteIDComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateWasteButton = new System.Windows.Forms.Button();
            this.BillingUpDown = new System.Windows.Forms.NumericUpDown();
            this.CreateNewWasteButton = new System.Windows.Forms.Button();
            this.UnitComboBox = new System.Windows.Forms.ComboBox();
            this.UnitTextBox = new System.Windows.Forms.TextBox();
            this.HazardousCheckBox = new System.Windows.Forms.CheckBox();
            this.ExclusiveToRoomCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.BillingUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "WasteID";
            // 
            // ViewBillingWasteIDComboBox
            // 
            this.ViewBillingWasteIDComboBox.FormattingEnabled = true;
            this.ViewBillingWasteIDComboBox.Location = new System.Drawing.Point(106, 26);
            this.ViewBillingWasteIDComboBox.Name = "ViewBillingWasteIDComboBox";
            this.ViewBillingWasteIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.ViewBillingWasteIDComboBox.TabIndex = 9;
            this.ViewBillingWasteIDComboBox.DropDown += new System.EventHandler(this.ViewWasteWasteIDComboBox_DropDown);
            this.ViewBillingWasteIDComboBox.SelectedIndexChanged += new System.EventHandler(this.ViewWasteWasteIDComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(107, 53);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(360, 76);
            this.NameTextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Billing per Unit (€)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Unit";
            // 
            // UpdateWasteButton
            // 
            this.UpdateWasteButton.Location = new System.Drawing.Point(359, 205);
            this.UpdateWasteButton.Name = "UpdateWasteButton";
            this.UpdateWasteButton.Size = new System.Drawing.Size(108, 23);
            this.UpdateWasteButton.TabIndex = 19;
            this.UpdateWasteButton.Text = "Update Waste";
            this.UpdateWasteButton.UseVisualStyleBackColor = true;
            this.UpdateWasteButton.Click += new System.EventHandler(this.UpdateWasteButton_Click);
            // 
            // BillingUpDown
            // 
            this.BillingUpDown.Enabled = false;
            this.BillingUpDown.Location = new System.Drawing.Point(107, 135);
            this.BillingUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.BillingUpDown.Name = "BillingUpDown";
            this.BillingUpDown.Size = new System.Drawing.Size(120, 20);
            this.BillingUpDown.TabIndex = 20;
            this.BillingUpDown.Tag = "€";
            this.BillingUpDown.ThousandsSeparator = true;
            // 
            // CreateNewWasteButton
            // 
            this.CreateNewWasteButton.Location = new System.Drawing.Point(12, 205);
            this.CreateNewWasteButton.Name = "CreateNewWasteButton";
            this.CreateNewWasteButton.Size = new System.Drawing.Size(110, 23);
            this.CreateNewWasteButton.TabIndex = 21;
            this.CreateNewWasteButton.Text = "Create New Waste";
            this.CreateNewWasteButton.UseVisualStyleBackColor = true;
            this.CreateNewWasteButton.Click += new System.EventHandler(this.CreateNewWasteButton_Click);
            // 
            // UnitComboBox
            // 
            this.UnitComboBox.Enabled = false;
            this.UnitComboBox.FormattingEnabled = true;
            this.UnitComboBox.Location = new System.Drawing.Point(107, 168);
            this.UnitComboBox.Name = "UnitComboBox";
            this.UnitComboBox.Size = new System.Drawing.Size(41, 21);
            this.UnitComboBox.TabIndex = 26;
            this.UnitComboBox.SelectedIndexChanged += new System.EventHandler(this.UnitComboBox_SelectedIndexChanged);
            // 
            // UnitTextBox
            // 
            this.UnitTextBox.Location = new System.Drawing.Point(154, 168);
            this.UnitTextBox.Name = "UnitTextBox";
            this.UnitTextBox.ReadOnly = true;
            this.UnitTextBox.Size = new System.Drawing.Size(185, 20);
            this.UnitTextBox.TabIndex = 27;
            // 
            // HazardousCheckBox
            // 
            this.HazardousCheckBox.AutoSize = true;
            this.HazardousCheckBox.Enabled = false;
            this.HazardousCheckBox.Location = new System.Drawing.Point(359, 138);
            this.HazardousCheckBox.Name = "HazardousCheckBox";
            this.HazardousCheckBox.Size = new System.Drawing.Size(77, 17);
            this.HazardousCheckBox.TabIndex = 42;
            this.HazardousCheckBox.Text = "Hazardous";
            this.HazardousCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExclusiveToRoomCheckBox
            // 
            this.ExclusiveToRoomCheckBox.AutoSize = true;
            this.ExclusiveToRoomCheckBox.Enabled = false;
            this.ExclusiveToRoomCheckBox.Location = new System.Drawing.Point(359, 171);
            this.ExclusiveToRoomCheckBox.Name = "ExclusiveToRoomCheckBox";
            this.ExclusiveToRoomCheckBox.Size = new System.Drawing.Size(114, 17);
            this.ExclusiveToRoomCheckBox.TabIndex = 43;
            this.ExclusiveToRoomCheckBox.Text = "Exclusive to Room";
            this.ExclusiveToRoomCheckBox.UseVisualStyleBackColor = true;
            // 
            // ViewWasteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 235);
            this.Controls.Add(this.ExclusiveToRoomCheckBox);
            this.Controls.Add(this.HazardousCheckBox);
            this.Controls.Add(this.UnitTextBox);
            this.Controls.Add(this.UnitComboBox);
            this.Controls.Add(this.CreateNewWasteButton);
            this.Controls.Add(this.BillingUpDown);
            this.Controls.Add(this.UpdateWasteButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ViewBillingWasteIDComboBox);
            this.Controls.Add(this.label9);
            this.Name = "ViewWasteForm";
            this.Text = "ViewWasteForm";
            this.Load += new System.EventHandler(this.ViewWasteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillingUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ViewBillingWasteIDComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UpdateWasteButton;
        private System.Windows.Forms.NumericUpDown BillingUpDown;
        private System.Windows.Forms.Button CreateNewWasteButton;
        private System.Windows.Forms.ComboBox UnitComboBox;
        private System.Windows.Forms.TextBox UnitTextBox;
        private System.Windows.Forms.CheckBox HazardousCheckBox;
        private System.Windows.Forms.CheckBox ExclusiveToRoomCheckBox;
    }
}