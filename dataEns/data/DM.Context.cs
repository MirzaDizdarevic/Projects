﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dataEns.data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class EnssolEntities : DbContext
    {
        public EnssolEntities()
            : base("name=EnssolEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Allgemein> Allgemeins { get; set; }
        public DbSet<Angebot> Angebots { get; set; }
    
        public virtual ObjectResult<Allgemein> uspAllgemeinSelectByID(Nullable<int> allgemeineID)
        {
            var allgemeineIDParameter = allgemeineID.HasValue ?
                new ObjectParameter("AllgemeineID", allgemeineID) :
                new ObjectParameter("AllgemeineID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Allgemein>("uspAllgemeinSelectByID", allgemeineIDParameter);
        }
    
        public virtual ObjectResult<Allgemein> uspAllgemeinSelectByID(Nullable<int> allgemeineID, MergeOption mergeOption)
        {
            var allgemeineIDParameter = allgemeineID.HasValue ?
                new ObjectParameter("AllgemeineID", allgemeineID) :
                new ObjectParameter("AllgemeineID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Allgemein>("uspAllgemeinSelectByID", mergeOption, allgemeineIDParameter);
        }
    
        public virtual ObjectResult<usp_AllgemeinSelectAll_Result1> usp_AllgemeinSelectAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_AllgemeinSelectAll_Result1>("usp_AllgemeinSelectAll");
        }
    
        public virtual ObjectResult<Nullable<decimal>> usp_InsertPodaci(string firmenname, string adresse, string pLZ, string stadt, string rechnungNr, string insgesammt, string adresseEnssol, string telefonEnssol, string firmennameEnssol, string beschreibung, Nullable<System.DateTime> datum)
        {
            var firmennameParameter = firmenname != null ?
                new ObjectParameter("Firmenname", firmenname) :
                new ObjectParameter("Firmenname", typeof(string));
    
            var adresseParameter = adresse != null ?
                new ObjectParameter("Adresse", adresse) :
                new ObjectParameter("Adresse", typeof(string));
    
            var pLZParameter = pLZ != null ?
                new ObjectParameter("PLZ", pLZ) :
                new ObjectParameter("PLZ", typeof(string));
    
            var stadtParameter = stadt != null ?
                new ObjectParameter("Stadt", stadt) :
                new ObjectParameter("Stadt", typeof(string));
    
            var rechnungNrParameter = rechnungNr != null ?
                new ObjectParameter("RechnungNr", rechnungNr) :
                new ObjectParameter("RechnungNr", typeof(string));
    
            var insgesammtParameter = insgesammt != null ?
                new ObjectParameter("Insgesammt", insgesammt) :
                new ObjectParameter("Insgesammt", typeof(string));
    
            var adresseEnssolParameter = adresseEnssol != null ?
                new ObjectParameter("AdresseEnssol", adresseEnssol) :
                new ObjectParameter("AdresseEnssol", typeof(string));
    
            var telefonEnssolParameter = telefonEnssol != null ?
                new ObjectParameter("TelefonEnssol", telefonEnssol) :
                new ObjectParameter("TelefonEnssol", typeof(string));
    
            var firmennameEnssolParameter = firmennameEnssol != null ?
                new ObjectParameter("FirmennameEnssol", firmennameEnssol) :
                new ObjectParameter("FirmennameEnssol", typeof(string));
    
            var beschreibungParameter = beschreibung != null ?
                new ObjectParameter("Beschreibung", beschreibung) :
                new ObjectParameter("Beschreibung", typeof(string));
    
            var datumParameter = datum.HasValue ?
                new ObjectParameter("Datum", datum) :
                new ObjectParameter("Datum", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("usp_InsertPodaci", firmennameParameter, adresseParameter, pLZParameter, stadtParameter, rechnungNrParameter, insgesammtParameter, adresseEnssolParameter, telefonEnssolParameter, firmennameEnssolParameter, beschreibungParameter, datumParameter);
        }
    
        public virtual ObjectResult<rptEnssolRacun_Result2> rptEnssolRacun(Nullable<int> allgemeineID)
        {
            var allgemeineIDParameter = allgemeineID.HasValue ?
                new ObjectParameter("AllgemeineID", allgemeineID) :
                new ObjectParameter("AllgemeineID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<rptEnssolRacun_Result2>("rptEnssolRacun", allgemeineIDParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> usp_insertAngebotPodaci(string firmenname, string adresse, string pLZ, string stadt, string angebotNr, string insgessamt, string adresseEnssol, string telefonEnssol, string firmenNameEnssol, string beschreibung, Nullable<System.DateTime> datum)
        {
            var firmennameParameter = firmenname != null ?
                new ObjectParameter("Firmenname", firmenname) :
                new ObjectParameter("Firmenname", typeof(string));
    
            var adresseParameter = adresse != null ?
                new ObjectParameter("Adresse", adresse) :
                new ObjectParameter("Adresse", typeof(string));
    
            var pLZParameter = pLZ != null ?
                new ObjectParameter("PLZ", pLZ) :
                new ObjectParameter("PLZ", typeof(string));
    
            var stadtParameter = stadt != null ?
                new ObjectParameter("Stadt", stadt) :
                new ObjectParameter("Stadt", typeof(string));
    
            var angebotNrParameter = angebotNr != null ?
                new ObjectParameter("AngebotNr", angebotNr) :
                new ObjectParameter("AngebotNr", typeof(string));
    
            var insgessamtParameter = insgessamt != null ?
                new ObjectParameter("Insgessamt", insgessamt) :
                new ObjectParameter("Insgessamt", typeof(string));
    
            var adresseEnssolParameter = adresseEnssol != null ?
                new ObjectParameter("AdresseEnssol", adresseEnssol) :
                new ObjectParameter("AdresseEnssol", typeof(string));
    
            var telefonEnssolParameter = telefonEnssol != null ?
                new ObjectParameter("TelefonEnssol", telefonEnssol) :
                new ObjectParameter("TelefonEnssol", typeof(string));
    
            var firmenNameEnssolParameter = firmenNameEnssol != null ?
                new ObjectParameter("FirmenNameEnssol", firmenNameEnssol) :
                new ObjectParameter("FirmenNameEnssol", typeof(string));
    
            var beschreibungParameter = beschreibung != null ?
                new ObjectParameter("Beschreibung", beschreibung) :
                new ObjectParameter("Beschreibung", typeof(string));
    
            var datumParameter = datum.HasValue ?
                new ObjectParameter("Datum", datum) :
                new ObjectParameter("Datum", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("usp_insertAngebotPodaci", firmennameParameter, adresseParameter, pLZParameter, stadtParameter, angebotNrParameter, insgessamtParameter, adresseEnssolParameter, telefonEnssolParameter, firmenNameEnssolParameter, beschreibungParameter, datumParameter);
        }
    
        public virtual ObjectResult<usp_AngebotSelectAll_Result> usp_AngebotSelectAll()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_AngebotSelectAll_Result>("usp_AngebotSelectAll");
        }
    
        public virtual ObjectResult<Angebot> usp_AngebotSelectByID(Nullable<int> angebotID)
        {
            var angebotIDParameter = angebotID.HasValue ?
                new ObjectParameter("AngebotID", angebotID) :
                new ObjectParameter("AngebotID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Angebot>("usp_AngebotSelectByID", angebotIDParameter);
        }
    
        public virtual ObjectResult<Angebot> usp_AngebotSelectByID(Nullable<int> angebotID, MergeOption mergeOption)
        {
            var angebotIDParameter = angebotID.HasValue ?
                new ObjectParameter("AngebotID", angebotID) :
                new ObjectParameter("AngebotID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Angebot>("usp_AngebotSelectByID", mergeOption, angebotIDParameter);
        }
    
        public virtual ObjectResult<rptEnssolPredRacun_Result> rptEnssolPredRacun(Nullable<int> angebotID)
        {
            var angebotIDParameter = angebotID.HasValue ?
                new ObjectParameter("AngebotID", angebotID) :
                new ObjectParameter("AngebotID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<rptEnssolPredRacun_Result>("rptEnssolPredRacun", angebotIDParameter);
        }
    }
}
