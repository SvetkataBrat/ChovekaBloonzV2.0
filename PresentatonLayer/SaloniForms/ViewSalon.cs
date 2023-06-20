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
using PresentationLayer;
using ServiceLayer;

namespace PresentatonLayer.SaloniForms
{
    public partial class ViewSalon : Form
    {
        private DbManager<Saloni, int> dbManagerSaloni = new DbManager<Saloni, int>(ContextGenerator.GetSaloniContext());
        private Saloni selectedSalon;
        
        private void ViewSalon_Load(object sender, EventArgs e)
        {
            ViewSalonListbox.DataSource = dbManagerSaloni.ReadAll();
        }
        
        public ViewSalon()
        {
            InitializeComponent();
        }

        private void ViewSaloniChangeName_Click(object sender, EventArgs e)
        {
            ViewSaloniNameTextbox.ReadOnly = false;
        }

        private void ViewSaloniChangeAdress_Click(object sender, EventArgs e)
        {
            ViewSaloniAdressTextbox.ReadOnly = false;
        }

        private void ViewSaloniBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();
            main.ShowDialog();
            this.Close();
        }

        private void ViewSaloniUpdate_Click(object sender, EventArgs e)
        {
            Saloni updateSalon = (Saloni)ViewSalonListbox.SelectedItem;
            dbManagerSaloni.Update(updateSalon);
        }

        private void ViewSaloniDelete_Click(object sender, EventArgs e)
        {
            ConfirmDeleteSalon confirmation = new ConfirmDeleteSalon();
            confirmation.ShowDialog();
            if (!confirmation.Visible)
            {
                if (confirmation.delete)
                {
                    Saloni deleteSalon = (Saloni)ViewSalonListbox.SelectedItem;
                    dbManagerSaloni.Delete(deleteSalon.Id);
                }
                confirmation.Close();
            }
        }

       
    }
}
