using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demolition_Planing_Tool
{
    public class Building
    {
        private List<Floor> floors;
        private string buildingName;

        public Building(string buildingName, int nrFloors, int nrRoomsPerFloor)
        {
            this.buildingName = buildingName;
            floors = new List<Floor>(nrFloors);
            for (var i = 0; i < nrFloors; i++)
            {
                floors.Add(new Floor());
            }
            foreach (Floor floor in floors)
            {
                floor.AddRoom(nrRoomsPerFloor);
            }
        }

        public string BuildingName
        {
            get { return buildingName; }
            set { buildingName = value; }
        }
        
        public List<Floor> GetFloors()
        {
            return floors;
        }

        public Floor GetIndividualFloor(int index)
        {
            return floors[index];
        }

        public double ComputeBillingBuilding()
        {
            double billingBuilding = 0;
            foreach (Floor floor in floors)
            {
                billingBuilding += floor.ComputeBillingFloor();
            }
            return billingBuilding;
        }
    }
}
