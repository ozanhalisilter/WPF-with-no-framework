using System;
using System.Windows.Input;



namespace WPF_with_no_framework.ViewModel
{

    // Bu classı başka bir .cs dosyasında mı barındırmalıyım?
    public class Commands : ICommand
    {
        public bool CanExecute(object param) { return true; } // IF the return val is 1 it executes rest 

        public event EventHandler CanExecuteChanged;
        public void Execute(object param) { }
    }

    //public class AddCommand : ICommand

    //{
    //    public UserViewModel ViewModel { get; set; }
    //    public AddCommand(UserViewModel viewModel)
    //    {
    //        this.ViewModel = viewModel;
    //    }
    //    public bool CanExecute(object param) { return true; } // IF the return val is 1 it executes rest 

    //    public event EventHandler CanExecuteChanged;
    //    public void Execute(object param)
    //    {

    //        this.ViewModel.AddMethod();
        
    
    //public class ButtonCommand : ICommand

    //{
    //    ButtonViewModel _buttonViewModel;
    //    public ButtonCommand(ButtonViewModel viewModel)
    //    {
    //        _buttonViewModel = viewModel;
    //    }
    //    public event EventHandler CanExecuteChanged;

    //    public bool CanExecute(object parameter)
    //    {
    //        return true;
    //    }

    //    public void Execute(object parameter)
    //    {
    //        _buttonViewModel.OnExecute();   
    //    }



}




