﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory_Manager.ViewModels;

namespace WPF_template.Stores
{
    public class NavStore
    {
        private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel 
        { 
            get => _currentViewModel;
            set {
                _currentViewModel = value;
                OnCurrentViewModelChanged(); }
        }

        public event Action CurrentViewModelChanged;

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }

    }
}