using HorecaManager___Business.Models;

namespace HorecaManager___Business.Exceptions;

public interface IEmployeeRepository
{
    List<Employee> GetEmployees(); 
}