﻿namespace UtilisateursGUI.GestionMdc
{
    partial class FrmModuleLectureMdc
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
            this.suprBtn = new System.Windows.Forms.Button();
            this.ajoutBtn = new System.Windows.Forms.Button();
            this.modifBtn = new System.Windows.Forms.Button();
            this.fmrButton = new System.Windows.Forms.Button();
            this.actualiserBtn = new System.Windows.Forms.Button();
            this.MedicsView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.MedicsView)).BeginInit();
            this.SuspendLayout();
            // 
            // suprBtn
            // 
            this.suprBtn.Location = new System.Drawing.Point(255, 309);
            this.suprBtn.Name = "suprBtn";
            this.suprBtn.Size = new System.Drawing.Size(75, 23);
            this.suprBtn.TabIndex = 23;
            this.suprBtn.Text = "Supprimer";
            this.suprBtn.UseVisualStyleBackColor = true;
            this.suprBtn.Click += new System.EventHandler(this.suprBtn_Click);
            // 
            // ajoutBtn
            // 
            this.ajoutBtn.Location = new System.Drawing.Point(93, 309);
            this.ajoutBtn.Name = "ajoutBtn";
            this.ajoutBtn.Size = new System.Drawing.Size(75, 23);
            this.ajoutBtn.TabIndex = 22;
            this.ajoutBtn.Text = "Ajouter";
            this.ajoutBtn.UseVisualStyleBackColor = true;
            this.ajoutBtn.Click += new System.EventHandler(this.ajoutBtn_Click);
            // 
            // modifBtn
            // 
            this.modifBtn.Location = new System.Drawing.Point(174, 309);
            this.modifBtn.Name = "modifBtn";
            this.modifBtn.Size = new System.Drawing.Size(75, 23);
            this.modifBtn.TabIndex = 21;
            this.modifBtn.Text = "Modifier";
            this.modifBtn.UseVisualStyleBackColor = true;
            this.modifBtn.Click += new System.EventHandler(this.modifBtn_Click);
            // 
            // fmrButton
            // 
            this.fmrButton.Location = new System.Drawing.Point(359, 309);
            this.fmrButton.Name = "fmrButton";
            this.fmrButton.Size = new System.Drawing.Size(75, 23);
            this.fmrButton.TabIndex = 20;
            this.fmrButton.Text = "Fermer";
            this.fmrButton.UseVisualStyleBackColor = true;
            this.fmrButton.Click += new System.EventHandler(this.fmrButton_Click);
            // 
            // actualiserBtn
            // 
            this.actualiserBtn.Location = new System.Drawing.Point(359, 280);
            this.actualiserBtn.Name = "actualiserBtn";
            this.actualiserBtn.Size = new System.Drawing.Size(75, 23);
            this.actualiserBtn.TabIndex = 19;
            this.actualiserBtn.Text = "Actualiser";
            this.actualiserBtn.UseVisualStyleBackColor = true;
            this.actualiserBtn.Click += new System.EventHandler(this.actualiserBtn_Click);
            // 
            // MedicsView
            // 
            this.MedicsView.AllowUserToAddRows = false;
            this.MedicsView.AllowUserToDeleteRows = false;
            this.MedicsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicsView.Location = new System.Drawing.Point(12, 12);
            this.MedicsView.Name = "MedicsView";
            this.MedicsView.ReadOnly = true;
            this.MedicsView.Size = new System.Drawing.Size(422, 248);
            this.MedicsView.TabIndex = 18;
            // 
            // FrmModuleLectureMdc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 352);
            this.Controls.Add(this.suprBtn);
            this.Controls.Add(this.ajoutBtn);
            this.Controls.Add(this.modifBtn);
            this.Controls.Add(this.fmrButton);
            this.Controls.Add(this.actualiserBtn);
            this.Controls.Add(this.MedicsView);
            this.Name = "FrmModuleLectureMdc";
            this.Text = "FrmModuleLectureMdccs";
            ((System.ComponentModel.ISupportInitialize)(this.MedicsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button suprBtn;
        private System.Windows.Forms.Button ajoutBtn;
        private System.Windows.Forms.Button modifBtn;
        private System.Windows.Forms.Button fmrButton;
        private System.Windows.Forms.Button actualiserBtn;
        private System.Windows.Forms.DataGridView MedicsView;
    }
}