using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO.Model
{
    public class Unidade
    {
        private int id_Unidade;
        private string nomeUnidade;
        private string bloco;
        private string ruaInterna;
        private string numAP;
        private Proprietario proprietario;
        private Inquilino inquilino;
        private ContasAPagar contas;
        private Endereco endereco;

        public Unidade()
        {
            this.endereco = new Endereco();
        }

        public string NomeUnidade { get { return nomeUnidade; } set { nomeUnidade = value; } }
        public string Bloco { get { return bloco; } set { bloco = value; } }
        public string RuaInterna { get { return ruaInterna; } set { ruaInterna = value; } }
        public string NumAP { get { return numAP; } set { numAP = value; } }

        public Proprietario Proprietario { get { return proprietario; } set { proprietario = value; } }
        public ContasAPagar Contas { get => contas; set => contas = value; }       
        public Inquilino Inquilino { get => inquilino; set => inquilino = value; }
        public Endereco Endereco { get => endereco; set => endereco = value; }
        public int Id_Unidade { get { return id_Unidade; } set { id_Unidade = value; } }
    }
}
