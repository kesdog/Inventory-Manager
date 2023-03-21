using Inventory_Manager.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_template.Stores;

namespace Inventory_Manager.ViewModels
{
    class NewComponentViewModel:ViewModelBase
    {
        private NavStore nav;

        private float _cost;

        public float Cost
        {
            get { return _cost; }
            set
            {
                _cost = value;
                OnPropertyChanged(nameof(Cost));

            }
        }
        private String _type;
        

        public String Type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }

        private String _condition;

        public String Condition
        {
            get
            {
                return _condition;
            }
            set
            {
                _condition = value;
                OnPropertyChanged(nameof(Condition));
            }
        }

        public ICommand getSelected { get; }
        public ICommand nav_back { get; }

        public ICommand createCPU { get; }
        public ICommand showCPU { get; }
        public NewComponentViewModel( NavStore navigation,Func<ViewModelBase> prevVm,Func<ViewModelBase> nxtVM)
        {
            this.nav=navigation;
            this.getSelected = new getSelected(this);
            nav_back = new Nav_to(nav, prevVm);

        }

       

    }
}
