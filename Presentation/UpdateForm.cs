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
    The Update form code
    Contains all background services for this form
    */
    public partial class UpdateForm : Form
    {
        //Initialize the required controllers and constructor
        UserAccountController accController = new UserAccountController();
        BindingList<UserAccount> bl = new BindingList<UserAccount>();
        public UpdateForm()
        {
            InitializeComponent();
        }
        //Run when "Details" button is clicked. Get information for the UserAccount by Number
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
        //Run when "Search" button is clicked. Get information for the UserAccount by Name
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
        //Run when is UserAccount data is clicked on datagridview. Loads the data in the textboxes.
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal accNo = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var item = accController.Get(accNo).FirstOrDefault();
            txtAccNumber.Text = item.AccountNo.ToString();
            txtName.Text = item.Name;
            dateTimePicker1.Value = Convert.ToDateTime(item.Dob);
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
        //Run when "Delete" button is clicked. Deletes the specified account from the database via UserAccoountController.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            bl.RemoveAt(dataGridView1.SelectedRows[0].Index);
            accController.Delete(decimal.Parse(txtAccNumber.Text));
            dataGridView1.DataSource = bl;
        }
        //Run when "Update" button is clicked. Saves the edited data to the database via UserAccountController.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            decimal accNo = Convert.ToDecimal(txtAccNumber.Text);
            var acc = accController.Get(accNo).First();
            acc.Name = txtName.Text;
            acc.Dob = dateTimePicker1.Value.ToString();
            acc.MotherName = null;
            acc.FatherName = null;
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
            accController.Update(acc);
            MessageBox.Show("Данните са обновени!");
        }
    }
}