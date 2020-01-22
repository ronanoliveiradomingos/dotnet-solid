using System;
using System.Collections.Generic;
using System.Linq;
using Solid.Dependency.Inversion.Model;
using Solid.Dependency.Inversion.Model.Enum;

namespace Solid.Dependency.Inversion.Business
{
    public class EmployeeManager : IEmployeeSearchable
    {
        private readonly List<Solid.Dependency.Inversion.Model.Employee> _employees;

        public EmployeeManager()
        {
            _employees = new List<Solid.Dependency.Inversion.Model.Employee>();
        }

        public void AddEmployee(Solid.Dependency.Inversion.Model.Employee employee)
        {
            _employees.Add(employee);
        }

        public IEnumerable<Solid.Dependency.Inversion.Model.Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position)
            => _employees.Where(emp => emp.Gender == gender && emp.Position == position);
    }
}