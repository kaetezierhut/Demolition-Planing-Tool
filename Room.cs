using Newtonsoft.Json;
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

        public Room() { roomWaste = new List<Waste>(); }

        // Computing the cost of the room
        public double ComputeBillingRoom()
        {
            double billingRoom = 0;
            foreach (Waste w in roomWaste)
            {
                billingRoom += w.Quantities * w.Billing;
            }
            return billingRoom;
        }

        // Adding waste to the room
        public void AddWaste(Waste waste)
        {
            roomWaste.Add(waste);
        }

        // Removing waste from the room
        public void RemoveWaste(Waste waste)
        {
            roomWaste.Remove(waste);
        }

        // Get list of waste in the room
        public List<Waste> GetRoomWaste()
        {
            return roomWaste;
        }

        // JSON Serialization of the waste (list of waste) in the room
        public string Serialize()
        {
            return JsonConvert.SerializeObject(roomWaste);
        }

    }
}
