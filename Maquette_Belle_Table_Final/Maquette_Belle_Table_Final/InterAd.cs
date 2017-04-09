﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maquette_Belle_Table_Final
{
    public partial class InterAd : Form
    {
        public Utilisateur utilisateur { get; set; }
        public InterAd()
        {
            InitializeComponent();
        }

        private void labelFermeture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //---------------------> * Rubrique Utilisateur * <---------------------

        private void buttonAddUti_Click(object sender, EventArgs e)
        {
            //Bouton Ajouter Utilisateur (Affiche le PopupAddModUser)
            new Maquette_Belle_Table.Popup_AddModUser().Show();
        }

        private void buttonModUti_Click(object sender, EventArgs e)
        {
            //Bouton Modifier Utilisateur (Affiche le PopupAddModUser)
            new Maquette_Belle_Table.Popup_AddModUser().Show();
        }

        private void buttonSuppUti_Click(object sender, EventArgs e)
        {
            //Bouton Supprimer Utilisateur
            dataGridViewUti.Rows.Remove(dataGridViewUti.CurrentRow);
        }

        private void dataGridViewUti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Partie code destiné à la DataGridView de la rubrique Utilisateur
        }

        //---------------------> * Fin Rubrique Utilisateur * <---------------------


        //---------------------> * Rubrique Historique de connexions * <---------------------

        private void dataGridViewHC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Partie code destiné à la DataGridView de la rubrique Histoirique de connexions
        }

        //---------------------> * Fin Rubrique Historique de connexions * <---------------------


        //---------------------> * Rubrique Changer de mot de passe * <---------------------

        private void buttonValCM_Click(object sender, EventArgs e)
        {
            //Partie code destiné au bouton Valider de la rubrique Changer de mot de passe
            buttonValCDMDP.DialogResult = DialogResult.OK;
            if (buttonValCDMDP.DialogResult == DialogResult.OK)
            {
                MessageBox.Show("Votre nouveau mot de passe a été valider.");
            }
        }

        private void buttonValCDMDP_Click(object sender, EventArgs e)
        {
            InterGes pourChangerMDP = new InterGes();
            if (textBoxNewMDP.Text == textBoxNewMDP2.Text)
            {
                if (pourChangerMDP.ChangerMotDePasse(utilisateur, textBoxOldPswd.Text, textBoxNewMDP.Text) == true) MessageBox.Show("Votre mot de passe a été changé.", "Action réussie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else MessageBox.Show("Mauvais mot de passe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Les nouveaux de passe ne correspondent pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void panelUtilisateur_Paint(object sender, PaintEventArgs e)
        {
            Utilisateur lesUtilisateurs = new Utilisateur();
            dataGridViewUti.DataSource = lesUtilisateurs.GetLesUtilisateurs();
            dataGridViewUti.Columns[9].Visible = false;
            dataGridViewUti.Columns[10].Visible = false;
            dataGridViewUti.Columns[11].Visible = false;
            dataGridViewUti.Columns[12].Visible = false;
            dataGridViewUti.Columns[13].Visible = false;
            dataGridViewUti.Columns[14].Visible = false;
            dataGridViewUti.Columns[15].Visible = false;
            dataGridViewUti.Columns[16].Visible = false;
        }

        private void panelHistoriqueC_Paint(object sender, PaintEventArgs e)
        {
            Utilisateur lesUtilisateurs = new Utilisateur();
            dataGridViewHC.DataSource = lesUtilisateurs.GetLesUtilisateurs();
            dataGridViewHC.Columns[1].Visible = false;
            dataGridViewHC.Columns[2].Visible = false;
            dataGridViewHC.Columns[3].Visible = false;
            dataGridViewHC.Columns[4].Visible = false;
            dataGridViewHC.Columns[5].Visible = false;
            dataGridViewHC.Columns[9].Visible = false;
            dataGridViewHC.Columns[12].Visible = false;
            dataGridViewHC.Columns[13].Visible = false;
            dataGridViewHC.Columns[14].Visible = false;
            dataGridViewHC.Columns[15].Visible = false;
            dataGridViewHC.Columns[16].Visible = false;
            dataGridViewHC.Columns[17].Visible = false;
        }
    }
}
