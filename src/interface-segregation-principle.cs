namespace Solid
{
    public interface IEmployee
    {
        bool AddEmployeeDetails();
    }
    public interface IEmployeeDatabase
    {
        bool AddEmployeeDetails();
        bool ShowEmployeeDetails(int employeeId);
    }

    // Este princípio afirma que qualquer cliente não deve ser forçado a usar uma interface que é irrelevante para ele. 
    // Agora, o que isso significa, suponha que exista um banco de dados para armazenar dados de todos os tipos de 
    // funcionários (ou seja, Permanente, não permanente), agora qual será a melhor abordagem para nossa interface?
    // E todos os tipos de classe de funcionários herdarão essa interface para salvar dados. Isso está bem, certo? Agora, 
    // suponha que a empresa um dia lhe tenha dito que deseja ler apenas dados de funcionários permanentes. O que você fará, 
    // basta adicionar um método a essa interface?
    // Mas agora estamos quebrando alguma coisa. Estamos forçando a classe de funcionários não permanentes a mostrar 
    // seus detalhes do banco de dados. Portanto, a solução é atribuir essa responsabilidade a outra interface.
    // E o funcionário não permanente implementará apenas IAddOperation e o funcionário permanente 
    // implementará a interface.

    public interface IAddOperation
    {
        bool AddEmployeeDetails();
    }
    public interface IGetOperation
    {
        bool ShowEmployeeDetails(int employeeId);
    }

}