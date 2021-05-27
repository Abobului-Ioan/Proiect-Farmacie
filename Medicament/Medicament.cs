using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using System.Linq;
using Medicaments;


namespace MedicamentClass
{
   
    #region Proprietati
    public class Medicament
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        private const char SEPARATOR_SECUNDAR_FISIER = ',';

        public int id
        {
            get; set;
        }

        public int pret
        {
            get; set;
        }

        public int gramaj
        {
            get; set;
        }

        public string nume_medicament
        {
            get; set;
        }

        public string data_expirare
        {
            get; set;
        }
        public TipAdministrare genMedicament { get; set; }
        public List<string> TipMedicament { get; set; }

        public string TipMedicamentAsString
        {
            get
            {
                string MedicamentString = string.Empty;

                foreach (string med in TipMedicament)
                {
                    if (MedicamentString != string.Empty)
                    {
                        MedicamentString += SEPARATOR_SECUNDAR_FISIER;
                    }
                    MedicamentString += med;
                }

                return MedicamentString;
            }
        }
        #endregion


        #region Constructori
        public Medicament() { }

        public Medicament(string info)
        {
            string[] informatii = info.Split(';');
            id = Convert.ToInt32(informatii[0]);
            nume_medicament = informatii[1];
            gramaj = Convert.ToInt32(informatii[2]);
            pret = Convert.ToInt32(informatii[3]);
            data_expirare = informatii[4];
            genMedicament = (TipAdministrare)int.Parse(informatii[5]);
            TipMedicament = new List<string>();
            TipMedicament.AddRange(informatii[6].Split(SEPARATOR_SECUNDAR_FISIER));
        
        }
        
        public Medicament(string _id,string _numeMedicament,string _gramaj,string _pret,string _data_expirare)
        {
            id = Convert.ToInt32(_id);
            nume_medicament = _numeMedicament;
            gramaj = Convert.ToInt32(_gramaj);
            pret = Convert.ToInt32(_pret);
            data_expirare = _data_expirare;
        }
        #endregion

        //public void afisare()
        //{
        //    Console.WriteLine("ID:" + id);
        //    Console.WriteLine("Nume medicament: " + nume_medicament);
        //    Console.WriteLine("Gramaj: " + gramaj + " mg");
        //    Console.WriteLine("Pret: " + pret + " lei");
        //    Console.WriteLine("Data expirare: " + data_expirare);
        //}

        public string ConversieLaSir()
        {
            string info;
            info = $"ID: {id} Nume medicament: {nume_medicament} Gramaj:  {gramaj} mg Pret: {pret}  lei  Data expirari: {data_expirare} Tip Administrare:{genMedicament} Tip Medicament:{TipMedicamentAsString}";
            return info;
        }

        //public static Medicament comparare(Medicament a, Medicament b)
        //{
        //    if (a.pret >= b.pret)
        //        return a;
        //    else
        //        return b;
        //}


        public string ConvertToString_File()
        {

            string sir = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}",
                            SEPARATOR_PRINCIPAL_FISIER, id.ToString(), (nume_medicament ?? " NECUNOSCUT "), (gramaj.ToString()?? " NECUNOSCUT "), (pret.ToString() ?? "NECUNOSCUT"),  data_expirare.ToString(),(int)genMedicament, TipMedicamentAsString);

            return sir;
        }

        public static List<Medicament> CautareMedicament(ArrayList list_Medicamente)
        {
            List<Medicament> list_MedicamentCautat = new List<Medicament>();
            string cautare_Medicament;
            Console.WriteLine("Introduceti numele medicamentului: ");
            cautare_Medicament = Console.ReadLine().Trim();
            foreach (Medicament medicament in list_Medicamente)
            {
                if (medicament.nume_medicament == cautare_Medicament)
                {
                    list_MedicamentCautat.Add(medicament);
                    return list_MedicamentCautat;
                }
                else
                {
                    Console.WriteLine("Nu exista medicamentul cautat");
                    return null;
                }
            }
            return list_MedicamentCautat;
        }


               public static List<Medicament> ModificareDateMedicament(List<Medicament> lista_medicamente)
            {
                Console.WriteLine("Introduceti id-ul medicamentului pe care vreti sa il modificati:");

                var id = int.Parse(Console.ReadLine());
                var medicament = lista_medicamente.FirstOrDefault(m => m.id == id);

                var index = lista_medicamente.IndexOf(medicament);


                if (index == 0)
                {
                    Console.WriteLine("Id-ul introdus nu exista!!!!");
                }
                else
                {
                    Console.WriteLine("Introdu id:");
                  var newId = int.Parse(Console.ReadLine());

                  

                    lista_medicamente[index].id = newId;
                    Console.WriteLine("Introdu numele medicamentului:");
                    lista_medicamente[index].nume_medicament = Console.ReadLine();
                    Console.WriteLine("Introdu gramajul medicamentului:");
                    lista_medicamente[index].gramaj = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introdu pretul medicamentului:");
                    lista_medicamente[index].pret = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introdu data expirari:");
                    lista_medicamente[index].data_expirare = Console.ReadLine();
                }
                return lista_medicamente;
            }

        }
    }
