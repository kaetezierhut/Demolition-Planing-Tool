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
    public partial class EditBuildingInfoName : Form
    {
        private Building building;
        public EditBuildingInfoName(Building building)
        {
            this.building = building;
            InitializeComponent();
        }

        // Update the building info
        private void UpdateInfoButton_Click(object sender, EventArgs e)
        {
            building.BuildingName = BuildingNameBox.Text;
            building.City = CityTextBox.Text;
            building.StreetName = StreetNameTextBox.Text;
            building.OwnerName = OwnerNameTextBox.Text;
            MessageBox.Show("Updated Building Information", "OK",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Load previous buidling info
        private void EditBuildingInfoName_Load(object sender, EventArgs e)
        {
            BuildingNameBox.Text = building.BuildingName;
            CityTextBox.Text = building.City;
            StreetNameTextBox.Text = building.StreetName;
            OwnerNameTextBox.Text = building.OwnerName;
        }
    }
}
