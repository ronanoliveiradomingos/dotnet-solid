using System;
using System.Linq;
using System.Collections.Generic;
using Solid.Dependency.Inversion.Model.Enum;

namespace Solid.Dependency.Inversion.Business
{
    public class EmployeeStatistics
    {
        private readonly IEmployeeSearchable _emp;

        public EmployeeStatistics(IEmployeeSearchable emp)
        {
            _emp = emp;
        }

        public int CountFemaleManagers() => _emp.GetEmployeesByGenderAndPosition(Gender.Female, Position.Manager).Count();
    }
}