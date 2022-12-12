namespace Demolition_Planing_Tool.Forms
{
    partial class EditBuildingInfoName
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
            this.label6 = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.OwnerNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StreetNameTextBox = new System.Windows.Forms.TextBox();
            this.BuildingNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "City";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(171, 65);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(100, 20);
            this.CityTextBox.TabIndex = 20;
            // 
            // OwnerNameTextBox
            // 
            this.OwnerNameTextBox.Location = new System.Drawing.Point(171, 141);
            this.OwnerNameTextBox.Name = "OwnerNameTextBox";
            this.OwnerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.OwnerNameTextBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Owner\'s Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Street";
            // 
            // StreetNameTextBox
            // 
            this.StreetNameTextBox.Location = new System.Drawing.Point(171, 105);
            this.StreetNameTextBox.Name = "StreetNameTextBox";
            this.StreetNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.StreetNameTextBox.TabIndex = 16;
            // 
            // BuildingNameBox
            // 
            this.BuildingNameBox.Location = new System.Drawing.Point(171, 23);
            this.BuildingNameBox.Name = "BuildingNameBox";
            this.BuildingNameBox.Size = new System.Drawing.Size(100, 20);
            this.BuildingNameBox.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Building Name";
            // 
            // UpdateInfoButton
            // 
            this.UpdateInfoButton.Location = new System.Drawing.Point(116, 188);
            this.UpdateInfoButton.Name = "UpdateInfoButton";
            this.UpdateInfoButton.Size = new System.Drawing.Size(107, 23);
            this.UpdateInfoButton.TabIndex = 22;
            this.UpdateInfoButton.Text = "Update Information";
            this.UpdateInfoButton.UseVisualStyleBackColor = true;
            this.UpdateInfoButton.Click += new System.EventHandler(this.UpdateInfoButton_Click);
            // 
            // EditBuildingInfoName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 234);
            this.Controls.Add(this.UpdateInfoButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.OwnerNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StreetNameTextBox);
            this.Controls.Add(this.BuildingNameBox);
            this.Controls.Add(this.label1);
            this.Name = "EditBuildingInfoName";
            this.Text = "EditBuildingInfoName";
            this.Load += new System.EventHandler(this.EditBuildingInfoName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox OwnerNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StreetNameTextBox;
        private System.Windows.Forms.TextBox BuildingNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateInfoButton;
    }
}