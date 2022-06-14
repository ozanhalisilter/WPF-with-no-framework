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



namespace WPF_with_no_framework.ViewModel
{
    public partial class UserViewModel : ViewModelBase
    {

        private ObservableCollection<Person> _PeopleList;

        public UserViewModel()
        {
            PeopleList = new ObservableCollection<Person> //add delete eklenecek
            //add basinca yeni ekranda formdan veriyi al
            {
                new Person { Id = 1, FirstName = "Ozan", LastName = "Ilter", Age = 22 },
                new Person { Id = 2, FirstName = "Mehmet", LastName = "Keskin", Age = 42 },
                new Person { Id = 3, FirstName = "Hasan", LastName = "Yilmaz", Age = 25 },
                new Person { Id = 4, FirstName = "Osman", LastName = "Ilter", Age = 32 },
                new Person { Id = 5, FirstName = "John", LastName = "Doe", Age = 23 }
            };

            //CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(UserGrid.ItemsSource);
            //view.SortDescriptions.Add(new SortDescription("Age", ListSortDirection.Ascending));

            
            
        }

        public ObservableCollection<Person> PeopleList
        {
            get { return _PeopleList; }
            set { _PeopleList = value;
                OnPropertyChanged("PeopleList");
            }
        }


        private ICommand mUpdater;
        public ICommand UpdateUpdater
        {
            get
            {
                if (mUpdater == null)
                {
                    mUpdater = new Updater(); ;
                }
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }



    }



}
