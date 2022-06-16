using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF_MVVM_DevExpress.ViewModel;

namespace WPF_MVVM_DevExpress
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            View.MainWindow window = new View.MainWindow();
            MainWindowViewModel VM = new MainWindowViewModel();
            window.DataContext = VM;
            window.Show();
        }
    }
}
