using System;
using System.Collections.Generic;
using Solid.Dependency.Inversion.Model;
using Solid.Dependency.Inversion.Model.Enum;

namespace Solid.Dependency.Inversion.Business
{
    public interface IEmployeeSearchable
    {
        IEnumerable<Solid.Dependency.Inversion.Model.Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position);
    }
}