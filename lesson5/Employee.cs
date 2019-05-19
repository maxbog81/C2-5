using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class Employee //: INotifyPropertyChanged
    {        
        public ObservableCollection<Employee> ListEmp = new ObservableCollection<Employee>();

        public string Name { get; set; }
        public Employee(string name)
        {
            Name = name;
        }

        public Employee()
        {
        }

        //public event PropertyChangedEventHandler PropertyChanged;
        //public void OnPropertyChanged([CallerMemberName]string prop = "")
        //{
        //    if (PropertyChanged != null)
        //        PropertyChanged(this, new PropertyChangedEventArgs(prop));
        //}

        public void AddElement()
        {
            for (int i = 0; i < 10; i++)
            {
                ListEmp.Add(new Employee($"Имя_{i}"));
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
