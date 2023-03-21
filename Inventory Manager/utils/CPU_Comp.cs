using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Manager.utils
{
    class CPU_Comp:ComponentBase
    {
        //component specific information

        //Chipset  eg AM4

        public String Chipset {get; set;}

        // CPU name eg 5800x 
        public String Name { get; set; }

        // number of cores eg 8
        public int NoCores { get; set; }

        //base and boost freq
        public float BaseFreq { get; set; }

        public float BoostFreq { get; set; }

        public Boolean FreeCooler { get; set; }

        public CPU_Comp(string chipset, string name, int noCores, float baseFreq, float boostFreq, [Optional] bool freeCooler)
        {
            this.ComponentType=Type.CPU;
            Chipset = chipset;
            Name = name;
            NoCores = noCores;
            BaseFreq = baseFreq;
            BoostFreq = boostFreq;
            this.FreeCooler = freeCooler;
        }
    }
}
