using System.ComponentModel;
using static WPF_with_no_framework.ViewModel.UserViewModel;

namespace WPF_with_no_framework.ViewModel
{
    public class ViewModelBase
    {

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

   
    }
}