﻿using Maquette_Belle_Table_Final;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maquette_Belle_Table
{
    public partial class PopNouveauRDV : Form
    {
        private static ISessionFactory sessionFactory = null;
        public Utilisateur utilisateur { get; set; }
        private Interlocuteur interlocuteur;
        public InterUti interUti { get; set; }
        public RendezVous rdv { get; set; }
        public Boolean isModifier = false;

        public PopNouveauRDV()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            PopNouveauRDV.ActiveForm.Close();
        }

        private void buttonAnul_Click(object sender, EventArgs e)
        {
            buttonAnul.DialogResult = DialogResult.Cancel;
        }

        private void buttonVal_Click(object sender, EventArgs e)
        {
            buttonVal.DialogResult = DialogResult.OK;
        }

        private void buttonVal_Click_1(object sender, EventArgs e)
        {
            sessionFactory = new Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();

            if (radioButtonNon.Checked)
            { }
            MessageBox.Show(AjouterRendezVous(Int32.Parse(textBoxCodeEntree.Text), (Interlocuteur)comboBoxListeClient.SelectedItem, textBoxObjRdv.Text, dateTimePickerHD.Value,
                dateTimePickerHF.Value, textBoxRue.Text, textBoxIC.Text, textBoxVille.Text,
                (TypeRdv)comboBoxTRDV.SelectedItem, utilisateur.planning, (RendezVous)comboBoxRDVprecedent.SelectedItem));
            interUti.chargerDataGridViewRdv();
            this.Close();
        }

        private void PopNouveauRDV_Load(object sender, EventArgs e)
        {

            TypeRdv lesTypesRdv = new TypeRdv();
            comboBoxTRDV.DataSource = lesTypesRdv.GetLesTypesRdv();

            ISet<Interlocuteur> mesInterlocteur = utilisateur.porteFeuille.lesInterlocuteurs;

            //comboBoxRDVprecedent.DataSource = inter
            //pour qu'il n y ai pas trop de données dans la combobox
            foreach (Interlocuteur interlocuteur in mesInterlocteur)
            {
                comboBoxListeClient.Items.Add(interlocuteur);
            }

if(isModifier==true)
{
    textBoxObjRdv.Text = rdv.ObjetRdv;
    dateTimePickerHD.Value = rdv.DateDebut;
    dateTimePickerHF.Value = rdv.DateFin;
    comboBoxListeClient.SelectedItem = rdv.interlocuteur;
    comboBoxTRDV.SelectedItem = rdv.typeRdv;
    comboBoxRDVprecedent.SelectedItem = rdv.rendezVousPrecedent;
    if(rdv.adresseDerogatoire!=null)
    {
        groupBoxAP.Visible = true;
        radioButtonNon.Checked = false;
        textBoxRue.Text = rdv.adresseDerogatoire;
        textBoxVille.Text = rdv.villeDerogatoire;
        textBoxCodeEntree.Text = rdv.codeEntreeDerogatoire.ToString();
        textBoxIC.Text = rdv.infoDerogatoire;
    }
}


            }
  


        private void comboBoxTRDV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public string AjouterRendezVous(int unCodeEntreeDerogatoire, Interlocuteur unInterlocuteur, string ObjetRdv, DateTime uneDateDebut,
            DateTime uneDateFin, string uneAdresseDerogatoire, string uneInfoDerogatoire, string uneVilleDerogatoire, TypeRdv unTypeRdv, Planning unPlanning, RendezVous unRdvPrecendent)
        {

            ISession session = sessionFactory.OpenSession();
            using (ITransaction transaction = session.BeginTransaction())

            {
                RendezVous unRendezVous = new RendezVous();
                // Si le rendez vous est un rendez vous existant, on l'associe
                if(isModifier==true){
                    unRendezVous = rdv;
                }

                if (unInterlocuteur == null) return "Merci de séléctionner un client.";
                else unRendezVous.interlocuteur = unInterlocuteur;

                if (unTypeRdv == null) return "Merci de séléctionner un type de rendez-vous.";
                else unRendezVous.typeRdv = unTypeRdv;

                if (ObjetRdv == null) return "Merci d'attribuer un bojet au rdv";
                else unRendezVous.ObjetRdv = ObjetRdv;

                unRendezVous.planning = unPlanning;
                if (uneDateDebut != null) unRendezVous.DateDebut = uneDateDebut;
                if (uneDateFin != null) unRendezVous.DateFin = uneDateFin;
                // si le rendez vous prend lieu à une adresse dérogatoire on récupère les champs
                // Sinon le rendez-vous à lieu à l'adresse du client
                if (radioButtonNon.Checked)
                {
                    if (unCodeEntreeDerogatoire != 0) unRendezVous.codeEntreeDerogatoire = unCodeEntreeDerogatoire;
                    if (uneAdresseDerogatoire != null) unRendezVous.adresseDerogatoire = uneAdresseDerogatoire;
                    if (uneInfoDerogatoire != null) unRendezVous.infoDerogatoire = uneInfoDerogatoire;
                    if (uneVilleDerogatoire != null) unRendezVous.villeDerogatoire = uneVilleDerogatoire;
                }
                    // on met à null dans le cas d'une modification d'un rdv dérogatoire à classique
                else 
                {
                unRendezVous.codeEntreeDerogatoire=0;
                    unRendezVous.adresseDerogatoire=null;
                        unRendezVous.infoDerogatoire=null;
                        unRendezVous.villeDerogatoire = null;
                }
                MessageBox.Show(unRdvPrecendent.ToString());
                unRendezVous.rendezVousPrecedent = unRdvPrecendent;
                session.SaveOrUpdate(unRendezVous);
                transaction.Commit();
                session.Dispose();
                
                try
                {
                    MailMessage mail = new MailMessage("bot@belletable.com", unInterlocuteur.mailInterlocuteur);
                    mail.Subject = "Nouveau rendez-vous avec " + unInterlocuteur.nomInterlocuteur;
                    mail.Body = "Vous avez un nouveau rendez-vous avec" + unInterlocuteur.nomInterlocuteur + " " + 
                        unInterlocuteur.prenomInterlocuteur + " le: ? à " + uneDateDebut.ToString();
    

                    SmtpClient client = new SmtpClient();
                    client.Host = "localhost";
                    client.Send(mail);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return "Rendez-vous ajouté.";
            }
        }

        private void comboBoxListeClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            interlocuteur = (Interlocuteur)comboBoxListeClient.SelectedItem;
            comboBoxRDVprecedent.DataSource = interlocuteur.lesRendezVous.ToList<RendezVous>();
        }

        private void labelRue_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonNon_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxAP.Visible = true;
        }

        private void radioButtonOui_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxAP.Visible = false;
        }
    }
}
