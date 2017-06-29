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
    public partial class Form : System.Windows.Forms.Form
    {
        DateTime date = DateTime.Now;
        string currency;
        string FixedLegFreqInterval;
        string floatingLegFreqInterval;
        string currentlyusing;
        public Form()
        {
            InitializeComponent();
            notionalEntry.Text = notionalEntry.Text + "0";
            Entry.Text = Entry.Text + "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notionalEntry.Focus();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (Entry.Text == "")
            {
                Entry.Text = "0";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (rateType.Text == "Fixed Rate")
            {
                rateType.Text = "Floating Rate";
                bool flip = true;
            }
            else
            {
                rateType.Text = "Fixed Rate";
                bool flip = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal floatEntryInt = Convert.ToDecimal(Entry.Text);
            decimal notionalEntryDec = Convert.ToDecimal(notionalEntry.Text);
            decimal output = notionalEntryDec * floatEntryInt;
            string outputstr = Convert.ToString(output).ToString();
            resultBox.Text = output.ToString();
            this.timer1.Start();
            if (notionalEntry.Text == "")
            {
                Console.WriteLine("Enter Something");
            }
            string newdate = date.ToString();
            DataGridViewRow row = (DataGridViewRow)paymentDates.Rows[0].Clone();
            row.Cells[0].Value = newdate;
            row.Cells[1].Value = newdate;
            paymentDates.Rows.Add(row);
       
        }


        private void notionalEntry_TextChanged(object sender, EventArgs e)
        {/*
            decimal notionalEntryDec = Convert.ToDecimal(notionalEntry.Text);
            if (notionalEntry.Text.EndsWith("m")) {
                decimal outputasdecimal = notionalEntryDec * 1000000;
                string output = Convert.ToString(outputasdecimal);
                notionalEntry.Text = output;
            }*/
            if (notionalEntry.Text == "")
            {
                notionalEntry.Text = "0";
                notionalEntry.SelectionLength = notionalEntry.Text.Length;
                Entry.SelectionLength = Entry.Text.Length;
            }
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar.Increment(90);
            notionalEntry.SelectionLength = notionalEntry.Text.Length;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "GBP")
            {
                currency = "GBP";
            }
            else if (comboBox1.Text == "USD") {
                currency = "USD";
            }
            else if (comboBox1.Text == "CAD")
            {
                currency = "CAD";
            }
            else if (comboBox1.Text == "EUR")
            {
                currency = "EUR";
            }
            else if (comboBox1.Text == "YEN")
            {
                currency = "YEN";
            }
            else if (comboBox1.Text == "RUB")
            {
                currency = "RUB";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Months")
            {
                currentlyusing = "Months";
                FixedLegFreqInterval = "Months";
            }
            if (comboBox2.Text == "Days")
            {
                currentlyusing = "Days";
                FixedLegFreqInterval = "Days";
            }
            if (comboBox2.Text == "Weeks")
            {
                currentlyusing = "Weeks";
                FixedLegFreqInterval = "Weeks";
            }
            if (comboBox2.Text == "Years")
            {
                currentlyusing = "Years";
                FixedLegFreqInterval = "Years";
            }
            fixedLegFreq.Text = fixedLegFreq.Text + " " + FixedLegFreqInterval;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Months")
            {
                floatingLegFreqInterval = "Months";
                currentlyusing = "Months";
            }
            if (comboBox3.Text == "Days")
            {
                floatingLegFreqInterval = "Days";
                currentlyusing = "Days";
            }
            if (comboBox3.Text == "Weeks")
            {
                floatingLegFreqInterval = "Weeks";
                currentlyusing = "Weeks";
            }
            if (comboBox3.Text == "Years")
            {
                floatingLegFreqInterval = "Years";
                currentlyusing = "Years";
            }
            floatingLegFreq.Text = floatingLegFreq.Text + " " + floatingLegFreqInterval;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Add variables that specify the fixedLegFreq
            //Text Replacement for intervals.
            if (fixedLegFreq.Text.EndsWith("d"))
            {
                FixedLegFreqInterval = "Days";
                fixedLegFreq.Text = fixedLegFreq.Text + " " + FixedLegFreqInterval;
                currentlyusing = "Days";
            }
            if (fixedLegFreq.Text.EndsWith("m"))
            {
                FixedLegFreqInterval = "Months";
                fixedLegFreq.Text = fixedLegFreq.Text + " " + FixedLegFreqInterval;
                currentlyusing = "Months";
            }
            if (fixedLegFreq.Text.EndsWith("y"))
            {
                FixedLegFreqInterval = "Years";
                fixedLegFreq.Text = fixedLegFreq.Text + " " + FixedLegFreqInterval;
                currentlyusing = "Years";
            }
            //Removes the m typed before it changes
            if (currentlyusing == "Months")
            {
                fixedLegFreq.Text = fixedLegFreq.Text.Replace("m", "");
            }
            if (currentlyusing == "Days")
            {
                fixedLegFreq.Text = fixedLegFreq.Text.Replace("d", "");
            }
            if (currentlyusing == "Years")
            {
                fixedLegFreq.Text = fixedLegFreq.Text.Replace("y", "");
                currentlyusing = "Nothing";
            }
            else
            {
                currentlyusing = "Nothing";
            }
        }

        private void floatingLegFreq_TextChanged(object sender, EventArgs e)
        {
            if (floatingLegFreq.Text.EndsWith("d"))
            {
                currentlyusing = "Days";
                floatingLegFreqInterval = "Days";
                floatingLegFreq.Text = floatingLegFreq.Text + " " + floatingLegFreqInterval;
            }
            if (floatingLegFreq.Text.EndsWith("m"))
            {
                currentlyusing = "Months";
                floatingLegFreqInterval = "Months";
                floatingLegFreq.Text = floatingLegFreq.Text + " " + floatingLegFreqInterval;
            }
            if (floatingLegFreq.Text.EndsWith("y"))
            {
                currentlyusing = "Years";
                floatingLegFreqInterval = "Years";
                floatingLegFreq.Text = floatingLegFreq.Text + " " + floatingLegFreqInterval;
            }
            if (currentlyusing == "Months")
            {
                floatingLegFreq.Text = floatingLegFreq.Text.Replace("m", "");
            }
            if (currentlyusing == "Days")
            {
                floatingLegFreq.Text = floatingLegFreq.Text.Replace("d", "");
            }
            if (currentlyusing == "Years")
            {
                floatingLegFreq.Text = floatingLegFreq.Text.Replace("y", "");
            }
            else
            {
                currentlyusing = "Nothing";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }
    }
}
