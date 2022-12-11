using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demolition_Planing_Tool
{
    [Serializable]
    public class Floor
    {
        private List<Waste> floorWaste;
        private List<Room> rooms;
        public Floor() 
        {
            rooms = new List<Room>();
            floorWaste = new List<Waste>();
        }

        public double ComputeBillingFloor()
        {
            double billingFloor = 0;

            foreach (Room room in rooms)
            {
                billingFloor += room.ComputeBillingRoom();
            }

            foreach (Waste waste in floorWaste)
            {
                billingFloor += waste.Quantities * waste.Billing;
            }

            return billingFloor;
        }

        public void AddRoom(int nrRoomsPerFloor)
        {
            for (int i = 0; i < nrRoomsPerFloor; i++)
            {
                rooms.Add(new Room());
            }
        }

        public void AddWaste(Waste waste)
        {
            floorWaste.Add(waste);
        }

        public void RemoveWaste(Waste waste)
        {
            floorWaste.Remove(waste);
        }

        public List<Room> GetRoomsList() { return rooms; }

        public Room GetRoom(int id)
        {
            return rooms[id];
        }

        public List<Waste> GetWasteList()
        {
            return floorWaste;
        }

        public string Serialize()
        {
            string floorSerialized = "{";
            floorSerialized += $"\"floorWaste\": {JsonConvert.SerializeObject(floorWaste)},";
            string roomSerialized = "\"rooms\": {";
            foreach (Room room in rooms)
            {
                if (rooms.IndexOf(room) + 1 == rooms.Count)
                {
                    roomSerialized += $"\"{rooms.IndexOf(room)}\": {room.Serialize()}";
                }
                else 
                {
                    roomSerialized += $"\"{rooms.IndexOf(room)}\": {room.Serialize()},";
                }
            }
            roomSerialized += "}}";
            floorSerialized += roomSerialized;
            return floorSerialized;
        }
    }
}
