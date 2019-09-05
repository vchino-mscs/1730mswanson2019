using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mswanson1c1
{
    public partial class rfmFoodTruck : Form
    {
        public rfmFoodTruck()
        {
            InitializeComponent();
        }

        private void RfmFoodTruck_Load(object sender, EventArgs e)
        {
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            txtHotDogsSubtotal.Text = (
                    4.0m * Convert.ToDecimal(txtHotDogs.Text)
                ).ToString("0.00");

            txtHamburgersSubtotal.Text = (
                    5.0m * Convert.ToDecimal(txtHamburgers.Text)
                ).ToString("0.00");

            txtPretaxtTotal.Text = (
                Convert.ToDecimal(txtHotDogsSubtotal.Text) + Convert.ToDecimal(txtHamburgersSubtotal.Text)
                ).ToString("0.00");

            txtTax.Text = (
               0.06875m * Convert.ToDecimal(txtPretaxtTotal.Text)
               ).ToString("0.00");

            txtTotal.Text = (
                Convert.ToDecimal(txtPretaxtTotal.Text) + Convert.ToDecimal(txtTax.Text)
                ).ToString("0.00");

            btnCLear.Focus();

        }

        private void TxtHamburgersSubtotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();     
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtHotDogs.Text = "0";
            txtHamburgers.Text = "0";
            txtHotDogsSubtotal.Text = "";
            txtHamburgersSubtotal.Text = "";
            txtPretaxtTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";



            txtHotDogs.Focus();


        }
    }
}
