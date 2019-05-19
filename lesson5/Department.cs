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
            ListDept.Add(new Department($"Подразд_100"));
            ListDept.Add(new Department($"Подразд_101"));
            ListDept.Add(new Department($"Подразд_102"));
            ListDept.Add(new Department($"Подразд_103"));
        }

        public override string ToString()
        {
            return Dept;
        }
    }
}
