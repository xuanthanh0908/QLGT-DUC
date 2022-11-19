using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BAOCAO
{
    class ConnectToDB
    {
        public static string conn = @"Data Source=ADMIN-PC\SQLEXPRESS;Initial Catalog=QLPT;Persist Security Info=True;User ID=sa;Password = sa123";
        SqlConnection connection = null;
        public DataSet get_data(string query, string table_name, List<SqlParameter> parameters)
        {

            DataSet dataSet = new DataSet();
            try
            {
                connection = new SqlConnection(conn);
                SqlDataAdapter data = new SqlDataAdapter(query, connection);
                if (parameters != null)
                    data.SelectCommand.Parameters.AddRange(parameters.ToArray());
                data.Fill(dataSet, table_name);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi :" + ex.Message);
            }

            return dataSet;
        }
        public void Excute(string query, List<SqlParameter> parameters)
        {
            try
            {
                connection = new SqlConnection(conn);
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                if (parameters != null)
                    command.Parameters.AddRange(parameters.ToArray());
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi :" + ex.Message);
            }
        }

    }
}
