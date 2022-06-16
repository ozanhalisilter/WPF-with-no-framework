using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_MVVM_DevExpress.View;

namespace WPF_MVVM_DevExpress.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public ICommand Add { get; set; }
        public ICommand PopUp { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Person> theCol;



        public ObservableCollection<Person> PeopleList
        {
            get { return theCol; }
            set { theCol = value; OnPropertyChanged("TheCol"); }
        }


        public MainWindowViewModel()
        {
            PeopleList = new ObservableCollection<Person>();
            Add = new RelayCommand(AddCommand);
            PopUp = new RelayCommand(OpenPopUpMethod);



        }





        private void AddCommand(object obj)
        {
            this.PeopleList.Add(new Person { Id = PeopleList.Count + 1, FirstName = "Test", LastName = "LastName", Age = (PeopleList.Count * 17) % 30 });
        }

        private void OpenPopUpMethod(object obj)
        {
            View.PopUpView window = new View.PopUpView();
            window.DataContext = new PopUpViewModel(PeopleList);
            window.Show();
        }

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }














    public class RelayCommand : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return this.canExecute == null || this.canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }
}
