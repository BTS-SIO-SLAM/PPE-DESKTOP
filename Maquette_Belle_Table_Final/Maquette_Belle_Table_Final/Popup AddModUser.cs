﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maquette_Belle_Table_Final;
using System.Net.Mail;
using NHibernate;
using NHibernate.Cfg;

namespace Maquette_Belle_Table
{
    public partial class Popup_AddModUser : Form
    {
        private static ISessionFactory sessionFactory = null;

        public Popup_AddModUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Popup_AddModUser.ActiveForm.Close();
        }

        private void radioButtonCom_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButtonAdm_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButtonUti_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        //Bouton Annuler sur Profil Admin
       

        //Bouton Annuler sur Profil Commercial
        private void buttonAnuCom_Click(object sender, EventArgs e)
        {
            buttonAnuCom.DialogResult = DialogResult.Cancel;
        }

        //Bouton Valider sur Profil Commercial
        private void buttonValCom_Click(object sender, EventArgs e)
        {
            int codeTypeUtilisateur = 0;
            MessageBox.Show(AjouterUtilisateur(codeTypeUtilisateur, textBoxLog.Text, textBoxNom.Text, textBoxPre.Text, textBoxEm.Text, textBoxTel.Text, textBoxRue.Text,
                textBoxVille.Text, textBoxCp.Text));
        }

        static string AjouterUtilisateur(int codeTypeUtilisateur, string loginUtilisateur, string nomUtilisateur, string prenomUtilisateur, string mailUtilisateur, string telUtilisateur, string adresseUtilisateur,
            string villeUtilisateur, string cpUtilisateur)
        {

            sessionFactory = new Configuration().Configure().BuildSessionFactory();

            ISession session = sessionFactory.OpenSession();
            using (ITransaction transaction = session.BeginTransaction())

            {
                Utilisateur unNouvelUtilisateur = new Utilisateur();

                MessageBox.Show(codeTypeUtilisateur.ToString());
                unNouvelUtilisateur.typeUtilisateur.codeTypeUtilisateur = codeTypeUtilisateur;
                if (loginUtilisateur != null) unNouvelUtilisateur.loginUtilisateur = loginUtilisateur; else return "Merci d'entrer un login d'utilisateur";
                if (nomUtilisateur != null) unNouvelUtilisateur.nomUtilisateur = nomUtilisateur; else return "Merci d'entrer un nom d'utilisateur";
                if (prenomUtilisateur != null) unNouvelUtilisateur.prenomUtilisateur = prenomUtilisateur; else return "Merci d'entrer un prénom d'utilisateur";
                if (mailUtilisateur != null) unNouvelUtilisateur.mailUtilisateur = mailUtilisateur; else return "Merci d'entrer un mail d'utilisateur";
                if (telUtilisateur != null) unNouvelUtilisateur.telUtilisateur = telUtilisateur; else return "Merci d'entrer un numéro téléphone d'utilisateur";
                if (adresseUtilisateur != null) unNouvelUtilisateur.adresseUtilisateur = adresseUtilisateur; else return "Merci d'entrer une adresse d'utilisateur";
                if (villeUtilisateur != null) unNouvelUtilisateur.villeUtilisateur = villeUtilisateur; else return "Merci d'entrer une ville d'utilisateur";
                if (cpUtilisateur != null) unNouvelUtilisateur.cpUtilisateur = cpUtilisateur; else return "Merci d'entrer un code postal d'utilisateur";


                //On génère un mot de passe aléatoire pour le nouvel Utilisateur
                Random random = new Random();
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                string motdepasse = new string(Enumerable.Repeat(chars, 10).Select(s => s[random.Next(s.Length)]).ToArray());

                // on converti la phrase random en md5
                InterLogin pourMD5 = new InterLogin();

                //on associe le mot de passe
                unNouvelUtilisateur.passwordUtilisateur = pourMD5.MD5Hash(motdepasse);

                session.Save(unNouvelUtilisateur);
                transaction.Commit();
                session.Dispose();

                // on envoie le MDP au mail du nouvel utilisateur
                MailMessage mail = new MailMessage();
                mail.Subject = "Nouvel accès à GEPEV!";
                mail.Body = "Votre mot de passe est : " + motdepasse;
                mail.From = new MailAddress("bot@belletable.com");
                mail.To.Add(unNouvelUtilisateur.mailUtilisateur);

                SmtpClient client = new SmtpClient();
                client.Host = "localhost";
                client.Send(mail);

                return "L'utilisateur a été crée et un mail lui a été envoyé.";
            }
        }

        private void panelTypeP_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelCom_Paint(object sender, PaintEventArgs e)
        {
            TypeUtilisateur lesTypesUtilisateur = new TypeUtilisateur();
            comboBoxTypeUser.DataSource = lesTypesUtilisateur.GetLesTypesUtilisateur();
        }
    }

}
