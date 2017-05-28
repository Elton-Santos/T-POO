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
        Unidade unidade = new Unidade();
        
        public string opcao;

        InquilinoDAO crud = new InquilinoDAO();
        Mensagens msg = new Mensagens();
        public void formInquilino()
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
                          "▒ ║                             Formulário de Cadastro de proprietario                             ║ ▒\n" +
                          "▒ ║                                                                                                ║ ▒\n" +
                          "▒ ╚════════════════════════════════════════════════════════════════════════════════════════════════╝ ▒\n" +
                          "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");

            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\n|*********************************** D A D O S    P E S S O A I S ***********************************|\n");
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("| Nome:..................: "); inquilino.Nome = Console.ReadLine();
                Console.Write("| CPF:...................: "); inquilino.Cpf = Convert.ToString(Console.ReadLine());
                Console.Write("| RG:....................: "); inquilino.Rg = Console.ReadLine();
                Console.Write("| Data de Nascimento:....: "); inquilino.DataNascimento = Convert.ToDateTime(Console.ReadLine());
                Console.Write("| Estado Civil:..........: "); inquilino.EstadoCivil = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n|***************************************** E N D E R Ç O ********************************************|\n");
                Console.ForegroundColor = ConsoleColor.White;
                /*
                Console.Write("| Logradouro:............: "); inquilino.Endereco.Logradouro = Convert.ToString(Console.ReadLine());
                Console.Write("| Número:................: "); inquilino.Endereco.Numero = Convert.ToInt32(Console.ReadLine());
                Console.Write("| Complemento:...........: "); inquilino.Endereco.Complemento = Convert.ToString(Console.ReadLine());
                Console.Write("| CEP:...................: "); inquilino.Endereco.Cep = Convert.ToString(Console.ReadLine());
                Console.Write("| Bairro:................: "); inquilino.Endereco.Bairro = Convert.ToString(Console.ReadLine());
                Console.Write("| Cidade:................: "); inquilino.Endereco.Cidade = Convert.ToString(Console.ReadLine());
                Console.Write("| UF::...................: "); inquilino.Endereco.Uf = Convert.ToString(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n|***************************************** C O N T A T O ********************************************|");
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("| Telefone Residencial:..: "); inquilino.Contato.TelResidencia = Convert.ToString(Console.ReadLine());
                Console.Write("| Celular:...............: "); inquilino.Contato.Celular = Convert.ToString(Console.ReadLine());
                Console.Write("| E-mail:................: "); inquilino.Contato.Email = Convert.ToString(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n|***************************************** U N I D A D E ********************************************|");
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("| Nome da Unidade:.......: "); unidade.NomeUnidade = Convert.ToString(Console.ReadLine());
                Console.Write("| Bloco:.................: "); unidade.Bloco = Convert.ToString(Console.ReadLine());
                Console.Write("| Rua Interna:...........: "); unidade.RuaInterna = Convert.ToString(Console.ReadLine());
                Console.Write("| Número Apartamento:....: "); unidade.NumAP = Convert.ToString(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                */
                //Opção Desejada         
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n[ 1 ] Salvar  [ 2 ] Calcelar: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao.Equals(1))
                {
                    crud.insert(inquilino);
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
