using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DytBaharucarAppfinal.UserInterface
{
    public partial class CustomerInformation : UserControl
    {
        public CustomerInformation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Olcumler olcumler = new Olcumler();
            olcumler.Show();
        }
    }
}
