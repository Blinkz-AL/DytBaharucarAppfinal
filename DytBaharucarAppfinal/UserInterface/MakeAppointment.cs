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
using DytBaharucarAppfinal.functions;

namespace DytBaharucarAppfinal.UserInterface
{
    public partial class MakeAppointment : UserControl
    {
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;
        private SqlDataReader reader;
        function fn = new function();
        public MakeAppointment()
        {
            InitializeComponent();
            InitializeDatabase();
        }
        private void InitializeDatabase()
        {
            // Veritabanı bağlantısını kurun (kendi bağlantı bilgilerinize göre güncelleyin).
            string connectionString = "Data Source=DESKTOP-V3JP2V0\\SQLEXPRESS; Initial Catalog=dytBahar;Integrated Security=True";
            connection = new SqlConnection(connectionString);
            dataAdapter = new SqlDataAdapter();
            dataSet = new DataSet();
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void MakeAppointment_Load(object sender, EventArgs e)
        {
            FillHoursSelectorComboBox();
            FillPatientComboBox();

        }
        private void FillHoursSelectorComboBox()
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-V3JP2V0\\SQLEXPRESS; Initial Catalog=dytBahar;Integrated Security=True")) // Bağlantı dizesini kendi bağlantı dizenizle değiştirin.
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'appointments'", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // İlgili sütun adını HoursSelector ComboBox'ına ekleyin.
                            HoursSelector.Items.Add(reader["COLUMN_NAME"].ToString());
                        }
                    }
                }
            }
        }
        private void FillPatientComboBox()
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
                            patientComboBox.Items.Add(reader["Name"].ToString());
                        }
                    }
                }
            }
        }
        private void HoursSelector_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void patientComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Seçilen öğeyi kontrol et
            if (patientComboBox.SelectedItem != null)
            {
                // Seçilen ismi alabilirsiniz.
                string selectedName = patientComboBox.SelectedItem.ToString();

                // Bu ismi kullanarak istediğiniz işlemleri gerçekleştirebilirsiniz.
                // Örneğin:
                MessageBox.Show($"Seçilen isim: {selectedName}");
            }
            else
            {
                MessageBox.Show("Lütfen bir hasta seçin.");
            }
        }

        private void MakeAppointmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                // DateTimePicker'dan seçilen tarihi alın.
                DateTime selectedDate = dateTimePicker1.Value;

                // Tarihi string formatına çevirin (örneğin: "yyyy-MM-dd").
                string formattedDate = selectedDate.ToString("yyyy-MM-dd");

                // Null kontrolü ekle
                if (connection == null)
                {
                    MessageBox.Show("Veritabanı bağlantısı başlatılamadı.");
                    return;
                }

                // Veritabanında bu tarihe ait bir randevu olup olmadığını kontrol edin.
                string checkQuery = $"SELECT COUNT(*) FROM appointments WHERE appointment_date = '{formattedDate}'";
                SqlCommand checkCommand = new SqlCommand(checkQuery, connection);

                // Null kontrolü ekle
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                int rowCount = (int)checkCommand.ExecuteScalar();

                // Eğer eşleşen veri bulunamazsa:
                if (rowCount > 0)
                {
                    // Aynı satırdaki HoursSelector sütununu patientComboBox değeri ile güncelleyin.
                    string updateQuery = $"UPDATE appointments SET {HoursSelector.Text} = @PatientValue WHERE appointment_date = '{formattedDate}'";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@PatientValue", patientComboBox.Text);

                        updateCommand.ExecuteNonQuery();
                    }
                }
                else
                {
                    // Eğer eşleşen veri yoksa, yeni bir satır ekleyin.
                    string insertQuery = $"INSERT INTO appointments (appointment_date, {HoursSelector.Text}) VALUES ('{formattedDate}', @PatientValue)";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@PatientValue", patientComboBox.Text);

                        insertCommand.ExecuteNonQuery();
                    }
                }

                // Veritabanından verileri çekin.
                string query = $"SELECT * FROM appointments WHERE appointment_date = '{formattedDate}'";

                // dataAdapter'ı kontrol edin ve kapatın
                if (dataAdapter != null)
                    dataAdapter.Dispose();

                dataAdapter = new SqlDataAdapter(new SqlCommand(query, connection));
                dataSet.Clear();
                dataAdapter.Fill(dataSet, "appointments");

                // DataGridView'e DataSet'i ata.
                appointmentsDateView.DataSource = dataSet.Tables["appointments"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                // Null kontrolü ekle
                if (connection != null && connection.State == ConnectionState.Open)
                    connection.Close();
            }

        }

    }

}