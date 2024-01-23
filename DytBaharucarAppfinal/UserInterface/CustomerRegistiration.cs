using DytBaharucarAppfinal.functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Add this line

namespace DytBaharucarAppfinal.UserInterface
{
    public partial class CustomerRegistiration : UserControl
    {
        function fn = new function();
        String query;
        public CustomerRegistiration()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }


        private void patientRegButton_Click(object sender, EventArgs e)
        {
            if (patientName.Text != "" && patientPhone.Text != "" && patientGender.Text != "" && patientBirth.Text != "" && patientRegTime.Text != "" && patientPurchasePlan.Text != "" && patientPaymentMethod.Text != "" && PatientRegistrationType.Text !="" && PatientAmountPaid.Text !="")
            {
                string name = patientName.Text;
                string phone = patientPhone.Text;
                string gender = patientGender.Text;
                string birth = patientBirth.Text;
                string regTime = patientRegTime.Text;
                string purchasePlan = patientPurchasePlan.Text;
                string paymentMethod = patientPaymentMethod.Text;
                string registrationType = PatientRegistrationType.Text;
                string amountPaid = PatientAmountPaid.Text;
                string additionalNote = PatientAdditionalNot.Text;

                // Corrected SQL query
                string query = "INSERT INTO patient VALUES (@Name, @Phone, @Gender, @Birth, @RegTime, @PurchasePlan, @PaymentMethod, @RegistrationType, @AmountPaid, @AdditionalNote)";

                // ...

                fn.setDataWithParameters(query,
                    new SqlParameter("@Name", name),
                    new SqlParameter("@Phone", phone),
                    new SqlParameter("@Gender", gender),
                    new SqlParameter("@Birth", birth),
                    new SqlParameter("@RegTime", regTime),
                    new SqlParameter("@PurchasePlan", purchasePlan),
                    new SqlParameter("@PaymentMethod", paymentMethod),
                    new SqlParameter("@RegistrationType", registrationType),
                    new SqlParameter("@AmountPaid", amountPaid),
                    new SqlParameter("@AdditionalNote", additionalNote)
                );

                // ...
            }
            else
            {
                MessageBox.Show("Alanları doldurun");
            }
        }
        private void CustomerRegistiration_Load(object sender, EventArgs e)
        {
         //   try
          //  {

          //  }
        //    catch(Exception ex)
         //   {
          //      MessageBox.Show("Hata oluştu" + ex.ToString());
//
         //   }
        //    query = "select * from patient";
        //    DataSet ds = fn.getData(query);

        }


    }
}
