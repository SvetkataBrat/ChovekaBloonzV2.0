using BusinessLayer;
using PresentatonLayer;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class ViewCustomers : Form
    {

        private DbManager<Customer, int> dbManagerCustomer = new DbManager<Customer, int>(ContextGenerator.GetCustomerContext());


        public ViewCustomers()
        {
            InitializeComponent();
        }

        private void ViewCustomers_Load(object sender, EventArgs e)
        {
            /*foreach (Customer c in AllContexts.customerContext.ReadAll())
            {
                ViewCustomersList.Items.Add(c);
            }*/
        }

        private void ViewCustomerChangeName_Click(object sender, EventArgs e)
        {
            ViewCustomerGetName.ReadOnly = false;
        }

        private void ViewCustomerChangeAddress_Click(object sender, EventArgs e)
        {
            ViewCustomerGetAddress.ReadOnly = false;
        }

        private void ViewCustomerChangeAge_Click(object sender, EventArgs e)
        {
            ViewCustomerGetAge.ReadOnly = false;
        }

        private void ViewCustomerChagePhone_Click(object sender, EventArgs e)
        {
            ViewCustomerGetPhone.ReadOnly = false;
        }

        private void ViewCustomerBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.ShowDialog();
            this.Close();   
        }

        private void ViewCustomerUpdate_Click(object sender, EventArgs e)
        {
            Customer updateCustomer = (Customer)ViewCustomersList.SelectedItem;
            dbManagerCustomer.Update(updateCustomer);
        }

        private void ViewCustomerDelete_Click(object sender, EventArgs e)
        {
            ConfirmDeleteCUstomer confirmation = new ConfirmDeleteCUstomer();
            confirmation.ShowDialog();
            if (!confirmation.Visible)
            {
                if (confirmation.delete)
                {
                    Customer deleteCustomer = (Customer)ViewCustomersList.SelectedItem;
                    dbManagerCustomer.Delete(deleteCustomer.Id);
                }
                confirmation.Close();
            }
        }
    }
}
