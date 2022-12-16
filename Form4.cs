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
    public partial class Form4 : Form
    {
        double InterestRate, monthlyInterestRate, loanAmount, MonthlyPayment, TotalPayment;
        int numberOfYears;
        String iMonthlyPayment, iTotalPayment;
        public Form4()
        {
            InitializeComponent();
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txtAmountOfLoan.Clear();
            txtInterestRate.Clear();
            txtNumberOfYears.Clear();
            lblMonthlyPayment.Text = "";
            lblTotalPayment.Text = "";
            rtfReceipt.Clear();
        }

        private void btn_Loan_Click(object sender, EventArgs e)
        {
            InterestRate = Convert.ToDouble(txtInterestRate.Text);
            monthlyInterestRate = InterestRate / 1200;
            numberOfYears = Convert.ToInt32(txtNumberOfYears.Text);
            loanAmount = Convert.ToDouble(txtAmountOfLoan.Text);

            MonthlyPayment = loanAmount * monthlyInterestRate / (1 - 1 / Math.Pow(1 + monthlyInterestRate, numberOfYears * 12));

            iMonthlyPayment = Convert.ToString(MonthlyPayment);
            iMonthlyPayment = String.Format("{0:C}", MonthlyPayment);
            lblMonthlyPayment.Text = (iMonthlyPayment);

            TotalPayment = MonthlyPayment * numberOfYears * 12;
            iTotalPayment = String.Format("{0:C}", TotalPayment);
            lblTotalPayment.Text = (iTotalPayment);

            txtAmountOfLoan.Text = String.Format("{0:C}", loanAmount);
        }

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            rtfReceipt.AppendText("Loan Management Systems Calculator" + "\n");
            rtfReceipt.AppendText("-------------------------------------------------------------------" + "\n");
            rtfReceipt.AppendText("Enter Amount Of Loan" + "\t" + txtAmountOfLoan.Text + "\n");
            rtfReceipt.AppendText("Enter Number Of Years" + "\t" + txtNumberOfYears.Text + "\n");
            rtfReceipt.AppendText("Monthly Payment" + "\t" + "\t" + lblMonthlyPayment.Text + "\n");
            rtfReceipt.AppendText("Total Payment" + "\t" + "\t" + lblTotalPayment.Text + "\n");
            rtfReceipt.AppendText("-------------------------------------------------------------------" + "\n");
            rtfReceipt.AppendText("----------------------------Thank You------------------------------" + "\n");

        }

        private void simpleV3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
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

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Hide();
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

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Apakah anda ingin keluar", "Loan System", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            
            if (iExit==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
