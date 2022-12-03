using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demolition_Planing_Tool
{
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

        public List<Waste> GetWasteList() { return floorWaste; }

        public Room GetRoom(int id)
        {
            return rooms[id];
        }
    }
}
