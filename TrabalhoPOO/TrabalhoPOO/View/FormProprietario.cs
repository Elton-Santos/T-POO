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
         
        public void cadastroProprietario()
        {
            Mensagens msg = new Mensagens();
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

            try
            {
                Proprietario proprietario = new Proprietario();
                Console.Write("Nome................:"); proprietario.Nome = Console.ReadLine();
                Console.Write("CPF.................:"); proprietario.Cpf = Console.ReadLine();
                Console.Write("RG..................:"); proprietario.Rg = Console.ReadLine();
                Console.Write("dataNascimento......:"); proprietario.DataNascimento = Convert.ToDateTime(Console.ReadLine());
                Console.Write("estadoCivil.........:"); proprietario.EstadoCivil = Console.ReadLine();

                Console.Write("Salvar [1]");
                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao.Equals(1))
                {
                    crud.insert(proprietario);
                }
            }
            catch(Exception ex)
            {
                msg.opcaoInvalida();
                Console.ReadKey();
                Console.Clear();
                cadastroProprietario();
            }
        }
    }
}
