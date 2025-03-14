using HorecaManager___Business.Exceptions;
using HorecaManager___Business.Models;

namespace HorecaManager___Business.Managers;

public class EmployeeManager
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeManager(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public List<Employee> GetEmployees()
    {
        return _employeeRepository.GetEmployees();
    }
}