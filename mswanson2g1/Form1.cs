﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mswanson2g1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //1a) 'Switch' Command with no default
            resultSwitch01TextBox.Text = Ex2gCalculations.Switch01(input1aTextBox.Text);

            //1b) Separate 'if' statements
            resultIf01TextBox.Text = Ex2gCalculations.If01(input1aTextBox.Text);

            //1c) If else if
            resultElseIf01TextBox.Text = Ex2gCalculations.ElseIf01(input1aTextBox.Text);

            //1d) Nested if else
            resultNestedIfElse01TextBox.Text = Ex2gCalculations.NestedIfElse01(input1aTextBox.Text);

            //1e) 'Switch' with default
            resultSwitchDefault01TextBox.Text = Ex2gCalculations.SwitchDefault01(input1aTextBox.Text);

            //1f) Separate 'if' statements with default value 0
            resultIfDefault01TextBox.Text = Ex2gCalculations.IfDefault01(input1aTextBox.Text);

            //1g) If else if with default
            resultElseIfDefault01TextBox.Text = Ex2gCalculations.ElseIfDefault01(input1aTextBox.Text);

            //1h) Nested if-else with default
            resultNestedIfElseDefault01TextBox.Text = Ex2gCalculations.NestedIfElseDefault01(input1aTextBox.Text);

            // 2a) 'Switch' with no default
            resultSwitch02TextBox.Text = Ex2gCalculations.Switch02(input2aTextBox.Text);


            // 2b) Separate 'if' statements
            resultIf02TextBox.Text = Ex2gCalculations.If02(input2aTextBox.Text);


            // 2c) if elseif
            resultElseIf02TextBox.Text = Ex2gCalculations.ElseIf02(input2aTextBox.Text);


            // 2d) Nested if-else
            resultNestedIfElse02TextBox.Text = Ex2gCalculations.NestedIfElse02(input2aTextBox.Text);




        }

        private void resultElseIfDefault01TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
