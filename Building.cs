using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            foreach (Floor floor in floors)
            {
                floor.addRoom(nrRoomsPerFloor);
            }
        }

        public string BuildingName
        {
            get { return buildingName; }
            set { buildingName = value; }
        }
    }
}
