using EmployeeManagementSystem.Interfaces;

namespace EmployeeManagementSystem.Models
{
    public class Employee : IPerson
    {
        private static int id;
        public int Salary { get; set; }
        public int Id { get; }
        public string Name { get; set; }
        public int Age { get; set ; }
        public Employee(String name,int age,int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
            id++;
            Id = id;
        }

        public string ShowInfo()
        {
            return $"Name:{Name} Age:{Age} ID:{Id} Salary:{Salary}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
