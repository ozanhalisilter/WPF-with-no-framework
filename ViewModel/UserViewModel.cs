using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using WPF_with_no_framework.Model;
using WPF_with_no_framework.View;
using WPF_with_no_framework.ViewModel;
using System;
using System.Windows;

namespace WPF_with_no_framework.ViewModel
{
    public partial class UserViewModel : ViewModelBase
    {

        private ObservableCollection<Person> _PeopleList;
        public RelayCommand AddUser { get; set; }
        public RelayCommand AddCommand { get; set; }


        public void AddUserToList(object data)
        {
            this.PeopleList.Add(new Person { Id = PeopleList.Count + 1, FirstName = "Test", LastName = "LastName" + PeopleList.Count, Age = 34 });
            MessageBox.Show("Test");
            
        }


        public UserViewModel()
        {
            //this.AddCommand = new AddCommand(this.DataContext);

            AddCommand = new RelayCommand(AddMethod);

            AddUser = new RelayCommand(AddUserToList);

            this.PeopleList = new ObservableCollection<Person> //add delete eklenecek
            //add basinca yeni ekranda formdan veriyi al
            {
                new Person { Id = 1, FirstName = "Ozan", LastName = "Ilter", Age = 22 },
                new Person { Id = 2, FirstName = "Mehmet", LastName = "Keskin", Age = 42 },
                new Person { Id = 3, FirstName = "Hasan", LastName = "Yilmaz", Age = 25 },
                new Person { Id = 4, FirstName = "Osman", LastName = "Ilter", Age = 32 },
                new Person { Id = 5, FirstName = "John", LastName = "Doe", Age = 23 }
            };

            this.PeopleList.Add(new Person { Id = PeopleList.Count + 1, FirstName = "Test", LastName = "LastName", Age = 34 });

            //CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(UserGrid.ItemsSource);
            //view.SortDescriptions.Add(new SortDescription("Age", ListSortDirection.Ascending));



        }

        
        //add command using relay commands
        
       
            
        
        
        
        public void AddMethod(object data)
        {

            PoppupView window = new PoppupView();
            window.DataContext = this;
            window.Show();
            System.Windows.MessageBox.Show("Test");
        }
        public ObservableCollection<Person> PeopleList 
        {
            get { return _PeopleList; }
            set
            {
                _PeopleList = value;
                OnCollectionChanged("PeopleList");
                //OnPropertyChanged("PeopleList");
            }
        }
    



    private ICommand mUpdater;
    public ICommand UpdateUpdater
    {
        get
        {
            if (mUpdater == null)
            {
                mUpdater = new Commands(); ;
            }
            return mUpdater;
        }
        set
        {
            mUpdater = value;
        }
    }



        //private ICommand _commandOpenSettings;

        //public ICommand CmdOpenSetting
        //{
        //    get
        //    {
        //        if (_commandOpenSettings == null)
        //        {
        //            _commandOpenSettings = new AddCommand();
        //        }
        //        return _commandOpenSettings;
        //    }
        //}


    }



}
