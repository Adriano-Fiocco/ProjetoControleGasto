using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ControleGastoAppData.Dto;
using System.Diagnostics;

namespace ControleGastoAppData.Dao
{
    public class PessoaDao : BancodadosDao
    {
        public bool IncluirPessoa(Pessoa pessoa)
        {
            SqlConnection sqlConnection = new SqlConnection(this.conexao);

            string sql = "Insert into pessoa(nome, email, cpf) Values(@nome, @email, @cpf);";

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;

            sqlCommand.Parameters.AddWithValue("@nome", pessoa.Nome);
            sqlCommand.Parameters.AddWithValue("@email", pessoa.Email);
            sqlCommand.Parameters.AddWithValue("@cpf", pessoa.Cpf);

            try
            {
                sqlConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception erro)
            {

                throw new Exception("Ocorreu um erro" + erro.Message);
                //Debug.WriteLine("Ocorreu uma falha" + erro.Message);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }

            
        }

        public bool AlterarPessoa(Pessoa pessoa)
        {
            SqlConnection sqlConnection = new SqlConnection(this.conexao);

            string sql = "Update pessoa set nome = @nome, email = @email, cpf = @cpf " +
                "Where codPessoa = @codPessoa";

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;

            sqlCommand.Parameters.AddWithValue("@nome", pessoa.Nome);
            sqlCommand.Parameters.AddWithValue("@email", pessoa.Email);
            sqlCommand.Parameters.AddWithValue("cpf", pessoa.Cpf);
            sqlCommand.Parameters.AddWithValue("@codPessoa", pessoa.CodigoPessoa);

            try
            {
                sqlConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception erro)
            {

                throw new Exception("Ocorreu um erro" + erro.Message);
                //Debug.WriteLine("Ocorreu uma falha" + erro.Message);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public bool ExcluirPessoa(int codigoPessoa)
        {
            SqlConnection sqlConnection = new SqlConnection(this.conexao);

            string sql = "Delete  From pessoa Where codPessoa = @codPessoa";

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;

            sqlCommand.Parameters.AddWithValue("@codPessoa", codigoPessoa);

            try
            {
                sqlConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception erro)
            {

                throw new Exception("Ocorreu um erro" + erro.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public Pessoa ObtemPessoa(int codigoPessoa)
        {
            SqlConnection sqlConnection = new SqlConnection(this.conexao);

            string sql = "Select * From pessoa Where codPessoa = @codPessoa";

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;

            sqlCommand.Parameters.AddWithValue("@codPessoa", codigoPessoa);

            ;

            try
            {
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                Pessoa pessoa = new Pessoa();

                while (sqlDataReader.Read())
                {
                    pessoa.CodigoPessoa = Convert.ToInt32(sqlDataReader["codPessoa"]);
                    pessoa.Nome = sqlDataReader["nome"].ToString();
                    pessoa.Email = sqlDataReader["email"].ToString();
                    pessoa.Cpf = sqlDataReader["cpf"].ToString();
                }

                return pessoa;
            }
            catch (Exception erro)
            {

                throw new Exception("Ocorreu um erro" + erro.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
        public DataSet ListaPessoa()
        {
            SqlConnection sqlConnection = new SqlConnection(this.conexao);

            string sql = "Select * From pessoa;";

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            try
            {
                sqlConnection.Open();

                DataSet dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "pessoa");

                return dataSet;
            }
            catch (Exception erro)
            {

                throw new Exception("Ocorreu um erro" + erro.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }


    }
}
