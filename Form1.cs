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
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            clearkan();
            fokuskan();
        }

        private void btnAngka_Click(object sender, EventArgs e)
        {
            Button btnA = (Button)sender;
            if (txt_utama.Text=="0")
            {
                txt_utama.Clear();
            }
            if(LambangOperator == "=")
            {
                txt_utama.Clear();
                LambangOperator = " ";
                HasilTemp = 0;
            }
            txt_utama.Text = txt_utama.Text + btnA.Text;
            OperatorDitekan = false;
            fokuskan();
        }

        private void btn_koma_Click(object sender, EventArgs e)
        {
            if(txt_utama.Text.Contains(',') == false)
            {
               txt_utama.Text = txt_utama.Text + ",";
            }
            if(LambangOperator == "=")
            {
                clearhasil();
            }
            fokuskan();
        }

        private void btn_PM_Click(object sender, EventArgs e)
        {
            txt_utama.Text = (Convert.ToDouble(txt_utama.Text) * -1).ToString();
            fokuskan();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            clearkan();
            fokuskan();
        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            txt_utama.Text = "0";
            if(LambangOperator == "=")
            {
                clearhasil();
            }
            fokuskan();
        }

        private void btn_backspace_Click(object sender, EventArgs e)
        {
            txt_utama.Text = txt_utama.Text.Remove(txt_utama.TextLength - 1);
            if((txt_utama.Text == "") ||  (txt_utama.Text == "−"))
            {
                txt_utama.Text = "0";
            }
            if(LambangOperator == "=")
            {
                clearhasil();
            }
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
                    else if (LambangOperator == "x")
                    {
                        HasilTemp = HasilTemp * Convert.ToDouble(txt_utama.Text);
                    }
                    else if (LambangOperator == "/")
                    {
                        HasilTemp = HasilTemp / Convert.ToDouble(txt_utama.Text);
                    }
                    else if (LambangOperator == "mod")
                    {
                        HasilTemp = HasilTemp % Convert.ToDouble(txt_utama.Text);
                    }
                }
            }

            if(btnOP.Text == "=")
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

        private void btn_akar_Click(object sender, EventArgs e)
        {
            HasilTemp = double.Parse(txt_utama.Text);
            HasilTemp = Math.Sqrt(HasilTemp);
            txt_utama.Text = HasilTemp.ToString();
        }

        private void btn_Sin_Click(object sender, EventArgs e)
        {
            HasilTemp = double.Parse(txt_utama.Text);
            HasilTemp = Math.Sin(HasilTemp);
            txt_utama.Text = HasilTemp.ToString();
        }

        private void btn_Cos_Click(object sender, EventArgs e)
        {
            HasilTemp = double.Parse(txt_utama.Text);
            HasilTemp = Math.Cos(HasilTemp);
            txt_utama.Text = HasilTemp.ToString();
        }

        private void btn_Tan_Click(object sender, EventArgs e)
        {
            HasilTemp = double.Parse(txt_utama.Text);
            HasilTemp = Math.Tan(HasilTemp);
            txt_utama.Text = HasilTemp.ToString();
        }

        private void btn_phi_Click(object sender, EventArgs e)
        {
            double HasilTemp = Math.PI;
            txt_utama.Text = HasilTemp.ToString();
        }

        private void btn_persen_Click(object sender, EventArgs e)
        {
            HasilTemp = double.Parse(txt_utama.Text);
            HasilTemp = HasilTemp * 0.01;
            txt_utama.Text = HasilTemp.ToString();
        }

        private void btn_akar3_Click(object sender, EventArgs e)
        {
            HasilTemp = double.Parse(txt_utama.Text);
            HasilTemp = Math.Pow(HasilTemp,0.3333333333333333333333334);
            txt_utama.Text = HasilTemp.ToString();
        }
        private void btn_pangkat2_Click(object sender, EventArgs e)
        {
            HasilTemp = double.Parse(txt_utama.Text);
            HasilTemp = Math.Pow(HasilTemp,2);
            txt_utama.Text = HasilTemp.ToString();
        }

        private void btn_pangkat3_Click(object sender, EventArgs e)
        {
            HasilTemp = double.Parse(txt_utama.Text);
            HasilTemp = Math.Pow(HasilTemp,3);
            txt_utama.Text = HasilTemp.ToString();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            HasilTemp = double.Parse(txt_utama.Text);
            HasilTemp = Math.Log10(HasilTemp);
            txt_utama.Text = HasilTemp.ToString();
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
                exitCal = MessageBox.Show("Confirm if you want to Exit", "Scientific Calculator",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (exitCal == DialogResult.Yes)
                {
                    Application.Exit();
                }
         }

        private void btnSinh_Click(object sender, EventArgs e)
        {
            HasilTemp = double.Parse(txt_utama.Text);
            HasilTemp = Math.Sinh(HasilTemp);
            txt_utama.Text = HasilTemp.ToString();
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            HasilTemp = double.Parse(txt_utama.Text);
            HasilTemp = Math.Cosh(HasilTemp);
            txt_utama.Text = HasilTemp.ToString();
        }

        private void btn_Tanh_Click(object sender, EventArgs e)
        {
            HasilTemp = double.Parse(txt_utama.Text);
            HasilTemp = Math.Tanh(HasilTemp);
            txt_utama.Text = HasilTemp.ToString();
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            HasilTemp = double.Parse(txt_utama.Text);
            HasilTemp = 1 / HasilTemp;
            txt_utama.Text = HasilTemp.ToString();
        }

        private void btnInx_Click(object sender, EventArgs e)
        {
            HasilTemp = double.Parse(txt_utama.Text);
            HasilTemp = Math.Log(HasilTemp);
            txt_utama.Text = HasilTemp.ToString();
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            double dec = Convert.ToDouble(txt_utama.Text);
            int i1 = Convert.ToInt32(dec);
            int i2 = (int)dec;
            txt_utama.Text = Convert.ToString(i2);
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt_utama.Text);
            txt_utama.Text = Convert.ToString(a, 2);
        }

        private void btnHexa_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt_utama.Text);
            txt_utama.Text = Convert.ToString(a, 16);
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txt_utama.Text);
            txt_utama.Text = Convert.ToString(a, 8);
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
