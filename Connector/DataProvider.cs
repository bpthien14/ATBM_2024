using Microsoft.VisualBasic.ApplicationServices;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDLNB_PH1.Connector
{
    public class DataProvider
    {
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataProvider();
                }
                return instance;
            }
        }
        private DataProvider() { }
        StaffConn staffConn = new StaffConn();
        public DataTable ExecuteQuerry(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (OracleConnection connection = new OracleConnection(StaffConn._connStr))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand(query, connection))
                {

                    if (parameter != null)
                    {
                        string[] temp = query.Split(' ');

                        List<string> listPara = new List<string>();

                        foreach (string item in temp)
                        {
                            if (item != String.Empty && item[0] == '@')
                                listPara.Add(item);
                        }

                        for (int i = 0; i < parameter.Length; i++)
                        {
                            command.Parameters.Add(listPara[i], parameter[i]);

                        }
                    }

                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        adapter.Fill(data);
                    }
                }
                connection.Close();
            }
            return data;

        }
        public string ExecuteReader(string query, object[] parameter = null)
        {
            string data = "";
            using (OracleConnection connection = new OracleConnection(StaffConn._connStr))
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Lấy dữ liệu từ cột đầu tiên (trong trường hợp này là your_column)
                            data = reader.GetString(0);
                        }
                        reader.Close();
                    }    
            }
                connection.Close();
            }
            return data;

        }
        public int ExecuteNonQuery(string query, OracleParameter[] parameters = null)
        {
            int rowsAffected = 0;

            try
            {
                using (OracleConnection connection = new OracleConnection(StaffConn._connStr))
                {
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);

                        }

                        connection.Open();
                        //MessageBox.Show(parameters.ToString()+" "+query);
                    
                        rowsAffected = command.ExecuteNonQuery();
                       
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                // You can handle or log the exception as per your requirement
            }

            return rowsAffected;
        }

    }
}
