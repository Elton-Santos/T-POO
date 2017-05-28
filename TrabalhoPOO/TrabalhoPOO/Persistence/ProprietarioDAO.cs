using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPOO.Controller;
using TrabalhoPOO.Model;
using TrabalhoPOO.View;

namespace TrabalhoPOO.Persistence
{
    public class ProprietarioDAO
    {
        public ProprietarioDAO()
        {
        }

        private Persistence.conexao db;
        private SqlConnection con;
        Relatorio relatorio = new Relatorio();

        public void insert(Proprietario dados)
        {
            con = new SqlConnection();
            db = new Persistence.conexao();
            con.ConnectionString = db.getConnectionString();

            SqlCommand cmd = new SqlCommand("INSERT INTO Proprietario(nome, cpf, rg, dataNascimento, estadoCivil)" +
                                                "VALUES(@nome, @cpf, @rg, @dataNascimento, @estadoCivil)", con);
            try
            {
                cmd.Parameters.AddWithValue("@nome", dados.Nome);
                cmd.Parameters.AddWithValue("@cpf", dados.Cpf);
                cmd.Parameters.AddWithValue("@rg", dados.Rg);
                cmd.Parameters.AddWithValue("dataNascimento", dados.DataNascimento);
                cmd.Parameters.AddWithValue("@estadoCivil", dados.EstadoCivil);

                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Dados Gravados com Sucesso!");
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: ", ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void select()
        {
            con = new SqlConnection();
            db = new Persistence.conexao();
            con.ConnectionString = db.getConnectionString();

            SqlDataReader dr = null;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Proprietario", con);
                dr = cmd.ExecuteReader();
                relatorio.printPessoa(); // Classe Relatório

                Console.ForegroundColor = ConsoleColor.Cyan;
                while (dr.Read())
                {
                    Console.WriteLine(" {0} \t {1} \t {2} \t {3} \t {4} \t  {5} \t {6}",
                        dr[0], dr[1], dr[2], dr[3], dr[4], dr[5], dr[6]);
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

        public void delete(MetodosDeComando p)
        {
            con = new SqlConnection();
            db = new Persistence.conexao();
            con.ConnectionString = db.getConnectionString();

            SqlCommand cmd = new SqlCommand("DELETE FROM Proprietario WHERE id_Proprietario='" + p.deletar() + "';", con);

            try
            {                
                con.Open();                
                cmd.ExecuteNonQuery();                
                Console.WriteLine("\n\tDados Excluidos com Sucesso! Tecle enter para voltar o Menu Inicial.\n");
                Console.ReadKey();
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

        public void alterar(int id, string nome)
        {
            con = new SqlConnection();
            db = new Persistence.conexao();
            con.ConnectionString = db.getConnectionString();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Proprietario SET nome = '" + nome + "'WHERE id_Proprietario=" + id + ";", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("\tDados Alterados com Sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
