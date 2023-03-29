﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaverecnyProjekt_IT4
{
    public partial class FormMain : Form
    {
        List<Employee> employees = new List<Employee>(); 
        List<Contract> contracts = new List<Contract>();

        public FormMain()
        {
            InitializeComponent();
            employees = SqlRepository.EmployeeList();
            contracts = SqlRepository.ContractList();
            updateemployee();
            updatecontracts();
        }

        private void updateemployee()
        {
            lvEmployee.Items.Clear();
            foreach(Employee employee in SqlRepository.EmployeeList())
            {
                if(employee.FirstName.ToLower().Contains(txtSearchEmployee.Text.ToLower()) || (employee.LastName.ToLower().Contains(txtSearchEmployee.Text.ToLower())))
                lvEmployee.Items.Add(new ListViewItem(new string[] { employee.ID.ToString(), employee.FirstName, employee.LastName, employee.BirthDate.ToString(), employee.Email, employee.PhoneNumber }));
            }
        }

        private void updatecontracts()
        {
            lvContract.Items.Clear();
            foreach (Contract contract in SqlRepository.ContractList())
            {
                lvContract.Items.Add(new ListViewItem(new string[] { contract.Customer, contract.Description }));
            }
        }



        private void btnLogOut_Click(object sender, EventArgs e)
        {


        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Close();
        }

        private void lvEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteEmployee.Enabled = lvEmployee.SelectedIndices.Count == 1;
            btnEditEmployee.Enabled = lvEmployee.SelectedIndices.Count == 1;
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            SqlRepository.DeleteEmployeebyId(int.Parse(lvEmployee.SelectedItems[0].Text));
            updateemployee();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Form formEmployee = new FormAddorEditEmployee();
            formEmployee.ShowDialog();

            employees = SqlRepository.EmployeeList();
            updateemployee();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            Form formEmployee = new FormAddorEditEmployee(employees[lvEmployee.SelectedIndices[0]]);
            formEmployee.ShowDialog();

            employees = SqlRepository.EmployeeList();
            updateemployee();
        }

        private void txtHledatEmployee_TextChanged(object sender, EventArgs e)
        {
            updateemployee();
        }

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            Form formContract = new FormAddorEditContract();
            formContract.ShowDialog();

            contracts = SqlRepository.ContractList();
            updatecontracts();
        }
    }
}
