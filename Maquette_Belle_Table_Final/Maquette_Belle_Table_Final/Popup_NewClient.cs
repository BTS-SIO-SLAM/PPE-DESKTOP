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
    public partial class Popup_NewClient : Form
    {
        private static ISessionFactory sessionFactory = null;
        public Popup_NewClient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Popup_NewClient.ActiveForm.Close();
        }

        private void radioButtonOui_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxParticulier.Enabled = true;
            groupBoxAS.Enabled = false;
        }

        private void radioButtonNon_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonNon.Checked)
            {
                groupBoxAS.Enabled = true;
                groupBoxParticulier.Enabled = false;

            }
        }

        private void buttonVal_Click(object sender, EventArgs e)
        {
            buttonVal.DialogResult = DialogResult.OK;
        }

        private void buttonAnul_Click(object sender, EventArgs e)
        {
            buttonAnul.DialogResult = DialogResult.Cancel;
        }

        private void labelFermeture_Click(object sender, EventArgs e)
        {

        }

        private void panelBorderRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBordeLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBorderBottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNom_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxAP_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxVille_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCp_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRue_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelRue_Click(object sender, EventArgs e)
        {

        }

        private void labelCP_Click(object sender, EventArgs e)
        {

        }

        private void labelVille_Click(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPrénom_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTel_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxAS_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxTS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelTS_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDS_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDS_Click(object sender, EventArgs e)
        {

        }

        private void textBoxICAS_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelICAS_Click(object sender, EventArgs e)
        {

        }

        private void textBoxVAS_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCPAS_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRAS_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelRAS_Click(object sender, EventArgs e)
        {

        }

        private void labelCPAS_Click(object sender, EventArgs e)
        {

        }

        private void labelVAS_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelIC_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxQParticulier_Enter(object sender, EventArgs e)
        {

        }

        private void Popup_NewClient_Load(object sender, EventArgs e)
        {
            TypeStructure lesTypeStructure = new TypeStructure();
            comboBoxTS.DataSource = lesTypeStructure.GetLesTypesStructure();
            groupBoxAS.Enabled = false;
            
        }

        static Boolean AjouterClient(Interlocuteur unInterlocuteur, string unnomclient, string unprenomclient, string untelclient,
            string unmailclient, Individu unindividu, Structure unestructure, PorteFeuille unPortefeuille)
        {
            sessionFactory = new Configuration().Configure().BuildSessionFactory();
            ISession session = sessionFactory.OpenSession();

            using (ITransaction transaction = session.BeginTransaction())

            {
                Interlocuteur I = new Interlocuteur();

                if (unInterlocuteur == null) { return false; }
                if (unnomclient.Length == 0) { return false; } else { I.nomInterlocuteur = unnomclient; }
                if (unprenomclient.Length == 0) { return false; } else { I.prenomInterlocuteur = unprenomclient; }
                if (untelclient.Length == 0) { return false; } else { I.telInterlocuteur = untelclient; }
                if (unmailclient.Length == 0) { return false; } else { I.mailInterlocuteur = unmailclient; }
                if (unindividu == null) { return false; }
                if (unestructure == null) { return false; }

                session.Save(I);
                transaction.Commit();
                return true;

            }
        }
    }
}