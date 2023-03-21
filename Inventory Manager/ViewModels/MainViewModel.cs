using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_template.Stores;

namespace Inventory_Manager.ViewModels
{
    class MainViewModel:ViewModelBase
    {
        NavStore nav;
        public ViewModelBase CurrentViewModel => nav.CurrentViewModel;

        public MainViewModel(NavStore navigation) 
        {
            nav= navigation;
            nav.CurrentViewModelChanged += OncurrentViewModelChanged;
        }

        private void OncurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
