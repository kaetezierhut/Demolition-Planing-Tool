using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using System.Windows.Forms;
using Demolition_Planing_Tool.Forms;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Newtonsoft.Json;

namespace Demolition_Planing_Tool
{
    public partial class ComputeForm : Form
    {
        private Building building;
        private int maxNumberOfFloors;
        private bool load;
        private List<Waste> itemBox = new List<Waste>();
        

        public ComputeForm(Building building, int numberOfFloors, bool load=false)
        {
            this.building = building;
            this.load = load;
            maxNumberOfFloors= numberOfFloors;
            InitializeComponent();
            if (this.load) MessageBox.Show("Loaded Document");
        }

        private void SaveDocumentButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = SaveFileDialog.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Cancel Save Document", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(SaveFileDialog.FileName))
                {
                    sw.Write(building.Serialize());
                }
                MessageBox.Show("Saved Document");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
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

        private void AddQuantitiesButton_Click(object sender, EventArgs e)
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
                        listBox1.Items.Add($"{floorIndex}\t\tNone\t\t{WasteIDComboBox.Text}\t\t" +
                            $"{quantities}\t\t{waste.Billing*waste.Quantities}\t\t{waste.Unit}");
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

                            Waste waste = new Waste(WasteIDComboBox.Text, quantities);
                            var floorIndex = FloorNumberComboBox.SelectedIndex;
                            var selectedFloor = building.GetIndividualFloor(floorIndex);
                            var roomIndex = RoomNumberComboBox.SelectedIndex;
                            var selectedRoom = selectedFloor.GetRoom(roomIndex);
                            selectedRoom.AddWaste(waste);
                            itemBox.Add(waste);
                            listBox1.Items.Add($"{floorIndex}\t{roomIndex}  \t\t{WasteIDComboBox.Text}\t\t" +
                            $"{quantities}\t\t{waste.Billing}\t\t{waste.Unit}");
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

        private void RoomCheckBox_CheckedChanged(object sender, EventArgs e)
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
                $"{building.GetFloors().Count} floors, max number of floors {maxNumberOfFloors}";

            if (load)
            {
                foreach (Floor floor in building.GetFloors())
                {
                    int floorInxdex = building.GetFloors().IndexOf(floor);
                    foreach (var waste in floor.GetWasteList())
                    {
                        itemBox.Add(waste);
                        listBox1.Items.Add($"{floorInxdex}\t\tNone\t{waste.WasteID}\t\t" +
                            $"{waste.Quantities}\t\t{waste.Billing * waste.Quantities}\t\t{waste.Unit}");
                    }
                    foreach (var room in floor.GetRoomsList())
                    {
                        int roomInxdex = floor.GetRoomsList().IndexOf(room);
                        foreach (var waste in room.GetRoomWaste())
                        {
                            itemBox.Add(waste);
                            listBox1.Items.Add($"{floorInxdex}\t\t{roomInxdex}\t\t{waste.WasteID}\t\t" +
                                $"{waste.Quantities}\t\t{waste.Billing * waste.Quantities}\t\t{waste.Unit}");
                        }
                    }
                }
            }
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

        private void ExportPDFButton_Click(object sender, EventArgs e)
        {
            PdfWriter writer = new PdfWriter(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName
                + "\\Export" + "_" + building.BuildingName + ".pdf");
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            document.Add(new Paragraph($"Building: {building.BuildingName}")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(20));
            document.Add(new Paragraph($"City: {building.City}")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(18));
            document.Add(new Paragraph($"Street: {building.StreetName}")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(16));
            document.Add(new Paragraph($"Owner: {building.OwnerName}")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(14));

            Table table = new Table(6, false);

            string[] labels = {"Floor", "Room", "WasteID", "Quantities", "Billing", "Unit"};
            for (int i = 0; i < labels.Length; i++)
            {
                table.AddCell(new Cell(1, 1)
                  .SetBackgroundColor(ColorConstants.GRAY)
                  .SetTextAlignment(TextAlignment.CENTER)
                  .Add(new Paragraph(labels[i])));
            }

            List<string[]> strings = new List<string[]>();

            foreach (string temp in listBox1.Items)
            {
                strings.Add(temp.Split(new[] {"\t\t"}, StringSplitOptions.None));
            }

            strings.Sort((x1, x2) =>
            {
                int floor1 = int.Parse(x1[0]);
                int floor2 = int.Parse(x2[0]);
                
                int room1 = x1[1] == "None" ? -1 : int.Parse(x1[1]) ;
                int room2 = x2[1] == "None" ? -1 : int.Parse(x2[1]);
                int quantities1 = int.Parse(x1[3]);
                int quantities2 = int.Parse(x2[3]);
                if (floor1 < floor2)
                {
                    return -1;
                }
                else if (floor1 > floor2)
                {
                    return 1;
                }
                else {
                    if (room1 < room2)
                    {
                        return -1;
                    }
                    else if (room2 < room1)
                    {
                        return 1;
                    }
                    else
                    {
                        if (quantities1 < quantities2)
                        {
                            return -1;
                        }
                        else if (quantities1 > quantities2)
                        {
                            return 1;
                        }
                        else return 0;
                    }
                }
            });

            strings.ForEach(items => {
                for (int i = 0; i < items.Length; i++)
                    table.AddCell(new Cell(1, 1)
                         .SetTextAlignment(TextAlignment.CENTER)
                         .Add(new Paragraph(items[i])));
                }
            );

            document.Add(table);
            document.Close();
            MessageBox.Show("PDF Exported", "OK",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ViewBilling_Click(object sender, EventArgs e)
        {
            new ViewBillingForm().ShowDialog();
        }

        private void EditBuildingInfoButton_Click(object sender, EventArgs e)
        {
            new EditBuildingInfoName(building).ShowDialog();
            PlaceHolderName.Text = $"Building: {building.BuildingName}, " +
                $"{building.GetFloors().Count} floors, max number of floors {maxNumberOfFloors}";
        }
    }
}
