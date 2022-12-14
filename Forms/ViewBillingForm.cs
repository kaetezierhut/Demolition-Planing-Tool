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
    public partial class ViewBillingForm : Form
    {
        public ViewBillingForm()
        {
            InitializeComponent();
        }

        private void ViewBillingForm_Load(object sender, EventArgs e)
        {
            foreach (var item in WasteData.unitData)
            {
                UnitComboBox.Items.Add(item.Key);
            }
        }

        private void ViewBillingWasteIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BillingUpDown.Enabled = true;
            UnitComboBox.Enabled = true;
            UnitTextBox.Enabled = true;
            HazardousCheckBox.Enabled = true;
            ExclusiveToRoomCheckBox.Enabled = true;
            string[] loaded = WasteData.wasteData[ViewBillingWasteIDComboBox.Text];
            NameTextBox.Text = loaded[0];
            BillingUpDown.Text = loaded[1];
            UnitComboBox.Text = loaded[2];
            ExclusiveToRoomCheckBox.Checked = bool.Parse(loaded[3]);
            UnitTextBox.Text = WasteData.unitData[UnitComboBox.Text];
        }

        private void UpdateBillingButton_Click(object sender, EventArgs e)
        {
            if (BillingUpDown.Enabled)
            {
                WasteData.wasteData[ViewBillingWasteIDComboBox.Text][1] = BillingUpDown.Text;
                WasteData.wasteData[ViewBillingWasteIDComboBox.Text][2] = UnitComboBox.Text;
                MessageBox.Show($"Updated WasteID {ViewBillingWasteIDComboBox.Text}", "Billing",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select WasteID first", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CreateNewWasteButton_Click(object sender, EventArgs e)
        {
            new CreateNewWasteForm().ShowDialog();
        }

        private void ViewBillingWasteIDComboBox_DropDown(object sender, EventArgs e)
        {
            foreach (var item in WasteData.wasteData)
            {
                ViewBillingWasteIDComboBox.Items.Add(item.Key);
            }
        }

        private void UnitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnitTextBox.Text = WasteData.unitData[UnitComboBox.Text];
        }
    }
}
