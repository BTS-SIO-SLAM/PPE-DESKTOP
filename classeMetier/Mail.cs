using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelleTable.Mail
{
    class Mail
    {
        private int numMail;
        private string contenuMail;
        private string objetMail;

        public Mail()
        {

        }

        //Setter
        public void SetnumMail(int unnumMail)
        {
            numMail = unnumMail;
        }


        public void SetcontenuMail(string uncontenuMail)
        {
            contenuMail = uncontenuMail;
        }

        public void SetobjetMail(string unobjetMail)
        {
            objetMail = unobjetMail;
        }

        //Getter
        public int GetnumMail()
        {
            return numMail;
        }

        public string GetcontenuMail()
        {
            return contenuMail;
        }

        public string GetobjetMail()
        {
            return objetMail;
        }
        
        public List<List<String>> ChargerLesMails(Connexion maConnexion, int id_salarie) 
        {
            DataTable dt = maConnexion.Select("SELECT * FROM MAIL WHERE id_salarie="+utilisateur.getId());
        }
        public void AjouterUnMail(){
        mysql.Command("INSERT INTO MAIL (contenuMail, objetMail, id_interlocuteur) VALUES (this.cotenuMail, this.objetMail, this.id_interlocuteur)");
        }
        }
}
