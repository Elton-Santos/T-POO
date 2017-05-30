using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPOO.Controller;
using TrabalhoPOO.Model;
using TrabalhoPOO.Persistence;

namespace TrabalhoPOO.View
{
    public class Menu
    {
        FormProprietario formProprietario = new FormProprietario();

        public void menuInicial()
        {

            while (true)
            {
                Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ SISTEMA ADMINISTRAÇÃO DE CONDOMÍNIOS ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n" +
                              "▒                                                                                                    ▒\n" +
                              "▒                                                                                                    ▒\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("▒ ╔══════════════════════════════════ SISTEMA DE CADASTRO ═════════════════════════════════════════╗ ▒\n" +
                              "▒ ║                                                                                                ║ ▒\n" +
                              "▒ ║    1   =>  Administrativo                                                                      ║ ▒\n" +
                              "▒ ║    2   =>  Cadastrados                                                                         ║ ▒\n" +
                              "▒ ║    0   =>  Sair                                                                                ║ ▒\n" +
                              "▒ ║                                                                                                ║ ▒\n" +
                              "▒ ╚════════════════════════════════════════════════════════════════════════════════════════════════╝ ▒\n" +
                              "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
                Console.Write("═══════════════>  Digite a Opção Desejada: ");
                Mensagens msg = new Mensagens();

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        menuAdministrativo();
                        break;
                    case "2":
                        Console.Clear();
                        escolhaEntidade();
                        break;
                    case "0":
                        Console.Clear();
                        msg.goodBye();
                        System.Environment.Exit(1);
                        break;
                    default:
                        msg.opcaoInvalida();
                        Console.ReadKey();
                        Console.Clear();
                        menuInicial();
                        break;
                }
            }
        }

