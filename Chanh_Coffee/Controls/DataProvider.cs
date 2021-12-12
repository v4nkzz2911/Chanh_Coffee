using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Chanh_Coffee.Controls
{
    public class DataProvider
    {
        private static DataProvider instace;
        
        
        private string connectionSTR = "Data Source=.\\sqlexpress;Initial Catalog=QuanLyQuanCafe;Integrated Security=True";

        public static DataProvider Instace 
        { 
            get { if (instace == null) instace = new DataProvider(); return instace; }
            private set => instace = value; 
        }

        private DataProvider()
        {

        }

        public DataTable ExcuteQuerry(string querry, object[] paramenter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(querry, connection);
                if (paramenter != null)
                {
                    string[] listPara = querry.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, paramenter[i]);
                            i++;
                        }
                    }

                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();

            }
            return data;
        }

        public int ExcuteNonQuerry(string querry, object[] paramenter = null)
        {
            int data =0 ;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(querry, connection);
                if (paramenter != null)
                {
                    string[] listPara = querry.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, paramenter[i]);
                            i++;
                        }
                    }

                }
                data = command.ExecuteNonQuery();


                connection.Close();

            }
            return data;
        }

        public object ExcuteScalar(string querry, object[] paramenter = null)
        {
            object data = 0 ;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(querry, connection);
                if (paramenter != null)
                {
                    string[] listPara = querry.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, paramenter[i]);
                            i++;
                        }
                    }

                }

                data = command.ExecuteScalar();

                connection.Close();

            }
            return data;
        }
    }
}
