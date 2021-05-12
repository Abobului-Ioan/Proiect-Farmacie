using System;
using MedicamentClass;
using NivelAccesDate;
using System.Collections.Generic;
using System.Collections;

namespace InterfataUtilizator

{


    class Program
    {
        static void Main(string[] args)
        {
            IStocareData adminMedicamente = StocareFactory.GetAdministratorStocare();
            ArrayList medicamente = adminMedicamente.GetMedicament();
            List<Medicament> lista_medicamente;
            

            Medicament paracetamol = new Medicament("1,paracetamol,300,5,20.05.2020");
            Console.WriteLine(paracetamol.ConversieLaSir());
            Medicament aspirina = new Medicament("2,acid acetilsalicilic,500,8,15.09.2020");
            Console.WriteLine(aspirina.ConversieLaSir());
            Console.WriteLine("\nMedicamentul cel mai scump este: " + Medicament.comparare(paracetamol, aspirina).ConversieLaSir());
            //lista_medicamente = Medicament.CautareMedicament(medicamente);
            //AfisareInformatii(lista_medicamente);
            //foreach (var medicament in medicamente)
            //{
            //    lista_cu_medicamente.add((medicament)medicament);
            //}


            //lista_medicamente.Add(paracetamol);
            //lista_medicamente.Add(aspirina);
            //Medicament.ModificareDateMedicament(lista_medicamente);
            //adminMedicamente.RewriteMedicaments(lista_medicamente);
            Medicament newMedicament = CitireTastatura();
            medicamente.Add(newMedicament);
            adminMedicamente.AddMedicament(newMedicament);
            Console.ReadKey();
        }

        public static void AfisareInformatii(List<Medicament> info)
        {
            if (info == null)
                return;
            Console.WriteLine("Informatii medicament:");
            if (info.Count == 0)
            {
                Console.WriteLine("- NONE -");
                return;
            }

            for (int i = 0; i < info.Count; i++)
            {
                Console.WriteLine(((Medicament)info[i]).ConversieLaSir());
               
            }
        }
        public static void AfisareInformatii(ArrayList info)
        {
            if (info == null)
                return;
            Console.WriteLine("Informatii medicament:");
            if (info.Count == 0)
            {
                Console.WriteLine("- NONE -");
                return;
            }

            for (int i = 0; i < info.Count; i++)
            {
                 Console.WriteLine(((Medicament)info[i]).ConversieLaSir());
              
            }
        }

        public static Medicament CitireTastatura()
        {
            Medicament MedicamentCitit = new Medicament();
            Console.WriteLine("Introduceti id-ul medicamentului:");
            MedicamentCitit.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti numele medicamentului:");
            MedicamentCitit.nume_medicament = Console.ReadLine();
            Console.WriteLine("Introduceti gramjul medicamentului:");
            MedicamentCitit.gramaj= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti pretul medicamentului:");
            MedicamentCitit.pret = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduceti data expirari medicamentului:");
            MedicamentCitit.data_expirare = Console.ReadLine();
            return MedicamentCitit;
        }
        

    }
    
}