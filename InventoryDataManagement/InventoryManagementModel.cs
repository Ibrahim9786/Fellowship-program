using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryDataManagement
{
    public class InventoryManagementModel
    {
        public List<Rice> Rice;
        public List<Pulses> Pulses;
        public List<Wheat> Wheat;
    }
    public class Rice
    {
        public string name;
        public string weight;
        public int price;
    }
    public class Pulses
    {
        public string name;
        public string weight;
        public int price;
    }
    public class Wheat
    {
        public string name;
        public string weight;
        public int price;
    }
}
