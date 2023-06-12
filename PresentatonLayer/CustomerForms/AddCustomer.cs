using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataLayer;
using PresentatonLayer;
using ServiceLayer;

namespace PresentationLayer
{
    public partial class AddCustomer : Form
    {

        private DbManager<Customer, int> dbManagerCustomer = new DbManager<Customer, int>(ContextGenerator.GetCustomerContext());

        public AddCustomer()
        {
            InitializeComponent();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void addCustomerBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void addCustomerConfirm_Click(object sender, EventArgs e)
        {
            string fName = addCustomerFNameTbox.Text;
            string lName = addCustomerLNameTbox.Text;
            string address = AddCustomerAddressTbox.Text;
            int age = int.Parse(addCustomerAgeTbox.Text);
            string phone = addCustomerPhoneTbox.Text;
            dbManagerCustomer.Create(new Customer(fName, lName, address, age, phone));
        }
    }
}
