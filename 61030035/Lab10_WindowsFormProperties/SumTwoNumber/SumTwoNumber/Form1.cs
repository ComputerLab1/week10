﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumTwoNumber
{
    public partial class SumberNumbers : Form
    {
        public SumberNumbers()
        {
            InitializeComponent();
        }

        private void secondNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get input values and convert strings to doubles
            double number1 = Double.Parse(firstNumberTextBox.Text);
            double number2 = Double.Parse(secondNumberTextBox.Text);

            //sum the two numbers
            double sum = number1 + number2;

            //display maximum value
            sumLabel.Text = "Sum :" + sum;
        }
    }
}