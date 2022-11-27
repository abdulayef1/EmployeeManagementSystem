using EmployeeManagementSystem.Exceptions;

namespace EmployeeManagementSystem.Models;

public class Department
{

    int indexForAdd = 0;
    private Employee[] _employees;
    private Employee[] _uptadetEmployees;
    private int _employeersLimit;

    public String Name { get; set; }
    public int EmployeeLimit
    {
        get
        {
            return _employeersLimit;
        }
        set
        {
            value = _employeersLimit;
        }
    }

    public Department(string name, int employeersLimit)
    {
        Name = name;
        _employeersLimit = employeersLimit;
        _employees = new Employee[_employeersLimit];
    }
    public void AddEmployee(Employee employee)
    {
        if (_employeersLimit - 1 < indexForAdd)
            throw new CapacityLimitException("Out of limit !");
        _employees[indexForAdd] = employee;
        indexForAdd++;
    }
    public Employee this[int index]
    {
        get
        {
            if (_employeersLimit - 1 < index)
                throw new CapacityLimitException("Out of limit !");
            return _employees[index];
        }
        set
        {
            if (_employeersLimit - 1 < index)
                throw new CapacityLimitException("Out of limit !");
            _employees[index] = value;
        }
    }

    public void UpdateDepartment(string newName, int newEmployeeLimit)
    {
        Name = newName;
        _uptadetEmployees = new Employee[newEmployeeLimit];


        for (int i = 0; i < newEmployeeLimit; i++)
        {
            if (i >= _employeersLimit)
                break;
            _uptadetEmployees[i] = _employees[i];
        }
        _employees = _uptadetEmployees;
        _employeersLimit = newEmployeeLimit;
    }

    public void  showAllEmployees() {

        foreach (var employee in _employees)
        {
            Console.WriteLine(employee);
        }
    }
}
