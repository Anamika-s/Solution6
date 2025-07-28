using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


using System.Xml.Serialization;
using System.Xml.Linq;
using System.Text.Json;

namespace BinaryFormatterDemo
{
    public class MyData
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Items { get; set; }
    }
    class Program
    {
        static void Main()
        {

            string jsonFilePath = "data.json";
            MyData newData = new MyData
            {
                Name = "Jane Doe",
                Age = 30,
                Items = new List<string> { "Apple", "Banana", "Orange" }
            };

            string newJsonString = System.Text.Json.JsonSerializer.Serialize(newData, new JsonSerializerOptions { WriteIndented = true }); // Optional: for pretty-printing
            //string jsonFilePath = "data.json";

            File.WriteAllText(jsonFilePath, newJsonString);

            Console.WriteLine($"Object serialized to {jsonFilePath}");
            string jsonString = File.ReadAllText(jsonFilePath);

            MyData data = System.Text.Json.JsonSerializer.Deserialize<MyData>(jsonString);

            // Now 'data' object contains the deserialized information
            Console.WriteLine($"Name: {data.Name}, Age: {data.Age}");
        }
    }
}