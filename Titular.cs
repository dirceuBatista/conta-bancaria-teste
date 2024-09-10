using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    public class Titular
    {

        public string Nome { get; set; }
        public decimal Cpf { get; set; }
        public string Email { get; set; }
        public string Rg { get; set; }
        public int Idade { get; set; }
        public string Endereço { get; set; }
        public int Agencia { get; set; }
        public decimal NumDaConta { get; set; }

        public Titular(string nome, decimal cpf, int idade)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Idade = idade;




        }
    }
}
