namespace HorecaManager___Business.Models;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public Employee(int id)
    {
        Id = id;
    }
    
    public Employee(int id, string name, string phone, string email) : this(id)
    {
        Name = name;
        Phone = phone;
        Email = email;
    }
}