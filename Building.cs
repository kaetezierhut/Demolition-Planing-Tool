using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demolition_Planing_Tool
{
    [Serializable]
    public class Building
    {
        private List<Floor> floors;
        private string buildingName;
        private string streetName;
        private string city;
        private string ownerName;

        public Building(string buildingName, string streetName, string city, 
            string ownerName, int nrFloors, int nrRoomsPerFloor)
        {
            this.buildingName = buildingName;
            this.streetName = streetName;
            this.city = city;
            this.ownerName = ownerName;

            // Init floor
            floors = new List<Floor>(nrFloors);
            for (var i = 0; i < nrFloors; i++)
            {
                floors.Add(new Floor());
            }
            // Init rooms per floor
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

        public string StreetName
        {
            get { return streetName; }
            set { streetName = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string OwnerName
        {
            get { return ownerName; }
            set { ownerName = value; }
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

        // JSON Serialization, see documentation for more details
        public string Serialize()
        {
            string buildingInfo = JsonConvert.SerializeObject(this).Replace("}", "");
            string buildingSeriliazed = $"{{ {buildingInfo.Replace("{", "")},";
            buildingSeriliazed += "\"floors\": {";
            foreach (Floor floor in floors)
            {
                if (floors.IndexOf(floor) + 1 == floors.Count)
                {
                    buildingSeriliazed += $"\"{floors.IndexOf(floor)}\": {floor.Serialize()}";
                }
                else
                {
                    buildingSeriliazed += $"\"{floors.IndexOf(floor)}\": {floor.Serialize()},";
                }
            }
            var alo = JsonConvert.DeserializeObject($"{buildingSeriliazed} }}, " +
                $"\"wasteData\": {JsonConvert.SerializeObject(WasteData.wasteData)} }}");
            return JsonConvert.SerializeObject(alo, Formatting.Indented);
        }
    }
}
