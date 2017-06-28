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
        {
            decimal notionalEntryDec = Convert.ToDecimal(notionalEntry.Text);
            if (notionalEntry.Text.EndsWith("m")) {
                decimal notionalEntry.Text = notionalEntryDec * 10000000;
            }
        }
    }
}
