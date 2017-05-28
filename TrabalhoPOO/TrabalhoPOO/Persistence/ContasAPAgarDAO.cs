using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPOO.View;
using TrabalhoPOO.Model;
using TrabalhoPOO.Persistence;

namespace TrabalhoPOO.Controller
{
    public class ContasAPAgarDAO
    {
        public ContasAPAgarDAO()
        {
        }

        private Persistence.conexao db;
        private SqlConnection con;
        Relatorio relatorio = new Relatorio();

        public void select()
        {
            con = new SqlConnection();
            db = new Persistence.conexao();
            con.ConnectionString = db.getConnectionString();

            SqlDataReader dr = null;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Divida", con);
                dr = cmd.ExecuteReader();
                relatorio.printQuantidadePRoprietario(); // Classe Relatório

                Console.ForegroundColor = ConsoleColor.Cyan;
                while (dr.Read())
                {
                    Console.WriteLine(" {0,2} \t {1,10} \t {2,10} \t {3,10} \t {4,10}",
                        dr[0], dr[1], dr[2], dr[3], dr[4]);
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

        public void insert(ContasAPagar div)
        {
            con = new SqlConnection();
            db = new Persistence.conexao();
            con.ConnectionString = db.getConnectionString();

            SqlCommand cmd = new SqlCommand(@"INSERT into Divida(descricaoDivida, dataVencimento, valorDivida) 
                                                VALUES (@Param1, @Param2, @Param3)", con);
            try
            {
                cmd.Parameters.AddWithValue("@Param1", div.DescricaoDivida);
                cmd.Parameters.AddWithValue("@Param2", div.DataVencimento);
                cmd.Parameters.AddWithValue("@Param3", div.ValorDivida);

                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Dados Gravados com Sucesso!");
                Console.ReadKey();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                con.Close();
            }
        }

        public void delete(MetodosDeComando p)
        {
            con = new SqlConnection();
            db = new Persistence.conexao();
            con.ConnectionString = db.getConnectionString();
            
            SqlCommand cmd = new SqlCommand("DELETE FROM ContasAPagar WHERE id_Financeiro='" + p.deletar() + "';", con);

            try
            {                
                con.Open();
                cmd.ExecuteNonQuery();          
                Console.WriteLine("\n\tDados excluidos!\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void alterar(int id, string valorDivida)
        {
            con = new SqlConnection();
            db = new Persistence.conexao();
            con.ConnectionString = db.getConnectionString();

            SqlCommand cmd = new SqlCommand("UPDATE ContasAPagar SET valorDivida = '" + valorDivida + "'WHERE id_Financeiro=" + id + ";", con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                
                Console.WriteLine("\tDados Alterados com Sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
