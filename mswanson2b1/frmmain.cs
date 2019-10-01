using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mswanson2b1
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtTotalUSD_TextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDAustralia.Text)
                + Convert.ToDecimal(txtUSDBhutan.Text)
                + Convert.ToDecimal(txtUSDCostaRica.Text)
                + Convert.ToDecimal(txtUSDCanada.Text)
                ).ToString("0.00");

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtRateAustralia.Text = "0.685597";
            txtAmountBhutan.Text = "0.00";
            txtRateBhutan.Text = "0.0139048";
            txtAmountCostaRica.Text = "0.00";
            txtRateCostaRica.Text = "0.00173589";
            txtAmountCanada.Text = "0.00";
            txtRateCanada.Text = "0.758993";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void calculate(object sender, EventArgs e)
        {
            decimal amountAustralia = Convert.ToDecimal(txtAmountAustralia.Text);
            decimal rateAustralia = Convert.ToDecimal(txtRateAustralia.Text);
            decimal usdAustralia = amountAustralia * rateAustralia;

            decimal amountBhutan = Convert.ToDecimal(txtAmountBhutan.Text);
            decimal rateBhutan = Convert.ToDecimal(txtRateBhutan.Text);
            decimal usdBhutan = amountBhutan * rateBhutan;

            decimal amountCostaRica = Convert.ToDecimal(txtAmountCostaRica.Text);
            decimal rateCostaRica = Convert.ToDecimal(txtRateCostaRica.Text);
            decimal usdCostaRica = amountCostaRica * rateCostaRica;


            decimal amountCanada = Convert.ToDecimal(txtAmountCanada.Text);
            decimal rateCanada = Convert.ToDecimal(txtRateCanada.Text);
            decimal usdCanada = amountCanada * rateCanada;

            txtUSDAustralia.Text = usdAustralia.ToString("0.00");
            txtUSDBhutan.Text = usdBhutan.ToString("0.00");
            txtUSDCostaRica.Text = usdCostaRica.ToString("0.00");
            txtUSDCanada.Text = usdCanada.ToString("0.00");

            txtTotalUSD.Text = usdAustralia + usdBhutan + usdCostaRica + usdCanada.ToString("0.00");
        }
    }