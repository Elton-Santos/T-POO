using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO.Model
{
    public class Contato
    {
        private string telResidencial;
        private string celular;
        private string email;

        public Contato()
        {
        }

        public Contato(string telResidencial, string celular, string email)
        {
            this.telResidencial = telResidencial;
            this.celular = celular;
            this.email = email;
        }

        public string TelResidencial { get { return telResidencial; } set { telResidencial = value; } }
        public string Celular { get { return celular; } set { celular = value; } }
        public string Email { get { return email; } set { email = value; } }
    }
}
