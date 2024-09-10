using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Banco
{
    public class Transacao
    {
        public decimal Valor { get; set; }

        public DateTime Data { get; set; }
        public string Nota { get; set; }


        public Transacao(decimal valor, DateTime data, string nota)
        {
            this.Valor = valor;
            this.Data = data;
            this.Nota = nota;
        }
    }
}

