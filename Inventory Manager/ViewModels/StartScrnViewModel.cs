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
    class StartScrnViewModel : ViewModelBase
    {
        private NavStore nav;

        public ICommand navToNewComp { get; }
        public ICommand navToViewInv {get;}
        public ICommand navToNewBuild { get; }
        
        public StartScrnViewModel(NavStore navigation,Func<ViewModelBase> newComponentVM, Func<ViewModelBase>  newBuildVM) 
        {
            nav = navigation;

            navToNewComp= new Nav_to(nav,newComponentVM);
            navToNewBuild = new Nav_to(nav, newBuildVM);

        } 
    }
}
