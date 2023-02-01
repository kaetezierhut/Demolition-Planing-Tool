using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demolition_Planing_Tool
{
    public class Floor
    {
        private List<Waste> floorWaste;
        private List<Room> rooms;
        private string floorIdRevit;
        public Floor()
        {
            rooms = new List<Room>();
            floorWaste = new List<Waste>();
        }

        public string FloorIdRevit
        {
            get { return floorIdRevit; }
            set { floorIdRevit = value; }
        }

        // Computing coists for the floor
        public double ComputeBillingFloor()
        {
            double billingFloor = 0;
            // Get bliing for rooms on the floor
            foreach (Room room in rooms)
            {
                billingFloor += room.ComputeBillingRoom();
            }
            // Get billing for waste within the floor
            foreach (Waste waste in floorWaste)
            {
                billingFloor += waste.Quantities * waste.Billing;
            }

            return billingFloor;
        }

        // Adding rooms to the floor
        public void AddRoom(int nrRoomsPerFloor)
        {
            for (int i = 0; i < nrRoomsPerFloor; i++)
            {
                rooms.Add(new Room());
            }
        }

        // Adding waste to the floor
        public void AddWaste(Waste waste)
        {
            floorWaste.Add(waste);
        }

        // Remove waste from the floor
        public void RemoveWaste(Waste waste)
        {
            floorWaste.Remove(waste);
        }

        // Get list of room in floor
        public List<Room> GetRoomsList() { return rooms; }

        // Get room in the floor from with their id
        public Room GetRoom(int id)
        {
            return rooms[id];
        }

        // Get list of waste in floor
        public List<Waste> GetWasteList()
        {
            return floorWaste;
        }

        // JSON Serialization
        // structure of the JSON file
        // Waste in each floor
        // Rooms in each floor
        // Waste in each room
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
