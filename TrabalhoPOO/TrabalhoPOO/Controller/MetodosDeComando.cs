using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPOO.Persistence;
using TrabalhoPOO.View;

namespace TrabalhoPOO.Controller
{
    public class MetodosDeComando
    {
        Menu menu = new Menu();
        Mensagens msg = new Mensagens();
        
        public void digitarOpcao(string opcao)
        {
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.Write("═══════════════>  Digite a Opção Desejada: ");
            opcao = Convert.ToString(Console.ReadLine());
            Console.Clear();
        }

        public int deletar()
        {
            Console.Write("\tDigite um ID para excluir? ");
           int  opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }
        

            public void alterarDivida()
        {
            ContasAPAgarDAO crud = new ContasAPAgarDAO();

            try
            {
                Console.Write("\tDigite numero do ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("\tValor para Alteração: ");
                double valor = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();
                crud.quitarDivida(id, valor);
            }
            catch (Exception)
            {
                msg.opcaoInvalida();
                Console.ReadKey();
                Console.Clear();
                menu.menuAdministrativo();
            }
            Console.Clear();
            menu.listaMetodosProprietario();
        }

        public void alteraProprietario()
        {
            ProprietarioDAO crud = new ProprietarioDAO();

            try
            {
                Console.Write("\tDigite numero do ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("\tNome: ");
                string nome = Console.ReadLine();

                Console.WriteLine();
                crud.alterar(id, nome);
            }
            catch (Exception)
            {
                msg.opcaoInvalida();
                Console.ReadKey();
                Console.Clear();
                menu.menuAdministrativo();
            }
            Console.Clear();
            menu.listaMetodosProprietario();
        }

        public void alterarInquilino()
        {
            InquilinoDAO crud = new InquilinoDAO();

            try
            {
                Console.Write("\tDigite numero do ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("\tNome: ");
                string nome = Console.ReadLine();

                Console.WriteLine();
            crud.alterar(id, nome);
            }
            catch (Exception)
            {
                msg.opcaoInvalida();
                Console.ReadKey();
                Console.Clear();
              menu.menuAdministrativo();
            }
            Console.Clear();
            menu.listaMetodosInquilino();
        }

        public void alteraUnidade()
        {
          UnidadeDAO crud = new UnidadeDAO();

            try
            {
                Console.Write("\tDigite numero do ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("\tNome: ");
                string nome = Console.ReadLine();

                Console.WriteLine();
                crud.alterar(id, nome);
            }
            catch (Exception)
            {
                msg.opcaoInvalida();
                Console.ReadKey();
                Console.Clear();
                menu.menuAdministrativo();
            }
            Console.Clear();
            menu.listaMetodosUnidade();
        }

        public void alteraDivida()
        {
            UnidadeDAO crud = new UnidadeDAO();  
            try
            {
                Console.Write(" Digite numero do ID para alteração: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("\tValor Quitação: ");
                string valorDivida = Console.ReadLine();

                Console.WriteLine();
                crud.alterar(id, valorDivida);
            }
            catch (Exception)
            {
                msg.opcaoInvalida();
                Console.ReadKey();
                Console.Clear();
              menu.menuAdministrativo();
            }
            Console.Clear();
            menu.menuAdministrativo();
        }
    }
}

