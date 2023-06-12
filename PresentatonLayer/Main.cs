using PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentatonLayer
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void MainAddCar_Click(object sender, EventArgs e)
        {
            AddCars addCars = new AddCars();
            this.Hide();
            addCars.ShowDialog();
            this.Close();
        }
        
        private void MainViewCars_Click(object sender, EventArgs e)
        {
            ViewCars viewCars = new ViewCars();
            this.Hide();
            viewCars.ShowDialog();
            this.Close();
        }


        private void MainAddSalon_Click(object sender, EventArgs e)
        {
           /*
            AddSalon addSalon = new AddSalon();
            this.Hide();
            addSalon.ShowDialog();
            this.Close();
           */
        }

        private void MainViewSalons_Click(object sender, EventArgs e)
        {
            /*
            AddSalon addSalon = new AddSalon();
            this.Hide();
            addSalon.ShowDialog();
            this.Close();
            */
        }

        private void MainAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            this.Hide();
            addCustomer.ShowDialog();
            this.Close();
        }

        private void MainViewCustomers_Click(object sender, EventArgs e)
        {
            ViewCustomers viewCustomers = new ViewCustomers();
            this.Hide();
            viewCustomers.ShowDialog();
            this.Close();
        }

        
    }
}
