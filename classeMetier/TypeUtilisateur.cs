using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_Belle_Table_Classes_métier
{
    public class TypeUtilisateur
    {
        private int codeTypeUtilisateur;
        private string libelleTypeUtilisateur;

        public TypeUtilisateur()
        {

        }
        //Setter
        public void SetLecodeTypeUtilisateur(int unCodeTypeUtilisateur)
        {
            codeTypeUtilisateur = unCodeTypeUtilisateur;
        }


        public void SetlibelleTypeUtilisateur(string unLibelleTypeUtilisateur)
        {
            libelleTypeUtilisateur = unLibelleTypeUtilisateur;
        }

        //Getter
        public int GetLecodeTypeUtilisateur()
        {
            return codeTypeUtilisateur;
        }

        public string GetlibelleTypeUtilisateur()
        {
            return libelleTypeUtilisateur;
        }
    }

}
