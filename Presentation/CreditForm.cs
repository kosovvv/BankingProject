using BankingProject.Business;
using BankingProject.Data;
using BankingProject.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingProject
{
    /*
    The CreditForm code
    Contains all background services for this form
    */
    public partial class CreditForm : Form
    {
        //Initialize the required controllers and constructor
        UserAccountController accController = new UserAccountController();
        DepositController depositcontroller =  new DepositController();
        public CreditForm()
        {
            InitializeComponent();
            comboBox1.Items.Add("В брой");
            comboBox1.Items.Add("Чек");
            lblDate.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }
        //Run when "Details" button is clicked. Get information for the UserAccount by Number
        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            decimal accNo = Convert.ToDecimal(txtAccNum.Text);
            var item = accController.Get(accNo).FirstOrDefault();
            txtName.Text = item.Name;
            txtOldBalance.Text = Convert.ToString(item.Balance);
        }
        //Run when "Update" button is clicked. Get information for the detalis of UserAccount and update them with specified data
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            {
                deposit.Date = lblDate.Text;
                deposit.AccountNo = Convert.ToDecimal(txtAccNum.Text);
                deposit.Name = txtName.Text;
                deposit.OldBalance = Convert.ToDecimal(txtOldBalance.Text);
                deposit.Mode = comboBox1.SelectedItem.ToString();
                deposit.DipAmount = Convert.ToDecimal(txtDepositAmount.Text);
            }
            depositcontroller.Add(deposit);
            decimal accNo = Convert.ToDecimal(txtAccNum.Text);
            var accountSend = accController.Get(accNo).FirstOrDefault();
            accController.MakeDepositTransaction(deposit.DipAmount, accountSend);
            MessageBox.Show($"Успешeно депозирахте {deposit.DipAmount.ToString()}лв. по сметката на {deposit.Name}!");
        }
    }
}