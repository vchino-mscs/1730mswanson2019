using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mswanson2d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SetPassValuesButton_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "Frank";
            textBox2Input.Text = "";
            textBox3Input.Text = "2.3";
            textBox4Input.Text = "false";
            textBox5InputA.Text = "2";
            textBox5InputB.Text = "2";
            textBox6Input.Text = "xyz";
            textBox7Input.Text = "1";
            textBox8InputA.Text = "1";
            textBox8InputB.Text = "2";
            textBox9Input.Text = "500";
            textBox10InputA.Text = "2";
            textBox10InputB.Text = "3";

        }

        private void SetFailValuesButton_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "xyz";
            textBox2Input.Text = "xyz";
            textBox3Input.Text = "2.4";
            textBox4Input.Text = "true";
            textBox5InputA.Text = "2";
            textBox5InputB.Text = "3";
            textBox6Input.Text = "Jones";
            textBox7Input.Text = "0";
            textBox8InputA.Text = "1";
            textBox8InputB.Text = "1";
            textBox9Input.Text = "499";
            textBox10InputA.Text = "4";
            textBox10InputB.Text = "3";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            textBox1ResultA.Text = "fail";
            textBox2ResultA.Text = "fail";
            textBox3ResultA.Text = "fail";
            textBox4ResultA.Text = "fail";
            textBox5ResultA.Text = "fail";
            textBox6ResultA.Text = "fail";
            textBox7ResultA.Text = "fail";
            textBox8ResultA.Text = "fail";
            textBox9ResultA.Text = "fail";
            textBox10ResultA.Text = "fail";

            textBox1ResultB.Text = "Sucess";
            textBox2ResultB.Text = "Sucess";
            textBox3ResultB.Text = "Sucess";
            textBox4ResultB.Text = "Sucess";
            textBox5ResultB.Text = "Sucess";
            textBox6ResultB.Text = "Sucess";
            textBox7ResultB.Text = "Sucess";
            textBox8ResultB.Text = "Sucess";
            textBox9ResultB.Text = "Sucess";
            textBox10ResultB.Text = "Sucess";



            if (textBox1Input.Text == "Frank")
                textBox1ResultA.Text = "Success";
            if (textBox1Input.Text != "Frank")
                textBox1ResultB.Text = "Fail";

            if (textBox2Input.Text == "")
                textBox2ResultA.Text = "Success";
            if (textBox2Input.Text != "")
                textBox2ResultB.Text = "Fail";

            decimal val3 = Convert.ToDecimal(textBox3Input.Text);
            if (val3 == 2.3m)
                textBox3ResultA.Text = "Success";
            if (val3 != 2.3m)
                textBox3ResultB.Text = "Fail";

            bool val4 = Convert.ToBoolean(textBox4Input.Text);
            if (val4 == false)
                textBox4ResultA.Text = "Success";
            if (val4 != false)
                textBox4ResultB.Text = "Fail";

            decimal val5A = Convert.ToDecimal(textBox5InputA.Text);
            decimal val5B = Convert.ToDecimal(textBox5InputB.Text);
            if (val5A == val5B)
                textBox5ResultA.Text = "Success";
            if (val5A != val5B)
                textBox5ResultB.Text = "Fail";

            if (textBox6Input.Text != "Jones")
                textBox6ResultA.Text = "Sucess";
            if (textBox6Input.Text == "Jones")
                textBox6ResultB.Text = "Fail";

            decimal val7 = Convert.ToDecimal(textBox7Input.Text);
            if (val7 == 1.0m)
                textBox7ResultA.Text = "Sucess";
            if (val7 < 1.0m)
                textBox7ResultB.Text = "Fail";

            decimal val8A = Convert.ToDecimal(textBox8InputA.Text);
            decimal val8B = Convert.ToDecimal(textBox8InputB.Text);
            if (val8A < val8B)
                textBox8ResultA.Text = "Sucess";
            if (val8A >= val8B)
                textBox8ResultB.Text = "Fail";

            decimal val9 = Convert.ToDecimal(textBox9Input.Text);
            if (val9 >= 500m)
                textBox9ResultA.Text = "Succes";
            if (val9 <= 499m)
                textBox9ResultB.Text = "Fail";

            decimal val10A = Convert.ToDecimal(textBox10InputA.Text);
            decimal val10B = Convert.ToDecimal(textBox10InputB.Text);
            if (val10A <= val10B)
                textBox10ResultA.Text = "Sucess";
            if (val10A >= val10B)
                textBox10ResultB.Text = "fail";










        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }
    }
}
