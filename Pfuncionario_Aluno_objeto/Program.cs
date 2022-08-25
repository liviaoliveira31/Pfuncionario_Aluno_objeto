using System;

namespace Pfuncionario_Aluno_objeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Aluno aluno1 = new Aluno();          
            Funcionario funcionario1 = new Funcionario();
           

            Console.WriteLine("\nFUNCIONARIO ");
            funcionario1.CadastrarFuncionario(); 
            

            Console.WriteLine("\nALUNO");
            aluno1.CadastrarAluno();

            Console.WriteLine("\nFICHA FUNCIONARIO ");
            Console.WriteLine(funcionario1.ImprimirCadastroF());
            Console.WriteLine("\nFICHA ALUNO");
            Console.WriteLine(aluno1.ImprimirCadastroA());


        }
    }
}
