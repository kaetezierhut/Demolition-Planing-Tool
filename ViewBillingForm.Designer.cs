namespace Demolition_Planing_Tool
{
    partial class ViewBillingForm
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
            this.UnitTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateBillingButton = new System.Windows.Forms.Button();
            this.BillingUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.BillingUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "WasteID";
            // 
            // ViewBillingWasteIDComboBox
            // 
            this.ViewBillingWasteIDComboBox.FormattingEnabled = true;
            this.ViewBillingWasteIDComboBox.Location = new System.Drawing.Point(185, 54);
            this.ViewBillingWasteIDComboBox.Name = "ViewBillingWasteIDComboBox";
            this.ViewBillingWasteIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.ViewBillingWasteIDComboBox.TabIndex = 9;
            this.ViewBillingWasteIDComboBox.SelectedIndexChanged += new System.EventHandler(this.ViewBillingWasteIDComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Enabled = false;
            this.NameTextBox.Location = new System.Drawing.Point(186, 93);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(120, 20);
            this.NameTextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Billing (€)";
            // 
            // UnitTextBox
            // 
            this.UnitTextBox.Enabled = false;
            this.UnitTextBox.Location = new System.Drawing.Point(186, 145);
            this.UnitTextBox.Name = "UnitTextBox";
            this.UnitTextBox.Size = new System.Drawing.Size(120, 20);
            this.UnitTextBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Unit";
            // 
            // UpdateBillingButton
            // 
            this.UpdateBillingButton.Location = new System.Drawing.Point(196, 183);
            this.UpdateBillingButton.Name = "UpdateBillingButton";
            this.UpdateBillingButton.Size = new System.Drawing.Size(97, 23);
            this.UpdateBillingButton.TabIndex = 19;
            this.UpdateBillingButton.Text = "Update Billing";
            this.UpdateBillingButton.UseVisualStyleBackColor = true;
            this.UpdateBillingButton.Click += new System.EventHandler(this.UpdateBillingButton_Click);
            // 
            // BillingUpDown
            // 
            this.BillingUpDown.Enabled = false;
            this.BillingUpDown.Location = new System.Drawing.Point(186, 119);
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
            // ViewBillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 240);
            this.Controls.Add(this.BillingUpDown);
            this.Controls.Add(this.UpdateBillingButton);
            this.Controls.Add(this.UnitTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ViewBillingWasteIDComboBox);
            this.Controls.Add(this.label9);
            this.Name = "ViewBillingForm";
            this.Text = "ViewBillingForm";
            this.Load += new System.EventHandler(this.ViewBillingForm_Load);
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
        private System.Windows.Forms.TextBox UnitTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UpdateBillingButton;
        private System.Windows.Forms.NumericUpDown BillingUpDown;
    }
}