using BankingProject.Business;
using BankingProject.Data;
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
   The BalanceSheet form code
   Contains all background services for this form
   */
    public partial class BalanceSheet : Form
    {
        //Initialize required controllers and constructor
        DebitController debitcontroller = new DebitController();
        DepositController depositcontroller = new DepositController();
        TransferController transfercontroller = new TransferController();
        public BalanceSheet()
        {
            InitializeComponent();
        }
        //Run when "Show" button is clicked. Get information for debit, deposit and transfer of specified useraccount
        private void btnShow_Click(object sender, EventArgs e)
        {
            decimal b = Convert.ToDecimal(txtName.Text);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView3.AutoGenerateColumns = false;
            dataGridView1.DataSource = debitcontroller.GetDebitDetails(b);
            dataGridView2.DataSource = depositcontroller.GetDepositDetails(b);
            dataGridView3.DataSource = transfercontroller.GetTransferDetails(b);
        }    
    }
}