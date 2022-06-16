using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


public class Person : INotifyPropertyChanged
{

    private string firstName;
    private string lastName ;
    private int age;
    private int id = 0;

    public int Id
    {
        get { return id; }
        set
        {
            id = value;
            OnPropertyChanged("Id");
        }
    }
    public string FirstName
    {
        get
        {
            return firstName;
        }
        set
        {
            firstName = value;
            OnPropertyChanged("FirstName");
        }
    }
    public string LastName
    {
        get { return lastName; }
        set
        {
            lastName = value;
            OnPropertyChanged("LastName");
        }
    }
    public int Age
    {
        get { return age; }
        set
        {
            age = value;
            OnPropertyChanged("Age");
        }
    }



    public event PropertyChangedEventHandler PropertyChanged;
    private void OnPropertyChanged(string propertyName)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }



}

