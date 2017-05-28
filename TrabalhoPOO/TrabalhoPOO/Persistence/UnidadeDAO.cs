using System;
using System.Data;
using System.Data.SqlClient;
using TrabalhoPOO.Controller;
using TrabalhoPOO.Model;
using TrabalhoPOO.Persistence;
using TrabalhoPOO.View;

namespace TrabalhoPOO.View
{
    public class UnidadeDAO
    {
        public int opcao;


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
                SqlCommand cmd = new SqlCommand("SELECT * FROM Unidade", con);
                dr = cmd.ExecuteReader();
                relatorio.printQuantidadePRoprietario(); // Classe Relatório

                Console.ForegroundColor = ConsoleColor.Cyan;
                while (dr.Read())
                {
                    Console.WriteLine(" {0,2} \t {1,10} \t {2,10} \t {3,10} ",
                        dr[0], dr[1], dr[2], dr[3]);
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

        public void insert(Unidade uni)
        {

            con = new SqlConnection();
            db = new Persistence.conexao();
            con.ConnectionString = db.getConnectionString();


            try
            {

                SqlCommand cmd = new SqlCommand("INSERT into Unidade(nomeUnidade, bloco, ruaInterna, numAP, nome, cpf) " +
                                                  "VALUES (@nomeUnidade, @bloco, @ruaInterna, @numAP, @nome, @cpf)", con);

                cmd.Parameters.AddWithValue("@nomeUnidade", uni.NomeUnidade);
                cmd.Parameters.AddWithValue("@bloco", uni.Bloco);
                cmd.Parameters.AddWithValue("@ruaInterna", uni.RuaInterna);
                cmd.Parameters.AddWithValue("@numAP", uni.NumAP);
                cmd.Parameters.AddWithValue("@nome", uni.Proprietario.Nome);
                cmd.Parameters.AddWithValue("@cpf", uni.Proprietario.Cpf);


                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("\n\t## Cadastro realizado com sucesso! ##\n");

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        public void delete(MetodosDeComando p)
        {
            con = new SqlConnection();
            db = new Persistence.conexao();
            con.ConnectionString = db.getConnectionString();

            SqlCommand cmd = new SqlCommand("DELETE FROM Unidade WHERE id_Unidade='" + p.deletar() + "';", con);

            try
            {
               
                con.Open();             
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine("\n\tDados excluidos!\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void alterar(int id, string nome)
        {
            con = new SqlConnection();
            db = new Persistence.conexao();
            con.ConnectionString = db.getConnectionString();

            SqlCommand cmd = new SqlCommand("UPDATE Unidade SET nomeUnidade = '" + nome + "'WHERE id_Unidade=" + id + ";", con);

            try
            {
                con.Open();               
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
