namespace EmployeeManagementSystem.Models;

internal class Department
{
    public Department(int employeedLimit)
    {
        EmployeeLimit = employeedLimit; 
        employees = new Employee[EmployeeLimit];
    }

    public String Name { get; set; }
    public int EmployeeLimit { get; set; }

    public Employee[] employees;

    public void AddEmployee(Employee employee)
    {

    }

}
