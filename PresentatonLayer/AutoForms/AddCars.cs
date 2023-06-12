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
using ServiceLayer;

namespace PresentatonLayer
{
    public partial class AddCars : Form
    {

        private DbManager<Auto, int> dbManagerAuto = new DbManager<Auto, int>(ContextGenerator.GetAutoContext());
        private Auto selectedAuto;


        public AddCars()
        {
            InitializeComponent();
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(ValidationManager.IsValidString(textBox2.Text)
                && ValidationManager.IsValidString(textBox3.Text)
                && ValidationManager.IsValidString(textBox4.Text)
                && ValidationManager.IsValidString(textBox5.Text))
                {
                      string brand = textBox2.Text;
                      int hp = int.Parse(textBox3.Text);
                      double price = double.Parse(textBox4.Text);
                      int salonID = int.Parse(textBox5.Text);

                      Auto car = new Auto(brand, hp, price, salonID);
                      dbManagerAuto.Create(car);

                      MessageBox.Show("Car created successfully! :)", "😎", MessageBoxButtons.OK, MessageBoxIcon.Information);

                      ClearTextBoxes();

                }
                else
                {
                    MessageBox.Show("You have to enter values in the text boxes! 🤨🤨🤨", "☹", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "😭", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ClearTextBoxes()
        {
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        private void AddCars_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }
    }
}
