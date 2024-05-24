using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Rema1000LagerStyringsSystem
{
    public class jsonFileReaderItem
    {
        public static List<Item> ReadJson(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);
            using (var jsonFileReader = File.OpenText(JsonFileName)) { return JsonConvert.DeserializeObject<List<Item>>(jsonString); }
        }
    }
}
