﻿using Maquette_Belle_Table_Final;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maquette_Belle_Table
{
    public partial class PopNouveauRDV : Form
    {
        private static ISessionFactory sessionFactory = null;
        public Utilisateur utilisateur { get; set; }
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
            MessageBox.Show(utilisateur.planning.idPlanning.ToString());

            if (AjouterRendezVous(Int32.Parse(textBoxCodeEntree.Text), (Interlocuteur)comboBoxListeClient.SelectedItem, dateTimePickerNRDV.Value.Date, dateTimePickerHD.Value,
                dateTimePickerHF.Value, textBoxRue.Text + " " + textBoxCp.Text, textBoxIC.Text,
                (TypeRdv)comboBoxTRDV.SelectedItem, utilisateur.planning) == true)
                MessageBox.Show("Rendez-vous ajouté");
            else MessageBox.Show("Erreur");
        }

        private void PopNouveauRDV_Load(object sender, EventArgs e)
        {
            TypeRdv lesTypesRdv = new TypeRdv();
            comboBoxTRDV.DataSource = lesTypesRdv.GetLesTypesRdv();
            
            IList<Interlocuteur> mesInterlocteur = utilisateur.porteFeuille.lesInterlocuteurs;
            
            //pour qu'il n y ai pas trop de données dans la combobox
            foreach(Interlocuteur interlocuteur in mesInterlocteur)
            {
                comboBoxListeClient.Items.Add(interlocuteur);
            }
            
        }


        private void comboBoxTRDV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        static bool AjouterRendezVous(int unCodeEntreeDerogatoire, Interlocuteur unInterlocuteur, DateTime uneDateRdv, DateTime uneHeureDebut,
            DateTime uneHeureFin, string uneAdresseDerogatoire, string uneInfoDerogatoire, TypeRdv unTypeRdv, Planning unPlanning)
        {


            ISession session = sessionFactory.OpenSession();
            using (ITransaction transaction = session.BeginTransaction())

            {
                RendezVous unRendezVous = new RendezVous();

                if (unInterlocuteur == null) return false;
                else unRendezVous.interlocuteur = unInterlocuteur;

                if (unTypeRdv == null) return false;
                else unRendezVous.typeRdv = unTypeRdv;

                if (unPlanning == null) return false;
                else unRendezVous.planning = unPlanning;

                if (uneDateRdv == null) return false;
                if (uneHeureDebut != null) unRendezVous.heureDebut = uneHeureDebut;
                if (uneHeureDebut != null) unRendezVous.heureFin = uneHeureFin;
                if (unCodeEntreeDerogatoire != 0) unRendezVous.codeEntreeDerogatoire = unCodeEntreeDerogatoire;
                if (uneAdresseDerogatoire != null) unRendezVous.adresseDerogatoire = uneAdresseDerogatoire;
                if (uneInfoDerogatoire != null) unRendezVous.adresseDerogatoire = uneAdresseDerogatoire;
                session.Save(unRendezVous);
                transaction.Commit();
                MessageBox.Show(unPlanning.idPlanning.ToString());
                return true;
            }
        }

    }
}
