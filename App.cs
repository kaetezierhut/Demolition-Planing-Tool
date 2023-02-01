using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.UI;
using System.Windows.Media.Imaging;
using System.IO;


namespace Demolition_Planing_Tool
{
    public class App : IExternalApplication
    {
        static string thisAssemblyPath = typeof(App).Assembly.Location;//path: the loaction is ../bin/Debug folder

        public Result OnStartup(UIControlledApplication application)
        {
            String panelName = "Open Demolition Planning Tool"; // the name of panel

            RibbonPanel ribbonDemoPanel = application.CreateRibbonPanel(panelName); // create a new RibbonPanel on the Addin tab

            PushButton myButton = (PushButton)ribbonDemoPanel.AddItem(new PushButtonData(
                "Demolition Planning Tool",
                "Demolition Planning Tool",
                thisAssemblyPath,
                "Demolition_Planing_Tool.CustomControl1")
            );

            //set the icon of button
            string ButtonIconsFolder = Path.GetDirectoryName(thisAssemblyPath); //path: the loaction is ../bin/Debug folder

            //myButton.LargeImage = new BitmapImage(new Uri(Path.Combine(ButtonIconsFolder, "tiger_35x35.png"), UriKind.Absolute)); //choose the .png with pixel 35x35. The size of the pixel is more appropriate
            //Bild in den bin-debug ordner drin haben, da wo auch das ganze dll zeug abliegt (bei der Fork)
            myButton.ToolTip = "Click to get the tiger image"; //tip of button

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

    }
}


