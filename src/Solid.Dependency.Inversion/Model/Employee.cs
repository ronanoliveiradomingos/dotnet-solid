using System;
using Solid.Dependency.Inversion.Model.Enum;

namespace Solid.Dependency.Inversion.Model
{
    public class Employee
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Position Position { get; set; }
    }
}