        public void escolhaEntidade()
        {
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ SISTEMA ADMINISTRAÇÃO DE CONDOMÍNIOS ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n" +
                          "▒                                                                                                    ▒\n" +
                          "▒                                                                                                    ▒\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("▒ ╔══════════════════════════════════ TABELA DE CADASTROS ═════════════════════════════════════════╗ ▒\n" +
                          "▒ ║                                                                                                ║ ▒\n" +
                          "▒ ║    1   =>  Proprietário                                                                        ║ ▒\n" +
                          "▒ ║    2   =>  Inquilino                                                                           ║ ▒\n" +
                          "▒ ║    3   =>  Unidade                                                                             ║ ▒\n" +
                          "▒ ║    4   =>  Voltar ao Menu Anterior                                                             ║ ▒\n" +
                          "▒ ║    0   =>  Sair                                                                                ║ ▒\n" +
                          "▒ ║                                                                                                ║ ▒\n" +
                          "▒ ╚════════════════════════════════════════════════════════════════════════════════════════════════╝ ▒\n" +
                          "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.Write("═══════════════>  Digite a Opção Desejada: ");
            string opcao = Console.ReadLine();
            Mensagens msg = new Mensagens();
            MetodosDeComando metodoOpcao = new MetodosDeComando();


            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    listaMetodosProprietario();
                    break;
                case "2":
                    Console.Clear();
                    listaMetodosInquilino();
                    break;
                case "3":
                    Console.Clear();
                    listaMetodosUnidade();
                    break;
                case "4":
                    Console.Clear();
                    menuInicial();
                    break;
                case "0":
                    Console.Clear();
                    msg.goodBye();
                    System.Environment.Exit(1);
                    break;
                default:
                    msg.opcaoInvalida();
                    Console.ReadKey();
                    Console.Clear();
                    escolhaEntidade();
                    break;
            }
        }

        public void listaMetodosProprietario()
        {
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ SISTEMA ADMINISTRAÇÃO DE CONDOMÍNIOS ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n" +
                          "▒                                                                                                    ▒\n" +
                          "▒                                                                                                    ▒\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("▒ ╔══════════════════════════════════ MANUTENÇÃO PROPRIETÁRIO══════════════════════════════════════╗ ▒\n" +
                          "▒ ║                                                                                                ║ ▒\n" +
                          "▒ ║    1   =>  Novo    Proprietário                                                                ║ ▒\n" +
                          "▒ ║    2   =>  Alterar Proprietário                                                                ║ ▒\n" +
                          "▒ ║    3   =>  Listar  Proprietários                                                               ║ ▒\n" +
                          "▒ ║    4   =>  Excluir Proprietário                                                                ║ ▒\n" +
                          "▒ ║    5   =>  Voltar ao Opcoes Inicial                                                            ║ ▒\n" +
                          "▒ ║    0   =>  Sair                                                                                ║ ▒\n" +
                          "▒ ║                                                                                                ║ ▒\n" +
                          "▒ ╚════════════════════════════════════════════════════════════════════════════════════════════════╝ ▒\n" +
                          "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.Write("═══════════════>  Digite a Opção Desejada: ");
            string opcao = Console.ReadLine();

            FormProprietario formProp = new FormProprietario();
            ProprietarioDAO crudProprietario = new ProprietarioDAO();
            MetodosDeComando metodoOpcao = new MetodosDeComando();
            Mensagens msg = new Mensagens();

            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    formProp.formProprietario();
                    Console.ReadKey();
                    Console.Clear();

                    break;
                case "2":
                    Console.Clear();
                    crudProprietario.select();
                    metodoOpcao.alteraProprietario();
                    Console.Clear();
                    break;
                case "3":
                    Console.Clear();
                    crudProprietario.select();
                    Console.ReadKey();
                    Console.Clear();
                    listaMetodosProprietario();
                    break;
                case "4":
                    crudProprietario.select();
                    crudProprietario.delete(metodoOpcao);
                    Console.Clear();
                    break;
                case "5":
                    Console.Clear();
                    escolhaEntidade();
                    Console.Clear();
                    break;
                case "0":
                    Console.Clear();
                    msg.goodBye();
                    System.Environment.Exit(1);
                    break;
                default:
                    msg.opcaoInvalida();
                    Console.ReadKey();
                    Console.Clear();
                    listaMetodosProprietario();
                    break;
            }
        }

        public void listaMetodosInquilino()
        {

            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ SISTEMA ADMINISTRAÇÃO DE CONDOMÍNIOS ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n" +
                          "▒                                                                                                    ▒\n" +
                          "▒                                                                                                    ▒\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("▒ ╔══════════════════════════════════ MANUTENÇÃO INQUILINO═════════════════════════════════════════╗ ▒\n" +
                          "▒ ║                                                                                                ║ ▒\n" +
                          "▒ ║    1   =>  Novo    Inquilino                                                                      ║ ▒\n" +
                          "▒ ║    2   =>  Alterar Inquilino                                                                   ║ ▒\n" +
                          "▒ ║    3   =>  Listar  Inquilino                                                                    ║ ▒\n" +
                          "▒ ║    4   =>  Excluir Inquilino                                                                   ║ ▒\n" +
                          "▒ ║    5   =>  Voltar ao Opcoes Inicial                                                            ║ ▒\n" +
                          "▒ ║    0   =>  Sair                                                                                ║ ▒\n" +
                          "▒ ║                                                                                                ║ ▒\n" +
                          "▒ ╚════════════════════════════════════════════════════════════════════════════════════════════════╝ ▒\n" +
                          "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.Write("═══════════════>  Digite a Opção Desejada: ");
            string opcao = Console.ReadLine();

            FormInquilino formInquilino = new FormInquilino();
            Mensagens msg = new Mensagens();
            InquilinoDAO crudInquilino = new InquilinoDAO();
            MetodosDeComando metodoOpcao = new MetodosDeComando();

            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    formInquilino.formInquilino();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "2":
                    Console.Clear();
                    crudInquilino.select();
                    metodoOpcao.alterarInquilino();
                    Console.Clear();
                    break;
                case "3":
                    Console.Clear();
                    crudInquilino.select();
                    Console.ReadKey();
                    Console.Clear();
                    listaMetodosInquilino();
                    break;
                case "4":
                    crudInquilino.select();
                    crudInquilino.delete(metodoOpcao);
                    Console.Clear();
                    break;
                case "5":
                    Console.Clear();
                    escolhaEntidade();
                    Console.Clear();
                    break;
                case "0":
                    msg.goodBye();
                    System.Environment.Exit(1);
                    break;
                default:
                    msg.opcaoInvalida();
                    Console.ReadKey();
                    Console.Clear();
                    listaMetodosInquilino();
                    break;
            }
        }


        public void menuAdministrativo()
        {
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ SISTEMA ADMINISTRAÇÃO DE CONDOMÍNIOS ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n" +
                          "▒                                                                                                    ▒\n" +
                          "▒                                                                                                    ▒\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("▒ ╔══════════════════════════════════ MENU ADMINISTRATIVO ═════════════════════════════════════════╗ ▒\n" +
                          "▒ ║                                                                                                ║ ▒\n" +
                          "▒ ║    1   =>  Incluir Dívida                                                                      ║ ▒\n" +
                          "▒ ║    2   =>  Quitar  Dívida                                                                      ║ ▒\n" +
                          "▒ ║    3   =>  Relatório                                                                          ║ ▒\n" +
                          "▒ ║    4   =>  Voltar ao Menu Anterior                                                             ║ ▒\n" +
                          "▒ ║    0   =>  Sair                                                                                ║ ▒\n" +
                          "▒ ║                                                                                                ║ ▒\n" +
                          "▒ ╚════════════════════════════════════════════════════════════════════════════════════════════════╝ ▒\n" +
                          "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.Write("═══════════════>  Digite a Opção Desejada: ");
            string opcao = Console.ReadLine();

            MetodosDeComando metodoOpcao = new MetodosDeComando();
            FormContasAPagar formDivida = new FormContasAPagar();
            ContasAPAgarDAO crudDivida = new ContasAPAgarDAO();
            RelatorioFicheiro ficheiro = new RelatorioFicheiro();
            ArquivoTXT arquivo = new ArquivoTXT();
            Mensagens msg = new Mensagens();

            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    formDivida.formularioDivida();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "2":
                    Console.Clear();
                    crudDivida.select();
                    metodoOpcao.alteraDivida();
                    Console.Clear();

                    break;
                case "3":
                    Console.Clear();
                    relatorios();
                    Console.Clear();
                    break;
                case "4":
                    Console.Clear();
                    menuInicial();
                    break;
                case "0":
                    Console.Clear();
                    msg.goodBye();
                    System.Environment.Exit(1);
                    break;
                default:
                    msg.opcaoInvalida();
                    Console.ReadKey();
                    Console.Clear();
                    menuAdministrativo();
                    break;
            }
        }

        public void listaMetodosUnidade()
        {

            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ SISTEMA ADMINISTRAÇÃO DE CONDOMÍNIOS ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n" +
                          "▒                                                                                                    ▒\n" +
                          "▒                                                                                                    ▒\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("▒ ╔══════════════════════════════════ MANUTENÇÃO INQUILINO═════════════════════════════════════════╗ ▒\n" +
                          "▒ ║                                                                                                ║ ▒\n" +
                          "▒ ║    1   =>  Novo    Unidade                                                                     ║ ▒\n" +
                          "▒ ║    2   =>  Alterar Unidade                                                                     ║ ▒\n" +
                          "▒ ║    3   =>  Listar  Unidade                                                                     ║ ▒\n" +
                          "▒ ║    4   =>  Excluir Unidade                                                                     ║ ▒\n" +
                          "▒ ║    5   =>  Voltar ao Opcoes Inicial                                                            ║ ▒\n" +
                          "▒ ║    0   =>  Sair                                                                                ║ ▒\n" +
                          "▒ ║                                                                                                ║ ▒\n" +
                          "▒ ╚════════════════════════════════════════════════════════════════════════════════════════════════╝ ▒\n" +
                          "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.Write("═══════════════>  Digite a Opção Desejada: ");
            string opcao = Console.ReadLine();

            FormUnidade formUnidade = new FormUnidade();
            Mensagens msg = new Mensagens();
            UnidadeDAO crudUnidade = new UnidadeDAO();
            MetodosDeComando metodoOpcao = new MetodosDeComando();

            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    formUnidade.formUnidade();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "2":
                    Console.Clear();
                    crudUnidade.select();
                    metodoOpcao.alteraUnidade();
                    Console.Clear();
                    break;
                case "3":
                    Console.Clear();
                    crudUnidade.select();
                    Console.ReadKey();
                    Console.Clear();
                    listaMetodosUnidade();
                    break;
                case "4":
                    crudUnidade.select();
                    crudUnidade.delete(metodoOpcao);
                    Console.Clear();
                    break;
                case "5":
                    Console.Clear();
                    escolhaEntidade();
                    Console.Clear();
                    break;
                case "0":
                    msg.goodBye();
                    System.Environment.Exit(1);
                    break;
                default:
                    msg.opcaoInvalida();
                    Console.ReadKey();
                    Console.Clear();
                    listaMetodosUnidade();
                    break;
            }
        }

        public void relatorios()
        {
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ SISTEMA ADMINISTRAÇÃO DE CONDOMÍNIOS ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n" +
                          "▒                                                                                                    ▒\n" +
                          "▒                                                                                                    ▒\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("▒ ╔══════════════════════════════════ MENU ADMINISTRATIVO ═════════════════════════════════════════╗ ▒\n" +
                          "▒ ║                                                                                                ║ ▒\n" +
                          "▒ ║    1   =>  Pendências Financeira                                                               ║ ▒\n" +
                          "▒ ║    2   =>  Consulta Unidade Por Proprietário                                                   ║ ▒\n" +
                          "▒ ║    3   =>  Unidade com Maior Saldo Devedor                                                     ║ ▒\n" +
                          "▒ ║    4   =>  Voltar ao Menu Anterior                                                             ║ ▒\n" +
                          "▒ ║    0   =>  Sair                                                                                ║ ▒\n" +
                          "▒ ║                                                                                                ║ ▒\n" +
                          "▒ ╚════════════════════════════════════════════════════════════════════════════════════════════════╝ ▒\n" +
                          "▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\n");
            Console.Write("═══════════════>  Digite a Opção Desejada: ");
            string opcao = Console.ReadLine();
            RelatorioDAO d = new RelatorioDAO();
            ContasAPAgarDAO contas = new ContasAPAgarDAO();
            Mensagens msg = new Mensagens();

            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    contas.select();
                    Console.Read();
                    break;
                case "2":
                    Console.Clear();
                    d.selectQuantidadeUnidadeProprieario();
                    Console.Read();
                    break;
                case "3":
                    Console.Clear();
                    d.maiorValorDevido();
                    break;
                case "0":
                    Console.Clear();
                    msg.goodBye();
                    System.Environment.Exit(1);
                    break;
                default:
                    msg.opcaoInvalida();
                    Console.ReadKey();
                    Console.Clear();
                    menuAdministrativo();
                    break;
            }
        }
    }
}
