using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mswanson2a1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            //txtDiscountAmount.Text =
            //    (Convert.ToDecimal(txtSubtotal.Text)
            //    * Convert.ToDecimal(txtDiscountPercent.Text) / 100).ToString("0.00");
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPercent = Convert.ToDecimal(txtDiscountPercent.Text);
            decimal discountAmount = subtotal * discountPercent / 100m;
            txtDiscountAmount.Text = discountAmount.ToString("0.00");
            //txtTotal.Text =
            //    (Convert.ToDecimal(txtSubtotal.Text)
            //    - Convert.ToDecimal(txtDiscountAmount.Text)).ToString("0.00");
            decimal total = subtotal - discountAmount;
            txtTotal.Text = total.ToString("0.00");
            



        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
