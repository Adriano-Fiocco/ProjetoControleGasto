using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastoAppData.Dto
{
    public class Receita
    {
        public int CodReceita { get; set; }
        public int CodPessoa { get; set; }
        public double ValorRenda { get; set; }
        public string TipoRenda { get; set; }
        public DateTime DataReceita  { get; set; }

        public Receita(int codPessoa, double valorRenda, string tipoRenda, DateTime dataReceita)
        {
            CodPessoa = codPessoa;
            ValorRenda = valorRenda;
            TipoRenda = tipoRenda;
            DataReceita = dataReceita;
        }
        public Receita()
        {

        }

    }
}
