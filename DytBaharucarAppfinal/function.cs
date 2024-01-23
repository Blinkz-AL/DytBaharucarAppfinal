using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DytBaharucarAppfinal.functions
{
    class function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection
            {
                ConnectionString = "Data Source=DESKTOP-V3JP2V0\\SQLEXPRESS; Initial Catalog=dytBahar;Integrated Security=True"
        };
            return con;
        }
        
        public DataSet getData(String query) //Get data from database
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }
        public void setDataWithParameters(String query, params SqlParameter[] parameters)
        {
            SqlConnection con = getConnection();
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = query;

                // Add parameters to the command
                cmd.Parameters.AddRange(parameters);

                cmd.ExecuteNonQuery();
            }
            con.Close();
            MessageBox.Show("Başarılı");
        }


    }
}
