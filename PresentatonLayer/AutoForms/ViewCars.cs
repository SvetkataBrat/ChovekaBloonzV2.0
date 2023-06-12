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
    public partial class ViewCars : Form
    {
        public ViewCars()
        {
            InitializeComponent();
        }

        private void ViewCars_Load(object sender, EventArgs e)
        {

        }

        private void change1(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
        }

        private void change2(object sender, EventArgs e)
        {
            ViewCustomerGetName.ReadOnly = false;
        }

        private void change3(object sender, EventArgs e)
        {
            ViewCustomerGetName.ReadOnly = false;
        }

        private void change4(object sender, EventArgs e)
        {
            ViewCustomerGetName.ReadOnly = false;
        }
    }
}
