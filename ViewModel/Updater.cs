using System;
using System.Windows.Input;



namespace WPF_with_no_framework.ViewModel
{
    public partial class UserViewModel
    {
        // Bu classı başka bir .cs dosyasında mı barındırmalıyım?
        private class Updater : ICommand
        {
            public bool CanExecute(object param) { return true; } // IF the return val is 1 it executes rest 

            public event EventHandler CanExecuteChanged;
            public void Execute(object param) { }
        }



    }



}
