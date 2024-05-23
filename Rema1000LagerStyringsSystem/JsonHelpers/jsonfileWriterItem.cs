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
    public class jsonfileWriterItem
    {
        public static void WriteToJson(List<Item> Items, string JsonFileName)
        {
            string output = Newtonsoft.Json.JsonConvert.SerializeObject(Items, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(JsonFileName, output);
        }
    }
}
