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
    // Completed - 100%
    public partial class CustomerList : Form
    {
        UserAccountController accController = new UserAccountController();
        public CustomerList()
        {
            InitializeComponent();
            LoadGrid();
        }
        private void LoadGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            var item = accController.GetAllAccounts();
            dataGridView1.DataSource = item;
        }
    }
}