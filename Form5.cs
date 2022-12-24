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

        private double Fahrenheit;
        private double Celcius;
        private double Kelvin;
        private double Reamur;

        private double FahrenheitToCelcius
        {
            get { return (Fahrenheit - 32) * (5 / 9); }
            set { Fahrenheit = value; }
        }
        private double FahrenheitToKelvin
        {
            get { return (Fahrenheit - 32) * (5 / 9) + 273.15; }
            set { Fahrenheit = value; }
        }
        private double FahrenheitToReamur
        {
            get { return (Fahrenheit - 32) * (4 / 9); }
            set { Fahrenheit = value; }
        }
        private double CelciusToKelvin
        {
            get { return Celcius + 273.15; }
            set { Celcius = value; }
        }
        private double CelciusToFahrenheit
        {
            get { return (Celcius * (9 / 5)) + 32; }
            set { Celcius = value; }
        }
        private double CelciusToReamur
        {
            get { return (4/5) * Reamur; }
            set { Celcius = value; }
        }
        private double ReamurToFahrenheit
        {
            get { return ((9 / 4) * Fahrenheit) + 32; }
            set { Reamur = value; }
        }
        private double ReamurToCelcius
        {
            get { return (5 / 4) * Reamur; }
            set { Reamur = value; }
        }
        private double ReamurToKelvin
        {
            get { return ((5 / 4) * Reamur) + 273.15; }
            set { Reamur = value; }
        }
        private double KelvinToCelcius
        {
            get { return Kelvin - 273.15; }
            set { Kelvin = value; }
        }
        private double KelvinToFahrenheit
        {
            get { return (Kelvin - 273.15) * (9 / 5) + 32; }
            set { Kelvin = value; }
        }
        private double KelvinToReamur
        {
            get { return ((4/5) * Kelvin) - 273.15; }
            set { Kelvin = value; }
        }

        private void Converter()
        {
            if(string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == ".")
            {
                textBox2.Text = "";
            }
            else if(comboBox1.Text == "Fahrenheit to Celcius")
            {
                FahrenheitToCelcius = Convert.ToDouble(textBox1.Text);
                textBox2.Text = FahrenheitToCelcius.ToString();
            }
            else if (comboBox1.Text == "Fahrenheit to Kelvin")
            {
                FahrenheitToKelvin = Convert.ToDouble(textBox1.Text);
                textBox2.Text = FahrenheitToKelvin.ToString();
            }
            else if (comboBox1.Text == "Fahrenheit to Reamur")
            {
                FahrenheitToReamur = Convert.ToDouble(textBox1.Text);
                textBox2.Text = FahrenheitToReamur.ToString();
            }
            else if (comboBox1.Text == "Celcius to Kelvin")
            {
                CelciusToKelvin = Convert.ToDouble(textBox1.Text);
                textBox2.Text = CelciusToKelvin.ToString();
            }
            else if (comboBox1.Text == "Celcius to Fahrenheit")
            {
                CelciusToFahrenheit = Convert.ToDouble(textBox1.Text);
                textBox2.Text = CelciusToFahrenheit.ToString();
            }
            else if (comboBox1.Text == "Celcius to Reamur")
            {
                CelciusToReamur = Convert.ToDouble(textBox1.Text);
                textBox2.Text = CelciusToReamur.ToString();
            }
            else if (comboBox1.Text == "Reamur to Fahrenheit")
            {
                ReamurToFahrenheit = Convert.ToDouble(textBox1.Text);
                textBox2.Text = ReamurToFahrenheit.ToString();
            }
            else if (comboBox1.Text == "Reamur to Celcius")
            {
                ReamurToCelcius = Convert.ToDouble(textBox1.Text);
                textBox2.Text = ReamurToCelcius.ToString();
            }
            else if (comboBox1.Text == "Reamur to Kelvin")
            {
                ReamurToKelvin = Convert.ToDouble(textBox1.Text);
                textBox2.Text = ReamurToKelvin.ToString();
            }
            else if (comboBox1.Text == "Kelvin to Celcius")
            {
                KelvinToCelcius = Convert.ToDouble(textBox1.Text);
                textBox2.Text = KelvinToCelcius.ToString();
            }
            else if (comboBox1.Text == "Kelvin to Fahrenheit")
            {
                KelvinToFahrenheit = Convert.ToDouble(textBox1.Text);
                textBox2.Text = KelvinToFahrenheit.ToString();
            }
            else if (comboBox1.Text == "Kelvin to Reamur")
            {
                KelvinToReamur = Convert.ToDouble(textBox1.Text);
                textBox2.Text = KelvinToReamur.ToString();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;
            exitCal = MessageBox.Show("Confirm if you want to Exit", "Temperature",
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
                case "Fahrenheit to Celcius":
                    label1.Text = "Fahrenheit";
                    label2.Text = "Celcius";
                    break;
                case "Fahrenheit to Kelvin":
                    label1.Text = "Fahrenheit";
                    label2.Text = "Kelvin";
                    break;
                case "Fahrenheit to Reamur":
                    label1.Text = "Fahrenheit";
                    label2.Text = "Reamur";
                    break;
                case "Celcius to Kelvin":
                    label1.Text = "Celcius";
                    label2.Text = "Kelvin";
                    break;
                case "Celcius to Fahrenheit":
                    label1.Text = "Celcius";
                    label2.Text = "Fahrenheit";
                    break;
                case "Celcius to Reamur":
                    label1.Text = "Celcius";
                    label2.Text = "Reamur";
                    break;
                case "Reamur to Fahrenheit":
                    label1.Text = "Reamur";
                    label2.Text = "Fahrenheit";
                    break;
                case "Reamur to Celcius":
                    label1.Text = "Reamur";
                    label2.Text = "Celcius";
                    break;
                case "Reamur to Kelvin":
                    label1.Text = "Reamur";
                    label2.Text = "Kelvin";
                    break;
                case "Kelvin to Fahrenheit":
                    label1.Text = "Kelvin";
                    label2.Text = "Fahrenheit";
                    break;
                case "Kelvin to Celcius":
                    label1.Text = "Kelvin";
                    label2.Text = "Celcius";
                    break;
                case "Kelvin to Reamur":
                    label1.Text = "Kelvin";
                    label2.Text = "Reamur";
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
