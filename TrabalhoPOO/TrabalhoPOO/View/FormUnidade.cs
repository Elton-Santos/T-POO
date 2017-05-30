using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPOO.Model;
using TrabalhoPOO.Persistence;

namespace TrabalhoPOO.View
{
    public class FormUnidade
    {
        Unidade unidade = new Unidade();
        Mensagens msg = new Mensagens();
        UnidadeDAO crud = new UnidadeDAO();

        private void cabecalho()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n" +
                          "▒                                                                                                    ▒\n" +
                          "▒                                       INCLUSÃO DE NOVA UNIDADE                                     ▒\n" +
                          "▒                                                                                                    ▒\n" +

                          "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");

            Console.Write("▒                                                                                                    ▒\n");

            Console.Write("▒ ╔═════════════════════════════════════════ FORMULÁRIO ═══════════════════════════════════════════╗ ▒\n" +
                          "▒ ║                                                                                                ║ ▒\n" +
                          "▒ ║                             Formulário de Cadastro de Unidade                                  ║ ▒\n" +
                          "▒ ║                                                                                                ║ ▒\n" +
                          "▒ ╚════════════════════════════════════════════════════════════════════════════════════════════════╝ ▒\n" +
                          "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
        }

        private void gravarUnidade()
        {
            InquilinoDAO crudInquilino = new InquilinoDAO();
            Proprietario crudProprietario = new Proprietario();
            UnidadeDAO crudUnidade = new UnidadeDAO();
            EnderecoDAO crudEndereco = new EnderecoDAO();

            Console.ForegroundColor = ConsoleColor.White;
            crudEndereco.select();
            Console.Write("| ID Endereço......................: "); unidade.Endereco.Id_Endereco = Convert.ToInt32(Console.ReadLine());
            Console.Write("| Nome da Unidade:.................: "); unidade.NomeUnidade = Convert.ToString(Console.ReadLine());
            Console.Write("| Bloco:...........................: "); unidade.Bloco = Convert.ToString(Console.ReadLine());
            Console.Write("| Rua Interna:.....................: "); unidade.RuaInterna = Convert.ToString(Console.ReadLine());
            Console.Write("| Número Apartamento:..............: "); unidade.NumAP = Console.ReadLine();
            Console.WriteLine("\n|****************************************************************************************************|");            Console.ForegroundColor = ConsoleColor.White;

        }

        public void formUnidade()
        {

            Menu menu = new Menu();
            cabecalho();
            try
            {
                gravarUnidade(); ;

                Console.Write("\n| Deseja Incluir novo Inquilino? " +
                                   "[1] SIM [2] NÃO ");

                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao.Equals(1))
                {
                    Console.Clear();
                    formUnidade();
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
                formUnidade();
            }
        }
    }
}




