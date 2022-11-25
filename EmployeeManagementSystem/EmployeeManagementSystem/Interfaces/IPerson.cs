namespace EmployeeManagementSystem.Interfaces
{
    internal interface IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string ShowInfo();
    }
}
