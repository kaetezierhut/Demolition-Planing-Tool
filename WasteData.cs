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
            {"17 01 01", new string[]{"Concrete", "122", "kg", "true" }},
            {"17 01 02", new string[]{"Bricks", "122", "kg", "true" }},
            {"17 01 03", new string[]{"Tiles and ceramix", "122", "kg", "true" }},
            {"17 01 06", new string[]{"Mixtures of or separate fractions of concrete, bricks, tiles and ceramics containing hazardous substances", "122", "kg", "true" }},
            {"17 01 07", new string[]{"Mixtures of concrete, bricks, tiles and ceramics other than those mentioned in 17 01 06", "122", "kg", "true" }},
        	// Group 2
        	{"17 02 01", new string[]{"Wood", "122", "kg", "true" }},
            {"17 02 02", new string[]{"Glass", "122", "kg", "true" }},
            {"17 02 03", new string[]{"Plastics", "122", "kg", "true" }},
            {"17 02 04", new string[]{"Glass, plastics and wood containing hazardous substances or are contaminated by hazardous substances", "122", "kg", "true" }},
        	// Group 3
        	{"17 03 01", new string[]{"Coal tar bitumen mixtures", "122", "kg", "true" }},
            {"17 03 02", new string[]{"Bitume mixtures other than those mentioned in 17 03 01", "122", "kg", "true" }},
            {"17 03 03", new string[]{"Coal tar and tar-containing products", "122", "kg", "true" }},
        	// Group 4
        	{"17 04 01", new string[]{"Copper, bronze, brass", "122", "kg", "true" }},
            {"17 04 02", new string[]{"Aluminium", "122", "kg", "true" }},
            {"17 04 03", new string[]{"Lead", "122", "kg", "true" }},
            {"17 04 04", new string[]{"Zinc", "122", "kg", "true" }},
            {"17 04 05", new string[]{"Iron and steel", "122", "kg", "true" }},
            {"17 04 06", new string[]{"Tin", "122", "kg", "true" }},
            {"17 04 07", new string[]{"Mixed metals", "122", "kg", "true" }},
            {"17 04 09", new string[]{"Metal wastes contaminated by hazardous substances", "122", "kg", "true" }},
            {"17 04 10", new string[]{"Cables containing oil, coal tar or other hazardous substances", "122", "kg", "true" }},
            {"17 04 11", new string[]{"Cables other than those mentioned in 17 04 10", "122", "kg", "true" }},
        	// Group 5  
        	{"17 05 03", new string[]{"Soil and stones containing hazardous substances", "122", "kg", "true" }},
            {"17 05 04", new string[]{"Soil and stones other than those mentioned in 17 05 03", "122", "kg", "true" }},
            {"17 05 05", new string[]{"Dredged material containing hazardous substances", "122", "kg", "true" }},
            {"17 05 06", new string[]{"Dredged material other than those mentioned in 17 05 05", "122", "kg", "true" }},
            {"17 05 07", new string[]{"Track ballast containing hazardous substances", "122", "kg", "true" }},
            {"17 05 08", new string[]{"Track ballast other than those mentioned in 17 05 07", "122", "kg", "true" }},
        	// Group 6
        	{"17 06 01", new string[]{"Insulation material containing asbestos", "122", "kg", "true" }},
            {"17 06 03", new string[]{"Other insulation material containing hazardous or similar substances", "122", "kg", "true" }},
            {"17 06 04", new string[]{"Insulation material other than those mentioned in 17 06 01 and 17 06 03", "122", "kg", "true" }},
            {"17 06 05", new string[]{"Asbestos-containing building materials", "122", "kg", "true" }},
        	// Group 8
        	{"17 08 01", new string[]{"Gypsum-based building materials contaminated by hazardous substances", "122", "kg", "true" }},
            {"17 08 02", new string[]{"Gypsum-based building materials other than those mentioned in 17 08 01", "122", "kg", "true" }},
        	// Group 9
        	{"17 09 01", new string[]{"Construction and demolition waste containing mercury", "122", "kg", "true" }},
            {"17 09 02", new string[]{"E.g., PCB-containing sealants, PCB-containing resin-based floor coverings, PCB-containing insulating glazing, PCB-containing condensers", "122", "kg", "true" }},
            {"17 09 03", new string[]{"Other construction and demolition wastes (including mixed wastes) containing hazardous substances", "122", "kg", "true" }},
            {"17 09 04", new string[]{"Mixed construction and demolition wastes other than those mentioned in 17 09 01, 17 09 02 and 17 09 03", "122", "kg", "true" }},
        };  
    }   
}
