using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;
using Demolition_Planing_Tool.Forms;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace Demolition_Planing_Tool
{
    public partial class ComputeForm : Form
    {
        private Building building;
        private int maxNumberOfFloors;
        private bool load;
        // This List is reponsible for added waste,
        // Index on this List correspondes to the index on listBox
        private List<Waste> itemBox = new List<Waste>();


        public ComputeForm(Building building, int numberOfFloors, bool load = false)
        {
            this.building = building;
            this.load = load;
            maxNumberOfFloors = numberOfFloors;
            InitializeComponent();
            // method Load document
            if (this.load) MessageBox.Show("Loaded Document", "Loded", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Save Document
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

        // Method delete waste
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Select index on list box. It is the waste which was added before
                int selectedIndex = listBox1.SelectedIndex;
                Waste toBeRemoved = itemBox[selectedIndex];

                // String in listbox
                var item = listBox1.Items[selectedIndex].ToString().Split(new[] { "\t\t" }, StringSplitOptions.None);
                // Get floor and room of the waste
                var selectedFloor = building.GetIndividualFloor(int.Parse(item[1]));
                var selectedRoom = item[2];
                // Remove it from the building and listbox
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

        private void UpdateListBox(string wasteID, dynamic floorIndex, dynamic roomIndex,
            dynamic quantities, dynamic billingPerUnit, string Unit, dynamic Hazardous, dynamic billing)
        {
            // Render the ListBox
            listBox1.Items.Add($"{wasteID}\t\t{floorIndex}\t\t{roomIndex}\t\t" +
                            $"{quantities}\t\t{billingPerUnit}\t\t{Unit}\t\t{Hazardous}\t\t{billing}");
        }

        // Method add quantities
        private void AddQuantitiesButton_Click(object sender, EventArgs e)
        {
            // In case we want to assign on the floor
            if (FloorCheckBox.Checked)
            {
                // Make sure to select floor
                if (FloorNumberComboBox.SelectedIndex > -1)
                {
                    // Make sure to select WasteID
                    if (WasteIDComboBox.SelectedIndex > -1)
                    {
                        int quantities = 0;
                        // Make sure the quantities >= 0
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
                        // Make sure the room exclusive waste are not belong to the floor
                        string exc = WasteData.wasteData[WasteIDComboBox.Text][3];
                        if (bool.Parse(exc))
                        {
                            MessageBox.Show("This waste belong exclusively to room, please choose other waste",
                                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        // Create the Waste object and add it to the floor
                        Waste waste = new Waste(WasteIDComboBox.Text, quantities);
                        var floorIndex = FloorNumberComboBox.SelectedIndex;
                        var selectedFloor = building.GetIndividualFloor(floorIndex);
                        selectedFloor.AddWaste(waste);

                        // Update it to listBox
                        itemBox.Add(waste);
                        UpdateListBox(WasteIDComboBox.Text, floorIndex, "None", quantities,
                            waste.Billing, waste.Unit, waste.Hazardous ? "yes" : "no", waste.Billing * waste.Quantities);
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
            // In case the waste is assigned to the room
            else if (RoomCheckBox.Checked)
            {
                // Make sure to select floor
                if (FloorNumberComboBox.SelectedIndex > -1)
                {
                    // Make sure to select room
                    if (RoomNumberComboBox.SelectedIndex > -1)
                    {
                        // Make sure to select WasteID
                        if (WasteIDComboBox.SelectedIndex > -1)
                        {
                            int quantities = 0;
                            // Make sure the quantities >= 0
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
                            // Create the Waste object and add it to the room
                            Waste waste = new Waste(WasteIDComboBox.Text, quantities);
                            var floorIndex = FloorNumberComboBox.SelectedIndex;
                            var selectedFloor = building.GetIndividualFloor(floorIndex);
                            var roomIndex = RoomNumberComboBox.SelectedIndex;
                            var selectedRoom = selectedFloor.GetRoom(roomIndex);
                            selectedRoom.AddWaste(waste);

                            // Update it to listBox
                            itemBox.Add(waste);
                            UpdateListBox(WasteIDComboBox.Text, floorIndex, roomIndex, quantities,
                            waste.Billing, waste.Unit, waste.Hazardous ? "yes" : "no", waste.Billing * waste.Quantities);
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

        // Select room to add waste
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

        // Select floor to add waste
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

        // Load floor number, wasteID when open the form
        private void ComputeForm_Load(object sender, EventArgs e)
        {
            // Load floor, room, wasteID info when starting
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

            // In case a saved file is loaded, it goes through each floor, room to add it to the list
            if (load)
            {
                foreach (Floor floor in building.GetFloors())
                {
                    int floorIndex = building.GetFloors().IndexOf(floor);
                    foreach (var waste in floor.GetWasteList())
                    {
                        itemBox.Add(waste);
                        UpdateListBox(waste.WasteID, floorIndex, "None", waste.Quantities,
                            waste.Billing, waste.Unit, waste.Hazardous ? "yes" : "no", waste.Billing * waste.Quantities);
                    }
                    foreach (var room in floor.GetRoomsList())
                    {
                        int roomInxdex = floor.GetRoomsList().IndexOf(room);
                        foreach (var waste in room.GetRoomWaste())
                        {
                            itemBox.Add(waste);
                            UpdateListBox(waste.WasteID, floorIndex, roomInxdex, waste.Quantities,
                            waste.Billing, waste.Unit, waste.Hazardous ? "yes" : "no", waste.Billing * waste.Quantities);
                        }
                    }
                }
            }
        }

        private void RoomNumberComboBox_DropDown(object sender, EventArgs e)
        {
            // Render at drop down for room after selecting floor
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

        // Method computing the total cost
        private void ComputeTotalCost_Click(object sender, EventArgs e)
        {
            // Compute Building billing
            var totalCost = building.ComputeBillingBuilding();
            TotalCost.Text = $"{totalCost}€";
        }

        // Method Export PDF
        private void ExportPDFButton_Click(object sender, EventArgs e)
        {
            // Export to Project folder
            var path = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
            PdfWriter writer = new PdfWriter(path + "\\Export" + "_" + building.BuildingName + ".pdf");
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            // Write Building Info to PDF
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

            Table table = new Table(8, false);
            // write listbox to pdf
            string[] labels = {"WasteID", "Floor", "Room","Quantities", "Billing/Unit (€)",
                "Unit", "Hazardous","Billing (€)"};
            for (int i = 0; i < labels.Length; i++)
            {
                table.AddCell(new Cell(1, 1)
                  .SetBackgroundColor(ColorConstants.GRAY)
                  .SetTextAlignment(TextAlignment.CENTER)
                  .Add(new Paragraph(labels[i])));
            }

            // Sort output by wasteID, floor, room
            List<string[]> strings = new List<string[]>();
            List<string[]> strings_sorted = new List<string[]>();

            foreach (string temp in listBox1.Items)
            {
                strings.Add(temp.Split(new[] { "\t\t" }, StringSplitOptions.None));
            }

            foreach (var id in WasteData.wasteData.Keys)
            {
                Table table1 = new Table(8, false);
                List<string[]> list1 = new List<string[]>();

                for (int i = 0; i < labels.Length; i++)
                {
                    table1.AddCell(new Cell(1, 1)
                      .SetBackgroundColor(ColorConstants.GRAY)
                      .SetTextAlignment(TextAlignment.CENTER)
                      .Add(new Paragraph(labels[i])));
                }

                foreach (var str in strings)
                {
                    if (str[0].Contains(id))
                    {
                        list1.Add(str);
                        strings_sorted.Add(str);
                    }
                }

                list1.Sort((x1, x2) =>
                {
                    int floor1 = int.Parse(x1[1]);
                    int floor2 = int.Parse(x2[1]);

                    int room1 = x1[2] == "None" ? -1 : int.Parse(x1[2]);
                    int room2 = x2[2] == "None" ? -1 : int.Parse(x2[2]);

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
                    else
                    {
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

                list1.ForEach(items =>
                {
                    for (int i = 0; i < items.Length; i++)
                        table1.AddCell(new Cell(1, 1)
                             .SetTextAlignment(TextAlignment.CENTER)
                             .Add(new Paragraph(items[i])));
                });

                if (list1.Any())
                {
                    document.Add(new Paragraph(id + " " + WasteData.wasteData[id][0])
                        .SetTextAlignment(TextAlignment.LEFT)
                        .SetFontSize(12)
                        .SetBold());

                    document.Add(table1);

                    document.Add(new Paragraph(" ")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(12));
                }
            }

            document.Add(new Paragraph("--------------------")
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetFontSize(12));

            ComputeTotalCost_Click(sender, e);
            document.Add(new Paragraph("Total Cost: " + TotalCost.Text)
                .SetTextAlignment(TextAlignment.RIGHT)
                .SetFontSize(12));
            document.Close();

            MessageBox.Show($"PDF Exported to {path}",
                "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Open view waste Form
        private void ViewWaste_Click(object sender, EventArgs e)
        {
            new ViewWasteForm().ShowDialog();
        }

        // Open Edit Buidling info form
        private void EditBuildingInfoButton_Click(object sender, EventArgs e)
        {
            new EditBuildingInfoName(building).ShowDialog();
            PlaceHolderName.Text = $"Building: {building.BuildingName}, " +
                $"{building.GetFloors().Count} floors, max number of floors {maxNumberOfFloors}";
        }

        // Render wasteid at dropdown in case we added new waste
        private void WasteIDComboBox_DropDown(object sender, EventArgs e)
        {
            foreach (var item in WasteData.wasteData)
            {
                WasteIDComboBox.Items.Add(item.Key);
            }
        }
    }
}
