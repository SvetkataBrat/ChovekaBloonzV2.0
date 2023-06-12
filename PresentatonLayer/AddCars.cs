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

        private DbManager<Saloni, int> dbManagerSaloni = new DbManager<Saloni, int>(ContextGenerator.GetSaloniContext());
        private Auto selectedSalon;

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
                if(ValidationManager.IsValidString(textBox1.Text)
                && ValidationManager.IsValidString(textBox2.Text)
                && ValidationManager.IsValidString(textBox3.Text)
                && ValidationManager.IsValidString(textBox4.Text)
                && ValidationManager.IsValidString(textBox5.Text))
                {
                      int id = int.Parse(textBox1.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationManager.IsValidString(textBox6.Text)
                && ValidationManager.IsValidString(textBox7.Text)
                && ValidationManager.IsValidString(textBox8.Text))
                {
                    int id = int.Parse(textBox6.Text);
                    string name = textBox7.Text;
                    string adress = textBox8.Text;


                    Saloni salon = new Saloni(name, adress);
                    dbManagerSaloni.Create(salon);

                    MessageBox.Show("Salon created successfully! :)", "😎", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
        }

        private void AddCars_Load(object sender, EventArgs e)
        {

        }
    }
}
