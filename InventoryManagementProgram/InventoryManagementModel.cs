using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementProgram
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
        public int Weight;
        public int Price;
    }

    public class Pulses
    {
        public string name;
        public int Weight;
        public int Price;
    }
    public class Wheat
    {
        public string name;
        public int Weight;
        public int Price;
    }
}
