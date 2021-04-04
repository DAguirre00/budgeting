using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Big_Project_practice
{
    public partial class Form1 : Form
    {
        public int counter = 0;
        public double Savings { get; private set; }

        public double Checking { get; private set; }

        public Form1()
        {
            InitializeComponent();
            CheckingTotal.Text = "0";
            SavingsTotal.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Cost_Trans_Const_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Calculate_Button_Click(object sender, EventArgs e)
        {
            Budgeting test = new Budgeting();
            if (ComboBoxState.Text.Contains("CT") && State_CheckBox.Checked)
            {
                Tax_Textbox.Text= State_Info.CT.tax_CT;
                Cost_Rent_Text.Text = State_Info.CT.rent_CT;
                Cost_Food_Text.Text = State_Info.CT.food_CT;
                Cost_Trans_Text.Text = State_Info.CT.trans_CT;
                Cost_Rent_Text.ReadOnly = false;
                Cost_Food_Text.ReadOnly = false;
                Cost_Trans_Text.ReadOnly = false;
                Calc_Savings_Text.ReadOnly = false;
            }
            double C_savings = test.Calculated_savings(Convert.ToDouble(Income_Text.Text), Convert.ToDouble(Tax_Textbox.Text), Convert.ToDouble(Cost_Rent_Text.Text), Convert.ToDouble(Cost_Food_Text.Text), Convert.ToDouble(Cost_Trans_Text.Text));
            Calc_Savings_Text.Text = Convert.ToString(C_savings);
            

            
            
        }
        
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            if (DepositBox.Text == "" || DepositText.Text == "")
            {
                MessageBox.Show("Please select an account and amount.");
            }
            else
            {
                CheckingSavings CheckingSavings = new CheckingSavings();
                CheckingSavings.Amount = DepositText.Text;
                CheckingSavings.Account = DepositBox.Text;
                CheckingSavings.CTotal = CheckingTotal.Text;
                CheckingSavings.STotal = SavingsTotal.Text;

                if (DepositBox.Text == "Savings")
                {
                    string temp = CheckingSavings.Deposit();
                    if (temp != "Error")
                    {
                        SavingsTotal.Text = temp;
                    }
                    else
                    {
                        MessageBox.Show("Enter a number into the box");
                    }
                }
                else if (DepositBox.Text == "Checking")
                {
                    string temp = CheckingSavings.Deposit();
                    if (temp != "Error")
                    {
                        CheckingTotal.Text = temp;
                    }
                    else
                    {
                        MessageBox.Show("Enter a number into the box");
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            CheckingSavings CheckingSavings = new CheckingSavings();
            CheckingSavings.Amount = WithdrawText.Text;
            CheckingSavings.Account = WithdrawBox.Text;
            CheckingSavings.CTotal = CheckingTotal.Text;
            CheckingSavings.STotal = SavingsTotal.Text;

            if (WithdrawBox.Text == "" || WithdrawText.Text == "")
            {
                MessageBox.Show("Please select an account and amount.");
            }
            else
            {
                if (WithdrawBox.Text == "Savings")
                {
                    string temp = CheckingSavings.Withdraw();
                    if (temp != "Error")
                    {
                        SavingsTotal.Text = temp;
                    }
                    else
                    {
                        MessageBox.Show("Enter a number into the box");
                    }
                }
                else if (WithdrawBox.Text == "Checking")
                {
                    string temp = CheckingSavings.Withdraw();
                    if (temp != "Error")
                    {
                        CheckingTotal.Text = temp;
                    }
                    else
                    {
                        MessageBox.Show("Enter a number into the box");
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void Transferbutton_Click(object sender, EventArgs e)
        {
            CheckingSavings CheckingSavings = new CheckingSavings();
            CheckingSavings.Amount = TransferText.Text;
            CheckingSavings.Account = TransferBox.Text;
            CheckingSavings.CTotal = CheckingTotal.Text;
            CheckingSavings.STotal = SavingsTotal.Text;

            if (TransferBox.Text == "" || TransferText.Text == "")
            {
                MessageBox.Show("Please select how you want to transfer.");
            }
            else
            {
                string[] temp = CheckingSavings.Transfer();
                if (temp[1] == "Error")
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    CheckingTotal.Text = temp[0];
                    SavingsTotal.Text = temp[2];
                }
            }
        }

        private void Income_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Time_Calc_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
