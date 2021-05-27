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
        List<Medicament> listMedicamenteFisier;
        public Form1()
        {
            InitializeComponent();
            listMedicamenteFisier = adminMedicamente.GetMedicamentsFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medicament med = new Medicament(textId.Text, textNume.Text, textGramaj.Text, textPret.Text, textDataExpirare.Text);
            if (rdbLichid.Checked)
                med.genMedicament = Medicaments.TipAdministrare.Lichid;
            if (rdbCapsule.Checked)
                med.genMedicament = Medicaments.TipAdministrare.Capsule;
            if (rdbInjectabil.Checked)
                med.genMedicament = Medicaments.TipAdministrare.Injectabil;
            if (rdbInjectabil.Checked)
                med.genMedicament = Medicaments.TipAdministrare.Inhalator;
            if (rdbInhalator.Checked)
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

     //AFISARE
        private void button2_Click(object sender, EventArgs e)
        {
            ListaMedicamente.Items.Clear();
            foreach (Medicament m in adminMedicamente.GetMedicaments())
            {
                ListaMedicamente.Items.Add(m.ConversieLaSir());
            }
        }

        //private void btnModificare_Click(object sender, EventArgs e)
        //{
        //    if (btnCauta.Tag.ToString() == "0")
        //        return;
        //    if (textId.Text == string.Empty || !int.TryParse(textId.Text, out int inputId))
        //    {
        //        labelId.ForeColor = Color.Red;
        //        return;
        //    }
        //    if(textPret.Text == string.Empty || !int.TryParse(textPret.Text, out int inputPret))
        //    {
        //        labelGramaj.ForeColor = Color.Red;
        //        return;
        //    }
        //}

        private void gpbTipAdministrare_Enter(object sender, EventArgs e)
        {

        }

        //private void btnCautare_Click(object sender, EventArgs e)
        //{
        //    if (textNume.Text == string.Empty)
        //    {
        //        labelNume.ForeColor = Color.Red;
        //        return;
        //    }
        //    if (btnCautare.Tag.ToString() == "1")
        //        btnCautare.Tag = "0";
        //    else if(btnCautare.Tag.ToString() == "0")
        //        btnCautare.Tag = "1";
        //    if(!IsString(textNume.Text))
        //    {
        //        labelNume.ForeColor = Color.Red;
        //        textNume.Clear();
        //        return;
        //    }
        //    ListaMedicamente.Items.Clear();
        //    Medicament medicamentCautat = new Medicament();
        //    medicamentCautat.nume_medicament = textNume.Text;
        //    List<Medicament> medicamenteCautate = adminMedicamente.SearchMedicaments(medicamentCautat, listMedicamenteFisier);
        //    if(medicamenteCautate.Count == 0)
        //    {
        //        ListaMedicamente.Items.Add("-----NU EXISTA-----");
        //        return;
        //    }
        //    foreach(Medicament m in medicamenteCautate)
        //    {
        //        ListaMedicamente.Items.Add( m.ConversieLaSir());
        //    }
        //}
        public static bool IsString(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsLetter(c))
                    return false;
            }


            return true;
        }
        private void show()
        {
            ListaMedicamente.Items.Clear();
            foreach (Medicament m in adminMedicamente.GetMedicaments())
            {
                ListaMedicamente.Items.Add(m.ConversieLaSir());
            }
        }
        private void buttonStergere_Click(object sender, EventArgs e)
        {
            Medicament m = adminMedicamente.GetMedicament (ListaMedicamente.SelectedIndex);
            adminMedicamente.DeleteMedicament(m);

            show();
            
            
            
        }

        private void stergereMedicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ListaMedicamente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cautareMedicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            this.Hide();
            fr2.Show();
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            Medicament m = adminMedicamente.GetMedicament(ListaMedicamente.SelectedIndex);
           
            m.id = Convert.ToInt32(textId.Text);
            m.nume_medicament = textNume.Text;
            m.gramaj = Convert.ToInt32(textGramaj.Text);
            m.pret = Convert.ToInt32(textPret.Text);
            m.data_expirare = textDataExpirare.Text;

            if (rdbLichid.Checked)
                m.genMedicament = Medicaments.TipAdministrare.Lichid;
            if (rdbCapsule.Checked)
                m.genMedicament = Medicaments.TipAdministrare.Capsule;
            if (rdbInjectabil.Checked)
                m.genMedicament = Medicaments.TipAdministrare.Injectabil;
            if (rdbInjectabil.Checked)
                m.genMedicament = Medicaments.TipAdministrare.Inhalator;
            if (rdbInhalator.Checked)
                m.genMedicament = Medicaments.TipAdministrare.Supozitor;

            m.TipMedicament = new List<string>();
            m.TipMedicament.AddRange(tipuriBifate);
            adminMedicamente.RewriteMedicaments(m);
            show();





        }
    }
}
