using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentatonLayer.AutoForms
{
    public partial class ConfirmDeleteAuto : Form
    {
        public ConfirmDeleteAuto()
        {
            InitializeComponent();
        }

        public bool delete;

        private void button1_Click(object sender, EventArgs e)
        {
            delete = true;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delete = false;
            this.Hide();
        }
    }
}
