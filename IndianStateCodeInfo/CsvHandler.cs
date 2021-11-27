using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace IndianStateCodeInfo
{
    class CsvHandler
    {
        public static void Implement()
        {
            string importPath = @"C:\Users\soare\source\repos\Fellowship-program\IndianStateCodeInfo\IndianStateCodeInfo\StateCodeInformation.csv";
            string exportPath = @"C:\Users\soare\source\repos\Fellowship-program\IndianStateCodeInfo\IndianStateCodeInfo\StateCodeInformationFromCsv.json";
            //reading from csv
            using (var reader = new StreamReader(importPath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Rread data successfully from address.csv");
                foreach (AddressData addressData in records)
                {
                    Console.Write(" " + addressData.state);
                    Console.Write(" " + addressData.serialnumber);
                    Console.Write(" " + addressData.code);

                    Console.Write("\n");
                }
                Console.WriteLine("\n **Now reading from csv file and write to csv file**");

                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(exportPath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, records);
                }
            }
        }
    }
}
