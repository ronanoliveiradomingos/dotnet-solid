namespace Solid
{
    public abstract class Employee
    {
        public virtual string GetProjectDetails(int employeeId)
        {
            return "Base Project";
        }
        public virtual string GetEmployeeDetails(int employeeId)
        {
            return "Base Employee";
        }
    }
    public class CasualEmployee : Employee
    {
        public override string GetProjectDetails(int employeeId)
        {
            return "Child Project";
        }
        public override string GetEmployeeDetails(int employeeId)
        {
            return "Child Employee";
        }
    }
    public class ContractualEmployee : Employee
    {
        public override string GetProjectDetails(int employeeId)
        {
            return "Child Project";
        }
        public override string GetEmployeeDetails(int employeeId)
        {
            throw new NotImplementedException();
        }
    }

    // Este princípio é simples, mas muito importante de entender. A classe filho não deve quebrar 
    // a definição e o comportamento do tipo da classe pai. Agora, qual é o significado disso !! 
    // Ok, deixe-me dar o mesmo exemplo de funcionário para fazer você entender esse princípio. 

    public void main()
    {
        List<Employee> employeeList = new List<Employee>();
        employeeList.Add(new ContractualEmployee());
        employeeList.Add(new CasualEmployee());
        foreach (Employee e in employeeList)
        {
            e.GetEmployeeDetails(1245);
        }
    }

    // Agora acho que você entendeu o problema. Sim, certo, para funcionário contratado, 
    // você não receberá uma exceção implementada e isso está violando o LSP. 
    // Então qual é a solução? Divida a coisa toda em 2 interfaces diferentes, 
    // 1. IProject 
    // 2. IEmployee e implemente de acordo com o tipo de funcionário.

    public interface IEmployee
    {
        string GetEmployeeDetails(int employeeId);
    }

    public interface IProject
    {
        string GetProjectDetails(int employeeId);
    }

    public class CasualEmployee : IEmployee
    {
        public override string GetEmployeeDetails(int employeeId)
        {
            return "Child Employee";
        }
    }
    public class ContractualEmployee : IProject
    {
        public override string GetProjectDetails(int employeeId)
        {
            return "Child Project";
        }
    }

}