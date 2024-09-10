using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var novaconta = new Conta(" dirceu",15821709670, 1000);
            Console.WriteLine($" Uma conta , com o CPF {novaconta.NumDaConta} foi criada com sucesso para o {novaconta.nome} com saldo inicial de: {novaconta.Saldo}");
            novaconta.depositar(800, DateTime.Now, "salario");
            Console.WriteLine($" Uma conta , com o CPF {novaconta.NumDaConta} foi criada com sucesso para o {novaconta.nome} com saldo inicial de: {novaconta.Saldo}");
            novaconta.sacar(900, DateTime.Now, "pagamento");
            Console.WriteLine($" Uma conta , com o CPF {novaconta.NumDaConta} foi criada com sucesso para o {novaconta.nome} com saldo inicial de: {novaconta.Saldo}");
            Console.ReadLine();
        }
    }
}
