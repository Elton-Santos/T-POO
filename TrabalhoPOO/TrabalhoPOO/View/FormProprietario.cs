using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPOO.Model;
using TrabalhoPOO.Persistence;

namespace TrabalhoPOO.View
{
    public class FormProprietario
    {        
        ProprietarioDAO crud = new ProprietarioDAO();
        Proprietario proprietario = new Proprietario();

        private void cabecario()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n" +
                          "▒                                                                                                    ▒\n" +
                          "▒                                       INCLUSÃO DE NOVO PROPRIETÁRIO                                ▒\n" +
                          "▒                                                                                                    ▒\n" +

                          "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");

            Console.Write("▒                                                                                                    ▒\n");

            Console.Write("▒ ╔═════════════════════════════════════════ FORMULÁRIO ═══════════════════════════════════════════╗ ▒\n" +
                          "▒ ║                                                                                                ║ ▒\n" +
                          "▒ ║                             Formulário de Cadastro de Proprietário                             ║ ▒\n" +
                          "▒ ║                                                                                                ║ ▒\n" +
                          "▒ ╚════════════════════════════════════════════════════════════════════════════════════════════════╝ ▒\n" +
                          "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
        }

        private void gravarDadosPessoais()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n|*********************************** D A D O S    P E S S O A I S ***********************************|\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("| Nome.............................: "); proprietario.Nome = Console.ReadLine();
            Console.Write("| CPF..............................: "); proprietario.Cpf = Console.ReadLine();
            Console.Write("| RG...............................: "); proprietario.Rg = Console.ReadLine();
            Console.Write("| Data de Nascimento...............: "); proprietario.DataNascimento = Convert.ToDateTime(Console.ReadLine());
            Console.Write("| Estado Civil.....................: "); proprietario.EstadoCivil = Console.ReadLine();
            crud.insertDadosPessoais(proprietario);
        }

        private void gravarEndereco()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n|***************************************** E N D E R Ç O ********************************************|\n");
            Console.ForegroundColor = ConsoleColor.White;

            crud.select();
            Console.Write("| ID Proprietário..................: "); proprietario.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("| Logradouro:......................: "); proprietario.Endereco.Logradouro = Convert.ToString(Console.ReadLine());
            Console.Write("| Número:..........................: "); proprietario.Endereco.Numero = Convert.ToString(Console.ReadLine());
            Console.Write("| Complemento:.....................: "); proprietario.Endereco.Complemento = Convert.ToString(Console.ReadLine());
            Console.Write("| CEP:.............................: "); proprietario.Endereco.Cep = Convert.ToString(Console.ReadLine());
            Console.Write("| Bairro:..........................: "); proprietario.Endereco.Bairro = Convert.ToString(Console.ReadLine());
            Console.Write("| Cidade:..........................: "); proprietario.Endereco.Estado = Convert.ToString(Console.ReadLine());
            Console.Write("| UF::.............................: "); proprietario.Endereco.Uf = Convert.ToString(Console.ReadLine());
            crud.insertEndereco(proprietario);
        }

        private void gravarContato()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n|***************************************** E N D E R Ç O ********************************************|\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("| ID Proprietário..................: "); proprietario.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("| Telefone Residencial:............: "); proprietario.Contato.TelResidencial = Convert.ToString(Console.ReadLine());
            Console.Write("| Número:..........................: "); proprietario.Contato.Celular = Convert.ToString(Console.ReadLine());
            Console.Write("| Email:...........................: "); proprietario.Contato.Email = Convert.ToString(Console.ReadLine());           
            crud.insertContato(proprietario);
        }

        private void gravarUnidade()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n|***************************************** U N I D A D E ********************************************|");
            Console.ForegroundColor = ConsoleColor.White; Unidade uni = new Unidade();

            EnderecoDAO crudEnd = new EnderecoDAO();

            crudEnd.select();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n|***************************************** U N I D A D E ********************************************|");
            Console.ForegroundColor = ConsoleColor.White; 
            Console.Write("| ID Inquilino.....................: "); proprietario.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("| ID Endereço......................: "); proprietario.Endereco.Id_Endereco = Convert.ToInt32(Console.ReadLine());
            Console.Write("| Nome da Unidade:.................: "); proprietario.Unidade.NomeUnidade = Convert.ToString(Console.ReadLine());
            Console.Write("| Bloco:...........................: "); proprietario.Unidade.Bloco = Convert.ToString(Console.ReadLine());
            Console.Write("| Rua Interna:.....................: "); proprietario.Unidade.RuaInterna = Convert.ToString(Console.ReadLine());
            Console.Write("| Número Apartamento:..............: "); proprietario.Unidade.NumAP = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n|****************************************************************************************************|");
            Console.ForegroundColor = ConsoleColor.White;
            crud.insertUnidade(proprietario);
        }

        public void formProprietario()
        {
            Mensagens msg = new Mensagens();
            Menu menu = new Menu();

            cabecario();
            try
            {
                gravarDadosPessoais();
                gravarEndereco();
                gravarContato();
                gravarUnidade();

                Console.Write("\n| Deseja Incluir novo Proprietário? " +
                                   "[1] SIM [2] NÃO ");

                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao.Equals(1))
                {
                    Console.Clear();
                    formProprietario();
                }
                else
                {
                    Console.Clear();
                    menu.menuInicial();
                }
            }
            catch (Exception)
            {
                msg.opcaoInvalida();
                Console.ReadKey();
                Console.Clear();
                formProprietario();
            }
        }
    }
}
