using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO.Model
{
    public class Pessoa
    {
        private string nome;
        private string cpf;
        private string rg;        
        private string estadoCivil;
        private DateTime dataNascimento;
        private Endereco endereco;
        private Contato contato;
        private Unidade unidade;

        public Pessoa()
        {

        }

        public Pessoa(DateTime dataNascimento, Endereco endereco, Contato contato, Unidade unidade)
        {
            this.dataNascimento = dataNascimento;
            this.endereco = new Endereco();
            this.contato = new Contato();
            this.unidade = new Unidade();
        }

        public string Nome { get { return nome; } set { nome = value; } }
        public string Cpf { get { return cpf; } set { cpf = value; } }
        public string Rg { get { return rg; } set { rg = value; } }       
        public string EstadoCivil { get { return estadoCivil; } set { estadoCivil = value; } }
        public DateTime DataNascimento { get { return dataNascimento; } set { dataNascimento = value; } }
    }
}
