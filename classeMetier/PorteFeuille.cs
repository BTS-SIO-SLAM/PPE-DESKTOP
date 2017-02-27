using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPE_Belle_Table_Classes_métier
{
    class PorteFeuille
    {
        private int idPortefeuille;
        private string libellePortefeuille;

        public PorteFeuille()
        {

        }

        //Setter
        public void SetidPortefeuille(int unidPortefeuille)
        {
            idPortefeuille = unidPortefeuille;
        }


        public void SetlibellePortefeuille(string unlibellePortefeuille)
        {
            libellePortefeuille = unlibellePortefeuille;
        }

        //Getter
        public int GetidPortefeuille()
        {
            return idPortefeuille;
        }

        public string GetlibellePortefeuille()
        {
            return libellePortefeuille;
        }
        
        public DataTable chargerLesClients(int idPortefeuille)
        {
            DataTable Lesclients = DatabaseConnect.Select("SELECT * FROM interlocuteur WHERE idPortefeuille=@idPortefeuille");

            return Lesclients;
        }
    }
}
