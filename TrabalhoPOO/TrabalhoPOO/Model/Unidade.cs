﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO.Model
{
    public class Unidade
    {
        private string nomeUnidade;
        private string bloco;
        private string ruaInterna;
        private string numAP;
        private Proprietario proprietario;
        private Endereco endereco;
        private Inquilino inquilino;

        public Unidade()
        {
        }

        public Unidade(string nomeUnidade, string bloco, string ruaInterna, string numAP, Proprietario proprietario, Endereco endereco, Inquilino inquilino)
        {
            this.nomeUnidade = nomeUnidade;
            this.bloco = bloco;
            this.ruaInterna = ruaInterna;
            this.numAP = numAP;
            this.proprietario = new Proprietario();
            this.endereco = new Endereco();
            this.inquilino = new Inquilino();
        }

        public string NomeUnidade { get { return nomeUnidade; } set { nomeUnidade = value; } }
        public string Bloco { get { return bloco; } set { bloco = value; } }
        public string RuaInterna { get { return ruaInterna; } set { ruaInterna = value; } }
        public string NumAP { get { return numAP; } set { numAP = value; } }
        public Proprietario Proprietario { get { return proprietario; } set { proprietario = value; } }
    }
}
