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
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            banking_dbContext db = new banking_dbContext();
            if (txtUsr.Text != "" || txtPsd.Text != "")
            {
                var user1 = db.AdminsTable.FirstOrDefault(a => a.Username.Equals(txtUsr.Text));
                if (txtUsr != null)
                {
                    if (user1.Password.Equals(txtPsd.Text))
                    {
                        Menu menu = new Menu();
                        menu.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Грешна парола!");
                    }
                }
                else
                {
                    MessageBox.Show("Грешна стойност!");
                }
            }
            else
            {
                MessageBox.Show("Моля, въведете потребителско име и парола!");
            }
        }
    }
}