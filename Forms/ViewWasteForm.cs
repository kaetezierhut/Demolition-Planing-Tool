using Demolition_Planing_Tool.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demolition_Planing_Tool
{
    public partial class ViewWasteForm : Form
    {
        public ViewWasteForm()
        {
            InitializeComponent();
        }

        // Render Unit at load
        private void ViewWasteForm_Load(object sender, EventArgs e)
        {
            foreach (var item in WasteData.unitData)
            {
                UnitComboBox.Items.Add(item.Key);
            }
        }

        private void ViewWasteWasteIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable other details after choosing the wasteID
            BillingUpDown.Enabled = true;
            UnitComboBox.Enabled = true;
            UnitTextBox.Enabled = true;
            HazardousCheckBox.Enabled = true;
            ExclusiveToRoomCheckBox.Enabled = true;

            // Load their information datil
            string[] loaded = WasteData.wasteData[ViewWasteWasteIDComboBox.Text];
            NameTextBox.Text = loaded[0];
            BillingUpDown.Text = loaded[1];
            UnitComboBox.Text = loaded[2];
            ExclusiveToRoomCheckBox.Checked = bool.Parse(loaded[3]);
            HazardousCheckBox.Checked = bool.Parse(loaded[4]);
            UnitTextBox.Text = WasteData.unitData[UnitComboBox.Text];
        }

        private void UpdateWasteButton_Click(object sender, EventArgs e)
        {
            // Change only when selected wasteid
            if (ViewWasteWasteIDComboBox.SelectedIndex > -1)
            {
                WasteData.wasteData[ViewWasteWasteIDComboBox.Text][1] = BillingUpDown.Text;
                WasteData.wasteData[ViewWasteWasteIDComboBox.Text][2] = UnitComboBox.Text;
                WasteData.wasteData[ViewWasteWasteIDComboBox.Text][3] = ExclusiveToRoomCheckBox.Checked.ToString();
                WasteData.wasteData[ViewWasteWasteIDComboBox.Text][4] = HazardousCheckBox.Checked.ToString();
                MessageBox.Show($"Updated WasteID {ViewWasteWasteIDComboBox.Text}", "Billing",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select WasteID first", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Open form for new waste
        private void CreateNewWasteButton_Click(object sender, EventArgs e)
        {
            new CreateNewWasteForm().ShowDialog();
        }

        // Render when dropdown in case we have new waste
        private void ViewWasteWasteIDComboBox_DropDown(object sender, EventArgs e)
        {
            foreach (var item in WasteData.wasteData)
            {
                ViewWasteWasteIDComboBox.Items.Add(item.Key);
            }
        }
        
        // Update description for unit
        private void UnitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnitTextBox.Text = WasteData.unitData[UnitComboBox.Text];
        }
    }
}
