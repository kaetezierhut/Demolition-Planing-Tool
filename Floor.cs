using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demolition_Planing_Tool
{
    internal class Floor
    {
        private List<Waste> floorWaste;
        private List<Room> rooms;
        public Floor() 
        {
            rooms = new List<Room>();
        }

        public double computeBillingFloor()
        {
            double billingFloor = 0;

            foreach (Room room in rooms)
            {
                billingFloor += room.computeBillingRoom();
            }

            foreach (Waste waste in floorWaste)
            {
                billingFloor += waste.Quantities * waste.Billing;
            }

            return billingFloor;
        }

        public void addRoom(int nrRoomsPerFloor)
        {
            for (int i = 0; i < nrRoomsPerFloor; i++)
            {
                rooms.Add(new Room());
            }
        }
    }
}
