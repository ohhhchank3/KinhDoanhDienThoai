using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DAO
{
    public class DBConnection
    {
        public SqlDataAdapter adapter;
        public SqlConnection connection;
        public DBConnection()
        {
            adapter = new SqlDataAdapter();
            connection = new SqlConnection(Properties.Resources.cnnStr);
        }
        public SqlConnection openConnection()
        {
            if (connection.State == ConnectionState.Closed || connection.State ==
            ConnectionState.Broken)
            {
                connection.Open();
            }
            return connection;
        }
        public void executeInsertQuery(String query, SqlParameter[] sqlParameter)
        {
            using (SqlCommand sqlCommand = new SqlCommand(query, openConnection()))
            {
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Parameters.AddRange(sqlParameter);
                openConnection().InfoMessage += Cnn_infomessage;
                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public void executeUpdateOrDeleteQuery(String query, SqlParameter[] sqlParameter)
        {
            using (SqlCommand sqlCommand = new SqlCommand(query, openConnection()))
            {
                openConnection().InfoMessage += Cnn_infomessage;
                int i = 0;
                try
                {
                    while (i < sqlParameter.Length)
                    {
                        sqlCommand.Parameters.AddWithValue(sqlParameter[i].ParameterName, sqlParameter[i].Value);
                        i++;
                    }
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public DataTable executeDisplayQuery(String query)
        {
            using (SqlCommand sqlCommand = new SqlCommand(query, openConnection()))
            {
                DataTable dt = new DataTable();
                try
                {
                    sqlCommand.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    da.Fill(dt);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return dt;
            }
        }
        public DataTable executeFindQuery(String query, SqlParameter[] sqlParameter)
        {
            using (SqlCommand sqlCommand = new SqlCommand(query, openConnection()))
            {
                DataTable dt = new DataTable();
                int i = 0;
                try
                {
                  
                    while (i < sqlParameter.Length)
                    {
                        sqlCommand.Parameters.AddWithValue(sqlParameter[i].ParameterName, sqlParameter[i].Value);
                        i++;
                    }
                    sqlCommand.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    da.Fill(dt);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return dt;
            }
        }
        public DataTable executeSearchQuery(String query, SqlParameter[] sqlParameter)
        {
            using (SqlCommand sqlCommand = new SqlCommand(query, openConnection()))
            {
                DataTable dt = new DataTable();
                int i = 0;
                try
                {
                    while (i < sqlParameter.Length)
                    {
                        sqlCommand.Parameters.AddWithValue(sqlParameter[i].ParameterName, sqlParameter[i].Value);
                        i++;
                    }
                    sqlCommand.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    da.Fill(dt);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                return dt;
            }
        }
        // bắt lỗi trigger(bẫy lỗi) 
        private void Cnn_infomessage(object sender, SqlInfoMessageEventArgs e)
        {
            MessageBox.Show(e.Message);
        }
    }
}
