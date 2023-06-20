using BusinessLayer;
using PresentationLayer;
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

namespace PresentatonLayer.AutoForms
{
    public partial class ViewCars : Form
    {

        private DbManager<Auto, int> dbManagerAuto = new DbManager<Auto, int>(ContextGenerator.GetAutoContext());
        private Auto selectedAuto;

        public ViewCars()
        {
            InitializeComponent();
        }

        private void ViewCars_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = dbManagerAuto.ReadAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.ReadOnly = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.ReadOnly = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Auto updateAuto = (Auto)listBox1.SelectedItem;
            dbManagerAuto.Update(updateAuto);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ConfirmDeleteAuto confirmation = new ConfirmDeleteAuto();
            confirmation.ShowDialog();
            if (!confirmation.Visible)
            {
                if (confirmation.delete)
                {
                    Auto deleteAuto = (Auto)listBox1.SelectedItem;
                    dbManagerAuto.Delete(deleteAuto.Id);
                }
                confirmation.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
