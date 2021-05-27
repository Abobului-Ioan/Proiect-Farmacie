using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using MedicamentClass;

namespace NivelAccesDate
{
    public class AdministrareDate_FisierText : IStocareData
    {
        private const int ID_MEDICAMENT = 1;
        private const int INCREMENT = 1;
        string NumeFisier { get; set; }
        public AdministrareDate_FisierText(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();
        }


        public void AddMedicament(Medicament m)
        {
            try
            {
                //instructiunea 'using' va apela la final swFisierText.Close();
                //al doilea parametru setat la 'true' al constructorului StreamWriter indica modul 'append' de deschidere al fisierului
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                {
                    swFisierText.WriteLine(m.ConvertToString_File());
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }
        public List<Medicament> GetMedicaments()
        {
            List<Medicament> medicaments = new List<Medicament>();

            try
            {

                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Medicament pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Medicament medicamentDinFisier = new Medicament(line);
                        medicaments.Add(medicamentDinFisier);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return medicaments;
        }
        public Medicament GetMedicament(string nume)
        {
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;
                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Medicament medicamentFisier = new Medicament(line);
                        if (nume.ToUpper() == medicamentFisier.nume_medicament.ToUpper())
                            return medicamentFisier;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return null;
        }
        public List<Medicament> GetMedicamentL(string nume)
        {
            List<Medicament> medicamente = new List<Medicament>();

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Medicament medicamentDinFisier = new Medicament(line);
                        if (nume.ToUpper() == medicamentDinFisier.nume_medicament.ToUpper())
                        {
                            medicamente.Add(medicamentDinFisier);
                            return medicamente;
                        }
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return null;
        }

        public Medicament GetMedicament(int idMedicament)
        {
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string linieDinFisier;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((linieDinFisier = sr.ReadLine()) != null)
                    {
                       Medicament medicament= new Medicament(linieDinFisier);
                        if (medicament.id == idMedicament)
                        {
                            return medicament;
                        }
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return null;
        }
        public List<Medicament> GetMedicamentsFile()
        {
            List<Medicament> medicaments = new List<Medicament>();

            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((line = sr.ReadLine()) != null)
                    {
                        Medicament medicamentDinFisier = new Medicament(line);
                        medicaments.Add(medicamentDinFisier);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {

                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return medicaments;
        }

        public bool RewriteMedicaments(Medicament listOfMedicaments)
        {
            List<Medicament> medicament = GetMedicaments();
            bool actualizareCuSucces = false;
            try
            {
                
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                {
                    foreach (Medicament medicamentCaut in medicament)
                    {
                        Medicament medicamentFisier = medicamentCaut;

                        if (medicamentCaut.id == listOfMedicaments.id)
                        {
                            medicamentFisier = listOfMedicaments;
                        }
                        swFisierText.WriteLine(medicamentFisier.ConvertToString_File());
                    }
                    actualizareCuSucces = true;
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return actualizareCuSucces;

        }
        //public bool RewriteMedicament(Medicament medicamentUpdate)
        //{

        //    ArrayList medicament = GetMedicament();
        //    File.Delete(NumeFisier);
        //    bool actualizareCuSucces = false;
        //    try
        //    {
        //        using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
        //        {
        //            foreach (Medicament medicamentCaut in medicament)
        //            {
        //                Medicament medicamentFisier = medicamentCaut;
        //                //informatiile despre studentul actualizat vor fi preluate din parametrul "studentActualizat"
        //                if (medicamentCaut.nume_medicament == medicamentUpdate.nume_medicament)
        //                {
        //                    medicamentFisier = medicamentUpdate;
        //                }
        //                swFisierText.WriteLine(medicamentFisier.ConvertToString_File());
        //            }
        //            actualizareCuSucces = true;
        //        }
        //    }
        //    catch (IOException eIO)
        //    {
        //        throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
        //    }
        //    catch (Exception eGen)
        //    {
        //        throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
        //    }

        //    return actualizareCuSucces;
        //}
        public List<Medicament> SearchMedicaments(Medicament medicamentCautat, List<Medicament> listaMedicamente)
        {
            //List<Car> autoFisier = GetCarsFile();
            List<Medicament> medicamenteGasite = new List<Medicament>();
            foreach (Medicament m in listaMedicamente)
            {
                if (medicamentCautat.nume_medicament == m.nume_medicament )
                    medicamenteGasite.Add(m);
            }

            return medicamenteGasite;
        }
        public bool DeleteMedicament(Medicament MedicamentUpdate)
        {
            List<Medicament> medicament = GetMedicaments();
            Medicament medicamentFisier;
            File.Delete(NumeFisier);
            bool actualizareCuSucces = false;
            int i = 0;
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                {
                    foreach (var medicamentCaut in medicament)
                    {
                        medicamentFisier = medicamentCaut;
                        i++;
                        if (medicamentFisier.id == MedicamentUpdate.id)
                        {
                            i--;
                            continue;
                        }
                        medicamentFisier.id = i;

                        swFisierText.WriteLine(medicamentFisier.ConvertToString_File());
                    }
                    actualizareCuSucces = true;
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return actualizareCuSucces;
        }
        private int GetId()
        {
            int IdMedicament = ID_MEDICAMENT;
            try
            {
                // instructiunea 'using' va apela sr.Close()
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string LinieDinFisier;
                    Medicament ultimulMedicamentDinFisier = null;

                    //citeste cate o linie si creaza un obiect de tip Student pe baza datelor din linia citita
                    while ((LinieDinFisier = sr.ReadLine()) != null)
                    {
                        ultimulMedicamentDinFisier = new Medicament(LinieDinFisier);
                    }

                    if (ultimulMedicamentDinFisier != null)
                    {
                        IdMedicament = ultimulMedicamentDinFisier.id + INCREMENT;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return IdMedicament;
        }

    }
}

