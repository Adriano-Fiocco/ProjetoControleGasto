using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleGastoAppData.Dto
{
    public class Despesa
    {
        public int CodDespesa { get; set; }
        public int CodPessoa { get; set; }
        public double ValorDespesa { get; set; }
        public string TipoDespesa { get; set; }
        public DateTime DataDespesa { get; set; }

        public Despesa(int codPessoa, double valorDespesa, string tipoDespesa, DateTime dateTime)
        {
            CodDespesa= codPessoa;
            ValorDespesa = valorDespesa;
            TipoDespesa = tipoDespesa;
            DataDespesa = dateTime;

        }
        public Despesa()
        {

        }
    }
}
