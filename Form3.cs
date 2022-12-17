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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;
            exitCal = MessageBox.Show("Confirm if you want to Exit", "Simple V2",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Btn_Bagi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 dan Angka 2 Harus Diisi Terlebih Dahulu");
            }
            else
            {
                try
                {
                    int Angka1;
                    int Angka2;
                    int Hasil;
                    Angka1 = int.Parse(textBox1.Text);
                    Angka2 = int.Parse(textBox2.Text);
                    Hasil = Angka1 / Angka2;
                    textBox3.Text = Hasil.ToString();
                }
                catch (DivideByZeroException ex1)
                {
                    MessageBox.Show("Cannot Divide By Zero", ex1.Message);
                }
            }
        }

        private void Btn_Tambah_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 dan Angka 2 Harus Diisi Terlebih Dahulu");
            }
            else 
            {
                Double Angka1;
                Double Angka2;
                Double Hasil;
                Angka1 = Double.Parse(textBox1.Text);
                Angka2 = Double.Parse(textBox2.Text);
                Hasil = Angka1 + Angka2;
                textBox3.Text = Hasil.ToString();
            }
          
        }

        private void Btn_Kurang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 dan Angka 2 Harus Diisi Terlebih Dahulu");
            }
            else
            {
                Double Angka1;
                Double Angka2;
                Double Hasil;
                Angka1 = Double.Parse(textBox1.Text);
                Angka2 = Double.Parse(textBox2.Text);
                Hasil = Angka1 - Angka2;
                textBox3.Text = Hasil.ToString();
            }
        }

        private void Btn_Kali_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Angka 1 dan Angka 2 Harus Diisi Terlebih Dahulu");
            }
            else
            {
                Double Angka1;
                Double Angka2;
                Double Hasil;
                Angka1 = Double.Parse(textBox1.Text);
                Angka2 = Double.Parse(textBox2.Text);
                Hasil = Angka1 * Angka2;
                textBox3.Text = Hasil.ToString();
            }
            
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void loanManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Hide();
        }

        private void simpleV3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            form.Show();
            this.Hide();
        }
    }
}
