using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Manager.utils
{
    public abstract class ComponentBase
    {
        // every PC component will have:
        //Cost set once  any changes to that later done through here
        private float Cost;
        //realease date
        public DateTime ReleaseDate { get; set; }           //may change to protected later
        //condition  new/used
        public Boolean condition { get; set; }
        //aquired date
        public DateTime AquiredDate { get; set; }

        //has component been tested (is is actually ready for use)

        public Boolean ready { get; set; }


        // an exaustive list types of components
        public enum Type
        {
            CPU,
            GPU,
            MotherBoard,
            RAM,
            PSU,
            Fan,
            Storage,
        }
        public Type ComponentType { get; set; }
        public String manufacturer;

        public override string ToString()
        {
            switch (this.ComponentType)
            {
                case Type.CPU:
                    return "CPU manufactured by: " + this.manufacturer + "/n"+"Release date: "+this.ReleaseDate;


                case Type.GPU:
                    break;
                case Type.MotherBoard:
                    break;
                case Type.RAM:
                    break;
                case Type.PSU:
                    break;
                case Type.Fan:
                    break;
                case Type.Storage:
                    break;



            }
            
            
            
            return base.ToString();
        }

    }
}
