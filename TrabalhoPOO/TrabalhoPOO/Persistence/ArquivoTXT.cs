using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TrabalhoPOO.View;
using TrabalhoPOO.Model;

namespace TrabalhoPOO.Persistence
{
    public class ArquivoTXT
    {
        StreamWriter escreve;
        StreamReader ler;
        string ficheiro = @"relatorioFinanceiro.txt";
        ContasAPagar div = new ContasAPagar();
        Menu menu = new Menu();
        
        public void arquivoTXT(string descricaoDivida, DateTime dataDivida, decimal valorDivida, string unidade)
        {
            Console.Clear();
            try
            {
                if (File.Exists(ficheiro).Equals(true))
                {
                    escreve = File.AppendText(ficheiro);                    
                    menu.menuAdministrativo();
                }
                else
                {
                    escreve = File.CreateText(ficheiro);                   
                    menu.menuAdministrativo();
                }

                string linha = descricaoDivida + ";\t" + dataDivida + ";\t" + valorDivida + ";\t" + unidade;
                escreve.WriteLine(linha);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
            finally
            {
                escreve.Close();
            }
            
        }

        public void imprimirDividas()
        {
            Console.Clear();
            RelatorioFicheiro relatorio = new RelatorioFicheiro();
            try
            {
                if (File.Exists(ficheiro).Equals(true))
                {
                    relatorio.print();

                    ler = File.OpenText(ficheiro);
                    string linha = "";
                    while ((linha = ler.ReadLine()) != null)
                    {
                        string[] campos = new string[4];
                        campos = linha.Split(';');
                        Console.WriteLine("  {0}\t\t\t{1}\t{2}\t\t{3}", campos[0], campos[1], campos[2], campos[3]);
                    }
                    ler.Close();
                    Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");

                    Console.WriteLine("\n\tTecle Enter para voltar ao Menu");                   
                }
                else
                {
                    Console.WriteLine("Ficheiro de regiostro não encontrado!");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Erro: "+ ex.Message);
            }
            Console.ReadLine();
        }
        
    }
}