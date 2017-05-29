using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPOO.Model;
using TrabalhoPOO.Persistence;

namespace TrabalhoPOO.View
{
    public class FormInquilino
    {
        Inquilino inquilino = new Inquilino();
        InquilinoDAO crud = new InquilinoDAO();
        Mensagens msg = new Mensagens();

        private void cabecalho()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n" +
                          "▒                                                                                                    ▒\n" +
                          "▒                                       INCLUSÃO DE NOVO INQUILIN0                                   ▒\n" +
                          "▒                                                                                                    ▒\n" +

                          "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");

            Console.Write("▒                                                                                                    ▒\n");

            Console.Write("▒ ╔═════════════════════════════════════════ FORMULÁRIO ═══════════════════════════════════════════╗ ▒\n" +
                          "▒ ║                                                                                                ║ ▒\n" +
                          "▒ ║                             Formulário de Cadastro de Inquilino                                ║ ▒\n" +
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

            Console.Write("| Nome:..................: "); inquilino.Nome = Console.ReadLine();
            Console.Write("| CPF:...................: "); inquilino.Cpf = Convert.ToString(Console.ReadLine());
            Console.Write("| RG:....................: "); inquilino.Rg = Console.ReadLine();
            Console.Write("| Data de Nascimento:....: "); inquilino.DataNascimento = Convert.ToDateTime(Console.ReadLine());
            Console.Write("| Estado Civil:..........: "); inquilino.EstadoCivil = Console.ReadLine();
            crud.insertDadosPessoais(inquilino);
        }

        private void gravarEndereco()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n|***************************************** E N D E R Ç O ********************************************|\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("| Logradouro:............: "); inquilino.Endereco.Logradouro = Convert.ToString(Console.ReadLine());
            Console.Write("| Número:................: "); inquilino.Endereco.Numero = Convert.ToString(Console.ReadLine());
            Console.Write("| Complemento:...........: "); inquilino.Endereco.Complemento = Convert.ToString(Console.ReadLine());
            Console.Write("| CEP:...................: "); inquilino.Endereco.Cep = Convert.ToString(Console.ReadLine());
            Console.Write("| Bairro:................: "); inquilino.Endereco.Bairro = Convert.ToString(Console.ReadLine());
            Console.Write("| Cidade:................: "); inquilino.Endereco.Estado = Convert.ToString(Console.ReadLine());
            Console.Write("| UF::...................: "); inquilino.Endereco.Uf = Convert.ToString(Console.ReadLine());
            crud.insertEndereco(inquilino);
        }

        private void gravarContato()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n|***************************************** C O N T A T O ********************************************|\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("| Telefone Residencial:..: "); inquilino.Contato.TelResidencial = Convert.ToString(Console.ReadLine());
            Console.Write("| Celular:...............: "); inquilino.Contato.Celular = Convert.ToString(Console.ReadLine());
            Console.Write("| E-mail:................: "); inquilino.Contato.Email = Convert.ToString(Console.ReadLine());
            crud.insertContato(inquilino);
        }

        private void gravarUnidade()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n|***************************************** U N I D A D E ********************************************|");
            Console.ForegroundColor = ConsoleColor.White; Unidade uni = new Unidade();

            Console.Write("| Nome da Unidade:.......: "); inquilino.Unidade.NomeUnidade = Convert.ToString(Console.ReadLine());
            Console.Write("| Bloco:.................: "); inquilino.Unidade.Bloco = Convert.ToString(Console.ReadLine());
            Console.Write("| Rua Interna:...........: "); inquilino.Unidade.RuaInterna = Convert.ToString(Console.ReadLine());
            Console.Write("| Número Apartamento:....: "); inquilino.Unidade.NumAP = Convert.ToString(Console.ReadLine());           
            Console.WriteLine("\n|****************************************************************************************************|");
            Console.ForegroundColor = ConsoleColor.White;
            crud.insertUnidade(inquilino);
        }

        public void formInquilino()
        {
            Menu menu = new Menu();
            cabecalho();
            try
            {
                gravarDadosPessoais();
                gravarEndereco();
                gravarContato();
                gravarUnidade();

                Console.Write("\n| Deseja Incluir novo Inquilino? " +
                                   "[1] SIM [2] NÃO ");

                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao.Equals(1))
                {
                    Console.Clear();
                    formInquilino();
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
                formInquilino();
            }
        }
    }
}
