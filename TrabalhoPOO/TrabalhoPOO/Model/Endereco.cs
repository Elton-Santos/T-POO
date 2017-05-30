using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO.Model
{
    public class Endereco
    {
        private string logradouro;
        private string numero;
        private string complemento;
        private string cep;
        private string bairro;
        private string estado;
        private string uf;
        private int id_Endereco;

        public Endereco()
        {
        }

       

        public string Logradouro { get { return logradouro; } set { logradouro = value; } }
        public string Numero { get { return numero; } set { numero = value; } }
        public string Complemento { get { return complemento; } set { complemento = value; } }
        public string Cep { get { return cep; } set { cep = value; } }
        public string Bairro { get { return bairro; } set { bairro = value; } }
        public string Estado { get { return estado; } set { estado = value; } }
        public string Uf { get { return uf; } set { uf = value; } }

        public int Id_Endereco { get => id_Endereco; set => id_Endereco = value; }
    }
}
