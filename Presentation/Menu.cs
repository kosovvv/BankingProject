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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void newAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newAccount newAccount = new newAccount();
            newAccount.MdiParent = this;
            newAccount.Show();
        }

        private void updatesearchaccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();
            updateForm.MdiParent = this;
            updateForm.Show();
        }

        private void AllCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerList customerList = new CustomerList();
            customerList.MdiParent = this;
            customerList.Show();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            CreditForm creditForm = new CreditForm();
            creditForm.MdiParent = this;
            creditForm.Show();
        }
        private void withdrawlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DebitForm debitForm = new DebitForm();
            debitForm.MdiParent = this;
            debitForm.Show();
        }
        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm();
            transferForm.MdiParent = this;
            transferForm.Show();
        }

        private void balanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BalanceSheet balanceSheet = new BalanceSheet();
            balanceSheet.MdiParent = this;
            balanceSheet.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
