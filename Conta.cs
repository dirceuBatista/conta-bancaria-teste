using Banco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace banco
{
    public class Conta : Titular
    {

        public List<Transacao> TodasTrans = new List<Transacao>();
        public List<Titular> TodosTitu = new List<Titular>();
        public decimal Saldo
        {
            get
            {
                decimal saldo = 0;
                
                    foreach (var item in TodasTrans)
                {
                    saldo = saldo + item.Valor;
                }
                return saldo;

            }
        }

       


        public Conta(string nome, decimal cpf,  decimal saldoinicial,int idade)
        {
            if (saldoinicial < 0)
                throw new Exception("saldo inicial não pode ser menor que zero.");
           this.Nome = nome;
            this.Cpf = cpf;
            this.Idade = idade;
            depositar(saldoinicial, DateTime.Now, "esse e o saldo");
           // novoTitular(nome, cpf, idade);
    
        }

        public decimal verSaldo()
        {
            return Saldo;
        }
        public void depositar(decimal valor, DateTime data, string nota)
        {
            if (valor <= 0)
                throw new ArgumentException(nameof(valor), " o valor do deposito deve ser positivo");
            var deposito = new Transacao(valor, data, nota);
            TodasTrans.Add(deposito);
        }
        public void sacar(decimal valor, DateTime data, string nota )
        {
            if (valor <= 0)
                throw new ArgumentOutOfRangeException(nameof(valor), " O valor do saque deve ser positivo");
            if (Saldo - valor <= 0)
                throw new ArgumentException(" não existe saldo duficiente ");
            var saque = new Transacao(-valor, data, nota);
            TodasTrans.Add(saque);
        }
        
        public void novoTitular(string nome, decimal cpf,int idade) { 
        
            var Titu = new Titular(nome, cpf, idade);
            //this.Nome = nome;
            //this.Cpf = cpf;
            //this.Idade = idade;
            TodosTitu.Add(Titu);

        }
    }

}
