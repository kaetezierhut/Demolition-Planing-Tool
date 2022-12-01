using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demolition_Planing_Tool
{
    public abstract class Waste
    {
        private string wasteID;
        private double billing;
        private bool roomExclusive = true;
        private string unit;
        private int quantities;

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
    }
}
