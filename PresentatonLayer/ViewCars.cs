using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using ServiceLayer;

namespace PresentatonLayer
{
    public partial class ViewCars : Form
    {
        Auto selectedAuto;
        Saloni selectedSalon;

        DbManager<Auto, int> autoManager = new DbManager<Auto, int>(ContextGenerator.GetAutoContext());
        DbManager<Saloni, int> salonManager = new DbManager<Saloni, int>(ContextGenerator.GetSaloniContext());


        public ViewCars()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
