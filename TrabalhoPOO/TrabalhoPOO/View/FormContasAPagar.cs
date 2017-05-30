using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPOO.Controller;
using TrabalhoPOO.Model;
using TrabalhoPOO.Persistence;

namespace TrabalhoPOO.View
{
    public class FormContasAPagar
    {
        ContasAPagar div = new ContasAPagar();
        ContasAPAgarDAO dividaCrud = new ContasAPAgarDAO();
        Mensagens msg = new Mensagens();
        Menu menu = new Menu();

        private void cabecalho()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n" +

                          "▒                                                                                                    ▒\n" +

                          "▒                                       LANÇAMENTO DE DESPESAS                                       ▒\n" +

                          "▒                                                                                                    ▒\n" +
                          "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.WriteLine("▒                                                                                                    ▒");
            Console.Write("▒ ╔═════════════════════════════════════ LISTA DE DESPESAS ════════════════════════════════════════╗ ▒\n" +
                          "▒ ║                                                                                                ║ ▒\n" +
                          "▒ ║    1   =>  IPTU                                                                                ║ ▒\n" +
                          "▒ ║    2   =>  Água                                                                                ║ ▒\n" +
                          "▒ ║    3   =>  Luz                                                                                 ║ ▒\n" +
                          "▒ ║    4   =>  Telefone                                                                            ║ ▒\n" +
                          "▒ ║    5   =>  Condomínio                                                                          ║ ▒\n" +
                          "▒ ║    0   =>  Sair                                                                                ║ ▒\n" +
                          "▒ ║                                                                                                ║ ▒\n" +
                          "▒ ╚════════════════════════════════════════════════════════════════════════════════════════════════╝ ▒\n" +
                          "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
        }

        private void gravarContaAPagar()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n|********************** L A N Ç A M E N T O   D E   C O N T A S  À   P A G A R **********************|\n");
            Console.ForegroundColor = ConsoleColor.White;
                       
            Console.Write("| Descrição da Dívida:.............: "); div.DescricaoDivida = Console.ReadLine();
            Console.Write("| Data de Vencimento:..............: "); div.DataVencimento = Convert.ToDateTime(Console.ReadLine());
            Console.Write("| Valor Devido:....................: "); div.ValorDivida = Convert.ToDecimal(Console.ReadLine());
            Console.Write("| Número do Apartamento:...........: "); div.UnidadeDevedora.NumAP = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n|****************************************************************************************************|\n");
            Console.ForegroundColor = ConsoleColor.White;

        }

        public void formularioDivida()
        {            
            cabecalho();
            try
            {
                gravarContaAPagar();
                ArquivoTXT gravarFicheiro = new ArquivoTXT();
                Console.Write("\n| [ 1 ] Salvar  [ 2 ] Calcelar: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao.Equals(1))
                {
                   gravarFicheiro.arquivoTXT(div.DescricaoDivida, div.DataVencimento, div.ValorDivida, div.UnidadeDevedora.NomeUnidade);
                    dividaCrud.insert(div);
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
                formularioDivida();
            }
        }
    }
}

