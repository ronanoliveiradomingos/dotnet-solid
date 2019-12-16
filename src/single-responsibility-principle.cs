namespace Solid
{
    public class Employee
    {
        public int Employee_Id { get; set; }
        public string Employee_Name { get; set; }

        public bool InsertIntoEmployeeTable(Employee emp)
        {
            // Insert into employee table
            return true;
        }

        public void GenerateReport(Employee emp)
        {
            // Report generation with employee data using crystal report
        }
    }

    // A classe "Employee" está assumindo 2 responsabilidades, uma é assumir a responsabilidade 
    // pela operação do banco de dados de funcionários e outra é gerar um relatório de funcionário. 
    // A classe de Employee não deve assumir a responsabilidade de geração de relatórios, 
    // porque suponha que alguns dias após o seu cliente solicitar que você forneça um recurso para gerar 
    // o relatório no Excel ou em qualquer outro formato de relatório, essa classe precisará ser alterada 
    // e isso não é bom.

    // Portanto, de acordo com o SRP, uma classe deve assumir uma responsabilidade; 
    // portanto, devemos escrever uma classe diferente para a geração de relatórios, 
    // para que qualquer alteração na geração de relatórios não afete a classe "Employee".

    public class ReportGeneration
    {
        public void GenerateReport(Employee emp)
        {
           // Report generation with employee data using crystal report
        }
    }

}