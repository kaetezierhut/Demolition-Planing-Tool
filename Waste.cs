using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demolition_Planing_Tool
{
    public class Waste
    {
        private string wasteID;
        private double billing;
        private bool roomExclusive = true;
        private string unit;
        private bool hazardous;
        private int quantities = 0;

        public Waste(string wasteID, int quatities)
        {
            this.wasteID = wasteID;
            quantities = quatities;

            // Initiate other value from wasteID
            var wasteValue = WasteData.wasteData[wasteID];
            billing = double.Parse(wasteValue[1]);
            unit = wasteValue[2];
            roomExclusive = bool.Parse(wasteValue[3]);
            hazardous = bool.Parse(wasteValue[4]);
        }

        // getter and setter of the attributes
        public string WasteID
        {
            get { return wasteID; }
            set { wasteID = value; }
        }

        public double Billing
        {
            get { return billing; }
            set { billing = value; }
        }

        public int Quantities
        {
            get { return quantities; }
            set { quantities = value; }
        }

        public bool RoomExclusive
        {
            get { return roomExclusive; }
            set { roomExclusive = value; }
        }

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        public bool Hazardous
        {
            get { return hazardous; }
            set { hazardous = value; }
        }

        // Method serialization
        public string Serialize()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
