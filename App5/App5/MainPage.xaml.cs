using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            listEmployee e = new listEmployee();
            e.EmployeeListPage();
            EmployeeView.ItemsSource = e.employees;

        }
        public void addItem(object sender, EventArgs e)
        {
            
            

        }
    }

    public class Employee
    {
        public  Employee(string name, string image)
        {
            this.DisplayName = name;
            this.Image = image;
        }
        public string DisplayName { get; set; }
        public string Image {  set; get; }
       
        


    }
    public class listEmployee
    {
        public ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        public void EmployeeListPage()
        {


            employees.Add(new Employee("Rob Finnerty", "http://simpleicon.com/wp-content/uploads/business-man-3.png"));
            employees.Add(new Employee("Bill Wrestler", "http://simpleicon.com/wp-content/uploads/business-man-3.png"));
            employees.Add(new Employee("Dr. Geri-Beth Hooper", "http://simpleicon.com/wp-content/uploads/business-man-3.png"));
            employees.Add(new Employee("Dr. Keith Joyce-Purdy", "http://simpleicon.com/wp-content/uploads/business-man-3.png"));
            employees.Add(new Employee("Sheri Spruce", "http://simpleicon.com/wp-content/uploads/business-man-3.png"));
            employees.Add(new Employee("Burt Indybrick", "http://simpleicon.com/wp-content/uploads/business-man-3.png"));


        }

    }

}
