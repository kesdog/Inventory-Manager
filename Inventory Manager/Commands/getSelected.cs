using Inventory_Manager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Manager.Commands
{
    class getSelected : CommandBase
    {

        NewComponentViewModel vm;
        public override void Execute(object parameter)
        {
             vm.Condition = parameter.ToString();
        }
        public getSelected(NewComponentViewModel CurrentVM)
        {
            vm= CurrentVM;
        }
    }
}
