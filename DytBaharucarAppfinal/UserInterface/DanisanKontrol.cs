using DytBaharucarAppfinal.functions;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DytBaharucarAppfinal.UserInterface
{
    public partial class DanisanKontrol : UserControl
    {
        private function fn = new function();
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;

        public DanisanKontrol()
        {
            InitializeComponent();
            InitializeDatabase();
    //        SearchData(); // Sayfa yüklendiğinde arama işlemini yap
        }

        private void InitializeDatabase()
        {
            string connectionString = "Data Source=DESKTOP-V3JP2V0\\SQLEXPRESS; Initial Catalog=dytBahar;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter();
            dataSet = new DataSet();

            string query = "SELECT * FROM patient";

            try
            {
                dataAdapter.SelectCommand = new SqlCommand(query, connection);
                dataAdapter.Fill(dataSet, "patient");

                // "patient" tablosu başarıyla doldurulduysa
                if (dataSet.Tables["patient"] != null)
                {
                    // "Name" sütununu "patientname" olarak değiştir
                    if (dataSet.Tables["patient"].Columns.Contains("Name"))
                    {
                        dataSet.Tables["patient"].Columns["Name"].ColumnName = "patientname";
                    }
                    else
                    {
                        // "Name" sütunu bulunamazsa, hata mesajı gönder
                        MessageBox.Show("Name sütunu bulunamadı.");
                    }
                }
                else
                {
                    // "patient" tablosu bulunamazsa, hata mesajı gönder
                    MessageBox.Show("patient tablosu bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda detayları göster
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }

            dataGridView1.DataSource = dataSet.Tables["patient"];
        }
        private void SearchData()
        {
            string searchedName = comboBox1.Text;

            // Arama sorgusunu oluştur
            string query = $"SELECT * FROM patient WHERE Name LIKE '%{searchedName}%'";

            try
            {
                // DataAdapter'ı bu sorgu ile doldur
                dataAdapter.SelectCommand = new SqlCommand(query, connection);
                dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "patient");

                // DataGridView'i güncelle
                dataGridView1.DataSource = dataSet.Tables["patient"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
        private void DanisanKontrol_Load(object sender, EventArgs e)
        {
            // Bu metodun içine arama işlemini yapacak kodu yazabilirsiniz.
            // Ancak, şu an SearchData metodunu kullanarak yaptık.
            FillComboBox1();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchedName = comboBox1.Text;

            try
            {
                // Eğer arama kutusu boş değilse, filtreleme işlemi yap
                if (!string.IsNullOrEmpty(searchedName))
                {
                    // "patientname" sütununu kullanarak arama sorgusu oluştur
                    string query = $"SELECT * FROM patient WHERE Name LIKE '%{searchedName}%'";

                    // DataAdapter'ı bu sorgu ile doldur
                    dataAdapter.SelectCommand = new SqlCommand(query, connection);
                    dataSet = new DataSet();
                    dataAdapter.Fill(dataSet, "patient");

                    // DataGridView'i güncelle
                    dataGridView1.DataSource = dataSet.Tables["patient"];
                }
                else
                {
                    // Arama kutusu boşsa, tüm verileri göster
                    InitializeDatabase();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
        private void FillComboBox1()
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
                            comboBox1.Items.Add(reader["Name"].ToString());
                        }
                    }
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilen öğeyi kontrol et
            if (comboBox1.SelectedItem != null)
            {
                // Seçilen ismi alabilirsiniz.
                string selectedName = comboBox1.SelectedItem.ToString();

                // Bu ismi kullanarak istediğiniz işlemleri gerçekleştirebilirsiniz.
                // Örneğin:
                MessageBox.Show($"Seçilen isim: {selectedName}");
            }
            else
            {
                MessageBox.Show("Lütfen bir hasta seçin.");
            }
        }
    }
    
}
