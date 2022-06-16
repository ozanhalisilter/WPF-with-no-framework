﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPF_MVVM_DevExpress.ViewModel
{


    public class PopUpViewModel : MainWindowViewModel
    {
        public ICommand AddForm { get; set; }

        public Person person;

        public Person Person
        {
            get { return person; }
            set { person = value; OnPropertyChanged("Person"); }
        }
        public PopUpViewModel(ObservableCollection<Person> peopleList)
        {
            PeopleList = peopleList;
            Person = new Person();
            AddForm = new RelayCommand(AddUser);

        }

        private bool IsInPeopleList(int Id)
        {
            for (int i = 0; i < PeopleList.Count; i++)
            {
                if (Id == PeopleList[i].Id)
                {
                    return true;
                    break;
                }
            }
            return false;
        }

        private int FindNextId(int x = 0)
        {
            if (IsInPeopleList(x))
            {
                return FindNextId(x + 1);
            }
            else
            {
                return x;
            }

        }
        private void AddUser(object obj)
        {
            //code checks for all inputs
            if (Person.FirstName == "" || Person.LastName == "" || Person.Age == 0)
            {
                MessageBox.Show("Please fill in all fields");
            }
            else
            {
                if (IsInPeopleList(Person.Id))
                {
                    Person.Id = FindNextId(PeopleList.Count);

                }
                PeopleList.Add(Person);
                Person = new Person();
            }
            //code that checks if Person.Id peoplelist or 


















            //Person.Id = PeopleList.Count + 1;
            //Person.Age = 5;
            //Person.FirstName = "";
            //Person.LastName = "";


        }


    }


}
