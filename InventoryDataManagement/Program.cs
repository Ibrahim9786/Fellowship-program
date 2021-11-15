using System;

namespace InventoryDataManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            String Path = "C:/Users/soare/source/repos/Fellowship-program/InventoryDataManagement/InventoryDataManagement/Inventory.json";
            Console.WriteLine("Welcome to the Inventory Data Management!");

            ReadInventoryData readInventoryData = new ReadInventoryData();
            InventoryManagementModel data = readInventoryData.Read(Path);

            for(int i = 0; i < data.Rice.Count; i++)
            {
                Console.WriteLine("Rice details");
                Console.WriteLine("Name : " + data.Rice[i].name + "Weight : " + data.Rice[i].weight + "Price : " + data.Rice[i].price);
                Console.WriteLine("-------------------------------------------");
            }
            for (int i = 0; i < data.Pulses.Count; i++)
            {
                Console.WriteLine("Pulses details");
                Console.WriteLine("Name : " + data.Pulses[i].name + "Weight : " + data.Pulses[i].weight + "Price : " + data.Pulses[i].price);
                Console.WriteLine("--------------------------------------------");
            }
            for (int i = 0; i < data.Wheat.Count; i++)
            {
                Console.WriteLine("Wheat details");
                Console.WriteLine("Name : " + data.Wheat[i].name + "Weight : " + data.Wheat[i].weight + "Price : " + data.Wheat[i].price);
                Console.WriteLine("--------------------------------------------");
            }
        }
    }
}
