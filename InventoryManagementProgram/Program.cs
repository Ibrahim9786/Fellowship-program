using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = "E:/B1.json/Inventory.json";
            Console.WriteLine("welcom to the inventort data management");

            ReadingInventoryData readingInventoryData = new ReadingInventoryData();
            InventoryManagementModel data = readingInventoryData.Read(Path);

            Console.WriteLine("Rice Details");
            for (int i = 0; i < data.Rice.Count; i++)
            {
                int valueOfRice = data.Rice[i].Weight * data.Rice[i].Price;
                //Console.WriteLine("Name: " + data.Rice[i].name + "Weight: " + data.Rice[i].Weight + "price: " + data.Rice[i].Price);
                Console.WriteLine("The value of {0} is {1} ", data.Rice[i], valueOfRice);
                Console.WriteLine("-------------------------");
            }
            Console.WriteLine("Pulses Details");
            for (int i = 0; i < data.Pulses.Count; i++)
            {
                int valueOfPulses = data.Pulses[i].Weight * data.Pulses[i].Price;
                //Console.WriteLine("Name: " + data.Pulses[i].name + "Weight: " + data.Pulses[i].Weight + "price: " + data.Pulses[i].Price); 
                Console.WriteLine("The value of {0} is {1} ", data.Pulses[i], valueOfPulses);
                Console.WriteLine("-------------------------");
            }
            Console.WriteLine("Wheat Details");
            for (int i = 0; i < data.Wheat.Count; i++)
            {
                int valueOfWheat = data.Wheat[i].Weight * data.Wheat[i].Price;
                //Console.WriteLine("Name: " + data.Wheat[i].name + "Weight: " + data.Wheat[i].Weight + "price: " + data.Wheat[i].Price);
                Console.WriteLine("The value of {0} is {1} ", data.Wheat[i], valueOfWheat);
                Console.WriteLine("-------------------------");
            }
            Console.ReadKey();
        }
    }
}
