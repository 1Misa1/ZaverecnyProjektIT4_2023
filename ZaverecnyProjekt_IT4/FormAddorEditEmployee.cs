using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaverecnyProjekt_IT4
{
    public partial class FormAddorEditEmployee : Form
    {

        private int id = -1;

        public FormAddorEditEmployee()
        {
            InitializeComponent();
        }

        public FormAddorEditEmployee(Employee employee)
        {
            id = employee.ID;
            InitializeComponent();
            txtFirstName.Text = employee.FirstName;
            txtLastName.Text = employee.LastName;
            dtpBirthdate.Value = employee.BirthDate;
            txtEmail.Text = employee.Email;
            txtPhoneNumber.Text = employee.PhoneNumber;

            btnAdd.Text = "Upravit";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                SqlRepository.AddEmployee(new Employee(txtFirstName.Text, txtLastName.Text, dtpBirthdate.Value, txtEmail.Text, txtPhoneNumber.Text));
            }
            else
            {
                SqlRepository.EditEmployee(id,new Employee(txtFirstName.Text, txtLastName.Text, dtpBirthdate.Value, txtEmail.Text, txtPhoneNumber.Text));
            }

            Close();

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtEmail.Text != "" && txtPhoneNumber.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

    }
}
