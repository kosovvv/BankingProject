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
    The CustomerList form code
    Contains all background services for this form
    */
    public partial class CustomerList : Form
    {
        //Initialize required controller and constructor
        UserAccountController accController = new UserAccountController();
        public CustomerList()
        {
            InitializeComponent();
            LoadGrid();
        }
        //Loads grid and get data from the UserAccountController via GetAllAccounts method
        private void LoadGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            var item = accController.GetAllAccounts();
            dataGridView1.DataSource = item;
        }
    }
}