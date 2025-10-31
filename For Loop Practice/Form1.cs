using System;
using System.Threading;
using System.Windows.Forms;

namespace For_Loop_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Practice 1: Output numbers 1–5
        private void btnPractice1_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            for (int i = 1; i <= 5; i++)
            {
                txtOutput.AppendText(i + Environment.NewLine);
            }
        }

        // Practice 2: Repeat phrase
        private void btnPractice2_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            for (int i = 0; i < 5; i++)
            {
                txtOutput.AppendText("Hi My Name is Ferd!" + Environment.NewLine);
            }
        }

        // Practice 3: Countdown with delay
        private void btnPractice3_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            for (int i = 5; i >= 1; i--)
            {
                txtOutput.AppendText(i + Environment.NewLine);
                txtOutput.Refresh();
                Thread.Sleep(500);
            }
            txtOutput.AppendText("BLAST OFF" + Environment.NewLine);
        }

        // Practice 4: Sum to 100 or user input
        private void btnPractice4_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            int limit = 100;
            if (int.TryParse(txtSumLimit.Text, out int userLimit))
            {
                limit = userLimit;
            }

            int sum = 0;
            for (int i = 1; i <= limit; i++)
            {
                sum += i;
            }

            txtOutput.AppendText($"Sum from 1 to {limit} = {sum}" + Environment.NewLine);
        }

        // Practice 5: Right triangle of stars
        private void btnPractice5_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    txtOutput.AppendText("*");
                }
                txtOutput.AppendText(Environment.NewLine);
            }
        }

        // Practice 6: Multiplication table
        private void btnPractice6_Click(object sender, EventArgs e)
        {
            bool errorFlag = false;
            txtOutput.Clear();
            int rows = 10;
            int cols = 10;

            if (int.TryParse(txtRows.Text, out int r)) rows = r;
            if (int.TryParse(txtCols.Text, out int c)) cols = c;

            if (rows + cols > 150) 
            {
                txtOutput.AppendText("NO!");
                errorFlag = true;
            }

            if (errorFlag == false) 
            {
                for (int i = 1; i <= rows; i++)
                {
                    for (int j = 1; j <= cols; j++)
                    {
                        txtOutput.AppendText((i * j).ToString().PadLeft(4));
                    }
                    txtOutput.AppendText(Environment.NewLine);
                }
            }
        }
    }
}
