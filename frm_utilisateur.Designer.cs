namespace SafiRepay
{
    partial class frm_utilisateur
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
            this.tbc_utilisateur = new MaterialSkin.Controls.MaterialTabControl();
            this.tbp_accueil = new System.Windows.Forms.TabPage();
            this.lbl_nbFraisValidesSupprimesDernieresSemaines = new MaterialSkin.Controls.MaterialLabel();
            this.tbp_parametresForfait = new System.Windows.Forms.TabPage();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_modifyParamsSheet = new System.Windows.Forms.Button();
            this.tbx_kms = new System.Windows.Forms.TextBox();
            this.tbx_overnight = new System.Windows.Forms.TextBox();
            this.tbx_relayStages = new System.Windows.Forms.TextBox();
            this.tbx_middayMeal = new System.Windows.Forms.TextBox();
            this.lbl_euroParRepas = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_euroParNuitRelaisEtapes = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_euroParNuitNuitee = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_euroKilometre = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_relaisEtapes = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_nuitee = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_deplacement = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_kilometrage = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_repasMidi = new MaterialSkin.Controls.MaterialLabel();
            this.tbp_controleFrais = new System.Windows.Forms.TabPage();
            this.btn_supprimerControleDesFrais = new System.Windows.Forms.Button();
            this.btn_validerControleDesFrais = new System.Windows.Forms.Button();
            this.tbx_nbJoursEnregistres = new System.Windows.Forms.TextBox();
            this.tbx_nbJoursTravailles = new System.Windows.Forms.TextBox();
            this.lbl_nbJoursEnregistres = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_nbJoursTravailles = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_deplacementControleDesFrais = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_nuiteeControleDesFrais = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_RelaisEtapeControleDesFrais = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_repasMidiControleDesFrais = new MaterialSkin.Controls.MaterialLabel();
            this.dgv_deplacement = new System.Windows.Forms.DataGridView();
            this.cln_dateDeplacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_montantDeplacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_relaisEtape = new System.Windows.Forms.DataGridView();
            this.cln_dateNuitee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_montantNuitee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_repasMidi = new System.Windows.Forms.DataGridView();
            this.cln_dateRelaisEtapes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_montantRelaisEtape = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_nuitee = new System.Windows.Forms.DataGridView();
            this.cln_dateRepasMidi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_montantRepasMidi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbp_profil = new System.Windows.Forms.TabPage();
            this.btn_modifierMotDePasseProfil = new System.Windows.Forms.Button();
            this.lbl_telephone = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_nom = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_prenom = new MaterialSkin.Controls.MaterialLabel();
            this.tbx_telUtilisateur = new System.Windows.Forms.TextBox();
            this.tbx_nomUtilisateur = new System.Windows.Forms.TextBox();
            this.tbx_prenomUtilisateur = new System.Windows.Forms.TextBox();
            this.tbs_utilisateur = new MaterialSkin.Controls.MaterialTabSelector();
            this.btn_deconnexion = new System.Windows.Forms.Button();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tbx_login = new System.Windows.Forms.TextBox();
            this.tbx_nbAccount = new System.Windows.Forms.TextBox();
            this.tbc_utilisateur.SuspendLayout();
            this.tbp_accueil.SuspendLayout();
            this.tbp_parametresForfait.SuspendLayout();
            this.tbp_controleFrais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_deplacement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_relaisEtape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_repasMidi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nuitee)).BeginInit();
            this.tbp_profil.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_utilisateur
            // 
            this.tbc_utilisateur.Controls.Add(this.tbp_accueil);
            this.tbc_utilisateur.Controls.Add(this.tbp_parametresForfait);
            this.tbc_utilisateur.Controls.Add(this.tbp_controleFrais);
            this.tbc_utilisateur.Controls.Add(this.tbp_profil);
            this.tbc_utilisateur.Depth = 0;
            this.tbc_utilisateur.Location = new System.Drawing.Point(0, 89);
            this.tbc_utilisateur.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbc_utilisateur.Name = "tbc_utilisateur";
            this.tbc_utilisateur.SelectedIndex = 0;
            this.tbc_utilisateur.Size = new System.Drawing.Size(1285, 511);
            this.tbc_utilisateur.TabIndex = 0;
            // 
            // tbp_accueil
            // 
            this.tbp_accueil.Controls.Add(this.lbl_nbFraisValidesSupprimesDernieresSemaines);
            this.tbp_accueil.Location = new System.Drawing.Point(4, 22);
            this.tbp_accueil.Name = "tbp_accueil";
            this.tbp_accueil.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_accueil.Size = new System.Drawing.Size(1277, 485);
            this.tbp_accueil.TabIndex = 0;
            this.tbp_accueil.Text = "Accueil";
            this.tbp_accueil.UseVisualStyleBackColor = true;
            // 
            // lbl_nbFraisValidesSupprimesDernieresSemaines
            // 
            this.lbl_nbFraisValidesSupprimesDernieresSemaines.AutoSize = true;
            this.lbl_nbFraisValidesSupprimesDernieresSemaines.Depth = 0;
            this.lbl_nbFraisValidesSupprimesDernieresSemaines.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_nbFraisValidesSupprimesDernieresSemaines.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_nbFraisValidesSupprimesDernieresSemaines.Location = new System.Drawing.Point(603, 83);
            this.lbl_nbFraisValidesSupprimesDernieresSemaines.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_nbFraisValidesSupprimesDernieresSemaines.Name = "lbl_nbFraisValidesSupprimesDernieresSemaines";
            this.lbl_nbFraisValidesSupprimesDernieresSemaines.Size = new System.Drawing.Size(77, 19);
            this.lbl_nbFraisValidesSupprimesDernieresSemaines.TabIndex = 0;
            this.lbl_nbFraisValidesSupprimesDernieresSemaines.Text = "Bienvenue";
            // 
            // tbp_parametresForfait
            // 
            this.tbp_parametresForfait.Controls.Add(this.btn_Cancel);
            this.tbp_parametresForfait.Controls.Add(this.btn_Confirm);
            this.tbp_parametresForfait.Controls.Add(this.btn_modifyParamsSheet);
            this.tbp_parametresForfait.Controls.Add(this.tbx_kms);
            this.tbp_parametresForfait.Controls.Add(this.tbx_overnight);
            this.tbp_parametresForfait.Controls.Add(this.tbx_relayStages);
            this.tbp_parametresForfait.Controls.Add(this.tbx_middayMeal);
            this.tbp_parametresForfait.Controls.Add(this.lbl_euroParRepas);
            this.tbp_parametresForfait.Controls.Add(this.lbl_euroParNuitRelaisEtapes);
            this.tbp_parametresForfait.Controls.Add(this.lbl_euroParNuitNuitee);
            this.tbp_parametresForfait.Controls.Add(this.lbl_euroKilometre);
            this.tbp_parametresForfait.Controls.Add(this.lbl_relaisEtapes);
            this.tbp_parametresForfait.Controls.Add(this.lbl_nuitee);
            this.tbp_parametresForfait.Controls.Add(this.lbl_deplacement);
            this.tbp_parametresForfait.Controls.Add(this.lbl_kilometrage);
            this.tbp_parametresForfait.Controls.Add(this.lbl_repasMidi);
            this.tbp_parametresForfait.Location = new System.Drawing.Point(4, 22);
            this.tbp_parametresForfait.Name = "tbp_parametresForfait";
            this.tbp_parametresForfait.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_parametresForfait.Size = new System.Drawing.Size(1277, 485);
            this.tbp_parametresForfait.TabIndex = 1;
            this.tbp_parametresForfait.Text = "Paramètres forfait";
            this.tbp_parametresForfait.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Red;
            this.btn_Cancel.Location = new System.Drawing.Point(748, 367);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(38, 39);
            this.btn_Cancel.TabIndex = 16;
            this.btn_Cancel.Text = "&X";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Visible = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Anul_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.Color.Green;
            this.btn_Confirm.Location = new System.Drawing.Point(704, 367);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(38, 39);
            this.btn_Confirm.TabIndex = 15;
            this.btn_Confirm.Text = "&V";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Visible = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Valid_Click);
            // 
            // btn_modifyParamsSheet
            // 
            this.btn_modifyParamsSheet.Location = new System.Drawing.Point(536, 361);
            this.btn_modifyParamsSheet.Name = "btn_modifyParamsSheet";
            this.btn_modifyParamsSheet.Size = new System.Drawing.Size(131, 51);
            this.btn_modifyParamsSheet.TabIndex = 13;
            this.btn_modifyParamsSheet.Text = "Modifier";
            this.btn_modifyParamsSheet.UseVisualStyleBackColor = true;
            this.btn_modifyParamsSheet.Click += new System.EventHandler(this.btn_modifierParametresForfait_Click);
            // 
            // tbx_kms
            // 
            this.tbx_kms.Location = new System.Drawing.Point(558, 241);
            this.tbx_kms.Name = "tbx_kms";
            this.tbx_kms.Size = new System.Drawing.Size(212, 20);
            this.tbx_kms.TabIndex = 12;
            // 
            // tbx_overnight
            // 
            this.tbx_overnight.Location = new System.Drawing.Point(558, 202);
            this.tbx_overnight.Name = "tbx_overnight";
            this.tbx_overnight.Size = new System.Drawing.Size(212, 20);
            this.tbx_overnight.TabIndex = 11;
            // 
            // tbx_relayStages
            // 
            this.tbx_relayStages.Location = new System.Drawing.Point(558, 164);
            this.tbx_relayStages.Name = "tbx_relayStages";
            this.tbx_relayStages.Size = new System.Drawing.Size(212, 20);
            this.tbx_relayStages.TabIndex = 10;
            // 
            // tbx_middayMeal
            // 
            this.tbx_middayMeal.Location = new System.Drawing.Point(558, 129);
            this.tbx_middayMeal.Name = "tbx_middayMeal";
            this.tbx_middayMeal.Size = new System.Drawing.Size(212, 20);
            this.tbx_middayMeal.TabIndex = 9;
            this.tbx_middayMeal.TextChanged += new System.EventHandler(this.Tbx_repasMidi_TextChanged);
            // 
            // lbl_euroParRepas
            // 
            this.lbl_euroParRepas.AutoSize = true;
            this.lbl_euroParRepas.Depth = 0;
            this.lbl_euroParRepas.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_euroParRepas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_euroParRepas.Location = new System.Drawing.Point(798, 128);
            this.lbl_euroParRepas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_euroParRepas.Name = "lbl_euroParRepas";
            this.lbl_euroParRepas.Size = new System.Drawing.Size(60, 19);
            this.lbl_euroParRepas.TabIndex = 8;
            this.lbl_euroParRepas.Text = "€/repas";
            // 
            // lbl_euroParNuitRelaisEtapes
            // 
            this.lbl_euroParNuitRelaisEtapes.AutoSize = true;
            this.lbl_euroParNuitRelaisEtapes.Depth = 0;
            this.lbl_euroParNuitRelaisEtapes.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_euroParNuitRelaisEtapes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_euroParNuitRelaisEtapes.Location = new System.Drawing.Point(798, 163);
            this.lbl_euroParNuitRelaisEtapes.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_euroParNuitRelaisEtapes.Name = "lbl_euroParNuitRelaisEtapes";
            this.lbl_euroParNuitRelaisEtapes.Size = new System.Drawing.Size(48, 19);
            this.lbl_euroParNuitRelaisEtapes.TabIndex = 7;
            this.lbl_euroParNuitRelaisEtapes.Text = "€/nuit";
            // 
            // lbl_euroParNuitNuitee
            // 
            this.lbl_euroParNuitNuitee.AutoSize = true;
            this.lbl_euroParNuitNuitee.Depth = 0;
            this.lbl_euroParNuitNuitee.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_euroParNuitNuitee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_euroParNuitNuitee.Location = new System.Drawing.Point(798, 201);
            this.lbl_euroParNuitNuitee.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_euroParNuitNuitee.Name = "lbl_euroParNuitNuitee";
            this.lbl_euroParNuitNuitee.Size = new System.Drawing.Size(48, 19);
            this.lbl_euroParNuitNuitee.TabIndex = 6;
            this.lbl_euroParNuitNuitee.Text = "€/nuit";
            // 
            // lbl_euroKilometre
            // 
            this.lbl_euroKilometre.AutoSize = true;
            this.lbl_euroKilometre.Depth = 0;
            this.lbl_euroKilometre.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_euroKilometre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_euroKilometre.Location = new System.Drawing.Point(798, 240);
            this.lbl_euroKilometre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_euroKilometre.Name = "lbl_euroKilometre";
            this.lbl_euroKilometre.Size = new System.Drawing.Size(17, 19);
            this.lbl_euroKilometre.TabIndex = 5;
            this.lbl_euroKilometre.Text = "€";
            // 
            // lbl_relaisEtapes
            // 
            this.lbl_relaisEtapes.AutoSize = true;
            this.lbl_relaisEtapes.Depth = 0;
            this.lbl_relaisEtapes.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_relaisEtapes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_relaisEtapes.Location = new System.Drawing.Point(248, 163);
            this.lbl_relaisEtapes.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_relaisEtapes.Name = "lbl_relaisEtapes";
            this.lbl_relaisEtapes.Size = new System.Drawing.Size(204, 19);
            this.lbl_relaisEtapes.TabIndex = 4;
            this.lbl_relaisEtapes.Text = "Relais étapes (nuit et repas) :";
            // 
            // lbl_nuitee
            // 
            this.lbl_nuitee.AutoSize = true;
            this.lbl_nuitee.Depth = 0;
            this.lbl_nuitee.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_nuitee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_nuitee.Location = new System.Drawing.Point(248, 201);
            this.lbl_nuitee.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_nuitee.Name = "lbl_nuitee";
            this.lbl_nuitee.Size = new System.Drawing.Size(141, 19);
            this.lbl_nuitee.TabIndex = 3;
            this.lbl_nuitee.Text = "Nuitée (hôtel seul) :";
            // 
            // lbl_deplacement
            // 
            this.lbl_deplacement.AutoSize = true;
            this.lbl_deplacement.Depth = 0;
            this.lbl_deplacement.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_deplacement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_deplacement.Location = new System.Drawing.Point(248, 240);
            this.lbl_deplacement.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_deplacement.Name = "lbl_deplacement";
            this.lbl_deplacement.Size = new System.Drawing.Size(105, 19);
            this.lbl_deplacement.TabIndex = 2;
            this.lbl_deplacement.Text = "Déplacement :";
            // 
            // lbl_kilometrage
            // 
            this.lbl_kilometrage.AutoSize = true;
            this.lbl_kilometrage.Depth = 0;
            this.lbl_kilometrage.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_kilometrage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_kilometrage.Location = new System.Drawing.Point(443, 240);
            this.lbl_kilometrage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_kilometrage.Name = "lbl_kilometrage";
            this.lbl_kilometrage.Size = new System.Drawing.Size(109, 19);
            this.lbl_kilometrage.TabIndex = 1;
            this.lbl_kilometrage.Text = "kilométrage à :";
            // 
            // lbl_repasMidi
            // 
            this.lbl_repasMidi.AutoSize = true;
            this.lbl_repasMidi.Depth = 0;
            this.lbl_repasMidi.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_repasMidi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_repasMidi.Location = new System.Drawing.Point(248, 128);
            this.lbl_repasMidi.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_repasMidi.Name = "lbl_repasMidi";
            this.lbl_repasMidi.Size = new System.Drawing.Size(91, 19);
            this.lbl_repasMidi.TabIndex = 0;
            this.lbl_repasMidi.Text = "Repas midi :";
            // 
            // tbp_controleFrais
            // 
            this.tbp_controleFrais.Controls.Add(this.btn_supprimerControleDesFrais);
            this.tbp_controleFrais.Controls.Add(this.btn_validerControleDesFrais);
            this.tbp_controleFrais.Controls.Add(this.tbx_nbJoursEnregistres);
            this.tbp_controleFrais.Controls.Add(this.tbx_nbJoursTravailles);
            this.tbp_controleFrais.Controls.Add(this.lbl_nbJoursEnregistres);
            this.tbp_controleFrais.Controls.Add(this.lbl_nbJoursTravailles);
            this.tbp_controleFrais.Controls.Add(this.lbl_deplacementControleDesFrais);
            this.tbp_controleFrais.Controls.Add(this.lbl_nuiteeControleDesFrais);
            this.tbp_controleFrais.Controls.Add(this.lbl_RelaisEtapeControleDesFrais);
            this.tbp_controleFrais.Controls.Add(this.lbl_repasMidiControleDesFrais);
            this.tbp_controleFrais.Controls.Add(this.dgv_deplacement);
            this.tbp_controleFrais.Controls.Add(this.dgv_relaisEtape);
            this.tbp_controleFrais.Controls.Add(this.dgv_repasMidi);
            this.tbp_controleFrais.Controls.Add(this.dgv_nuitee);
            this.tbp_controleFrais.Location = new System.Drawing.Point(4, 22);
            this.tbp_controleFrais.Name = "tbp_controleFrais";
            this.tbp_controleFrais.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_controleFrais.Size = new System.Drawing.Size(1277, 485);
            this.tbp_controleFrais.TabIndex = 2;
            this.tbp_controleFrais.Text = "Contrôle des frais";
            this.tbp_controleFrais.UseVisualStyleBackColor = true;
            // 
            // btn_supprimerControleDesFrais
            // 
            this.btn_supprimerControleDesFrais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_supprimerControleDesFrais.Location = new System.Drawing.Point(712, 423);
            this.btn_supprimerControleDesFrais.Name = "btn_supprimerControleDesFrais";
            this.btn_supprimerControleDesFrais.Size = new System.Drawing.Size(100, 25);
            this.btn_supprimerControleDesFrais.TabIndex = 13;
            this.btn_supprimerControleDesFrais.Text = "&SUPPRIMER";
            this.btn_supprimerControleDesFrais.UseVisualStyleBackColor = false;
            // 
            // btn_validerControleDesFrais
            // 
            this.btn_validerControleDesFrais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_validerControleDesFrais.Location = new System.Drawing.Point(472, 423);
            this.btn_validerControleDesFrais.Name = "btn_validerControleDesFrais";
            this.btn_validerControleDesFrais.Size = new System.Drawing.Size(100, 25);
            this.btn_validerControleDesFrais.TabIndex = 12;
            this.btn_validerControleDesFrais.Text = "&VALIDER";
            this.btn_validerControleDesFrais.UseVisualStyleBackColor = false;
            // 
            // tbx_nbJoursEnregistres
            // 
            this.tbx_nbJoursEnregistres.Location = new System.Drawing.Point(309, 378);
            this.tbx_nbJoursEnregistres.Name = "tbx_nbJoursEnregistres";
            this.tbx_nbJoursEnregistres.Size = new System.Drawing.Size(100, 20);
            this.tbx_nbJoursEnregistres.TabIndex = 11;
            // 
            // tbx_nbJoursTravailles
            // 
            this.tbx_nbJoursTravailles.Location = new System.Drawing.Point(309, 341);
            this.tbx_nbJoursTravailles.Name = "tbx_nbJoursTravailles";
            this.tbx_nbJoursTravailles.Size = new System.Drawing.Size(100, 20);
            this.tbx_nbJoursTravailles.TabIndex = 10;
            // 
            // lbl_nbJoursEnregistres
            // 
            this.lbl_nbJoursEnregistres.AutoSize = true;
            this.lbl_nbJoursEnregistres.Depth = 0;
            this.lbl_nbJoursEnregistres.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_nbJoursEnregistres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_nbJoursEnregistres.Location = new System.Drawing.Point(79, 377);
            this.lbl_nbJoursEnregistres.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_nbJoursEnregistres.Name = "lbl_nbJoursEnregistres";
            this.lbl_nbJoursEnregistres.Size = new System.Drawing.Size(208, 19);
            this.lbl_nbJoursEnregistres.TabIndex = 9;
            this.lbl_nbJoursEnregistres.Text = "Nombre de jours enregistrés :";
            // 
            // lbl_nbJoursTravailles
            // 
            this.lbl_nbJoursTravailles.AutoSize = true;
            this.lbl_nbJoursTravailles.Depth = 0;
            this.lbl_nbJoursTravailles.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_nbJoursTravailles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_nbJoursTravailles.Location = new System.Drawing.Point(79, 340);
            this.lbl_nbJoursTravailles.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_nbJoursTravailles.Name = "lbl_nbJoursTravailles";
            this.lbl_nbJoursTravailles.Size = new System.Drawing.Size(194, 19);
            this.lbl_nbJoursTravailles.TabIndex = 8;
            this.lbl_nbJoursTravailles.Text = "Nombre de jours travaillés :";
            // 
            // lbl_deplacementControleDesFrais
            // 
            this.lbl_deplacementControleDesFrais.AutoSize = true;
            this.lbl_deplacementControleDesFrais.Depth = 0;
            this.lbl_deplacementControleDesFrais.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_deplacementControleDesFrais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_deplacementControleDesFrais.Location = new System.Drawing.Point(998, 108);
            this.lbl_deplacementControleDesFrais.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_deplacementControleDesFrais.Name = "lbl_deplacementControleDesFrais";
            this.lbl_deplacementControleDesFrais.Size = new System.Drawing.Size(97, 19);
            this.lbl_deplacementControleDesFrais.TabIndex = 7;
            this.lbl_deplacementControleDesFrais.Text = "Déplacement";
            // 
            // lbl_nuiteeControleDesFrais
            // 
            this.lbl_nuiteeControleDesFrais.AutoSize = true;
            this.lbl_nuiteeControleDesFrais.Depth = 0;
            this.lbl_nuiteeControleDesFrais.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_nuiteeControleDesFrais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_nuiteeControleDesFrais.Location = new System.Drawing.Point(732, 108);
            this.lbl_nuiteeControleDesFrais.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_nuiteeControleDesFrais.Name = "lbl_nuiteeControleDesFrais";
            this.lbl_nuiteeControleDesFrais.Size = new System.Drawing.Size(53, 19);
            this.lbl_nuiteeControleDesFrais.TabIndex = 6;
            this.lbl_nuiteeControleDesFrais.Text = "Nuitée";
            // 
            // lbl_RelaisEtapeControleDesFrais
            // 
            this.lbl_RelaisEtapeControleDesFrais.AutoSize = true;
            this.lbl_RelaisEtapeControleDesFrais.Depth = 0;
            this.lbl_RelaisEtapeControleDesFrais.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_RelaisEtapeControleDesFrais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_RelaisEtapeControleDesFrais.Location = new System.Drawing.Point(435, 108);
            this.lbl_RelaisEtapeControleDesFrais.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_RelaisEtapeControleDesFrais.Name = "lbl_RelaisEtapeControleDesFrais";
            this.lbl_RelaisEtapeControleDesFrais.Size = new System.Drawing.Size(91, 19);
            this.lbl_RelaisEtapeControleDesFrais.TabIndex = 5;
            this.lbl_RelaisEtapeControleDesFrais.Text = "Relais étape";
            // 
            // lbl_repasMidiControleDesFrais
            // 
            this.lbl_repasMidiControleDesFrais.AutoSize = true;
            this.lbl_repasMidiControleDesFrais.Depth = 0;
            this.lbl_repasMidiControleDesFrais.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_repasMidiControleDesFrais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_repasMidiControleDesFrais.Location = new System.Drawing.Point(162, 108);
            this.lbl_repasMidiControleDesFrais.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_repasMidiControleDesFrais.Name = "lbl_repasMidiControleDesFrais";
            this.lbl_repasMidiControleDesFrais.Size = new System.Drawing.Size(83, 19);
            this.lbl_repasMidiControleDesFrais.TabIndex = 4;
            this.lbl_repasMidiControleDesFrais.Text = "Repas midi";
            // 
            // dgv_deplacement
            // 
            this.dgv_deplacement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_deplacement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_dateDeplacement,
            this.cln_montantDeplacement});
            this.dgv_deplacement.Location = new System.Drawing.Point(929, 130);
            this.dgv_deplacement.Name = "dgv_deplacement";
            this.dgv_deplacement.Size = new System.Drawing.Size(243, 150);
            this.dgv_deplacement.TabIndex = 3;
            // 
            // cln_dateDeplacement
            // 
            this.cln_dateDeplacement.HeaderText = "Date";
            this.cln_dateDeplacement.Name = "cln_dateDeplacement";
            // 
            // cln_montantDeplacement
            // 
            this.cln_montantDeplacement.HeaderText = "Déplacement";
            this.cln_montantDeplacement.Name = "cln_montantDeplacement";
            // 
            // dgv_relaisEtape
            // 
            this.dgv_relaisEtape.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_relaisEtape.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_dateNuitee,
            this.cln_montantNuitee});
            this.dgv_relaisEtape.Location = new System.Drawing.Point(365, 130);
            this.dgv_relaisEtape.Name = "dgv_relaisEtape";
            this.dgv_relaisEtape.Size = new System.Drawing.Size(243, 150);
            this.dgv_relaisEtape.TabIndex = 2;
            // 
            // cln_dateNuitee
            // 
            this.cln_dateNuitee.HeaderText = "Date";
            this.cln_dateNuitee.Name = "cln_dateNuitee";
            // 
            // cln_montantNuitee
            // 
            this.cln_montantNuitee.HeaderText = "Montant";
            this.cln_montantNuitee.Name = "cln_montantNuitee";
            // 
            // dgv_repasMidi
            // 
            this.dgv_repasMidi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_repasMidi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_dateRelaisEtapes,
            this.cln_montantRelaisEtape});
            this.dgv_repasMidi.Location = new System.Drawing.Point(83, 130);
            this.dgv_repasMidi.Name = "dgv_repasMidi";
            this.dgv_repasMidi.Size = new System.Drawing.Size(243, 150);
            this.dgv_repasMidi.TabIndex = 1;
            // 
            // cln_dateRelaisEtapes
            // 
            this.cln_dateRelaisEtapes.HeaderText = "Date";
            this.cln_dateRelaisEtapes.Name = "cln_dateRelaisEtapes";
            // 
            // cln_montantRelaisEtape
            // 
            this.cln_montantRelaisEtape.HeaderText = "Montant";
            this.cln_montantRelaisEtape.Name = "cln_montantRelaisEtape";
            // 
            // dgv_nuitee
            // 
            this.dgv_nuitee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nuitee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_dateRepasMidi,
            this.cln_montantRepasMidi});
            this.dgv_nuitee.Location = new System.Drawing.Point(647, 130);
            this.dgv_nuitee.Name = "dgv_nuitee";
            this.dgv_nuitee.Size = new System.Drawing.Size(243, 150);
            this.dgv_nuitee.TabIndex = 0;
            // 
            // cln_dateRepasMidi
            // 
            this.cln_dateRepasMidi.HeaderText = "Date";
            this.cln_dateRepasMidi.Name = "cln_dateRepasMidi";
            // 
            // cln_montantRepasMidi
            // 
            this.cln_montantRepasMidi.HeaderText = "Montant";
            this.cln_montantRepasMidi.Name = "cln_montantRepasMidi";
            // 
            // tbp_profil
            // 
            this.tbp_profil.Controls.Add(this.tbx_nbAccount);
            this.tbp_profil.Controls.Add(this.tbx_login);
            this.tbp_profil.Controls.Add(this.materialLabel1);
            this.tbp_profil.Controls.Add(this.btn_modifierMotDePasseProfil);
            this.tbp_profil.Controls.Add(this.lbl_telephone);
            this.tbp_profil.Controls.Add(this.lbl_nom);
            this.tbp_profil.Controls.Add(this.lbl_prenom);
            this.tbp_profil.Controls.Add(this.tbx_telUtilisateur);
            this.tbp_profil.Controls.Add(this.tbx_nomUtilisateur);
            this.tbp_profil.Controls.Add(this.tbx_prenomUtilisateur);
            this.tbp_profil.Location = new System.Drawing.Point(4, 22);
            this.tbp_profil.Name = "tbp_profil";
            this.tbp_profil.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_profil.Size = new System.Drawing.Size(1277, 485);
            this.tbp_profil.TabIndex = 3;
            this.tbp_profil.Text = "Profil";
            this.tbp_profil.UseVisualStyleBackColor = true;
            // 
            // btn_modifierMotDePasseProfil
            // 
            this.btn_modifierMotDePasseProfil.Location = new System.Drawing.Point(793, 346);
            this.btn_modifierMotDePasseProfil.Name = "btn_modifierMotDePasseProfil";
            this.btn_modifierMotDePasseProfil.Size = new System.Drawing.Size(254, 62);
            this.btn_modifierMotDePasseProfil.TabIndex = 8;
            this.btn_modifierMotDePasseProfil.Text = "MODIFIER MON MOT DE PASSE";
            this.btn_modifierMotDePasseProfil.UseVisualStyleBackColor = true;
            this.btn_modifierMotDePasseProfil.Click += new System.EventHandler(this.Btn_modifierMotDePasseProfil_Click);
            // 
            // lbl_telephone
            // 
            this.lbl_telephone.AutoSize = true;
            this.lbl_telephone.Depth = 0;
            this.lbl_telephone.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_telephone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_telephone.Location = new System.Drawing.Point(680, 245);
            this.lbl_telephone.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_telephone.Name = "lbl_telephone";
            this.lbl_telephone.Size = new System.Drawing.Size(91, 19);
            this.lbl_telephone.TabIndex = 7;
            this.lbl_telephone.Text = "Téléphone : ";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Depth = 0;
            this.lbl_nom.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_nom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_nom.Location = new System.Drawing.Point(680, 152);
            this.lbl_nom.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(50, 19);
            this.lbl_nom.TabIndex = 5;
            this.lbl_nom.Text = "Nom :";
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Depth = 0;
            this.lbl_prenom.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_prenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_prenom.Location = new System.Drawing.Point(680, 108);
            this.lbl_prenom.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(69, 19);
            this.lbl_prenom.TabIndex = 4;
            this.lbl_prenom.Text = "Prénom :";
            // 
            // tbx_telUtilisateur
            // 
            this.tbx_telUtilisateur.Location = new System.Drawing.Point(793, 246);
            this.tbx_telUtilisateur.Name = "tbx_telUtilisateur";
            this.tbx_telUtilisateur.Size = new System.Drawing.Size(254, 20);
            this.tbx_telUtilisateur.TabIndex = 3;
            // 
            // tbx_nomUtilisateur
            // 
            this.tbx_nomUtilisateur.Location = new System.Drawing.Point(793, 153);
            this.tbx_nomUtilisateur.Name = "tbx_nomUtilisateur";
            this.tbx_nomUtilisateur.Size = new System.Drawing.Size(254, 20);
            this.tbx_nomUtilisateur.TabIndex = 1;
            // 
            // tbx_prenomUtilisateur
            // 
            this.tbx_prenomUtilisateur.Location = new System.Drawing.Point(793, 109);
            this.tbx_prenomUtilisateur.Name = "tbx_prenomUtilisateur";
            this.tbx_prenomUtilisateur.Size = new System.Drawing.Size(254, 20);
            this.tbx_prenomUtilisateur.TabIndex = 0;
            // 
            // tbs_utilisateur
            // 
            this.tbs_utilisateur.BaseTabControl = this.tbc_utilisateur;
            this.tbs_utilisateur.Depth = 0;
            this.tbs_utilisateur.Location = new System.Drawing.Point(0, 63);
            this.tbs_utilisateur.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbs_utilisateur.Name = "tbs_utilisateur";
            this.tbs_utilisateur.Size = new System.Drawing.Size(1285, 23);
            this.tbs_utilisateur.TabIndex = 2;
            // 
            // btn_deconnexion
            // 
            this.btn_deconnexion.Location = new System.Drawing.Point(1187, 33);
            this.btn_deconnexion.Name = "btn_deconnexion";
            this.btn_deconnexion.Size = new System.Drawing.Size(85, 24);
            this.btn_deconnexion.TabIndex = 3;
            this.btn_deconnexion.Text = "Déconnexion";
            this.btn_deconnexion.UseVisualStyleBackColor = true;
            this.btn_deconnexion.Click += new System.EventHandler(this.Btn_deconnexion_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(680, 197);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(54, 19);
            this.materialLabel1.TabIndex = 9;
            this.materialLabel1.Text = "Login :";
            // 
            // tbx_login
            // 
            this.tbx_login.Location = new System.Drawing.Point(793, 198);
            this.tbx_login.Name = "tbx_login";
            this.tbx_login.Size = new System.Drawing.Size(254, 20);
            this.tbx_login.TabIndex = 10;
            // 
            // tbx_nbAccount
            // 
            this.tbx_nbAccount.Location = new System.Drawing.Point(1244, 6);
            this.tbx_nbAccount.Name = "tbx_nbAccount";
            this.tbx_nbAccount.Size = new System.Drawing.Size(30, 20);
            this.tbx_nbAccount.TabIndex = 11;
            this.tbx_nbAccount.Visible = false;
            // 
            // frm_utilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 602);
            this.Controls.Add(this.btn_deconnexion);
            this.Controls.Add(this.tbs_utilisateur);
            this.Controls.Add(this.tbc_utilisateur);
            this.MaximizeBox = false;
            this.Name = "frm_utilisateur";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SafiRepay";
            this.Load += new System.EventHandler(this.Frm_utilisateur_Load);
            this.tbc_utilisateur.ResumeLayout(false);
            this.tbp_accueil.ResumeLayout(false);
            this.tbp_accueil.PerformLayout();
            this.tbp_parametresForfait.ResumeLayout(false);
            this.tbp_parametresForfait.PerformLayout();
            this.tbp_controleFrais.ResumeLayout(false);
            this.tbp_controleFrais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_deplacement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_relaisEtape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_repasMidi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nuitee)).EndInit();
            this.tbp_profil.ResumeLayout(false);
            this.tbp_profil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tbc_utilisateur;
        private System.Windows.Forms.TabPage tbp_accueil;
        private System.Windows.Forms.TabPage tbp_parametresForfait;
        private MaterialSkin.Controls.MaterialTabSelector tbs_utilisateur;
        private System.Windows.Forms.TabPage tbp_controleFrais;
        private System.Windows.Forms.TabPage tbp_profil;
        private System.Windows.Forms.Button btn_deconnexion;
        private System.Windows.Forms.TextBox tbx_kms;
        private System.Windows.Forms.TextBox tbx_overnight;
        private System.Windows.Forms.TextBox tbx_relayStages;
        private System.Windows.Forms.TextBox tbx_middayMeal;
        private MaterialSkin.Controls.MaterialLabel lbl_euroParRepas;
        private MaterialSkin.Controls.MaterialLabel lbl_euroParNuitRelaisEtapes;
        private MaterialSkin.Controls.MaterialLabel lbl_euroParNuitNuitee;
        private MaterialSkin.Controls.MaterialLabel lbl_euroKilometre;
        private MaterialSkin.Controls.MaterialLabel lbl_relaisEtapes;
        private MaterialSkin.Controls.MaterialLabel lbl_nuitee;
        private MaterialSkin.Controls.MaterialLabel lbl_deplacement;
        private MaterialSkin.Controls.MaterialLabel lbl_kilometrage;
        private MaterialSkin.Controls.MaterialLabel lbl_repasMidi;
        private System.Windows.Forms.Button btn_modifyParamsSheet;
        private MaterialSkin.Controls.MaterialLabel lbl_telephone;
        private MaterialSkin.Controls.MaterialLabel lbl_nom;
        private MaterialSkin.Controls.MaterialLabel lbl_prenom;
        private System.Windows.Forms.TextBox tbx_telUtilisateur;
        private System.Windows.Forms.TextBox tbx_nomUtilisateur;
        private System.Windows.Forms.TextBox tbx_prenomUtilisateur;
        private System.Windows.Forms.Button btn_modifierMotDePasseProfil;
        private System.Windows.Forms.DataGridView dgv_deplacement;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_dateDeplacement;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_montantDeplacement;
        private System.Windows.Forms.DataGridView dgv_relaisEtape;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_dateNuitee;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_montantNuitee;
        private System.Windows.Forms.DataGridView dgv_repasMidi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_dateRelaisEtapes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_montantRelaisEtape;
        private System.Windows.Forms.DataGridView dgv_nuitee;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_dateRepasMidi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_montantRepasMidi;
        private MaterialSkin.Controls.MaterialLabel lbl_nbFraisValidesSupprimesDernieresSemaines;
        private System.Windows.Forms.Button btn_supprimerControleDesFrais;
        private System.Windows.Forms.Button btn_validerControleDesFrais;
        private System.Windows.Forms.TextBox tbx_nbJoursEnregistres;
        private System.Windows.Forms.TextBox tbx_nbJoursTravailles;
        private MaterialSkin.Controls.MaterialLabel lbl_nbJoursEnregistres;
        private MaterialSkin.Controls.MaterialLabel lbl_nbJoursTravailles;
        private MaterialSkin.Controls.MaterialLabel lbl_deplacementControleDesFrais;
        private MaterialSkin.Controls.MaterialLabel lbl_nuiteeControleDesFrais;
        private MaterialSkin.Controls.MaterialLabel lbl_RelaisEtapeControleDesFrais;
        private MaterialSkin.Controls.MaterialLabel lbl_repasMidiControleDesFrais;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox tbx_login;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TextBox tbx_nbAccount;
    }
}