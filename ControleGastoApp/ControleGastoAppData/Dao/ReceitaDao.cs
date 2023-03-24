using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ControleGastoAppData.Dto;
using System.Net.Http.Headers;

namespace ControleGastoAppData.Dao
{
    public class ReceitaDao : BancodadosDao
    {
        public bool IncluirReceita(Receita receita)
        {
            SqlConnection sqlConnection = new SqlConnection(this.conexao);

            string sql = "Insert into receita (codPessoa, valorRenda, tipoRenda, dataReceita) " +
                "Values (@codPessoa, @valorRenda, @tipoRenda,@dataReceita);";

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;

            sqlCommand.Parameters.AddWithValue("@codPessoa", receita.CodPessoa);
            sqlCommand.Parameters.AddWithValue("@valorRenda", receita.ValorRenda);
            sqlCommand.Parameters.AddWithValue("@TipoRenda", receita.TipoRenda);
            sqlCommand.Parameters.AddWithValue("@dataReceita", receita.DataReceita);

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

        public bool AlterarReceita(Receita receita)
        {
            SqlConnection sqlConnection = new SqlConnection(this.conexao);

            string sql = "Update receita set codPessoa = @codPessoa, valorRenda = @valorRenda, tipoRenda = @tipoRenda," +
                " dataReceita = @dataReceita " +
                " Where receita.codReceita = @codReceita;"; 
                

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;

            sqlCommand.Parameters.AddWithValue("@codPessoa", receita.CodPessoa);
            sqlCommand.Parameters.AddWithValue("@valorRenda", receita.ValorRenda);
            sqlCommand.Parameters.AddWithValue("@tipoRenda", receita.TipoRenda);
            sqlCommand.Parameters.AddWithValue("@codReceita", receita.CodReceita);
            sqlCommand.Parameters.AddWithValue("@dataReceita", receita.DataReceita);

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

        public bool ExcluirReceita(int codReceita)
        {
            SqlConnection sqlConnection = new SqlConnection(this.conexao);

            string sql = " Delete  From receita Where codReceita = @codReceita;";

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;

            sqlCommand.Parameters.AddWithValue("codReceita", codReceita);

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

        public Receita ObtemReceita(int codReceita)
        {
            SqlConnection sqlConnection = new SqlConnection(this.conexao);

            string sql = "Select * From receita Where codReceita = @codReceita;";

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("codReceita", codReceita);
            try
            {
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                Receita receita = new Receita();

                while (sqlDataReader.Read())
                {
                    receita.CodReceita = Convert.ToInt32(sqlDataReader["codReceita"]);
                    receita.CodPessoa = Convert.ToInt32(sqlDataReader["codPessoa"]);
                    receita.ValorRenda = Convert.ToDouble(sqlDataReader["valorRenda"]);
                    receita.TipoRenda = sqlDataReader["tipoRenda"].ToString();
                    receita.DataReceita = Convert.ToDateTime(sqlDataReader["dataReceita"]);
                }

                return receita;
            }
            catch (Exception erro)
            {

                throw new Exception("Ocorreu um erro" + erro.Message);
            }
        }

        public DataSet ListaReceita(int codReceita)
        {
            SqlConnection sqlConnection = new SqlConnection(this.conexao);

            string sql = " select receita.codReceita, pessoa.nome, tipoRenda as 'Tipo de Receita'," +
                " valorRenda as 'Valor da Receita', dataReceita as 'Data da Receita' from receita, pessoa " +
                "where receita.codPessoa = pessoa.codPessoa;";

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            try
            {
                sqlConnection.Open();

                DataSet dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "receita");

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

        public DataSet ObtemReceitaDaPessoa(int codPessoa) 
        {
            SqlConnection sqlConnection = new SqlConnection(this.conexao);

            string sql = "select  " +
                "receita.tipoRenda as 'Receita' ,receita.valorRenda as 'Valor da Renda'" +
                "from receita where receita.codPessoa = @codpessoa";

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@codpessoa", codPessoa);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            try
            {
                sqlConnection.Open();

                DataSet dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "receita");

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
        public bool DeletarTudoReceita(int codPessoa) 
        {
            SqlConnection sqlConnection = new SqlConnection(this.conexao);

            string sql = " Delete  From receita Where receita.codPessoa = @codPessoa;";

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;

            sqlCommand.Parameters.AddWithValue("codPessoa", codPessoa);

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
    }
}
