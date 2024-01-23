using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DytBaharucarAppfinal
{
    public partial class Olcumler : Form
    {
        public Olcumler()
        {
            InitializeComponent();
        }
        private void OlcumlerFillComboBox()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-V3JP2V0\\SQLEXPRESS; Initial Catalog=dytBahar;Integrated Security=True")) // Bağlantı dizesini kendi bağlantı dizenizle değiştirin.
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT DISTINCT Name FROM patient", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // ComboBox'a isimleri ekleyin.
                            OlcumlerComboBox.Items.Add(reader["Name"].ToString());
                        }
                    }
                }
            }
        }
        private void Olcumler_Load(object sender, EventArgs e)
        {
            OlcumlerFillComboBox();
        }
    }
}
