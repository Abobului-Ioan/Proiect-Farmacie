using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using MedicamentClass;

namespace NivelAccesDate
{
    public interface IStocareData
    {
        void AddMedicament(Medicament m);
        List<Medicament> GetMedicaments();
        bool RewriteMedicaments(Medicament listOfMedicaments);
        Medicament GetMedicament(string nume);
        Medicament GetMedicament(int idMedicament);
        List<Medicament> GetMedicamentsFile();
        List<Medicament> GetMedicamentL(string nume);
        List<Medicament> SearchMedicaments(Medicament medicamentCautat, List<Medicament> listaMedicamente);
        bool DeleteMedicament(Medicament medicamentUpdate);
    }

}
