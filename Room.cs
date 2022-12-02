using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Demolition_Planing_Tool
{
    public class Room
    {
        private List<Waste> roomWaste;

        public Room() { roomWaste = new List<Waste>();}

        public double computeBillingRoom()
        {
            double billingRoom = 0;
            foreach (Waste w in roomWaste)
            {
                billingRoom += w.Quantities * w.Billing;
            }
            return billingRoom;
        }

        public void addWaste(Waste waste) 
        {
            roomWaste.Add(waste);
        }

        public List<Waste> getRoomWaste() { return roomWaste; }

    }
}
