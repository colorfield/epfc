using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECOLE_CRM
{
    public class Data_Etudiant
    {
        // pas d'accesseurs, tout en public pour simplifier...
        public int id;
        public String nom;
        public String prenom;
        public DateTime ddn;
        public String adr;

        public Data_Etudiant(int id, String nom, String prenom, DateTime ddn, String adr)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.ddn = ddn;
            this.adr = adr;
        }

        public Data_Etudiant() { }

        public override String ToString()
        {
            return "[ " + id + ", " + nom + ", " + prenom + " ]";
        }
    }
}
