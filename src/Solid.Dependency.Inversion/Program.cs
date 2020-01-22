using System;
using Solid.Dependency.Inversion.Business;
using Solid.Dependency.Inversion.Model;
using Solid.Dependency.Inversion.Model.Enum;

namespace Solid.Dependency.Inversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var empManager = new EmployeeManager();
            empManager.AddEmployee(new Employee { Name = "Susana", Gender = Gender.Female, Position = Position.Manager });
            empManager.AddEmployee(new Employee { Name = "Inês", Gender = Gender.Female, Position = Position.Manager });
            empManager.AddEmployee(new Employee { Name = "Nuno", Gender = Gender.Male, Position = Position.Adminstrator });
            empManager.AddEmployee(new Employee { Name = "Cristina", Gender = Gender.Female, Position = Position.Executive });
            empManager.AddEmployee(new Employee { Name = "Filipa", Gender = Gender.Female, Position = Position.Adminstrator });
            empManager.AddEmployee(new Employee { Name = "Mafalda", Gender = Gender.Female, Position = Position.Manager });

            var statistics = new EmployeeStatistics(empManager);
            Console.WriteLine($"Number of female managers in our company is: {statistics.CountFemaleManagers()}");
        }
    }
}