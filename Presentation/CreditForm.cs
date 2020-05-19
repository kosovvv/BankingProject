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
    public partial class CreditForm : Form
    {
        UserAccountController accController = new UserAccountController();
        DepositController depositcontroller =  new DepositController();
        public CreditForm()
        {
            InitializeComponent();
            comboBox1.Items.Add("В брой");
            comboBox1.Items.Add("Чек");
            lblDate.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }
        private void btnGetDetails_Click(object sender, EventArgs e)
        {
            decimal accNo = Convert.ToDecimal(txtAccNum.Text);
            var item = accController.Get(accNo).FirstOrDefault();
            txtName.Text = item.Name;
            txtOldBalance.Text = Convert.ToString(item.Balance);
        }
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
            var item = accController.Get(accNo).FirstOrDefault();
            accController.MakeDepositTransaction(deposit.DipAmount, item);
            MessageBox.Show($"Успешeно депозирахте {deposit.DipAmount.ToString()}лв. по сметката на {deposit.Name}!");
        }
    }
}