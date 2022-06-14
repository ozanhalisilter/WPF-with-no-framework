﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF_with_no_framework.ViewModel;

namespace WPF_with_no_framework
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    
    
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            View.MainPage window = new View.MainPage();
                UserViewModel VM = new UserViewModel();
            window.DataContext = VM;
            window.Show();
        }
    }

}
