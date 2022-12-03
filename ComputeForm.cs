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
        private List<Waste> itemBox = new List<Waste>();

        public ComputeForm(Building building)
        {
            this.building = building;
            InitializeComponent();            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();
            MessageBox.Show("Saved Data"); 
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        // Delete Button
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = listBox1.SelectedIndex;
                Waste toBeRemoved = itemBox[selectedIndex];
                var item = listBox1.Items[selectedIndex].ToString().Split('\t');
                var selectedFloor = building.GetIndividualFloor(int.Parse(item[0].Split(' ')[1]));
                var selectedRoom = item[1].Split(' ')[1];
                if (selectedRoom == "None")
                {
                    selectedFloor.RemoveWaste(toBeRemoved);
                }
                else
                {
                    var room = selectedFloor.GetRoom(int.Parse(selectedRoom));
                    room.RemoveWaste(toBeRemoved);
                }
                itemBox.Remove(toBeRemoved);
                listBox1.Items.RemoveAt(selectedIndex);
            }
            catch (Exception)
            {
                MessageBox.Show("Please select an item to delete it");
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

                        Waste waste = new Waste(WasteIDComboBox.Text, quantities);
                        var floorIndex = FloorNumberComboBox.SelectedIndex;
                        var selectedFloor = building.GetIndividualFloor(floorIndex);
                        selectedFloor.AddWaste(waste);
                        itemBox.Add(waste);
                        listBox1.Items.Add($"Floor: {floorIndex}\tRoom: None\tWasteID: {WasteIDComboBox.Text}\t" +
                            $"Quantities: {quantities}\tBilling: {waste.Billing}\tUnit: {waste.Unit}");
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
                            var floorIndex = FloorNumberComboBox.SelectedIndex;
                            var selectedFloor = building.GetIndividualFloor(floorIndex);
                            var roomIndex = RoomNumberComboBox.SelectedIndex;
                            var selectedRoom = selectedFloor.GetRoom(roomIndex);
                            selectedRoom.AddWaste(waste);
                            itemBox.Add(waste);
                            listBox1.Items.Add($"Floor: {floorIndex}\tRoom: {roomIndex}\tWasteID: {WasteIDComboBox.Text}\t" +
                            $"Quantities: {quantities}\tBilling: {waste.Billing}\tUnit: {waste.Unit}");
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
            FloorNumberComboBox.Enabled = true;
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
            FloorNumberComboBox.Enabled = true;
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

        private void ComputeForm_Load(object sender, EventArgs e)
        {
            var floorsBuildingCount = building.GetFloors().Count;
            if (FloorNumberComboBox.Items.Count < floorsBuildingCount)
            {
                for (var i = 0; i < floorsBuildingCount; i++)
                {
                    FloorNumberComboBox.Items.Add($"Floor {i}");
                }
            }
            RoomNumberComboBox.Enabled = false;
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
                MessageBox.Show("Please select Floor First", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int floorIndex = FloorNumberComboBox.SelectedIndex;
                var selectedFloor = building.GetIndividualFloor(floorIndex);
                var roomFloorCount = selectedFloor.GetRoomsList().Count;

                if (RoomNumberComboBox.Items.Count < roomFloorCount)
                {
                    for (var i = 0; i < roomFloorCount; i++)
                    {
                        RoomNumberComboBox.Items.Add($"Room {i}");
                    }
                }
            }
            
        }

        private void ComputeTotalCost_Click(object sender, EventArgs e)
        {
            var totalCost = building.ComputeBillingBuilding();
            TotalCost.Text = $"{totalCost}€";
        }
    }
}
