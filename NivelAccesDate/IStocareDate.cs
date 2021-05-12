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
        ArrayList GetMedicament();
        bool RewriteMedicament(Medicament medicamentUpdate);
    }

}
