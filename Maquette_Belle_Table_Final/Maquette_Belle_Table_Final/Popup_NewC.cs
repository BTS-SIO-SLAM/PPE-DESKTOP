﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Linq;

namespace Maquette_Belle_Table_Final
{
    public partial class Popup_NewC : Form
    {
        public Utilisateur utilisateur { get; set; }
        private InterUti interUti = null;
        private static ISessionFactory sessionFactory = new Configuration().Configure().BuildSessionFactory();

        public Popup_NewC()
        {
            InitializeComponent();
        }
        public Popup_NewC(InterUti interUtiCall)
    {
        interUti = interUtiCall as InterUti; 
        InitializeComponent();
    }

        private void label2_Click(object sender, EventArgs e)
        {
            Popup_NewC.ActiveForm.Close();
        }

        private void buttonVal_Click(object sender, EventArgs e)
        {
            Conge nouveauConge = new Conge();
            nouveauConge.dateDebutConge = dateTimePickerDD.Value;
            nouveauConge.dateFinConge = dateTimePickerDF.Value;
              ISession session = sessionFactory.OpenSession();

              using (ITransaction transaction = session.BeginTransaction())
              {
                  session.Save(nouveauConge);
                  transaction.Commit();
                  session.Close();
              }

            CongesUtilisateur nouveauCongeUtilisateur = new CongesUtilisateur();
            nouveauCongeUtilisateur.conge=nouveauConge;
            nouveauCongeUtilisateur.utilisateur=utilisateur;
            ISession session2 = sessionFactory.OpenSession();

               using (ITransaction transaction = session2.BeginTransaction())
              {
                  session2.Save(nouveauCongeUtilisateur);
                  transaction.Commit();
                  session2.Close();              
              }

               ISession session3 = sessionFactory.OpenSession();
               using (ITransaction transaction = session3.BeginTransaction())
               {
                   session3.Update(utilisateur);
                   transaction.Commit();
               }

            interUti.chargerCalendar();
            Popup_NewC.ActiveForm.Close();
            
        }

        private void buttonAnul_Click(object sender, EventArgs e)
        {
            Popup_NewC.ActiveForm.Close();
        }
    }
}
