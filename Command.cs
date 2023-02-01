using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Architecture;
using Autodesk.Revit.UI;
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

            Building b = new Building(pi.Name, "", "", "", floors.Count, maxRoomCount);

            List<Floor> floorBuilding = b.GetFloors();

            for (int i = 0; i < floorBuilding.Count; i++)
            {
                floorBuilding[i].FloorIdRevit = floors[i].Id.ToString();
            }

            for (int i = 0; i < floorBuilding.Count; i++)
            {
                List<Autodesk.Revit.DB.Architecture.Room> floorRevitRooms = allRooms[i];
                List<Room> floorRooms = floorBuilding[i].GetRoomsList();
                for (int j = 0; j < floorRevitRooms.Count; j++)
                {
                    floorRooms[i].RoomIdRevit = floorRevitRooms[i].Id.ToString();
                }
            }

            ComputeForm dialog = new ComputeForm(b, floors.Count);

            List<List<List<Material>>> floorsWallMaterial = new List<List<List<Material>>>();
            // Get walls will be assigned to floor
            for (int i = 0; i < myFloors.Count; i++)
            {
                ElementId levelId = myFloors.ElementAt(i).Id;

                ElementLevelFilter levelFilter = new ElementLevelFilter(levelId);
                collector = new FilteredElementCollector(doc);
                ICollection<Element> allWallsOnLevel1 = collector.OfClass(typeof(Wall)).WherePasses(levelFilter).ToElements();
                List<List<Material>> floorWallMaterial = new List<List<Material>>();
                foreach (Element wall in allWallsOnLevel1)
                {
                    Wall w = wall as Wall;
                    WallType a = w.WallType;
                    List<Material> WallMaterial = new List<Material>();
                    if (WallKind.Basic == a.Kind)
                    {
                        foreach (CompoundStructureLayer structureLayer in a.GetCompoundStructure().GetLayers())
                        {
                            Material layerMaterial = doc.GetElement(structureLayer.MaterialId) as Material;
                            WallMaterial.Add(layerMaterial);
                            string convertedWasteID = ConvertRevitIDToWasteID(layerMaterial.Id.ToString());
                            Waste wallWaste = new Waste(convertedWasteID, 1);
                            dialog.itemBox.Add(wallWaste);
                            floorBuilding[i].AddWaste(wallWaste);
                            dialog.UpdateListBox(convertedWasteID, i, "None", 1,
                            wallWaste.Billing, wallWaste.Unit, wallWaste.Hazardous ? "yes" : "no", wallWaste.Billing * wallWaste.Quantities);
                        }
                    }
                    else
                    {
                        //Debug.WriteLine("Floor ID " + levelId + "Wall ID " + wall.Id + " Wall Name " + wall.Name);
                    }
                    floorWallMaterial.Add(WallMaterial);
                }
                floorsWallMaterial.Add(floorWallMaterial);
            }

            // Get windows in each floor
            List<List<List<Material>>> floorsWindowsMaterial = new List<List<List<Material>>>();
            for (int i = 0; i < myFloors.Count; i++)
            {
                ElementId levelId = myFloors.ElementAt(i).Id;
                ElementCategoryFilter windowsFilter = new ElementCategoryFilter(BuiltInCategory.OST_Windows);

                ElementLevelFilter levelFilter = new ElementLevelFilter(levelId);
                collector = new FilteredElementCollector(doc);
                ICollection<Element> allWindowsOnLevel1 = collector.WherePasses(levelFilter).WherePasses(windowsFilter).ToElements();
                List<List<Material>> floorWindowMaterial = new List<List<Material>>();
                foreach (Element window in allWindowsOnLevel1)
                {
                    FamilyInstance wFamily = window as FamilyInstance;
                    List<Material> windowMaterial = new List<Material>();
                    foreach (ElementId materialId in wFamily.GetMaterialIds(false))
                    {
                        Material material = wFamily.Document.GetElement(materialId) as Material;
                        windowMaterial.Add(material);
                        string convertedWasteID = ConvertRevitIDToWasteID(material.Id.ToString());
                        Waste wallWaste = new Waste(convertedWasteID, 1);
                        dialog.itemBox.Add(wallWaste);
                        floorBuilding[i].AddWaste(wallWaste);
                        dialog.UpdateListBox(convertedWasteID, i, "None", 1,
                        wallWaste.Billing, wallWaste.Unit, wallWaste.Hazardous ? "yes" : "no", wallWaste.Billing * wallWaste.Quantities);
                    }
                    floorWindowMaterial.Add(windowMaterial);
                }
                floorsWindowsMaterial.Add(floorWindowMaterial);
            }

            // Get doors in each floor
            List<List<List<Material>>> floorsDoorsMaterial = new List<List<List<Material>>>();
            for (int i = 0; i < myFloors.Count; i++)
            {
                ElementId levelId = myFloors.ElementAt(i).Id;
                ElementCategoryFilter doorsFilter = new ElementCategoryFilter(BuiltInCategory.OST_Doors);
                ElementLevelFilter levelFilter = new ElementLevelFilter(levelId);
                collector = new FilteredElementCollector(doc);
                ICollection<Element> allDoorsOnLevel1 = collector.WherePasses(levelFilter).WherePasses(doorsFilter).ToElements();
                List<List<Material>> floorDoorMaterial = new List<List<Material>>();
                foreach (Element door in allDoorsOnLevel1)
                {
                    FamilyInstance wFamily = door as FamilyInstance;
                    List<Material> doorMaterial = new List<Material>();
                    foreach (ElementId materialId in wFamily.GetMaterialIds(false))
                    {
                        Material material = wFamily.Document.GetElement(materialId) as Material;
                        doorMaterial.Add(material);
                        string convertedWasteID = ConvertRevitIDToWasteID(material.Id.ToString());
                        Waste wallWaste = new Waste(convertedWasteID, 1);
                        dialog.itemBox.Add(wallWaste);
                        floorBuilding[i].AddWaste(wallWaste);
                        dialog.UpdateListBox(convertedWasteID, i, "None", 1,
                        wallWaste.Billing, wallWaste.Unit, wallWaste.Hazardous ? "yes" : "no", wallWaste.Billing * wallWaste.Quantities);
                    }
                    floorDoorMaterial.Add(doorMaterial);
                }
                floorsDoorsMaterial.Add(floorDoorMaterial);
            }

            dialog.ShowDialog();
            return Result.Succeeded;
        }

        private string ConvertRevitIDToWasteID(string revitId)
        {
            string convert = "";
            switch (revitId)
            {
                case "96504": // Holz - Birkematerial
                    convert = "17 02 01"; break;
                case "3570": // Metall - Lackiert - Graumaterial 
                    convert = "17 04 07"; break;
                case "3550": // Metall - Chrommaterial
                    convert = "17 04 07"; break;
                case "303547": // Glas - Mattglasmateria
                    convert = "17 02 02"; break;
                case "4073": // Glasmaterial
                    convert = "17 02 02"; break;
                case "3765": // Kunststoff - Weißmaterial
                    convert = "17 02 03"; break;
                case "3345": // Stahlbeton - Ortbeton
                    convert = "17 01 07"; break;
                case "3358": // Gipswandbauplatte
                    convert = "17 01 03"; break;
                case "3355": // Wärmedämmung - hart
                    convert = "17 01 07"; break;
                case "3587": // Mauerwerk - Sichtmauerwerk
                    convert = "17 01 02"; break;
            }
            return convert;
        }
    }
}
