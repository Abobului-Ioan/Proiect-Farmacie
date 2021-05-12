using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicamentClass;
using NivelAccesDate;



namespace InterfataUtilizatorForms
{
    
    public partial class Form1 : Form
        
    {
        IStocareData adminMedicamente = StocareFactory.GetAdministratorStocare();
        List<String> tipuriBifate = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medicament med = new Medicament(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            if (radioButton1.Checked)
                med.genMedicament = Medicaments.TipAdministrare.Lichid;
            if (radioButton2.Checked)
                med.genMedicament = Medicaments.TipAdministrare.Capsule;
            if (radioButton3.Checked)
                med.genMedicament = Medicaments.TipAdministrare.Injectabil;
            if (radioButton3.Checked)
                med.genMedicament = Medicaments.TipAdministrare.Inhalator;
            if (radioButton4.Checked)
                med.genMedicament = Medicaments.TipAdministrare.Supozitor;

            med.TipMedicament = new List<string>();
            med.TipMedicament.AddRange(tipuriBifate);
            adminMedicamente.AddMedicament(med);



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox;
            string tipBifat = checkBoxControl.Text;
            if (checkBoxControl.Checked == true)
                tipuriBifate.Add(tipBifat);
            else
                tipuriBifate.Remove(tipBifat);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
