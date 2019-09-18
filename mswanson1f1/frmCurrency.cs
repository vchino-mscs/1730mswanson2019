using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mswanson1f1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            txtCurrency.Text = "0.00";
            txtRate.Text = "0.717976";
            lblCurrency.Text = btnAustralia.Text = ": ";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Focus();
        }

        private void BtnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            txtCurrency.Text = "0.000";
            txtRate.Text = "0.717976";
            txtCurrency.Focus();
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            lblCurrency.Text = "Australian Dollar";
        }

        private void BtnBhutan_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = picBhutan.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            txtCurrency.Text = "0.000";
            txtRate.Text = "0.0139793";
            txtCurrency.Focus();
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            lblCurrency.Text = "Bhutanese Ngultrum";   
        }

        private void BtnCostaRica_Click(object sender, EventArgs e)
        {
            btnCostaRica.BackgroundImage = picCostaRica.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            txtCurrency.Text = "0.000";
            txtRate.Text = "0.00173462";
            txtCurrency.Focus();
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            lblCurrency.Text = "Costa Rican Colon";

        }

        private void BtnCanada_Click(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnCostaRica.BackgroundImage = picCostaRicaDim.Image;
            txtCurrency.Text = "0.000";
            txtRate.Text = "0.754696";
            txtCurrency.Focus();
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            lblCurrency.Text = "Canadian Dollar";


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void calcUSD(object sender, EventArgs e)
        {
           
        }

        private void TxtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtUSDollars_TextChanged(object sender, EventArgs e)
        {
            txtUSDollars.Text= (
                Convert.ToDecimal(txtCurrency.Text) *
  
                Convert.ToDecimal(txtRate.Text)
                ).ToString("0.00");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            lblEquation.Text = lblEquation.Text +  " + " + txtTotalUSD.Text;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtCurrency.Text = "0.00";
            txtRate.Text = "0.717976";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = ".00";
            lblCurrency.Text = "0.00";
        }

        private void TxtTotalUSD_TextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                 Convert.ToDecimal(txtTotalUSD.Text) + Convert.ToDecimal(txtUSDollars.Text)
                 ).ToString("0.00");
        }
    }
}
