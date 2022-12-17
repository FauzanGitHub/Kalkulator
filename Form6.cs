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
    public partial class Form6 : Form
    {
        bool operandPerformed = false;
        string operand = "";
        double result = 0;
        string firstnum, secondnum;
        public Form6()
        {
            InitializeComponent();
        }

        private void NumEvent(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || operandPerformed)
                txtResult.Clear();

            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
            operandPerformed = false;
        }

        private void OperandEvent(object sender, EventArgs e)
        {
            operandPerformed = true;
            Button btn = (Button)sender;
            string newOperand = btn.Text;

            lbResult.Text = lbResult.Text + " " + txtResult.Text + " " + newOperand;

            switch (operand)
            {
                case "+": txtResult.Text = (result + Double.Parse(txtResult.Text)).ToString(); break;
                case "-": txtResult.Text = (result - Double.Parse(txtResult.Text)).ToString(); break;
                case "*": txtResult.Text = (result * Double.Parse(txtResult.Text)).ToString(); break;
                case "/": txtResult.Text = (result / Double.Parse(txtResult.Text)).ToString(); break;
                default: break;
            }

            result = Double.Parse(txtResult.Text);
            operand = newOperand;
            firstnum = lbResult.Text;

        }

        private void bCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void bC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            lbResult.Text = "";
            result = 0;
            operand = "";
        }

        private void bEq_Click(object sender, EventArgs e)
        {
            secondnum = txtResult.Text;
            lbResult.Text = "";
            operandPerformed = true;

            switch (operand)
            {
                case "+": txtResult.Text = (result + Double.Parse(txtResult.Text)).ToString(); break;
                case "-": txtResult.Text = (result - Double.Parse(txtResult.Text)).ToString(); break;
                case "*": txtResult.Text = (result * Double.Parse(txtResult.Text)).ToString(); break;
                case "/": txtResult.Text = (result / Double.Parse(txtResult.Text)).ToString(); break;
                default: break;
            }

            result = Double.Parse(txtResult.Text);
            txtResult.Text = result.ToString();
            result = 0;
            operand = "";

            btnClearHistory.Visible = true;
            rtbDisplayHistory.AppendText(firstnum + "   " + secondnum + "  =  " + "\n");
            rtbDisplayHistory.AppendText("\n\t" + txtResult.Text+"\n\n");
            lblHistoryDisplay.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!operandPerformed && !txtResult.Text.Contains(","))
            {
                txtResult.Text += ",";
            }
            else if (operandPerformed)
            {
                txtResult.Text = "0";
            }

            if (!txtResult.Text.Contains(","))
            {
                txtResult.Text += ",";
            }

            operandPerformed = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitCal;
            exitCal = MessageBox.Show("Confirm if you want to Exit", "Simple V3",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exitCal == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Hide();
        }

        private void loanManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
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

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void simpleV2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            rtbDisplayHistory.Clear();
            if(lblHistoryDisplay.Text =="")
            {
                lblHistoryDisplay.Text = "There's No History Yet";
            }
            btnClearHistory.Visible = false;
            rtbDisplayHistory.ScrollBars = 0;
        }
    }
}
