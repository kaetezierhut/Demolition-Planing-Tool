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
    public partial class IntroForm : Form
    {
        public IntroForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string buildingName = BuildingNameBox.Text;
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
            else if (numberOfFloors < 1 || numberOfFloors > 20)
            {
                MessageBox.Show("Please enter positive number " +
                    "for number of floor and between 1 and 20", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (numberOfRoomsPerFloor < 2 || numberOfRoomsPerFloor > 50)
            {
                MessageBox.Show("Please enter positive number " +
                    "for number of room in each floor and between 2 and 50", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Building building = new Building(buildingName, numberOfFloors, numberOfRoomsPerFloor);
                new ComputeForm(building).ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
        }
    }
}
