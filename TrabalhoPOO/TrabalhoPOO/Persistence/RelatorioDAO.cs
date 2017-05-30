using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPOO.View;

namespace TrabalhoPOO.Persistence
{
    public class RelatorioDAO
    {
        public RelatorioDAO()
        {

        }

        private Persistence.conexao db;
        private SqlConnection con;
        Relatorio relatorio = new Relatorio();

        public void selectDividaEmAtraso()
        {
            con = new SqlConnection();
            db = new Persistence.conexao();
            con.ConnectionString = db.getConnectionString();

            SqlDataReader dr = null;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT a.id_Divida, a.descricaoDivida, a.dataVencimento, a.valorDivida, " +
                                                       "b.nome " +
                                               "FROM Divida as A INNER JOIN Proprietario as B on b.nome = b.nome " +
                                               "WHERE dataVencimento  > GETDATE()", con);

                dr = cmd.ExecuteReader();
               // relatorio.printPessoa(); // Classe Relatório

                Console.ForegroundColor = ConsoleColor.Cyan;
                while (dr.Read())
                {
                    Console.WriteLine(" {0,2} | {1,15} | {2,12} | {3,10}, | {4,10}",
                        dr[0], dr[1], dr[2], dr[3], dr[4]);
                    Console.WriteLine("▒------------------------------------------------------------------------------------------------------------------------------------------------------▒\n");
                }
                Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                Console.ForegroundColor = ConsoleColor.White;

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO: ", ex.Message);
            }
            finally
            {
                if (dr != null)
                {
                    dr.Close();
                }
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public void maiorValorDevido()
        {
            con = new SqlConnection();
            db = new Persistence.conexao();
            con.ConnectionString = db.getConnectionString();

            SqlDataReader dr = null;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select MAX(divi.valorDivida) from dbo.Divida divi", con);

                dr = cmd.ExecuteReader();
                // relatorio.printPessoa(); // Classe Relatório

                Console.ForegroundColor = ConsoleColor.Cyan;
                while (dr.Read())
                {
                    Console.WriteLine(" {0,2}",
                        dr[0]);
                    Console.WriteLine("▒------------------------------------------------------------------------------------------------------------------------------------------------------▒\n");
                }
                Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                Console.ForegroundColor = ConsoleColor.White;

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO: ", ex.Message);
            }
            finally
            {
                if (dr != null)
                {
                    dr.Close();
                }
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public void selectQuantidadeUnidadeProprieario()
        {
            con = new SqlConnection();
            db = new Persistence.conexao();
            con.ConnectionString = db.getConnectionString();

            SqlDataReader dr = null;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT prop.nome, count(prop.nome) as qtd_unidade " +
                                                    "FROM dbo.Unidade unid, dbo.Proprietario prop " +
                                                    "WHERE  prop.id_Proprietario = unid.id_Proprietario group by prop.nome", con);

                dr = cmd.ExecuteReader();
                relatorio.pintQuantidadeUnidadeProprietario(); // Classe Relatório

                Console.ForegroundColor = ConsoleColor.Cyan;
                while (dr.Read())
                {
                    Console.WriteLine(" {0,30} | {1,15} ",
                        dr[0], dr[1]);
                    Console.WriteLine("▒----------------------------------------------------------------------------------------------------▒\n");
                }
                Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                Console.ForegroundColor = ConsoleColor.White;

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO: ", ex.Message);
            }
            finally
            {
                if (dr != null)
                {
                    dr.Close();
                }
                if (con != null)
                {
                    con.Close();
                }
            }
        }
    }
}
