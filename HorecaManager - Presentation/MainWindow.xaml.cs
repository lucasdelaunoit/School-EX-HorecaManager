using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HorecaManager___Business.Managers;
using HorecaManager___Business.Models;
using HorecaManager___Data_layer;

namespace HorecaManager___Presentation;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private EmployeeManager _employeeManager;
    private const string connectionString = "Data Source=DESKTOP-1A2B3C4;Initial Catalog=HorecaManager;Integrated Security=True";
    private ObservableCollection<Employee> allEmployees;
    private ObservableCollection<Employee> selectedEmployees;
    
    public MainWindow()
    {
        InitializeComponent();
        _employeeManager = new EmployeeManager(new EmployeeRepository(connectionString));
        
        allEmployees = new ObservableCollection<Employee>(_employeeManager.GetEmployees());
        ListBoxAllEmployees.ItemsSource = _employeeManager.GetEmployees();
        
        selectedEmployees = new ObservableCollection<Employee>();
        ListBoxAllSelectedEmployees.ItemsSource = selectedEmployees;
    }
    
    private void ButtonAddEmployee_Click(object sender, RoutedEventArgs e)
    {
        List<Employee> employees = new List<Employee>();
        
        foreach (Employee employee in ListBoxAllEmployees.SelectedItems)
        {
            employees.Add(employee);
        }
        
        foreach (Employee employee in employees)
        {
            selectedEmployees.Add(employee);
            allEmployees.Remove(employee);
        }
    }

    private void ButtonAddAllEmployee_Click(object sender, RoutedEventArgs e)
    {
        foreach (Employee employee in allEmployees) selectedEmployees.Add(employee);
        allEmployees.Clear();
    }
}