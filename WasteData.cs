using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Demolition_Planing_Tool
{
    internal class WasteData
    {
        public static Dictionary<string, string[]> wasteData = new Dictionary<string, string[]>()
        {
            // WasteID, Waste Name, price/billing?, unit, exclusive for room?
            // Group 1
            { "11", new string[]{"Beton", "122", "kg", "true" }},
            { "12", new string[]{"Beton", "122", "kg", "true" }},
            { "13", new string[]{"Beton", "122", "kg", "true" }},
            { "16", new string[]{"Beton", "122", "kg", "true" }},
            { "17", new string[]{"Beton", "122", "kg", "true" }},
            // Group 2
            { "21", new string[]{"Beton", "122", "kg", "true" }},
            { "22", new string[]{"Beton", "122", "kg", "true" }},
            { "23", new string[]{"Beton", "122", "kg", "true" }},
            { "24", new string[]{"Beton", "122", "kg", "true" }},
            // Group 3
            { "31", new string[]{"Beton", "122", "kg", "true" }},
            { "32", new string[]{"Beton", "122", "kg", "true" }},
            // Group 4
            { "41", new string[]{"Beton", "122", "kg", "true" }},
            { "42", new string[]{"Beton", "122", "kg", "true" }},
            { "43", new string[]{"Beton", "122", "kg", "true" }},
            { "44", new string[]{"Beton", "122", "kg", "true" }},
            { "45", new string[]{"Beton", "122", "kg", "true" }},
            { "46", new string[]{"Beton", "122", "kg", "true" }},
            { "47", new string[]{"Beton", "122", "kg", "true" }},
            { "48", new string[]{"Beton", "122", "kg", "true" }},
            { "49", new string[]{"Beton", "122", "kg", "true" }},
            { "410", new string[]{"Beton", "122", "kg", "true" }},
            { "411", new string[]{"Beton", "122", "kg", "true" }},
            // Group 5
            { "53", new string[]{"Beton", "122", "kg", "true" }},
            { "54", new string[]{"Beton", "122", "kg", "true" }},
            { "55", new string[]{"Beton", "122", "kg", "true" }},
            { "56", new string[]{"Beton", "122", "kg", "true" }},
            { "57", new string[]{"Beton", "122", "kg", "true" }},
            { "58", new string[]{"Beton", "122", "kg", "true" }},
            // Group 6
            { "61", new string[]{"Beton", "122", "kg", "true" }},
            { "63", new string[]{"Beton", "122", "kg", "true" }},
            { "64", new string[]{"Beton", "122", "kg", "true" }},
            { "65", new string[]{"Beton", "122", "kg", "true" }},
            // Group 8 
            { "81", new string[]{"Beton", "122", "kg", "true" }},
            { "82", new string[]{"Beton", "122", "kg", "true" }},
            // Group 9
            { "91", new string[]{"Beton", "122", "kg", "true" }},
            { "92", new string[]{"Beton", "122", "kg", "true" }},
            { "93", new string[]{"Beton", "122", "kg", "true" }},
            { "94", new string[]{"Beton", "122", "kg", "true" }},
        };  
    }   
}
