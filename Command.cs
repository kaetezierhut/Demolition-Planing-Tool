using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Architecture;
using Autodesk.Revit.UI;
using iText.Kernel.XMP.Impl;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demolition_Planing_Tool
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]

    public class CustomControl1 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiApp = commandData.Application;
            UIDocument uidoc = uiApp.ActiveUIDocument;
            Document doc = uidoc.Document;
            ProjectInfo pi = doc.ProjectInformation;

            // Get floors from Revit
            ElementClassFilter familyInstanceFloor = new ElementClassFilter(typeof(Level));
            ElementCategoryFilter floorCatergoryFilter = new ElementCategoryFilter(BuiltInCategory.OST_Levels);
            LogicalAndFilter floorInstanceFilter = new LogicalAndFilter(familyInstanceFloor, floorCatergoryFilter);
            FilteredElementCollector collector = new FilteredElementCollector(doc);
            ICollection<Element> myFloors = collector.WherePasses(floorInstanceFilter).ToElements();
            List<Level> floors = new List<Level>();

            foreach (Element floor in myFloors)
            {
                if (floor is Level)
                {
                    floors.Add(floor as Level);
                }
            }

            // Get Rooms from all Floors
            List<List<Autodesk.Revit.DB.Architecture.Room>> allRooms = new List<List<Autodesk.Revit.DB.Architecture.Room>>();
            int maxRoomCount = 0;

            foreach (Element floor in myFloors)
            {
                ElementId levelId = floor.Id;

                ElementLevelFilter levelFilter = new ElementLevelFilter(levelId);
                FilteredElementCollector roomCollector = new FilteredElementCollector(doc);
                IList<Element> allRoomsOnLevel = roomCollector.WherePasses(new RoomFilter()).WherePasses(levelFilter).ToElements();

                List<Autodesk.Revit.DB.Architecture.Room> rooms = new List<Autodesk.Revit.DB.Architecture.Room>();
                
                foreach (Element room in allRoomsOnLevel)
                {
                    if (room is Autodesk.Revit.DB.Architecture.Room)
                    {
                        rooms.Add(room as Autodesk.Revit.DB.Architecture.Room);
                        //Debug.WriteLine("roomId " + room.Id);
                    }
                }
                //Debug.WriteLine("levelId " + levelId + " " + "room count " + rooms.Count);
                if (rooms.Count > maxRoomCount)
                {
                    maxRoomCount = rooms.Count;
                }
                allRooms.Add(rooms);
            }

            // Get walls will be assigned to floor
            foreach (Element floor in myFloors)
            {
                ElementId levelId = floor.Id;

                ElementLevelFilter levelFilter = new ElementLevelFilter(levelId);
                collector = new FilteredElementCollector(doc);
                ICollection<Element> allWallsOnLevel1 = collector.OfClass(typeof(Wall)).WherePasses(levelFilter).ToElements();

                foreach (Element wall in allWallsOnLevel1)
                {
                    //Debug.WriteLine("Floor ID " + levelId + "Wall ID " + wall.Id);
                }
            }

            // Get windows in each floor
            foreach (Element floor in myFloors)
            {
                ElementId levelId = floor.Id;
                ElementCategoryFilter windowsFilter = new ElementCategoryFilter(BuiltInCategory.OST_Windows);

                ElementLevelFilter levelFilter = new ElementLevelFilter(levelId);
                collector = new FilteredElementCollector(doc);
                ICollection<Element> allWindowsOnLevel1 = collector.WherePasses(windowsFilter).WherePasses(levelFilter).ToElements();

                foreach (Element window in allWindowsOnLevel1)
                {
                    Debug.WriteLine("Floor ID " + levelId + " window ID " + window.Id);
                }
            }

            // Get doors in each floor
            foreach (Element floor in myFloors)
            {
                ElementId levelId = floor.Id;
                ElementCategoryFilter doorsFilter = new ElementCategoryFilter(BuiltInCategory.OST_Doors);
                ElementLevelFilter levelFilter = new ElementLevelFilter(levelId);
                collector = new FilteredElementCollector(doc);
                ICollection<Element> allDoorsOnLevel1 = collector.WherePasses(doorsFilter).WherePasses(levelFilter).ToElements();

                foreach (Element doors in allDoorsOnLevel1)
                {
                    Debug.WriteLine("Floor ID " + levelId + " doors" +
                        " ID " + doors.Id);
                }
            }


            Building b = new Building(pi.Name, "", "", "", floors.Count, maxRoomCount);
            ComputeForm dialog = new ComputeForm(b, floors.Count);
            dialog.ShowDialog();
            return Result.Succeeded;
        }
    }
}
