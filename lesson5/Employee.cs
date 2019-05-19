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
        Random r = new Random();
        public ObservableCollection<Employee> ListEmp = new ObservableCollection<Employee>();

        public string Name { get; set; }
        public string Dept { get; set; }
        public Employee(string name,string dept)
        {
            Name = name;
            Dept = dept;
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
                ListEmp.Add(new Employee($"Имя_{i}", $"Подразд_{r.Next(100, 103)}"));
            }
        }

        public override string ToString()
        {
            return Name+" - " +Dept;
        }
    }
}
