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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        double HasilTemp;
        string LambangOperator;
        bool OperatorDitekan;

        private void fokuskan()
        {
            txt_utama.Focus();
            txt_utama.Select(txt_utama.Text.Length, 1);
        }

        private void clearhasil()
        {
            HasilTemp = 0;
            LambangOperator = " ";
            OperatorDitekan = false;
        }

        private void clearkan()
        {
            txt_utama.Text = "0";
            txt_temp.Text = "";
            clearhasil();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            clearkan();
            fokuskan();
        }

        private void btnAngka_Click(object sender, EventArgs e)
        {
            Button btnA = (Button)sender;
            if (txt_utama.Text == "0")
            {
                txt_utama.Clear();
            }
            if (LambangOperator == "=")
            {
                txt_utama.Clear();
                LambangOperator = " ";
                HasilTemp = 0;
            }
            txt_utama.Text = txt_utama.Text + btnA.Text;
            OperatorDitekan = false;
            fokuskan();
        }
        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button btnOP = (Button)sender;
            if (OperatorDitekan == false)
            {
                if (txt_temp.Text == "")
                {
                    HasilTemp = Convert.ToDouble(txt_utama.Text);
                }
                else
                {
                    if (LambangOperator == "+")
                    {
                        HasilTemp = HasilTemp + Convert.ToDouble(txt_utama.Text);
                    }
                    else if (LambangOperator == "−")
                    {
                        HasilTemp = HasilTemp - Convert.ToDouble(txt_utama.Text);
                    }
                    else if (LambangOperator == "/")
                    {
                        HasilTemp = HasilTemp / Convert.ToDouble(txt_utama.Text);
                    }
                    else if (LambangOperator == "x")
                    {
                        HasilTemp = HasilTemp * Convert.ToDouble(txt_utama.Text);
                    }
                 }
            }

            if (btnOP.Text == "=")
            {
                txt_temp.Text = "";
                txt_utama.Text = HasilTemp.ToString();
            }
            else
            {
                txt_temp.Text = HasilTemp.ToString() + btnOP.Text;
                txt_utama.Text = "0";
            }

            LambangOperator = Convert.ToString(btnOP.Text);
            OperatorDitekan = true;
            fokuskan();
        }

        private void btn_PM_Click(object sender, EventArgs e)
        {
            txt_utama.Text = (Convert.ToDouble(txt_utama.Text) * -1).ToString();
            fokuskan();
        }

        private void btn_Koma_Click(object sender, EventArgs e)
        {
            if (txt_utama.Text.Contains(',') == false)
            {
                txt_utama.Text = txt_utama.Text + ",";
            }
            if (LambangOperator == "=")
            {
                clearhasil();
            }
            fokuskan();
        }

        private void btn_Backspace_Click(object sender, EventArgs e)
        {
            txt_utama.Text = txt_utama.Text.Remove(txt_utama.TextLength - 1);
            if ((txt_utama.Text == "") || (txt_utama.Text == "−"))
            {
                txt_utama.Text = "0";
            }
            if (LambangOperator == "=")
            {
                clearhasil();
            }
            fokuskan();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clearkan();
            fokuskan();
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            txt_utama.Text = "0";
            if (LambangOperator == "=")
            {
                clearhasil();
            }
            fokuskan();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;
            exitCal = MessageBox.Show("Confirm if you want to Exit", "Simple Calculator",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(exitCal==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void simpleV2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
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
