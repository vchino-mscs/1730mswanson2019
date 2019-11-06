﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mswanson2E1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCalc_Click(object sender, EventArgs e)
        {
            result01TextBox.Text = "";
            result02TextBox.Text = "";
            result03TextBox.Text = "";
            result03bTextBox.Text = "";
            result04TextBox.Text = "";
            result04bTextBox.Text = "";
            result05TextBox.Text = "";
            result05bTextBox.Text = "";
            result06TextBox.Text = "";
            result06bTextBox.Text = "";
            result07TextBox.Text = "";
            result08TextBox.Text = "";
            result10TextBox.Text = "";


            //#01
            decimal subtotal = Convert.ToDecimal(input01aTextBox.Text);
            //result01TextBox.Text = (subtotal >= 250 && subtotal < 500).ToString();
            result01TextBox.Text = (LogicalOperations.q01(subtotal)).ToString();
            //#02
            int timeInService = Convert.ToInt32(input02aTextBox.Text);
            result02TextBox.Text = (
                LogicalOperations.q02(timeInService)
                ).ToString();


            //separate#03
            bool isValid = Convert.ToBoolean(input03aTextBox.Text);
            int years = Convert.ToInt32(input03cTextBox.Text);

            //#03
            int counter = Convert.ToInt32(input03bTextBox.Text);
            result03TextBox.Text = (
                LogicalOperations.q03(isValid, years, counter)
                ).ToString();
            result03bTextBox.Text = counter.ToString();

            //#04
            counter = Convert.ToInt32(input03bTextBox.Text);
            result04TextBox.Text = (
                LogicalOperations.q04(isValid, years, counter)
                ).ToString();
            result04bTextBox.Text = counter.ToString();

            //#05
            counter = Convert.ToInt32(input03bTextBox.Text);
            result05TextBox.Text = (
                LogicalOperations.q05(isValid, years, counter)
                ).ToString();
            result05bTextBox.Text = counter.ToString();

            //#06
            counter = Convert.ToInt32(input03bTextBox.Text);
            result06TextBox.Text = (
                LogicalOperations.q06(isValid, years, counter)
                ).ToString();
            result06bTextBox.Text = counter.ToString();

            //#07
            DateTime startDate = Convert.ToDateTime(input07aTextBox.Text);
            DateTime expirationDate = Convert.ToDateTime(input07bTextBox.Text);
            DateTime date = Convert.ToDateTime(input07cTextBox.Text);
            isValid = Convert.ToBoolean(input07dTextBox.Text);
            result07TextBox.Text = (
                LogicalOperations.q07(startDate, expirationDate, date, isValid)
                ).ToString();

            //#08
            decimal thisYTD = Convert.ToDecimal(input08aTextBox.Text);
            decimal lastYTD = Convert.ToDecimal(input08bTextBox.Text);
            string empType = input08cTextBox.Text;
            int startYear = Convert.ToInt32(input08dTextBox.Text);
            int currentYear = Convert.ToInt32(input08eTextBox.Text);
            result08TextBox.Text = (
                (LogicalOperations.q08(thisYTD, lastYTD, empType, startYear, currentYear))
                ).ToString();

            //#09
            counter = Convert.ToInt32(input09aTextBox.Text);
            years = Convert.ToInt32(input09bTextBox.Text);
            result09TextBox.Text = (
               (LogicalOperations.q09(counter, years))
                ).ToString();
            result09bTextBox.Text = counter.ToString();


            //#10
            int a = Convert.ToInt32(input10aTextBox.Text);
            int b = Convert.ToInt32(input10bTextBox.Text);
            int c = Convert.ToInt32(input10cTextBox.Text);
            int d = Convert.ToInt32(input10dTextBox.Text);
            result10TextBox.Text = (
                  (LogicalOperations.q10(a, b, c, d))
                ).ToString();
            int x = b * c;
            int y = a + x;
            int z = y - d;
            result10TextBox.Text = z.ToString();

            //#11
            bool member = Convert.ToBoolean(input11aTextBox.Text);
            decimal price = Convert.ToDecimal(input11bTextBox.Text);
            float weight = Convert.ToSingle(input11cTextBox.Text);
            result11TextBox.Text = (
                LogicalOperations.q11(member, price, weight)
                ).ToString();

            //#12
            member = Convert.ToBoolean(input12aTextBox.Text);
            price = Convert.ToDecimal(input12bTextBox.Text);
            weight = Convert.ToSingle(input12cTextBox.Text);
            result12TextBox.Text = (
                LogicalOperations.q12(member, price, weight)
                ).ToString();

            //#13
            string shipState = input13aTextBox.Text;
            string itemType = input13bTextBox.Text;
            result13TextBox.Text = (
                LogicalOperations.q13(shipState, itemType)
                ).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }    
}
