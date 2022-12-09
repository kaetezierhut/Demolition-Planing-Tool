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
            foreach (var item in WasteData.wasteData)
            {
                ViewBillingWasteIDComboBox.Items.Add(item.Key);
            }
        }

        private void ViewBillingWasteIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BillingUpDown.Enabled = true;
            string[] loaded = WasteData.wasteData[ViewBillingWasteIDComboBox.Text];
            NameTextBox.Text = loaded[0];
            BillingUpDown.Text = loaded[1];
            UnitTextBox.Text = loaded[2];
        }

        private void UpdateBillingButton_Click(object sender, EventArgs e)
        {
            if (BillingUpDown.Enabled)
            {
                WasteData.wasteData[ViewBillingWasteIDComboBox.Text][1] = BillingUpDown.Text;
                MessageBox.Show($"Updated WasteID {ViewBillingWasteIDComboBox.Text} Billing", "Billing",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select WasteID first", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
