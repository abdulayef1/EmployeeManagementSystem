using EmployeeManagementSystem.Models;
using System.Text;

Department dp = new Department("Backend",5);

Employee ep = new Employee("Mhmmd", 21, 2000);
Employee ep1 = new Employee("Ayat", 21, 3000);
Employee ep2 = new Employee("Nigar", 21, 4000);
Employee ep3 = new Employee("Fidan", 21, 5000);
Employee ep4 = new Employee("Murad", 21, 6000);
Employee ep5 = new Employee("Jale", 21, 7000);



//dp.AddEmployee(ep);
//dp.AddEmployee(ep1);
//dp.AddEmployee(ep2);
//dp.AddEmployee(ep3);

dp[0] = ep;
dp[1] = ep1;
dp[2] = ep2;
dp[3] = ep3;
dp[4] = ep4;

Console.WriteLine($"Department name:{dp.Name}");
dp.showAllEmployees();

dp.UpdateDepartment("Backend2", 10);
dp[9] = ep5;
Console.WriteLine($"Department name:{dp.Name}");
dp.showAllEmployees();

