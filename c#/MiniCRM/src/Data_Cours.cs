using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECOLE_CRM
{
    /// <summary>
    /// Classe drainant en plus de l'id et du titre du cours
    /// l'année d'inscription d'un étudiant à celui-ci
    /// N'a de sens que dans le contexte de la modification des inscriptions
    /// </summary>
    class Data_Cours
    {
        // pas d'accesseurs, tout en public pour simplifier...
        public int id;
        public int year;
        public String titre;

        public Data_Cours(int id, int year, String titre)
        {
            this.id = id;
            this.year = year;
            this.titre = titre;
        }

        public Data_Cours() { }


        public override String ToString()
        {
            return "[ " + id + ", " + titre + " ]";
        }
    }


    
}
