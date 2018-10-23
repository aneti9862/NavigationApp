﻿using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace TestApp.ViewModels
{
    public class ViewAViewModel : BindableBase, INavigationAware
    {
        public ViewAViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            Debug.WriteLine("Navigated From ViewA");
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
        }

        private INavigationService _navigationService;
    }
}
