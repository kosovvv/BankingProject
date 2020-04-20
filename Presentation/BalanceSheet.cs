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
    public partial class BalanceSheet : Form
    {
        DebitController debitcontroller = new DebitController();
        DepositController depositcontroller = new DepositController();
        TransferController transfercontroller = new TransferController();
        public BalanceSheet()
        {
            InitializeComponent();
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            decimal b = Convert.ToDecimal(txtName.Text);
            dataGridView1.DataSource = debitcontroller.GetDebitDetails(b);
            dataGridView2.DataSource = depositcontroller.GetDepositDetails(b);
            dataGridView3.DataSource = transfercontroller.GetTransferDetails(b);
        }    
    }
}