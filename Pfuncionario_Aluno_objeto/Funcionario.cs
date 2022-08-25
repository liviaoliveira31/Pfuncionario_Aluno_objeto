using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pfuncionario_Aluno_objeto
{
    internal class Funcionario: Pessoa
    {
        int NumPis;
        float Salario;
        String Setor;

        public Funcionario()
        {

        }

        public Funcionario(int numPis, float salario, string setor, string nome, DateTime dataNasc, string cpf)
            :base(nome, dataNasc, cpf)
        {
            NumPis = numPis;
            Salario = salario;
            Setor = setor;
            Nome = nome;
            DataNasc = dataNasc;
            Cpf = cpf;
        }


       

        public void setNumPis()
        {
            Console.WriteLine("Informe o PIS do Funcionario: ");
            this.NumPis = int.Parse(Console.ReadLine());

        }
       

        public void setSalario()
        {
            Console.WriteLine("Informe o Salario do funcionario: ");
            this.Salario = float.Parse(Console.ReadLine());
        }
      

        public void setSetor()
        {
            Console.WriteLine("Informe o Setor do Funcionario: ");
            this.Setor = Console.ReadLine();
        }

       


        public void CadastrarFuncionario()
        {
            setNome();
            setDataNasc();
            setCpf();
            setNumPis();
            setSalario();
            setSetor();
        }

        public string ImprimirCadastroF() //metodo = função
        {
            return "\nNome: " + this.Nome + "\nData de nascimento: " + this.DataNasc.ToLongDateString() +
                   "\nCPF: " + this.Cpf + "\nPIS: "+ this.NumPis + "\nSalario: " +this.Salario + "\nSetor: "+this.Setor;
        }



    }
}
