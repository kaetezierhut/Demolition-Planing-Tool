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
    public partial class ComputeForm : Form
    {
        private Building building;
        public ComputeForm(Building building)
        {
            this.building = building;
            InitializeComponent();            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();
            MessageBox.Show("Saved Data"); 
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int x = listBox1.SelectedIndex;

                listBox1.Items.RemoveAt(x);
            }
            catch (Exception)
            {
                MessageBox.Show("Select first an item to delete it");
            }
        }

        // Add Quantities
        private void button3_Click(object sender, EventArgs e)
        {
            if (FloorCheckBox.Checked)
            {
                if (FloorNumberComboBox.SelectedIndex > -1)
                {
                    if (WasteIDComboBox.SelectedIndex > -1)
                    {
                        int quantities = 0;
                        try 
                        {
                            quantities = int.Parse(QuantitiesTextBox.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Please enter a positive integer number for quantities", 
                                "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        finally
                        {
                            if (quantities < 0)
                            {
                                MessageBox.Show("Please enter a positive integer number for quantities", 
                                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }


                        Waste waste = new Waste(WasteIDComboBox.SelectedText, quantities);
                        var floorsBuilding = building.GetFloors();
                        string selectedFloorComboBox = (string)FloorNumberComboBox.SelectedItem;
                        var splitted = selectedFloorComboBox.Split(' ');
                        int floorIndex = int.Parse(splitted[1]);
                        var selectedFloor = floorsBuilding[floorIndex];
                        selectedFloor.AddWaste(waste);

                    }
                    else
                    {
                        MessageBox.Show("Please select WasteID", "Warning", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please select Floor", "Warning", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else if (RoomCheckBox.Checked)
            {
                if (FloorNumberComboBox.SelectedIndex > -1)
                {
                    if (RoomNumberComboBox.SelectedIndex > -1)
                    {
                        if (WasteIDComboBox.SelectedIndex > -1)
                        {
                            int quantities = 0;
                            try
                            {
                                quantities = int.Parse(QuantitiesTextBox.Text);
                            }
                            catch
                            {
                                MessageBox.Show(
                                    "Please enter a positive integer number for quantities",
                                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            finally
                            {
                                if (quantities < 0)
                                {
                                    MessageBox.Show("Please enter a positive integer number for quantities",
                                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }

                            Waste waste = new Waste(WasteIDComboBox.SelectedText, quantities);
                            var floorsBuilding = building.GetFloors();
                            string selectedFloorComboBox = (string)FloorNumberComboBox.SelectedItem;
                            var splitted = selectedFloorComboBox.Split(' ');
                            int floorIndex = int.Parse(splitted[1]);
                            var selectedFloor = floorsBuilding[floorIndex];
                            //var selectedRoom = 
                            //selectedFloor.AddWaste(waste);

                        }
                        else
                        {
                            MessageBox.Show("Please select WasteID", "Warning", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select Room", "Warning", 
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please select Floor", "Warning", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Room checkBox
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (RoomCheckBox.Checked) 
            {
                FloorCheckBox.Checked = false;
                RoomNumberComboBox.Enabled = true;
            }
            if (!FloorCheckBox.Checked && !RoomCheckBox.Checked)
            {
                RoomCheckBox.Checked = true;
                RoomNumberComboBox.Enabled = false;
            }
        }

        private void FloorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FloorCheckBox.Checked)
            {
                RoomCheckBox.Checked = false;
                RoomNumberComboBox.Enabled = false;
            }
            if (!FloorCheckBox.Checked && !RoomCheckBox.Checked)
            {
                RoomCheckBox.Checked = true;
                RoomNumberComboBox.Enabled = true;
            }
        }

        private void FloorNumberComboBox_DropDown(object sender, EventArgs e)
        {
            var floorsBuildingCount = building.GetFloors().Count;
            if (FloorNumberComboBox.Items.Count < floorsBuildingCount)
            {
                for (var i = 0; i < floorsBuildingCount; i++)
                {
                    FloorNumberComboBox.Items.Add($"Floor {i}");
                }
            }
        }

        private void ComputeForm_Load(object sender, EventArgs e)
        {
            foreach (var item in WasteData.wasteData)
            {
                WasteIDComboBox.Items.Add(item.Key);
            }
            PlaceHolderName.Text = $"Building: {building.BuildingName}, " +
                $"{building.GetFloors().Count} floors";
        }

        private void RoomNumberComboBox_DropDown(object sender, EventArgs e)
        {
            if (FloorNumberComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select Floor", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var floorsBuilding = building.GetFloors();
                string selectedFloorComboBox = (string)FloorNumberComboBox.SelectedItem;
                var splitted = selectedFloorComboBox.Split(' ');
                int floorIndex = int.Parse(splitted[1]);
                var selectedFloor = floorsBuilding[floorIndex];
                var roomFloorCount = selectedFloor.GetRooms().Count;

                if (RoomNumberComboBox.Items.Count < roomFloorCount)
                {
                    for (var i = 0; i < roomFloorCount; i++)
                    {
                        RoomNumberComboBox.Items.Add($"Room {i}");
                    }
                }
            }
            
        }
    }
}
