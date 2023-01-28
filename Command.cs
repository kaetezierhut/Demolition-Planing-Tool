using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
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
        private static UIDocument uidoc;
        private static Document doc;
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiApp = commandData.Application;
            uidoc = uiApp.ActiveUIDocument;
            doc = uidoc.Document;

            FilteredElementCollector collector = new FilteredElementCollector(doc);
            ElementCategoryFilter filterFloor = new ElementCategoryFilter(BuiltInCategory.OST_Floors);
            IList<Element> floorList = collector.WherePasses(filterFloor).WhereElementIsNotElementType().ToElements();
            Debug.WriteLine(floorList.Count);

            foreach (Element floor in floorList)
            {
                Debug.WriteLine(floor.ToString());
            }
            Building b = new Building("", "", "", "", floorList.Count, 0);
            ComputeForm dialog = new ComputeForm(b, floorList.Count);
            dialog.ShowDialog();
            return Result.Succeeded;
        }
    }
}
