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
            // WasteID, Waste Name, price/billing, unit, exclusive to room, hazard
            // Group 1
        	{ "17 01 01", new string[]{ "concrete", "122", "kg", "false", "false" }},
            { "17 01 02", new string[]{ "bricks", "122", "kg", "false", "false" }},
            { "17 01 03", new string[]{ "tiles and ceramix", "122", "kg", "false", "false" }},
            { "17 01 06", new string[]{ "Mixtures of or separate fractions of concrete, bricks, tiles and ceramics containing hazardous substances", "122", "kg", "false", "true" }},
            { "17 01 07", new string[]{ "mixtures of concrete, bricks, tiles and ceramics other than those mentioned in 17 01 06", "122", "kg", "false", "false" }},
        	// Group 2
        	{ "17 02 01", new string[]{ "wood", "122", "kg", "false", "false" }},
            { "17 02 02", new string[]{ "glass", "122", "kg", "false", "false" }},
            { "17 02 03", new string[]{ "plastics", "122", "kg", "false", "false" }},
            { "17 02 04", new string[]{ "glass, plastics and wood containing hazardous substances or are contaminated by hazardous substances", "122", "kg", "false", "true" }},
        	// Group 3
        	{ "17 03 01", new string[]{ "coal tar bitumen mixtures", "122", "kg", "false", "true" }},
            { "17 03 02", new string[]{ "bitume mixtures other than those mentioned in 17 03 01", "122", "kg", "false", "false" }},
            { "17 03 03", new string[]{ "coal tar and tar-containing products", "122", "kg", "false", "true" }},
        	// Group 4
        	{ "17 04 01", new string[]{ "copper, bronze, brass", "122", "kg", "false", "false" }},
            { "17 04 02", new string[]{ "aluminium", "122", "kg", "false", "false" }},
            { "17 04 03", new string[]{ "lead", "122", "kg", "false", "false" }},
            { "17 04 04", new string[]{ "zinc", "122", "kg", "false", "false" }},
            { "17 04 05", new string[]{ "iron and steel", "122", "kg", "false", "false" }},
            { "17 04 06", new string[]{ "tin", "122", "kg", "false", "false" }},
            { "17 04 07", new string[]{ "mixed metals", "122", "kg", "false", "false" }},
            { "17 04 09", new string[]{ "Metal wastes contaminated by hazardous substances", "122", "kg", "false", "true" }},
            { "17 04 10", new string[]{ "cables containing oil, coal tar or other hazardous substances", "122", "kg", "false", "true" }},
            { "17 04 11", new string[]{ "cables other than those mentioned in 17 04 10", "122", "kg", "false", "false" }},
        	// Group 5
        	{ "17 05 03", new string[]{ "soil and stones containing hazardous substances", "122", "kg", "false", "true" }},
            { "17 05 04", new string[]{ "soil and stones other than those mentioned in 17 05 03", "122", "kg", "false" , "false" }},
            { "17 05 05", new string[]{ "Dredged material containing hazardous substances", "122", "kg", "false", "true" }},
            { "17 05 06", new string[]{ "Dredged material other than those mentioned in 17 05 05", "122", "kg", "false", "false" }},
            { "17 05 07", new string[]{ "Track ballast containing hazardous substances", "122", "kg", "false", "true" }},
            { "17 05 08", new string[]{ "track ballast other than those mentioned in 17 05 07", "122", "kg", "false", "false" }},
        	// Group 6
        	{ "17 06 01", new string[]{ "Insulation material containing asbestos", "122", "kg", "false", "true" }},
            { "17 06 03", new string[]{ "other insulation material containing hazardous or similar substances", "122", "kg", "false" , "true" }},
            { "17 06 04", new string[]{ "Insulation material other than those mentioned in 17 06 01 and 17 06 03", "122", "kg", "false", "false" }},
            { "17 06 05", new string[]{ "asbestos-containing building materials", "122", "kg", "false", "true" }},
        	// Group 8
        	{ "17 08 01", new string[]{ "Gypsum-based building materials contaminated by hazardous substances", "122", "kg", "false", "true" }},
            { "17 08 02", new string[]{ "Gypsum-based building materials other than those mentioned in 17 08 01", "122", "kg", "false", "false" }},
        	// Group 9
        	{ "17 09 01", new string[]{ "Construction and demolition waste containing mercury", "122", "kg", "false", "true" }},
            { "17 09 02", new string[]{ "e.g. PCB-containing sealants, PCB-containing resin-based floor coverings, PCB-containing insulating glazing, PCB-containing condensers", "122", "kg", "false" , "true" }},
            { "17 09 03", new string[]{ "other construction and demolition wastes (including mixed wastes) containing hazardous substances", "122", "kg", "false" , "true" }},
            { "17 09 04", new string[]{ "mixed construction and demolition wastes other than those mentioned in 17 09 01, 17 09 02 and 17 09 03", "122", "kg", "false" , "false" }},
        };

        public static Dictionary<string, string> unitData = new Dictionary<string, string>()
        {
            {"m3", "0.5.1 Room measure"},
            {"m2", "0.5.2 Area dimension"},
            {"cm2", "0.5.3 Area measurement"},
            {"m", "0.5.4 Length dimension"},
            {"pcs", "0.5.5 Quantity"},
            {"kg", "0.5.6 Mass"},
            {"t", "0.5.6 Mass"},
        };
    }   
}
