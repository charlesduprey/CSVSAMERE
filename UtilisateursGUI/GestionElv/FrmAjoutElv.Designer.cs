﻿namespace UtilisateursGUI.GestionElv
{
    partial class FrmAjoutElv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tiertemp1 = new System.Windows.Forms.RadioButton();
            this.tiertemp = new System.Windows.Forms.RadioButton();
            this.lblClasse_cmbx = new System.Windows.Forms.ComboBox();
            this.commentSante_text = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.saveBtnEleve = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.idClasse = new System.Windows.Forms.Label();
            this.commentSante = new System.Windows.Forms.Label();
            this.tierTemps = new System.Windows.Forms.Label();
            this.telParent_txt = new System.Windows.Forms.TextBox();
            this.telParent = new System.Windows.Forms.Label();
            this.telEleve_txt = new System.Windows.Forms.TextBox();
            this.telEleve = new System.Windows.Forms.Label();
            this.AjoutEleve = new System.Windows.Forms.Label();
            this.dateNaissance = new System.Windows.Forms.Label();
            this.nomEleve_txt = new System.Windows.Forms.TextBox();
            this.prenomEleve_txt = new System.Windows.Forms.TextBox();
            this.prenomEleve = new System.Windows.Forms.Label();
            this.nomEleve = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tiertemp1
            // 
            this.tiertemp1.AutoSize = true;
            this.tiertemp1.Location = new System.Drawing.Point(464, 298);
            this.tiertemp1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tiertemp1.Name = "tiertemp1";
            this.tiertemp1.Size = new System.Drawing.Size(53, 21);
            this.tiertemp1.TabIndex = 158;
            this.tiertemp1.Text = "non";
            this.tiertemp1.UseVisualStyleBackColor = true;
            // 
            // tiertemp
            // 
            this.tiertemp.AutoSize = true;
            this.tiertemp.Checked = true;
            this.tiertemp.Location = new System.Drawing.Point(275, 298);
            this.tiertemp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tiertemp.Name = "tiertemp";
            this.tiertemp.Size = new System.Drawing.Size(48, 21);
            this.tiertemp.TabIndex = 157;
            this.tiertemp.TabStop = true;
            this.tiertemp.Text = "oui";
            this.tiertemp.UseVisualStyleBackColor = true;
            // 
            // lblClasse_cmbx
            // 
            this.lblClasse_cmbx.FormattingEnabled = true;
            this.lblClasse_cmbx.Location = new System.Drawing.Point(275, 263);
            this.lblClasse_cmbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblClasse_cmbx.Name = "lblClasse_cmbx";
            this.lblClasse_cmbx.Size = new System.Drawing.Size(301, 24);
            this.lblClasse_cmbx.TabIndex = 156;
            // 
            // commentSante_text
            // 
            this.commentSante_text.Location = new System.Drawing.Point(275, 329);
            this.commentSante_text.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.commentSante_text.Name = "commentSante_text";
            this.commentSante_text.Size = new System.Drawing.Size(301, 22);
            this.commentSante_text.TabIndex = 155;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(275, 167);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(301, 22);
            this.dateTimePicker1.TabIndex = 154;
            // 
            // saveBtnEleve
            // 
            this.saveBtnEleve.Location = new System.Drawing.Point(275, 385);
            this.saveBtnEleve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveBtnEleve.Name = "saveBtnEleve";
            this.saveBtnEleve.Size = new System.Drawing.Size(303, 44);
            this.saveBtnEleve.TabIndex = 153;
            this.saveBtnEleve.Text = "Enregistrer";
            this.saveBtnEleve.UseVisualStyleBackColor = true;
            this.saveBtnEleve.Click += new System.EventHandler(this.saveBtnEleve_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(43, 385);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(159, 44);
            this.closeButton.TabIndex = 152;
            this.closeButton.Text = "Fermer";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // idClasse
            // 
            this.idClasse.AutoSize = true;
            this.idClasse.Location = new System.Drawing.Point(40, 266);
            this.idClasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idClasse.Name = "idClasse";
            this.idClasse.Size = new System.Drawing.Size(58, 17);
            this.idClasse.TabIndex = 151;
            this.idClasse.Text = "Classe :";
            // 
            // commentSante
            // 
            this.commentSante.AutoSize = true;
            this.commentSante.Location = new System.Drawing.Point(39, 332);
            this.commentSante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.commentSante.Name = "commentSante";
            this.commentSante.Size = new System.Drawing.Size(138, 17);
            this.commentSante.TabIndex = 150;
            this.commentSante.Text = "Commentaire santé :";
            // 
            // tierTemps
            // 
            this.tierTemps.AutoSize = true;
            this.tierTemps.Location = new System.Drawing.Point(39, 300);
            this.tierTemps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tierTemps.Name = "tierTemps";
            this.tierTemps.Size = new System.Drawing.Size(83, 17);
            this.tierTemps.TabIndex = 149;
            this.tierTemps.Text = "Tier temps :";
            // 
            // telParent_txt
            // 
            this.telParent_txt.Location = new System.Drawing.Point(275, 231);
            this.telParent_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.telParent_txt.Name = "telParent_txt";
            this.telParent_txt.Size = new System.Drawing.Size(301, 22);
            this.telParent_txt.TabIndex = 148;
            // 
            // telParent
            // 
            this.telParent.AutoSize = true;
            this.telParent.Location = new System.Drawing.Point(39, 240);
            this.telParent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telParent.Name = "telParent";
            this.telParent.Size = new System.Drawing.Size(163, 17);
            this.telParent.TabIndex = 147;
            this.telParent.Text = "Téléphone des parents :";
            // 
            // telEleve_txt
            // 
            this.telEleve_txt.Location = new System.Drawing.Point(275, 199);
            this.telEleve_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.telEleve_txt.Name = "telEleve_txt";
            this.telEleve_txt.Size = new System.Drawing.Size(301, 22);
            this.telEleve_txt.TabIndex = 146;
            // 
            // telEleve
            // 
            this.telEleve.AutoSize = true;
            this.telEleve.Location = new System.Drawing.Point(39, 208);
            this.telEleve.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telEleve.Name = "telEleve";
            this.telEleve.Size = new System.Drawing.Size(148, 17);
            this.telEleve.TabIndex = 145;
            this.telEleve.Text = "Téléphone de l\'élève :";
            // 
            // AjoutEleve
            // 
            this.AjoutEleve.AutoSize = true;
            this.AjoutEleve.Location = new System.Drawing.Point(220, 39);
            this.AjoutEleve.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AjoutEleve.Name = "AjoutEleve";
            this.AjoutEleve.Size = new System.Drawing.Size(104, 17);
            this.AjoutEleve.TabIndex = 144;
            this.AjoutEleve.Text = "Ajout de l\'élève";
            this.AjoutEleve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateNaissance
            // 
            this.dateNaissance.AutoSize = true;
            this.dateNaissance.Location = new System.Drawing.Point(39, 175);
            this.dateNaissance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.Size = new System.Drawing.Size(134, 17);
            this.dateNaissance.TabIndex = 143;
            this.dateNaissance.Text = "Date de naissance :";
            // 
            // nomEleve_txt
            // 
            this.nomEleve_txt.Location = new System.Drawing.Point(275, 103);
            this.nomEleve_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nomEleve_txt.Name = "nomEleve_txt";
            this.nomEleve_txt.Size = new System.Drawing.Size(301, 22);
            this.nomEleve_txt.TabIndex = 142;
            // 
            // prenomEleve_txt
            // 
            this.prenomEleve_txt.Location = new System.Drawing.Point(275, 135);
            this.prenomEleve_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.prenomEleve_txt.Name = "prenomEleve_txt";
            this.prenomEleve_txt.Size = new System.Drawing.Size(301, 22);
            this.prenomEleve_txt.TabIndex = 141;
            // 
            // prenomEleve
            // 
            this.prenomEleve.AutoSize = true;
            this.prenomEleve.Location = new System.Drawing.Point(39, 139);
            this.prenomEleve.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prenomEleve.Name = "prenomEleve";
            this.prenomEleve.Size = new System.Drawing.Size(65, 17);
            this.prenomEleve.TabIndex = 140;
            this.prenomEleve.Text = "Prénom :";
            // 
            // nomEleve
            // 
            this.nomEleve.AutoSize = true;
            this.nomEleve.Location = new System.Drawing.Point(39, 107);
            this.nomEleve.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomEleve.Name = "nomEleve";
            this.nomEleve.Size = new System.Drawing.Size(49, 17);
            this.nomEleve.TabIndex = 139;
            this.nomEleve.Text = "Nom  :";
            // 
            // FrmAjoutElv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 468);
            this.Controls.Add(this.tiertemp1);
            this.Controls.Add(this.tiertemp);
            this.Controls.Add(this.lblClasse_cmbx);
            this.Controls.Add(this.commentSante_text);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.saveBtnEleve);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.idClasse);
            this.Controls.Add(this.commentSante);
            this.Controls.Add(this.tierTemps);
            this.Controls.Add(this.telParent_txt);
            this.Controls.Add(this.telParent);
            this.Controls.Add(this.telEleve_txt);
            this.Controls.Add(this.telEleve);
            this.Controls.Add(this.AjoutEleve);
            this.Controls.Add(this.dateNaissance);
            this.Controls.Add(this.nomEleve_txt);
            this.Controls.Add(this.prenomEleve_txt);
            this.Controls.Add(this.prenomEleve);
            this.Controls.Add(this.nomEleve);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAjoutElv";
            this.Text = "FrmAjoutElv";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton tiertemp1;
        private System.Windows.Forms.RadioButton tiertemp;
        private System.Windows.Forms.ComboBox lblClasse_cmbx;
        private System.Windows.Forms.TextBox commentSante_text;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button saveBtnEleve;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label idClasse;
        private System.Windows.Forms.Label commentSante;
        private System.Windows.Forms.Label tierTemps;
        private System.Windows.Forms.TextBox telParent_txt;
        private System.Windows.Forms.Label telParent;
        private System.Windows.Forms.TextBox telEleve_txt;
        private System.Windows.Forms.Label telEleve;
        private System.Windows.Forms.Label AjoutEleve;
        private System.Windows.Forms.Label dateNaissance;
        private System.Windows.Forms.TextBox nomEleve_txt;
        private System.Windows.Forms.TextBox prenomEleve_txt;
        private System.Windows.Forms.Label prenomEleve;
        private System.Windows.Forms.Label nomEleve;

    }
}