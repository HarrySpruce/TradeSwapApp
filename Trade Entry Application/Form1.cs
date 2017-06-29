using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trade_Entry_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notionalEntry.Focus();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (rateType.Text == "Fixed Rate")
            {
                rateType.Text = "Floating Rate";
            }
            else
            {
                rateType.Text = "Fixed Rate";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal floatEntryInt = Convert.ToDecimal(floatEntry.Text);
            decimal notionalEntryDec = Convert.ToDecimal(notionalEntry.Text);
            decimal output = notionalEntryDec * floatEntryInt;
            string outputstr = Convert.ToString(output).ToString();
            resultBox.Text = output.ToString();
        }

        private void notionalEntry_TextChanged(object sender, EventArgs e)
        {/*
            decimal notionalEntryDec = Convert.ToDecimal(notionalEntry.Text);
            if (notionalEntry.Text.EndsWith("m")) {
                decimal outputasdecimal = notionalEntryDec * 1000000;
                string output = Convert.ToString(outputasdecimal);
                notionalEntry.Text = output;
            }*/
        }

        private void notionalEntry_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void notionalEntry_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        private void notionalEntry_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine(e.KeyChar);
            if (e.KeyChar == 'm') {
                e.Handled = true;
                double d = double.Parse(notionalEntry.Text);
                d = d * 10000000.0;
                notionalEntry.Text = d.ToString();
                Console.WriteLine(d);
                notionalEntry.SelectionStart = notionalEntry.Text.Length;
            }
            if (e.KeyChar == 'k')
            {
                e.Handled = true;
                double d = double.Parse(notionalEntry.Text);
                d = d * 1000.0;
                notionalEntry.Text = d.ToString();
                Console.WriteLine(d);
                notionalEntry.SelectionStart = notionalEntry.Text.Length;
            }
            Console.WriteLine("{0}", (int)e.KeyChar);
            int asciivalue = (int)e.KeyChar;
            if ((asciivalue < 48 || asciivalue > 57) && asciivalue != 8)
            {
                e.Handled = true;
            }
        }
    }
}
