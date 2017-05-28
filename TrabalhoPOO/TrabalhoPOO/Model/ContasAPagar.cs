using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO.Model
{
    public class ContasAPagar
    {
        private string descricaoDivida;
        private DateTime dataVencimento;
        private decimal valorDivida;
        private string unidadeDevedora;

        public string DescricaoDivida { get => descricaoDivida; set => descricaoDivida = value; }
        public DateTime DataVencimento { get => dataVencimento; set => dataVencimento = value; }
        public decimal ValorDivida { get => valorDivida; set => valorDivida = value; }
        public string UnidadeDevedora { get => unidadeDevedora; set => unidadeDevedora = value; }
    }
}
