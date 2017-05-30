using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPOO.View;

namespace TrabalhoPOO.Persistence
{
    public class EnderecoDAO
    {
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM Endereco", con);
                dr = cmd.ExecuteReader();
                relatorio.printEndereco(); // Classe Relatório

                Console.ForegroundColor = ConsoleColor.Cyan;
                while (dr.Read())
                {
                    Console.WriteLine("| {0,3} | {1,25} | {2,5} | {3,15} | {4,10} |  {5,18} | {6,3} |",
                        dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);
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
