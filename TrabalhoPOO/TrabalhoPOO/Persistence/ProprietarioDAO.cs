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

        public void insertDadosPessoais(Proprietario dados)
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
                Console.WriteLine("\n| Dados Gravados com Sucesso!");
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

        public void insertEndereco(Proprietario dados)
        {
            con = new SqlConnection();
            db = new Persistence.conexao();
            con.ConnectionString = db.getConnectionString();

            SqlCommand cmd = new SqlCommand("INSERT INTO Endereco(logradouro, numero, complemento, cep, estado, uf, bairro) VALUES(@logradouro, @numero, @complemento, @cep, @estado, @uf, @bairro)", con);

            try
            {
                cmd.Parameters.AddWithValue("@logradouro", dados.Endereco.Logradouro);
                cmd.Parameters.AddWithValue("@numero", dados.Endereco.Numero);
                cmd.Parameters.AddWithValue("@complemento", dados.Endereco.Complemento);
                cmd.Parameters.AddWithValue("@cep", dados.Endereco.Cep);
                cmd.Parameters.AddWithValue("@estado", dados.Endereco.Estado);
                cmd.Parameters.AddWithValue("@uf", dados.Endereco.Uf);
                cmd.Parameters.AddWithValue("@bairro", dados.Endereco.Bairro);

                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("\n| Dados Gravados com Sucesso!");              
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

        public void insertContato(Proprietario dados)
        {
            con = new SqlConnection();
            db = new Persistence.conexao();
            con.ConnectionString = db.getConnectionString();

            SqlCommand cmd = new SqlCommand("INSERT INTO Contato(Residencial, celular, email) VALUES(@Residencial, @celular, @email)", con);
            try
            {
                cmd.Parameters.AddWithValue("@Residencial", dados.Contato.TelResidencial);
                cmd.Parameters.AddWithValue("@celular", dados.Contato.Celular);
                cmd.Parameters.AddWithValue("@email", dados.Contato.Email);

                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("\n| Dados Gravados com Sucesso!");
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

        public void insertUnidade(Proprietario dados)
        {
            con = new SqlConnection();
            db = new Persistence.conexao();
            con.ConnectionString = db.getConnectionString();

            SqlCommand cmd = new SqlCommand("INSERT INTO Unidade(nomeUnidade, bloco, ruaInterna, numAP) VALUES(@nomeUnidade, @bloco, @ruaInterna, @numAP)", con);
            try
            {
                cmd.Parameters.AddWithValue("@nomeUnidade", dados.Unidade.NomeUnidade);
                cmd.Parameters.AddWithValue("@bloco", dados.Unidade.Bloco);
                cmd.Parameters.AddWithValue("@ruaInterna", dados.Unidade.RuaInterna);
                cmd.Parameters.AddWithValue("@numAP", dados.Unidade.NumAP);

                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("\n| Dados Gravados com Sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
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
