using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleGastoAppData.Dto;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using System.Diagnostics;

namespace ControleGastoAppData.Dao
{
    public class DespesaDao : BancodadosDao 
    {
        public bool IncluirDespesa(Despesa despesa)
        {
            SqlConnection sqlConnection = new SqlConnection(this.conexao);

            string sql = "Insert into despesa (codPessoa, tipoDespesa, valorDespesa, dataDespesa) " +
                "                     Values(@codPessoa, @tipoDespesa, @valorDespesa, @dataDespesa);";

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;

            
            sqlCommand.Parameters.AddWithValue("codPessoa", despesa.CodPessoa);
            sqlCommand.Parameters.AddWithValue("tipoDespesa", despesa.TipoDespesa);
            sqlCommand.Parameters.AddWithValue("valorDespesa", despesa.ValorDespesa);
            sqlCommand.Parameters.AddWithValue("dataDespesa", despesa.DataDespesa);
            


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
                //return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public bool AlterarDespesa(Despesa despesa)
        {
            SqlConnection sqlConnection = new SqlConnection(this.conexao);

            string sql = "Update despesa set codPessoa = @codPessoa, tipoDespesa = @tipoDespesa, " +
                                            "valorDespesa = @valorDespesa, dataDespesa = @dataDespesa " +
                                            "Where despesa.codDespesa = @codDespesa";

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;

            sqlCommand.Parameters.AddWithValue("@codPessoa", despesa.CodPessoa);
            sqlCommand.Parameters.AddWithValue("@tipoDespesa", despesa.TipoDespesa);
            sqlCommand.Parameters.AddWithValue("@valorDespesa", despesa.ValorDespesa);
            sqlCommand.Parameters.AddWithValue("@codDespesa", despesa.CodDespesa);
            sqlCommand.Parameters.AddWithValue("@dataDespesa", despesa.DataDespesa);

            try
            {
                sqlConnection.Open();

                sqlCommand.ExecuteNonQuery();

                return true;
            }
            catch (Exception erro)
            {

                throw new Exception("Ocorreu um erro" + erro.Message);
               // Debug.WriteLine("Ocorreu uma falha" + erro.Message);
                //return false;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public bool ExcluirDespesa(int codDespesa)
        {
            SqlConnection sqlConnection = new SqlConnection(this.conexao);

            string sql = " Delete  From despesa Where codDespesa = @codDespesa";

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("codDespesa", codDespesa);
            

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

        public Despesa ObtemDespesa(int codDespesa)
        {
            SqlConnection sqlConnection = new SqlConnection(this.conexao);

            string sql = " Select * From despesa Where codDespesa = @codDespesa";

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("codDespesa", codDespesa);
            try
            {
                sqlConnection.Open();

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                Despesa despesa = new Despesa();

                while (sqlDataReader.Read())
                {
                    despesa.CodDespesa = Convert.ToInt32(sqlDataReader["codDespesa"]);
                    despesa.CodPessoa = Convert.ToInt32(sqlDataReader["codPessoa"]);
                    despesa.TipoDespesa = sqlDataReader["tipoDespesa"].ToString();
                    despesa.ValorDespesa = Convert.ToDouble(sqlDataReader["valorDespesa"]);
                    despesa.DataDespesa = Convert.ToDateTime(sqlDataReader["dataDespesa"]);
                    

                }

                return despesa;


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

        public DataSet ListaDespesa(int codDespesa)
        {
            SqlConnection sqlConnection = new SqlConnection(this.conexao);

            string sql = 
                "select despesa.codDespesa, pessoa.nome ,tipoDespesa as 'Tipo da Despesa', " +
                "valorDespesa as 'Valor da despesa', dataDespesa as 'Data da Despesa' from despesa, pessoa" +
                " where despesa.codPessoa = pessoa.codPessoa;";

            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = sql;
            sqlCommand.Connection = sqlConnection;
            
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            try
            {
                sqlConnection.Open();

                DataSet dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "despesa");

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

        public DataSet ObtemDespesaDaPessoa(int codPessoa)
        {
            SqlConnection sqlConnection = new SqlConnection(this.conexao);

            string sql = "select despesa.tipoDespesa as 'Despesa', despesa.valorDespesa as 'Valor da Despesa' " +
                " " +
                "from despesa where despesa.codPessoa = @codpessoa";

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

                sqlDataAdapter.Fill(dataSet, "despesa");

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

        public bool DeletarTudoDespesa(int codPessoa)
        {
            SqlConnection sqlConnection = new SqlConnection(this.conexao);

            string sql = " Delete  From despesa Where despesa.codPessoa = @codPessoa;";

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
