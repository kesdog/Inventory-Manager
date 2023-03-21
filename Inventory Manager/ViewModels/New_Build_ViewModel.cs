using Inventory_Manager.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_template.Stores;

namespace Inventory_Manager.ViewModels
{
    class New_Build_ViewModel:ViewModelBase
    {
        private NavStore nav;
        public ICommand nav_back { get; }

        public New_Build_ViewModel(NavStore navigation, Func<ViewModelBase> prevVM, Func<ViewModelBase> nextVM) 
        {
            nav= navigation;
            nav_back = new Nav_to(nav, prevVM);
        }
    }
}
