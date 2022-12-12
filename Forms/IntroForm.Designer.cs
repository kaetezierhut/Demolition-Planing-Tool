namespace Demolition_Planing_Tool
{
    partial class IntroForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BuildingNameBox = new System.Windows.Forms.TextBox();
            this.NumberFloorBox = new System.Windows.Forms.TextBox();
            this.NumberRoomPerFloorBox = new System.Windows.Forms.TextBox();
            this.StartPlanningButton = new System.Windows.Forms.Button();
            this.LoadDocuButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.StreetNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OwnerNameTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Building Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of floors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Max rooms per floor";
            // 
            // BuildingNameBox
            // 
            this.BuildingNameBox.Location = new System.Drawing.Point(392, 38);
            this.BuildingNameBox.Name = "BuildingNameBox";
            this.BuildingNameBox.Size = new System.Drawing.Size(100, 20);
            this.BuildingNameBox.TabIndex = 3;
            // 
            // NumberFloorBox
            // 
            this.NumberFloorBox.Location = new System.Drawing.Point(392, 195);
            this.NumberFloorBox.Name = "NumberFloorBox";
            this.NumberFloorBox.Size = new System.Drawing.Size(100, 20);
            this.NumberFloorBox.TabIndex = 4;
            this.NumberFloorBox.Text = "0";
            // 
            // NumberRoomPerFloorBox
            // 
            this.NumberRoomPerFloorBox.Location = new System.Drawing.Point(392, 246);
            this.NumberRoomPerFloorBox.Name = "NumberRoomPerFloorBox";
            this.NumberRoomPerFloorBox.Size = new System.Drawing.Size(100, 20);
            this.NumberRoomPerFloorBox.TabIndex = 5;
            this.NumberRoomPerFloorBox.Text = "0";
            // 
            // StartPlanningButton
            // 
            this.StartPlanningButton.Location = new System.Drawing.Point(392, 332);
            this.StartPlanningButton.Name = "StartPlanningButton";
            this.StartPlanningButton.Size = new System.Drawing.Size(100, 23);
            this.StartPlanningButton.TabIndex = 6;
            this.StartPlanningButton.Text = "Start Document";
            this.StartPlanningButton.UseVisualStyleBackColor = true;
            this.StartPlanningButton.Click += new System.EventHandler(this.StartPlanningButton_Click);
            // 
            // LoadDocuButton
            // 
            this.LoadDocuButton.Location = new System.Drawing.Point(392, 388);
            this.LoadDocuButton.Name = "LoadDocuButton";
            this.LoadDocuButton.Size = new System.Drawing.Size(100, 23);
            this.LoadDocuButton.TabIndex = 7;
            this.LoadDocuButton.Text = "Load Document";
            this.LoadDocuButton.UseVisualStyleBackColor = true;
            this.LoadDocuButton.Click += new System.EventHandler(this.LoadDocuButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // StreetNameTextBox
            // 
            this.StreetNameTextBox.Location = new System.Drawing.Point(392, 120);
            this.StreetNameTextBox.Name = "StreetNameTextBox";
            this.StreetNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.StreetNameTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Street";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Owner\'s Name";
            // 
            // OwnerNameTextBox
            // 
            this.OwnerNameTextBox.Location = new System.Drawing.Point(392, 156);
            this.OwnerNameTextBox.Name = "OwnerNameTextBox";
            this.OwnerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.OwnerNameTextBox.TabIndex = 11;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(392, 80);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(100, 20);
            this.CityTextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "City";
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.OwnerNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StreetNameTextBox);
            this.Controls.Add(this.LoadDocuButton);
            this.Controls.Add(this.StartPlanningButton);
            this.Controls.Add(this.NumberRoomPerFloorBox);
            this.Controls.Add(this.NumberFloorBox);
            this.Controls.Add(this.BuildingNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IntroForm";
            this.Text = "Demolition Planning Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BuildingNameBox;
        private System.Windows.Forms.TextBox NumberFloorBox;
        private System.Windows.Forms.TextBox NumberRoomPerFloorBox;
        private System.Windows.Forms.Button StartPlanningButton;
        private System.Windows.Forms.Button LoadDocuButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox StreetNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OwnerNameTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label label6;
    }
}