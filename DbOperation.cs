using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace ExecuteScript
{
   public class DbOperation
    {
        public DataTable Listele(string sorgu,string server, string port, string username, string password, string database)
        {      
            MySqlDataAdapter dap = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection("server="+server+";port="+port+";username="+username+";password="+password+";database="+database+";persistsecurityinfo=True;");          
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = sorgu;
                cmd.ExecuteNonQuery();
                dap.SelectCommand = cmd;
                dap.Fill(ds);
                return ds.Tables[0];                
            }
            catch (MySqlException e)
            {
                throw new Exception("Hata!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

      
    }
}
