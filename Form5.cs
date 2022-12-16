using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private double Farenheit;
        private double Celcius;
        private double Kelvin;

        private double FarenheitToCelcius
        {
            get { return (Farenheit - 32) * 5 / 9; }
            set { Farenheit = value; }
        }
        private double FarenheitToKelvin
        {
            get { return (Farenheit - 32) * 5 / 273.15; }
            set { Farenheit = value; }
        }
        private double CelciusToKelvin
        {
            get { return Celcius + 273.15; }
            set { Celcius = value; }
        }
        private double CelciusToFarenheit
        {
            get { return (Celcius * 9 / 5) + 32; }
            set { Celcius = value; }
        }
        private double KelvinToCelcius
        {
            get { return Kelvin - 273.15; }
            set { Kelvin = value; }
        }
        private double KelvinToFarenheit
        {
            get { return (Kelvin - 273.15) * 9 / 5 + 32; }
            set { Kelvin = value; }
        }

        private void Converter()
        {
            if(string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == ".")
            {
                textBox2.Text = "";
            }
            else if(comboBox1.Text == "Farenheit to Celcius")
            {
                FarenheitToCelcius = Convert.ToDouble(textBox1.Text);
                textBox2.Text = FarenheitToCelcius.ToString();
            }
            else if (comboBox1.Text == "Farenheit to Kelvin")
            {
                FarenheitToKelvin = Convert.ToDouble(textBox1.Text);
                textBox2.Text = FarenheitToKelvin.ToString();
            }
            else if (comboBox1.Text == "Celcius to Farenheit")
            {
                CelciusToFarenheit = Convert.ToDouble(textBox1.Text);
                textBox2.Text = CelciusToFarenheit.ToString();
            }
            else if (comboBox1.Text == "Celcius to Kelvin")
            {
                CelciusToKelvin = Convert.ToDouble(textBox1.Text);
                textBox2.Text = CelciusToKelvin.ToString();
            }
            else if (comboBox1.Text == "Kelvin to Celcius")
            {
                KelvinToCelcius = Convert.ToDouble(textBox1.Text);
                textBox2.Text = KelvinToCelcius.ToString();
            }
            else if (comboBox1.Text == "Kelvin to Farenheit")
            {
                KelvinToFarenheit = Convert.ToDouble(textBox1.Text);
                textBox2.Text = KelvinToFarenheit.ToString();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;
            exitCal = MessageBox.Show("Confirm if you want to Exit", "Simple Calculator",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void simpleV2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void loanManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((ch == 46 && textBox1.Text.IndexOf(".") != -1) ||
                (ch == 45 && textBox1.Text.IndexOf("-") != -1) ||
                (ch == 45 && textBox1.Text.IndexOf(".") != -1) ||
                (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 45))
            {
                e.Handled = true;
                return;
            }
        }

        private void ChangeLabel()
        {
            switch(comboBox1.Text)
            {
                case "Farenheit to Celcius":
                    label1.Text = "Farenheit";
                    label2.Text = "Celcius";
                    break;
                case "Farenheit to Kelvin":
                    label1.Text = "Farenheit";
                    label2.Text = "Kelvin";
                    break;
                case "Celcius to Kelvin":
                    label1.Text = "Celcius";
                    label2.Text = "Kelvin";
                    break;
                case "Celcius to Farenheit":
                    label1.Text = "Celcius";
                    label2.Text = "Farenheit";
                    break;
                case "Kelvin to Farenheit":
                    label1.Text = "Kelvin";
                    label2.Text = "Farenheit";
                    break;
                case "Kelvin to Celcius":
                    label1.Text = "Kelvin";
                    label2.Text = "Celcius";
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Converter();
            ChangeLabel();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Converter();
        }

        private void simpleV3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
            this.Hide();
        }
    }
}
