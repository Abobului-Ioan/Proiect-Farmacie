using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NivelAccesDate;
using MedicamentClass;
using System.Windows.Forms;

namespace InterfataUtilizatorForms
{
    public partial class Form2 : Form
        
    {
        IStocareData adminMedicamente = StocareFactory.GetAdministratorStocare();
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonCauta_Click(object sender, EventArgs e)
        {

            dataGridMedicament.DataSource = null;
            dataGridMedicament.DataSource = adminMedicamente.GetMedicaments();
            lblMesaj.Text = "Introduceti numele animeului cautat:";
            lblMesaj.ForeColor = Color.Black;
            Medicament a = adminMedicamente.GetMedicament(txtNume2.Text);
            if (a == null)
            {
                dataGridMedicament.DataSource = null;
                lblMesaj.Text = "Medicamentul nu a fost gasit. Introduceti altul?";
                lblMesaj.ForeColor = Color.Red;
            }
            else
            {
                dataGridMedicament.DataSource = null;
                lblMesaj.Text = "Medicamentul a fost gasit. Introduceti altul?";
                lblMesaj.ForeColor = Color.Green;
                dataGridMedicament.DataSource = adminMedicamente.GetMedicamentL(txtNume2.Text);
            }

            txtNume2.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            this.Close();
        }
    }
}
