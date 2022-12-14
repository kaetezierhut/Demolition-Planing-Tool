namespace Demolition_Planing_Tool.Forms
{
    partial class CreateNewWasteForm
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
            this.CreateNewWasteButton = new System.Windows.Forms.Button();
            this.BillingUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.WasteIDTextBox = new System.Windows.Forms.TextBox();
            this.UnitComboBox = new System.Windows.Forms.ComboBox();
            this.UnitTextBox = new System.Windows.Forms.TextBox();
            this.ExclusiveToRoomCheckBox = new System.Windows.Forms.CheckBox();
            this.HazardousCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.BillingUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateNewWasteButton
            // 
            this.CreateNewWasteButton.Location = new System.Drawing.Point(360, 191);
            this.CreateNewWasteButton.Name = "CreateNewWasteButton";
            this.CreateNewWasteButton.Size = new System.Drawing.Size(113, 23);
            this.CreateNewWasteButton.TabIndex = 34;
            this.CreateNewWasteButton.Text = "Create New Waste";
            this.CreateNewWasteButton.UseVisualStyleBackColor = true;
            this.CreateNewWasteButton.Click += new System.EventHandler(this.CreateNewWasteButton_Click);
            // 
            // BillingUpDown
            // 
            this.BillingUpDown.Location = new System.Drawing.Point(108, 125);
            this.BillingUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.BillingUpDown.Name = "BillingUpDown";
            this.BillingUpDown.Size = new System.Drawing.Size(120, 20);
            this.BillingUpDown.TabIndex = 33;
            this.BillingUpDown.Tag = "€";
            this.BillingUpDown.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Billing per Unit (€)";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(108, 43);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(360, 76);
            this.NameTextBox.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "WasteID";
            // 
            // WasteIDTextBox
            // 
            this.WasteIDTextBox.Location = new System.Drawing.Point(108, 19);
            this.WasteIDTextBox.Name = "WasteIDTextBox";
            this.WasteIDTextBox.Size = new System.Drawing.Size(120, 20);
            this.WasteIDTextBox.TabIndex = 37;
            // 
            // UnitComboBox
            // 
            this.UnitComboBox.FormattingEnabled = true;
            this.UnitComboBox.Location = new System.Drawing.Point(108, 156);
            this.UnitComboBox.Name = "UnitComboBox";
            this.UnitComboBox.Size = new System.Drawing.Size(59, 21);
            this.UnitComboBox.TabIndex = 38;
            this.UnitComboBox.SelectedIndexChanged += new System.EventHandler(this.UnitComboBox_SelectedIndexChanged);
            // 
            // UnitTextBox
            // 
            this.UnitTextBox.Location = new System.Drawing.Point(173, 156);
            this.UnitTextBox.Name = "UnitTextBox";
            this.UnitTextBox.ReadOnly = true;
            this.UnitTextBox.Size = new System.Drawing.Size(294, 20);
            this.UnitTextBox.TabIndex = 39;
            // 
            // ExclusiveToRoomCheckBox
            // 
            this.ExclusiveToRoomCheckBox.AutoSize = true;
            this.ExclusiveToRoomCheckBox.Location = new System.Drawing.Point(16, 192);
            this.ExclusiveToRoomCheckBox.Name = "ExclusiveToRoomCheckBox";
            this.ExclusiveToRoomCheckBox.Size = new System.Drawing.Size(114, 17);
            this.ExclusiveToRoomCheckBox.TabIndex = 40;
            this.ExclusiveToRoomCheckBox.Text = "Exclusive to Room";
            this.ExclusiveToRoomCheckBox.UseVisualStyleBackColor = true;
            // 
            // HazardousCheckBox
            // 
            this.HazardousCheckBox.AutoSize = true;
            this.HazardousCheckBox.Location = new System.Drawing.Point(173, 192);
            this.HazardousCheckBox.Name = "HazardousCheckBox";
            this.HazardousCheckBox.Size = new System.Drawing.Size(77, 17);
            this.HazardousCheckBox.TabIndex = 41;
            this.HazardousCheckBox.Text = "Hazardous";
            this.HazardousCheckBox.UseVisualStyleBackColor = true;
            // 
            // CreateNewWasteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 226);
            this.Controls.Add(this.HazardousCheckBox);
            this.Controls.Add(this.ExclusiveToRoomCheckBox);
            this.Controls.Add(this.UnitTextBox);
            this.Controls.Add(this.UnitComboBox);
            this.Controls.Add(this.WasteIDTextBox);
            this.Controls.Add(this.CreateNewWasteButton);
            this.Controls.Add(this.BillingUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Name = "CreateNewWasteForm";
            this.Text = "CreateNewWasteForm";
            this.Load += new System.EventHandler(this.CreateNewWasteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillingUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateNewWasteButton;
        private System.Windows.Forms.NumericUpDown BillingUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox WasteIDTextBox;
        private System.Windows.Forms.ComboBox UnitComboBox;
        private System.Windows.Forms.TextBox UnitTextBox;
        private System.Windows.Forms.CheckBox ExclusiveToRoomCheckBox;
        private System.Windows.Forms.CheckBox HazardousCheckBox;
    }
}