using EmployeeManagementSystem.Interfaces;

namespace EmployeeManagementSystem.Models
{
    internal class Employee : IPerson
    {
        private static int id;
        public Employee(String name,int age,int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
            id++;
            Id = id;
        }
        public int Salary { get; set; }
        public int Id { get; }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
