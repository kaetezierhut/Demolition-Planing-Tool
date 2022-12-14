using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demolition_Planing_Tool.Forms
{
    public partial class CreateNewWasteForm : Form
    {
        public CreateNewWasteForm()
        {
            InitializeComponent();
        }

        // Reder Unit at load
        private void CreateNewWasteForm_Load(object sender, EventArgs e)
        {
            foreach (var item in WasteData.unitData)
            {
                UnitComboBox.Items.Add(item.Key);
            }
        }

        // Info Box for each unit according to DIN
        private void UnitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnitTextBox.Text = WasteData.unitData[UnitComboBox.Text];
        }
        
        private void CreateNewWasteButton_Click(object sender, EventArgs e)
        {
            // Make sure the wasteID only have number and space
            try
            {
                int wasteID = int.Parse(WasteIDTextBox.Text.Replace(" ", ""));
            }
            catch
            {
                MessageBox.Show("WasteID should only consist of integer and space ", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (UnitComboBox.SelectedIndex > -1)
            {
                // Add it to our data
                WasteData.wasteData.Add(
                WasteIDTextBox.Text, new string[] {NameTextBox.Text, BillingUpDown.Text,
                    UnitComboBox.Text, ExclusiveToRoomCheckBox.Checked.ToString(), HazardousCheckBox.Checked.ToString()}
                );
                MessageBox.Show($"Added new WasteID", "Billing",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select Unit tpye", "Warning",
                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   
        }
    }
}
