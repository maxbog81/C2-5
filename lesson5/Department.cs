using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    class Department //: INotifyPropertyChanged
    {
        Random r = new Random();
        public ObservableCollection<Department> ListDept = new ObservableCollection<Department>();
        public string Dept { get; set; }
        public Department(string dept)
        {
            Dept = dept;
        }

        public Department()
        {
        }

        public void AddElement()
        {
            for (int i = 0; i < 10; i++)
            {
                ListDept.Add(new Department($"Подразд_{r.Next(100, 103)}"));
            }
        }

        public override string ToString()
        {
            return Dept;
        }
    }
}
