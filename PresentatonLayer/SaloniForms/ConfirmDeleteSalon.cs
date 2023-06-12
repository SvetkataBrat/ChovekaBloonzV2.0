using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentatonLayer.SaloniForms
{
    public partial class ConfirmDeleteSalon : Form
    {
        public bool delete;
        public ConfirmDeleteSalon()
        {
            InitializeComponent();
        }

        private void ConfirmDeleteSalonNo_Click(object sender, EventArgs e)
        {
            delete = false;
            this.Hide();
        }

        private void ConfirmDeleteSalonYes_Click(object sender, EventArgs e)
        {
            delete = true;
            this.Hide();
        }
    }
}
