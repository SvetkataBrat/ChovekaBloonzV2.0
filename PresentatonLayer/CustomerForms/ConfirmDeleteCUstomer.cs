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
    public partial class ConfirmDeleteCUstomer : Form
    {
        public bool delete;

        public ConfirmDeleteCUstomer()
        {
            InitializeComponent();
        }

        private void ConfirmDeleteUserNo_Click(object sender, EventArgs e)
        {
            delete = false;
            this.Hide();
        }

        private void ConfirmDeletUserYes_Click(object sender, EventArgs e)
        {
            delete = true;
            this.Hide();
        }

        private void ConfirmDeleteCUstomer_Load(object sender, EventArgs e)
        {

        }
    }
}
