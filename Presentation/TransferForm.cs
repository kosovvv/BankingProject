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
    public partial class TransferForm : Form
    {
        UserAccountController accController = new UserAccountController();
        TransferController transferController = new TransferController();
        public TransferForm()
        {
            InitializeComponent();
            lblDate.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            decimal accNo = Convert.ToDecimal(txtTransferFrom.Text);
            var item = accController.Get(accNo).FirstOrDefault(); 
            txtName.Text = item.Name;
            decimal b1 = Convert.ToDecimal(item.Balance);
            decimal totalbal = Convert.ToDecimal(txtTransfer.Text);
            decimal transferaccNo = Convert.ToDecimal(txtTransferDestination.Text);
            if (b1 > totalbal)
            {
                var item2 = accController.Get(transferaccNo).FirstOrDefault();
                accController.MakeTransaction(totalbal, item, item2);
                Transfer transfer = new Transfer();
                {
                    transfer.AccountNo = Convert.ToDecimal(txtTransferFrom.Text);
                    transfer.ToTransfer = Convert.ToDecimal(txtTransferDestination.Text);
                    transfer.Date = DateTime.UtcNow.ToString();
                    transfer.Name = txtName.Text;
                    transfer.Balance = Convert.ToDecimal(txtTransfer.Text);
                }
                transferController.Add(transfer); 
                MessageBox.Show("Успешeно преведохте " + transfer.Balance + "лв. по сметката на " + item2.Name + "!");
            }
        }
        private void btnDetails_Click(object sender, EventArgs e)
        {
            decimal accNo = Convert.ToDecimal(txtTransferFrom.Text);
            var item = accController.Get(accNo).FirstOrDefault();
            txtName.Text = item.Name;
            txtCurrentAmount.Text = Convert.ToString(item.Balance);
        }
    }
}