using BusinessLayer;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentatonLayer.SaloniForms
{
    public partial class AddSalon : Form
    {
        private DbManager<Saloni, int> dbManagerSaloni = new DbManager<Saloni, int>(ContextGenerator.GetSaloniContext());
        private Saloni selectedSalon;
        public AddSalon()
        {
            InitializeComponent();
        }

        private void AddSalonButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationManager.IsValidString(SalonNameTextbox.Text)
                && ValidationManager.IsValidString(SalonAdressTextbox.Text))
                {
                    string name = SalonNameTextbox.Text;
                    string adress = SalonAdressTextbox.Text;


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
            SalonNameTextbox.Text = string.Empty;
            SalonAdressTextbox.Text = string.Empty;
        }
    }
}
