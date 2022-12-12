using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demolition_Planing_Tool
{
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
        }

        private void StartPlanningButton_Click(object sender, EventArgs e)
        {
            string buildingName = BuildingNameBox.Text;
            string streetName = StreetNameTextBox.Text;
            string city = CityTextBox.Text;
            string ownerName = OwnerNameTextBox.Text;
            int numberOfFloors = 0;
            int numberOfRoomsPerFloor = 0;
            try
            {
                numberOfFloors = int.Parse(NumberFloorBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter positive number " +
                    "for number of floor", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                numberOfRoomsPerFloor = int.Parse(NumberRoomPerFloorBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter positive number " +
                    "for number of room in each floor", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (buildingName == "")
            {
                MessageBox.Show("Please enter building name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (numberOfFloors < 1 || numberOfFloors > 60)
            {
                MessageBox.Show("Please enter positive number " +
                    "for number of floor and between 1 and 60", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (numberOfRoomsPerFloor < 2 || numberOfRoomsPerFloor > 50)
            {
                MessageBox.Show("Please enter positive number " +
                    "for number of room in each floor and between 2 and 50", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Building building = new Building(buildingName, streetName, city, ownerName, numberOfFloors, numberOfRoomsPerFloor);
                new ComputeForm(building, numberOfFloors).ShowDialog();
            }
        }

        private void LoadDocuButton_Click(object sender, EventArgs e)
        {
            string textzh;
            Debug.WriteLine(JsonConvert.SerializeObject(WasteData.wasteData, Formatting.Indented));
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Cancel Load Document", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName)) {
                    textzh = sr.ReadToEnd();
                }
                JObject loaded = JObject.Parse(textzh);
                Building building = new Building(
                    loaded["BuildingName"].ToString(),
                    loaded["BuildingName"].ToString(),
                    loaded["BuildingName"].ToString(),
                    loaded["BuildingName"].ToString(),
                    loaded["floors"].Count(),
                    loaded["floors"]["0"]["rooms"].Count()
                );
                WasteData.wasteData = JsonConvert.DeserializeObject<Dictionary<string, string[]>>(loaded["wasteData"].ToString());
                foreach (var floor in loaded["floors"])
                {
                    string floorIndex = ((JProperty) (floor)).Name;
                    Floor buildingFloor = building.GetIndividualFloor(int.Parse(floorIndex));
                    foreach (var waste in ((JProperty)(floor)).Value["floorWaste"])
                    {
                        Waste floorWaste = JsonConvert.DeserializeObject<Waste>(waste.ToString());
                        buildingFloor.AddWaste(floorWaste);
                    }
                    foreach (var room in ((JProperty)(floor)).Value["rooms"])
                    {
                        string roomIndex = ((JProperty)(room)).Name;
                        Room floorRoom = buildingFloor.GetRoom(int.Parse(roomIndex));
                        foreach (var waste in ((JProperty)(room)).Value)
                        {
                            Waste roomWaste = JsonConvert.DeserializeObject<Waste>(waste.ToString());
                            floorRoom.AddWaste(roomWaste);
                        }
                    }
                }
                new ComputeForm(building, loaded["floors"]["0"]["rooms"].Count(), true).ShowDialog();
            }
        }
    }
}
