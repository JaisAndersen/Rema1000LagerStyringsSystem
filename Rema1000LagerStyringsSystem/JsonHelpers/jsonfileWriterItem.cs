using System.Collections.Generic;
using System.IO;

namespace Rema1000LagerStyringsSystem
{
    public class jsonFileWriterItem
    {
        public static void WriteToJson(List<Item> Items, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(Items, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }
    }
}
