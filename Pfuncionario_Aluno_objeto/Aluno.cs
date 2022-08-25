using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pfuncionario_Aluno_objeto
{
    internal class Aluno: Pessoa
    {
        int Registro;
        DateTime DataMatricula;

        public Aluno()
        {

        }

        public Aluno(int registro, DateTime dataMatricula, string nome, DateTime dataNasc, string cpf)
            :base(nome, dataNasc, cpf)
        {
            Registro = registro;
            DataMatricula = dataMatricula;
        }

        public void setRegistro()
        {
            Console.WriteLine("Informe o registro do aluno: ");
            this.Registro = int.Parse(Console.ReadLine());
        }

        public void setDataMatricula()
        {
            Console.WriteLine("Informe a data da matricula do aluno: : ");
            this.DataMatricula = DateTime.Parse(Console.ReadLine());
        }

        public void CadastrarAluno()
        {
            setNome();
            setDataNasc();
            setCpf();
            setRegistro();
            setDataMatricula();
            
        }

        public string ImprimirCadastroA() //metodo = função
        {
            return "\nNome: " + this.Nome + "\nData de nascimento: " + this.DataNasc.ToLongDateString() +
                   "\nCPF: " + this.Cpf + "\nRegistro: " + this.Registro + "\nData Matricula: " + this.DataMatricula.ToLongDateString();
        }


    }
}
