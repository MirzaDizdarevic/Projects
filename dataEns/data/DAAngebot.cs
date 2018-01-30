using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataEns.data
{
    public class DAAngebot
    {
        public static void InsertAngebotPodatke(Angebot an)
        {
            DAConnection.dm.usp_insertAngebotPodaci(an.Firmenname, an.Adresse, an.PLZ, an.Stadt, an.AngebotNr,
                    an.Insgessamt, an.AdresseEnssol, an.TelefonEnssol, an.FirmenNameEnssol, an.Beschreibung, an.Datum).First();
        }

        public static List<usp_AngebotSelectAll_Result> AngebotSelectAll()
        {
            return DAConnection.dm.usp_AngebotSelectAll().ToList();
        }

        public static Angebot SelectAngebotByID(int AngebotID)
        {
            return DAConnection.dm.usp_AngebotSelectByID(AngebotID).First();
        }

        public static List<rptEnssolPredRacun_Result> SelectReport(int AngebotID)
        {
            return DAConnection.dm.rptEnssolPredRacun(AngebotID).ToList();
        }
    }
}
