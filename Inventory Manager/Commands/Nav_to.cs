using Inventory_Manager.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_template.Stores;

namespace Inventory_Manager.Commands
{
    class Nav_to : CommandBase
    {

        readonly NavStore nav;
        private readonly Func<ViewModelBase> _createViewModel; // nxt viewmodel


        public Nav_to(NavStore navigation, Func<ViewModelBase> createVM)
        {
            nav = navigation;
            _createViewModel = createVM;

        }
        public override void Execute(object parameter)
        {
            nav.CurrentViewModel = this._createViewModel();
        }
    }
}
