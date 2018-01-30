using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dataEns.data
{
    public class DAAllgemein
    {
        public static void InsertPodatke(Allgemein A)
        {
            DAConnection.dm.usp_InsertPodaci(A.Firmenname, A.Adresse, A.PLZ, A.Stadt, A.RechnungNr, A.Insgesammt, A.AdresseEnssol, A.TelefonEnssol, A.FirmennameEnssol, A.Beschreibung, A.Datum).First();
        }

        public static List<usp_AllgemeinSelectAll_Result1> AllgemeinSelectAll()
        {
            return DAConnection.dm.usp_AllgemeinSelectAll().ToList();
        }

        public static Allgemein SelectAllgemeinByID(int AllgemeineID)
        {
            return DAConnection.dm.uspAllgemeinSelectByID(AllgemeineID).First();
        }

        public static List<rptEnssolRacun_Result2> SelectReport(int AllgemeineID)
        {
            return DAConnection.dm.rptEnssolRacun(AllgemeineID).ToList();
        }
    }
}
