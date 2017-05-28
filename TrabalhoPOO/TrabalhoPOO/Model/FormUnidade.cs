using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPOO1.Model;


namespace TrabalhoPOO1.View
{
    public class FormUnidade
    {
        Unidade uni = new Unidade();
        Mensagens msg = new Mensagens();
        string ficheiro = @"FicheiroUnidade.txt";

        public void formUnidade()
        {

            UnidadeCRUD unidadeCRUD = new UnidadeCRUD();
            int opcao = 0;
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

            try
            {
                Console.Write("| Nome do Condomínio:.....: "); uni.NomeUnidade = Console.ReadLine();
                Console.Write("| Bloco:..................: "); uni.Bloco = Console.ReadLine();
                Console.Write("| Número da Rua:..........: "); uni.RuaInterna = Console.ReadLine();
                Console.Write("| Número do Apartamento:..: "); uni.NumAP = Console.ReadLine();
                Console.Write("| Nome do proprietario:...: "); uni.Proprietario.Nome  = Convert.ToString(Console.ReadLine());
                Console.Write("| CPF Proprietario:.......: "); uni.Proprietario.Cpf = Convert.ToString(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\t[ 1 ] Salvar  [ 2 ] Calcelar: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao.Equals(1))
                {
                    unidadeCRUD.insert(uni);
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




