﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using UtilisateursBLL;

namespace UtilisateursGUI.GestionVst
{
    public partial class FrmModifVst : Form
    {
        public FrmModifVst()
        {
            InitializeComponent();

            
            #region Initialisation du Formulaire de modification
            

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            UtilisateursBLL.GestionVisite.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Visite"]);
            UtilisateursBLL.GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Eleve"]);
            //uneGestionEleve = new List<GestionEleve>();

            //GestionEleve unEleve = new GestionEleve();
            //uneGestionEleve = unEleve.GetEleve();

            // Création d'un objet List d'Eleves à afficher dans la liste
            listeEleves = GestionEleve.GetElevesNonArchives();
            
            nomElv_cmbx.DataSource = listeEleves;
            nomElv_cmbx.DisplayMember = "Nom";
            nomElv_cmbx.ValueMember = "Id_eleves";

            numSelectionne = (int)nomElv_cmbx.SelectedIndex;

            #region Remplissage des cases
            if (listeEleves[numSelectionne].ArchiveEleve == false)
            {
                prenomEleve_txt.Text = listeEleves[numSelectionne].Prenom;
                dateTimePicker1.Text = listeEleves[numSelectionne].Date_naissance.ToString();
                lblClasse_cmbx.DataSource = GestionClasse.GetClasses();
                lblClasse_cmbx.DisplayMember = "LibelleClasse";
                lblClasse_cmbx.SelectedIndex = listeEleves[numSelectionne].Id_classe - 1;
            }

            #region Brouillon
            /*
            nbClasse = listeEleves[numSelectionne].Id_classe;
            listeNomClasses = new List<string>();
            nbClasse = GestionClasse.GetClasses().Count;
            listeNomClasses.Add(GestionEleve.GetLeNomDeClasse(numSelectionne));
            
            while (ind <= nbClasse)
            {
                listeNomClasses.Add(GestionEleve.GetLeNomDeClasse(ind));
                ind++;
            }

            lblClasse_cmbx.DataSource = listeNomClasses; //GestionEleve.GetLeNomDeClasse(listeEleves[numSelectionne].Id_classe);
            lblClasse_cmbx.DisplayMember = "LibelleClasse";

            while (ind <= GestionClasse.GetClasses().Count)
            {
                lblClasse_cmbx.Value[ind] = GestionEleve.GetLeNomDeClasse(ind);
                ind++;
            }*/
            #endregion
            #endregion
            
            #region Attributs de l'application
            private int numSelectionne;
            //  private int nbClasse;
            //  private int ind = 0;
            private List<Eleve> listeEleves; // initialisation de la liste
            // private List<string> listeNomClasses;
            #endregion
            #region Actions concernant la liste déroulante des noms des élèves
            private void nomElv_list_SelectionChangeCommitted(object sender, EventArgs e)
            {
                int numSelectionne = (int)nomElv_cmbx.SelectedIndex;

                #region Remplissage des cases
                prenomEleve_txt.Text = listeEleves[numSelectionne].Prenom;
                dateTimePicker1.Text = listeEleves[numSelectionne].Date_naissance.ToString();
                telEleve_txt.Text = listeEleves[numSelectionne].Tel_eleve.ToString();
                telParent_txt.Text = listeEleves[numSelectionne].Tel_parent.ToString();
                tierTemps_txt.Text = listeEleves[numSelectionne].Tier_temps.ToString();
                commentSante_text.Text = listeEleves[numSelectionne].Commentaire_sante;

                lblClasse_cmbx.DataSource = GestionClasse.GetClasses();
                lblClasse_cmbx.DisplayMember = "NiveauClasse" + "LibelleClasse";
                lblClasse_cmbx.SelectedIndex = listeEleves[numSelectionne].Id_classe - 1;

                // lblClasse_cmbx.DataSource = GestionEleve.GetLeNomDeClasse(nbClasse); //GestionEleve.GetLeNomDeClasse(listeEleves[numSelectionne].Id_classe);
                // lblClasse_cmbx.DisplayMember = "LibelleClasse";
                #endregion
            }
            #endregion
        }
    }
}
