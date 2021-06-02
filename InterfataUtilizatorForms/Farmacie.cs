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
using System.IO;



namespace InterfataUtilizatorForms
{
    
    public partial class Farmacie : Form
        
    {
        private const int limita = 0;
        IStocareData adminMedicamente = StocareFactory.GetAdministratorStocare();
        List<String> tipuriBifate = new List<string>();
        public string TextArea { get; set; }
        List<Medicament> listMedicamenteFisier;
        public Farmacie()
        {
            InitializeComponent();
            listMedicamenteFisier = adminMedicamente.GetMedicamentsFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ValidareDate() == false)
            {
                return;
            }
            Medicament med = new Medicament(textId.Text, textNume.Text, textGramaj.Text, textPret.Text, textDataExpirare.Text);
            if (rdbLichid.Checked)
                med.genMedicament = MedicamentClass.TipAdministrare.Lichid;
            if (rdbCapsule.Checked)
                med.genMedicament = MedicamentClass.TipAdministrare.Capsule;
            if (rdbInjectabil.Checked)
                med.genMedicament = MedicamentClass.TipAdministrare.Injectabil;
            if (rdbInjectabil.Checked)
                med.genMedicament = MedicamentClass.TipAdministrare.Inhalator;
            if (rdbInhalator.Checked)
                med.genMedicament = MedicamentClass.TipAdministrare.Supozitor;

            med.TipMedicament = new List<string>();
            med.TipMedicament.AddRange(tipuriBifate);
            adminMedicamente.AddMedicament(med);

            ResetareControale();
            show();

            

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
            ListaMedicamente.Items.Add("Lista Medicamente");
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
        private void ResetareControale()
        {
            textId.Text = textNume.Text = textGramaj.Text = textPret.Text = textDataExpirare.Text = String.Empty;
            rdbCapsule.Checked = false;
            rdbInhalator.Checked = false;
            rdbInjectabil.Checked = false;
            rdbLichid.Checked = false;
            rdbSupozitor.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            tipuriBifate.Clear();
            ListaMedicamente.Text = string.Empty;

        }
        private TipAdministrare? GetTipAdministrare()
        {
            if (rdbCapsule.Checked)
                return TipAdministrare.Capsule;
            if (rdbInhalator.Checked)
                return TipAdministrare.Inhalator;
            if (rdbInjectabil.Checked)
                return TipAdministrare.Injectabil;
            if (rdbLichid.Checked)
                return TipAdministrare.Lichid;
            if (rdbSupozitor.Checked)
                return TipAdministrare.Supozitor;
            return null;
        }
        private bool ValidareDate()
        {
            int input;
            bool Valid = true;
            TipAdministrare? tipAdministrare = GetTipAdministrare();
            if(tipAdministrare.HasValue == false)
            {
                gpbTipAdministrare.ForeColor = Color.Red;
                Valid = false;
            }
            if(textId.Text == string.Empty)
            {
                labelId.ForeColor = Color.Red;
                Valid = false;
            }
            if (textNume.Text == string.Empty)
            {
                labelNume.ForeColor = Color.Red;
                Valid = false;
            }
            if (textGramaj.Text == string.Empty)
            {
                labelGramaj.ForeColor = Color.Red;
                Valid = false;
            }
            if (textPret.Text == string.Empty)
            {
                labelPret.ForeColor = Color.Red;
                Valid = false;
            }
            if (textDataExpirare.Text == string.Empty)
            {
                labelData.ForeColor = Color.Red;
                Valid = false;
            }
            if(tipuriBifate.Count == limita)
            {
                gpbTipMedicament.ForeColor = Color.Red;
                Valid = false;
            }
            if(!int.TryParse(textId.Text, out input))
            {
                labelId.ForeColor = Color.Red;
                textId.Clear();
                Valid = false;
            }
            if (!int.TryParse(textGramaj.Text, out input))
            {
                labelGramaj.ForeColor = Color.Red;
                textGramaj.Clear();
                Valid = false;
            }
            if (!int.TryParse(textPret.Text, out input))
            {
                labelPret.ForeColor = Color.Red;
                textPret.Clear();
                Valid = false;
            }
            if (Valid == true)
            {
                labelId.ForeColor = Color.Black;
                labelNume.ForeColor = Color.Black;
                labelPret.ForeColor = Color.Black;
                labelGramaj.ForeColor = Color.Black;
                labelData.ForeColor = Color.Black;
                gpbTipAdministrare.ForeColor = Color.Black;
                gpbTipMedicament.ForeColor = Color.Black;
                return true;
            }
            else
                return false;


        }
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
            ListaMedicamente.Items.Add("Lista Medicamente:");
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
            ResetareControale();
            
            
            
        }

        private void ListaMedicamente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetareControale();
            Medicament m = adminMedicamente.GetMedicament(ListaMedicamente.SelectedIndex);
            textId.Text = m.id.ToString();
            textNume.Text = m.nume_medicament;
            textGramaj.Text = m.gramaj.ToString();
            textPret.Text = m.pret.ToString();
            textDataExpirare.Text = m.data_expirare;

            foreach(Control c in gpbTipAdministrare.Controls)
            {
                if(c.GetType() == typeof(RadioButton))
                {
                    if(m.genMedicament.ToString() == c.Text)
                    {
                        ((RadioButton)c).Checked = true;
                    }
                }
            }

            foreach(Control c in gpbTipMedicament.Controls)
            {
                if(c.GetType() == typeof(CheckBox))
                {
                    foreach(var gen in m.TipMedicament)
                    {
                        if (((CheckBox)c).Text == gen)
                            ((CheckBox)c).Checked = true;
                    }
                }
            }
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
           if(ValidareDate() == false)
            {
                return;
            }
            m.id = Convert.ToInt32(textId.Text);
            m.nume_medicament = textNume.Text;
            m.gramaj = Convert.ToInt32(textGramaj.Text);
            m.pret = Convert.ToInt32(textPret.Text);
            m.data_expirare = textDataExpirare.Text;

            //if (rdbLichid.Checked)
            //    m.genMedicament = MedicamentClass.TipAdministrare.Lichid;
            //if (rdbCapsule.Checked)
            //    m.genMedicament = MedicamentClass.TipAdministrare.Capsule;
            //if (rdbInjectabil.Checked)
            //    m.genMedicament = MedicamentClass.TipAdministrare.Injectabil;
            //if (rdbInjectabil.Checked)
            //    m.genMedicament = MedicamentClass.TipAdministrare.Inhalator;
            //if (rdbInhalator.Checked)
            //    m.genMedicament = MedicamentClass.TipAdministrare.Supozitor;
            TipAdministrare? tipAdministrare = GetTipAdministrare();
            if(tipAdministrare.HasValue)
            {
                m.genMedicament = tipAdministrare.Value;
            }
            m.TipMedicament = new List<string>();
            m.TipMedicament.AddRange(tipuriBifate);
            adminMedicamente.RewriteMedicaments(m);
            show();
            ResetareControale();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
