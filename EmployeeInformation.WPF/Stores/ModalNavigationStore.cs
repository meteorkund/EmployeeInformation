﻿using EmployeeInformation.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInformation.WPF.Stores
{
    public class ModalNavigationStore
    {
        private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel = value;
                CurrentViewModelChanged?.Invoke();
            }
        }


        public bool IsOpen => CurrentViewModel != null;
        public event Action CurrentViewModelChanged;

        public void Close()
        {
            CurrentViewModel = null;
        }
    }
}
