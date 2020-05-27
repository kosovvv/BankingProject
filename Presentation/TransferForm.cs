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
   The transfer form code
   Contains all background services for this form
   */
    public partial class TransferForm : Form
    {
        //Initialize the required controllers and constructor
        UserAccountController accController = new UserAccountController();
        TransferController transferController = new TransferController();
        public TransferForm()
        {
            InitializeComponent();
            //Shows daily date
            lblDate.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }
        //Run when "Transfer" button is clicked. Creates transfer, make operation between accounts and send saves to the database via TransferController.
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            decimal accNo = Convert.ToDecimal(txtTransferFrom.Text);
            var accSend = accController.Get(accNo).FirstOrDefault(); 
            txtName.Text = accSend.Name;
            decimal b1 = Convert.ToDecimal(accSend.Balance);
            decimal totalbal = Convert.ToDecimal(txtTransfer.Text);
            decimal transferaccNo = Convert.ToDecimal(txtTransferDestination.Text);
            if (b1 > totalbal)
            {
                var accRecieve = accController.Get(transferaccNo).FirstOrDefault();
                accController.MakeTransaction(totalbal, accSend, accRecieve);
                Transfer transfer = new Transfer();
                {
                    transfer.AccountNo = Convert.ToDecimal(txtTransferFrom.Text);
                    transfer.ToTransfer = Convert.ToDecimal(txtTransferDestination.Text);
                    transfer.Date = DateTime.UtcNow.ToString();
                    transfer.Name = txtName.Text;
                    transfer.Balance = Convert.ToDecimal(txtTransfer.Text);
                }
                transferController.Add(transfer); 
                MessageBox.Show($"Успешeно преведохте {transfer.Balance}лв. по сметката на {accRecieve.Name}!");
            }
        }
        //Run when "Details" button is clicked. Get information for the UserAccount by Number
        private void btnDetails_Click(object sender, EventArgs e)
        {
            decimal accNo = Convert.ToDecimal(txtTransferFrom.Text);
            var item = accController.Get(accNo).FirstOrDefault();
            txtName.Text = item.Name;
            txtCurrentAmount.Text = Convert.ToString(item.Balance);
        }
    }
}