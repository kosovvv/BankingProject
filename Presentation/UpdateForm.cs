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
    // Completed - 100%
    public partial class UpdateForm : Form
    {
        UserAccountController accController = new UserAccountController();
        BindingList<UserAccount> bl = new BindingList<UserAccount>();
        public UpdateForm()
        {
            InitializeComponent();
        }
        private void btnDetalis_Click(object sender, EventArgs e)
        {
            decimal AccNo = Convert.ToDecimal(txtAccNumber.Text);
            var items = accController.Get(AccNo); 
            foreach (var item in items)
            {
                bl.Add(item);
            }
            dataGridView1.DataSource = bl;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var Name = txtName.Text;
            var items = accController.Get(Name);
            foreach (var item in items)
            {
                bl.Add(item);
            }
            dataGridView1.DataSource = bl;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal accNo = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var item = accController.Get(accNo).FirstOrDefault();
            txtAccNumber.Text = item.AccountNo.ToString();
            txtName.Text = item.Name;
            txtMother.Text = item.MotherName;
            txtFather.Text = item.FatherName;
            txtBoxPhone.Text = item.PhoneNo;
            txtBoxAddress.Text = item.Address;
            txtBoxOblast.Text = item.Oblast;
            txtBoxCity.Text = item.State;
            if (item.Gender =="male")
            {
                rButtonMale1.Checked = true;
            }
            else if (item.Gender == "female")
            {
                rButtonMale1.Checked = true;
            }
            if (item.MaritialStatus=="married")
            {
                rbtnMarried1.Checked = true;
            }
            else if (item.MaritialStatus == "unmarried")
            {
                rbtnUnmarried1.Checked = true;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            bl.RemoveAt(dataGridView1.SelectedRows[0].Index);
            accController.Delete(decimal.Parse(txtAccNumber.Text));
            dataGridView1.DataSource = bl;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            decimal accNo = Convert.ToDecimal(txtAccNumber.Text);
            var acc = accController.Get(accNo).First(); //useracc
            acc.Name = txtName.Text;
            acc.Date = dateTimePicker1.Value.ToString();
            acc.MotherName = txtMother.Text;
            acc.FatherName = txtFather.Text;
            acc.PhoneNo = txtBoxPhone.Text;
            if (rButtonMale1.Checked == true)
            {
                acc.Gender = "male";
            }
            else
            {
                if (rButtonFemale1.Checked== true)
                {
                    acc.Gender = "female";
                }
            }
            if (rbtnMarried1.Checked == true)
            {
                acc.MaritialStatus = "Married";
            }
            else
            {
                if (rbtnUnmarried1.Checked == true)
                {
                    acc.MaritialStatus = "Unmarried";
                }
            }
            acc.Address = txtBoxAddress.Text;
            acc.Oblast = txtBoxOblast.Text;
            acc.State = txtBoxCity.Text;
            accController.SaveChanges();
            MessageBox.Show("Данните са обновени!");
        }
    }
}