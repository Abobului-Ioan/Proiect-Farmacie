using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using MedicamentClass;

namespace NivelAccesDate
{
    public class AdministrareDate_FisierText : IStocareData
    {
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
                    swFisierText.WriteLine(m.ConversieLaSir());
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
        public ArrayList GetMedicament()
        {
            ArrayList medicaments = new ArrayList();

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

        //public void RewriteMedicaments(List<Medicament> listOfMedicaments)
        //{
        //    try
        //    {
        //        File.Delete(NumeFisier);
        //        using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
        //        {
        //            foreach (var medicament in listOfMedicaments)
        //            {
        //                swFisierText.WriteLine(medicament.ConvertToString_File());

        //            }
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

        //}
        public bool RewriteMedicament(Medicament medicamentUpdate)
        {
            ArrayList medicament = GetMedicament();
            bool actualizareCuSucces = false;
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, false))
                {
                    foreach (Medicament medicamentCaut in medicament)
                    {
                        Medicament medicamentFisier = medicamentCaut;
                        //informatiile despre studentul actualizat vor fi preluate din parametrul "studentActualizat"
                        if (medicamentCaut.nume_medicament == medicamentUpdate.nume_medicament)
                        {
                            medicamentFisier = medicamentUpdate;
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

    }
}

