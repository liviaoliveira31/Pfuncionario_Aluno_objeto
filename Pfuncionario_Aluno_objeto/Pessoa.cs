using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pfuncionario_Aluno_objeto
{
     internal class Pessoa
    {
        public String Nome;
        public DateTime DataNasc;
        public String Cpf;

        public Pessoa()
        {

        }

        public Pessoa(string nome, DateTime dataNasc, string cpf )        {
            Nome = nome;
            DataNasc = dataNasc;
            Cpf = cpf;
        }

        public void setNome()
        {
            Console.WriteLine("Informe o nome:");
            this.Nome = Console.ReadLine();
        }

        public void setDataNasc()
        {
            Console.WriteLine("Informe a data de nascimento: ");
            this.DataNasc = DateTime.Parse(Console.ReadLine());
        }
       

        public void setCpf()
        {
            Console.WriteLine("Informe o cpf: ");
            this.Cpf = Console.ReadLine();

        }
       



    }


}
