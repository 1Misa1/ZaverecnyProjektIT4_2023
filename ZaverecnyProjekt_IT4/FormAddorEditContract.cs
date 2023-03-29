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
    public partial class FormAddorEditContract : Form
    {
        private int id = -1;

        public FormAddorEditContract()
        {
            InitializeComponent();
        }

        public FormAddorEditContract(Contract contract)
        {
            id = contract.ID;
            InitializeComponent();
            txtCustomer.Text = contract.Customer;
            txtDescription.Text = contract.Customer;

            btnAdd.Text = "Upravit";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (id == -1)
            {
                SqlRepository.AddContract(new Contract(txtCustomer.Text, txtDescription.Text));
            }
            else
            {
                SqlRepository.EditContract(id, new Contract(txtCustomer.Text, txtDescription.Text));
            }

            Close();
        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomer.Text!= "" && txtDescription.Text != "")
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
