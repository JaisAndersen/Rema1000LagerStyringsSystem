using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Schema;
using Rema1000LagerStyringsSystem.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Rema1000LagerStyringsSystem.JsonHelpers
{
    public class jsonFIleReaderItem
    {
        public static List<Item> ReadJson(string JsonFileName)
        {
            string jsonString = File.ReadAllText(JsonFileName);
            using (var jsonFileReader = File.OpenText(JsonFileName)) { return JsonConvert.DeserializeObject<List<Item>>(jsonString); }
        }
    }
}
