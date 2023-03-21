using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Inventory_Manager.ViewModels;
using WPF_template.Stores;

namespace Inventory_Manager
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavStore nav;
        
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(nav)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }

        public App() 
        {
            nav = new NavStore();
            nav.CurrentViewModel = createStrtScrnViewmodel();
        }
        // innit every VM at this level

        private StartScrnViewModel createStrtScrnViewmodel()
        {
            return new StartScrnViewModel(nav,CreateNewComponentViewModel, CreateNewBuildViewModel);
        }
        private NewComponentViewModel CreateNewComponentViewModel()
        {
            return new NewComponentViewModel(nav, createStrtScrnViewmodel,null);
        }
        private New_Build_ViewModel CreateNewBuildViewModel() 
        {
            return new New_Build_ViewModel(nav,createStrtScrnViewmodel,null);
        }
    }
}
