using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

//Богатов Максим
//1.	Создать сущности Employee и Department и заполнить списки сущностей начальными данными.
//2.	Для списка сотрудников и списка департаментов предусмотреть визуализацию(отображение).
//Это можно сделать, например, с использованием ComboBox или ListView.
//3.	Предусмотреть редактирование сотрудников и департаментов.Должна быть возможность изменить департамент у сотрудника.Список департаментов для выбора можно выводить в ComboBox,
//и все это можно выводить на дополнительной форме.
//4.	Предусмотреть возможность создания новых сотрудников и департаментов.Реализовать это либо на форме редактирования, либо сделать новую форму.


namespace lesson5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Employee Emp = new Employee();
        Department Dept = new Department();
        public MainWindow()
        {
            InitializeComponent();

            Emp.AddElement();
            Dept.AddElement();
            EmpView.ItemsSource = Emp.ListEmp;
            DeptView.ItemsSource = Dept.ListDept;
            EmpCombo.ItemsSource = Emp.ListEmp;
            DeptCombo.ItemsSource = Dept.ListDept;
        }

        private void EmpbtnAdd_Click(object sender, RoutedEventArgs e)
        {
            string emp = EmpTextBox.Text;
            Emp.ListEmp.Add(new Employee(emp));
        }

        private void EmpbtnDel_Click(object sender, RoutedEventArgs e)
        {
            string emp = EmpTextBox.Text;

            foreach (var item in Emp.ListEmp.ToArray())
            {
                if (item.ToString() == emp)
                    Emp.ListEmp.Remove(item);
            }
        }

        private void DeptbtnAdd_Click(object sender, RoutedEventArgs e)
        {
            string dept = DeptTextBox.Text;
            Dept.ListDept.Add(new Department(dept));
        }

        private void DeptbtnDel_Click(object sender, RoutedEventArgs e)
        {
            string dept = DeptTextBox.Text;

            foreach (var item in Dept.ListDept.ToArray())
            {
                if (item.ToString() == dept)
                    Dept.ListDept.Remove(item);
            }
        }
    }
}
