using HorecaManager___Business.Exceptions;
using HorecaManager___Business.Models;

namespace HorecaManager___Data_layer;

public class EmployeeRepository : IEmployeeRepository
{
    public EmployeeRepository(string connectionString)
    {
        // Connect to the database
        Console.WriteLine("COnected" + connectionString);
    }
    
    public List<Employee> GetEmployees()
    {
        Employee employee1 = new Employee(1, "John Doe", "123456789", "test@test.com");
        Employee employee2 = new Employee(2, "Jane Doe", "987654321", "test@test.coms");
        Employee employee3 = new Employee(3, "John Smith", "123456789", "test@test.cosm");
        Employee employee4 = new Employee(4, "Jane Smith", "987654321", "test@test.cosdm");
        
        return new List<Employee> { employee1, employee2, employee3, employee4 };
    }
}