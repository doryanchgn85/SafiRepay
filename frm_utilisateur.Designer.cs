﻿namespace SafiRepay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_utilisateur));
            this.btn_deconnexion = new System.Windows.Forms.Button();
            this.tbs_user = new MaterialSkin.Controls.MaterialTabSelector();
            this.tbc_user = new MaterialSkin.Controls.MaterialTabControl();
            this.tbp_dashboard = new System.Windows.Forms.TabPage();
            this.pbx_logoSafi = new System.Windows.Forms.PictureBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.tbp_sheet = new System.Windows.Forms.TabPage();
            this.tbx_newKms = new System.Windows.Forms.TextBox();
            this.tbx_newOvernight = new System.Windows.Forms.TextBox();
            this.tbx_newRelayStage = new System.Windows.Forms.TextBox();
            this.tbx_newMiddayMeal = new System.Windows.Forms.TextBox();
            this.cbx_dateSheet = new System.Windows.Forms.ComboBox();
            this.btn_confirmDate = new System.Windows.Forms.Button();
            this.lbl_month = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_newText = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
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
            this.lbl_repasMidi = new MaterialSkin.Controls.MaterialLabel();
            this.tbp_profil = new System.Windows.Forms.TabPage();
            this.tbx_nbAccount = new System.Windows.Forms.TextBox();
            this.tbx_phoneUser = new System.Windows.Forms.TextBox();
            this.tbx_loginUser = new System.Windows.Forms.TextBox();
            this.tbx_lastnameUser = new System.Windows.Forms.TextBox();
            this.tbx_firstnameUser = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.tbc_user.SuspendLayout();
            this.tbp_dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logoSafi)).BeginInit();
            this.tbp_sheet.SuspendLayout();
            this.tbp_profil.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_deconnexion
            // 
            this.btn_deconnexion.Location = new System.Drawing.Point(843, 28);
            this.btn_deconnexion.Name = "btn_deconnexion";
            this.btn_deconnexion.Size = new System.Drawing.Size(85, 24);
            this.btn_deconnexion.TabIndex = 3;
            this.btn_deconnexion.Text = "Déconnexion";
            this.btn_deconnexion.UseVisualStyleBackColor = true;
            this.btn_deconnexion.Click += new System.EventHandler(this.Btn_deconnexion_Click);
            // 
            // tbs_user
            // 
            this.tbs_user.BaseTabControl = this.tbc_user;
            this.tbs_user.Depth = 0;
            this.tbs_user.Location = new System.Drawing.Point(0, 52);
            this.tbs_user.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbs_user.Name = "tbs_user";
            this.tbs_user.Size = new System.Drawing.Size(941, 23);
            this.tbs_user.TabIndex = 4;
            // 
            // tbc_user
            // 
            this.tbc_user.Controls.Add(this.tbp_dashboard);
            this.tbc_user.Controls.Add(this.tbp_sheet);
            this.tbc_user.Controls.Add(this.tbp_profil);
            this.tbc_user.Depth = 0;
            this.tbc_user.Location = new System.Drawing.Point(0, 90);
            this.tbc_user.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbc_user.Name = "tbc_user";
            this.tbc_user.SelectedIndex = 0;
            this.tbc_user.Size = new System.Drawing.Size(941, 509);
            this.tbc_user.TabIndex = 5;
            // 
            // tbp_dashboard
            // 
            this.tbp_dashboard.Controls.Add(this.pbx_logoSafi);
            this.tbp_dashboard.Controls.Add(this.materialLabel5);
            this.tbp_dashboard.Location = new System.Drawing.Point(4, 22);
            this.tbp_dashboard.Name = "tbp_dashboard";
            this.tbp_dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_dashboard.Size = new System.Drawing.Size(933, 483);
            this.tbp_dashboard.TabIndex = 0;
            this.tbp_dashboard.Text = "Accueil";
            this.tbp_dashboard.UseVisualStyleBackColor = true;
            // 
            // pbx_logoSafi
            // 
            this.pbx_logoSafi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbx_logoSafi.Image = ((System.Drawing.Image)(resources.GetObject("pbx_logoSafi.Image")));
            this.pbx_logoSafi.Location = new System.Drawing.Point(410, 25);
            this.pbx_logoSafi.Name = "pbx_logoSafi";
            this.pbx_logoSafi.Size = new System.Drawing.Size(93, 104);
            this.pbx_logoSafi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbx_logoSafi.TabIndex = 6;
            this.pbx_logoSafi.TabStop = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(351, 3);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(204, 19);
            this.materialLabel5.TabIndex = 18;
            this.materialLabel5.Text = "BIENVENUE SUR SAFIREPAY";
            // 
            // tbp_sheet
            // 
            this.tbp_sheet.Controls.Add(this.tbx_newKms);
            this.tbp_sheet.Controls.Add(this.tbx_newOvernight);
            this.tbp_sheet.Controls.Add(this.tbx_newRelayStage);
            this.tbp_sheet.Controls.Add(this.tbx_newMiddayMeal);
            this.tbp_sheet.Controls.Add(this.cbx_dateSheet);
            this.tbp_sheet.Controls.Add(this.btn_confirmDate);
            this.tbp_sheet.Controls.Add(this.lbl_month);
            this.tbp_sheet.Controls.Add(this.materialLabel7);
            this.tbp_sheet.Controls.Add(this.lbl_newText);
            this.tbp_sheet.Controls.Add(this.materialLabel6);
            this.tbp_sheet.Controls.Add(this.btn_Cancel);
            this.tbp_sheet.Controls.Add(this.btn_Confirm);
            this.tbp_sheet.Controls.Add(this.btn_modifyParamsSheet);
            this.tbp_sheet.Controls.Add(this.tbx_kms);
            this.tbp_sheet.Controls.Add(this.tbx_overnight);
            this.tbp_sheet.Controls.Add(this.tbx_relayStages);
            this.tbp_sheet.Controls.Add(this.tbx_middayMeal);
            this.tbp_sheet.Controls.Add(this.lbl_euroParRepas);
            this.tbp_sheet.Controls.Add(this.lbl_euroParNuitRelaisEtapes);
            this.tbp_sheet.Controls.Add(this.lbl_euroParNuitNuitee);
            this.tbp_sheet.Controls.Add(this.lbl_euroKilometre);
            this.tbp_sheet.Controls.Add(this.lbl_relaisEtapes);
            this.tbp_sheet.Controls.Add(this.lbl_nuitee);
            this.tbp_sheet.Controls.Add(this.lbl_deplacement);
            this.tbp_sheet.Controls.Add(this.lbl_repasMidi);
            this.tbp_sheet.Location = new System.Drawing.Point(4, 22);
            this.tbp_sheet.Name = "tbp_sheet";
            this.tbp_sheet.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_sheet.Size = new System.Drawing.Size(933, 483);
            this.tbp_sheet.TabIndex = 1;
            this.tbp_sheet.Text = "Les forfaits";
            this.tbp_sheet.UseVisualStyleBackColor = true;
            // 
            // tbx_newKms
            // 
            this.tbx_newKms.Location = new System.Drawing.Point(553, 212);
            this.tbx_newKms.Name = "tbx_newKms";
            this.tbx_newKms.Size = new System.Drawing.Size(94, 20);
            this.tbx_newKms.TabIndex = 49;
            this.tbx_newKms.Text = "0";
            this.tbx_newKms.Visible = false;
            this.tbx_newKms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_newKms_KeyPress);
            // 
            // tbx_newOvernight
            // 
            this.tbx_newOvernight.Location = new System.Drawing.Point(553, 173);
            this.tbx_newOvernight.Name = "tbx_newOvernight";
            this.tbx_newOvernight.Size = new System.Drawing.Size(94, 20);
            this.tbx_newOvernight.TabIndex = 48;
            this.tbx_newOvernight.Text = "0";
            this.tbx_newOvernight.Visible = false;
            this.tbx_newOvernight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_newKms_KeyPress);
            // 
            // tbx_newRelayStage
            // 
            this.tbx_newRelayStage.Location = new System.Drawing.Point(553, 135);
            this.tbx_newRelayStage.Name = "tbx_newRelayStage";
            this.tbx_newRelayStage.Size = new System.Drawing.Size(94, 20);
            this.tbx_newRelayStage.TabIndex = 47;
            this.tbx_newRelayStage.Text = "0";
            this.tbx_newRelayStage.Visible = false;
            this.tbx_newRelayStage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_newKms_KeyPress);
            // 
            // tbx_newMiddayMeal
            // 
            this.tbx_newMiddayMeal.Location = new System.Drawing.Point(553, 100);
            this.tbx_newMiddayMeal.Name = "tbx_newMiddayMeal";
            this.tbx_newMiddayMeal.Size = new System.Drawing.Size(94, 20);
            this.tbx_newMiddayMeal.TabIndex = 46;
            this.tbx_newMiddayMeal.Text = "0";
            this.tbx_newMiddayMeal.Visible = false;
            this.tbx_newMiddayMeal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_newKms_KeyPress);
            // 
            // cbx_dateSheet
            // 
            this.cbx_dateSheet.FormattingEnabled = true;
            this.cbx_dateSheet.Items.AddRange(new object[] {
            "2020-03-01",
            "2020-04-01",
            "2020-05-01",
            "2020-06-01",
            "2020-07-01",
            "2020-08-01",
            "2020-09-01",
            "2020-10-01",
            "2020-11-01",
            "2020-12-01"});
            this.cbx_dateSheet.Location = new System.Drawing.Point(422, 22);
            this.cbx_dateSheet.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_dateSheet.Name = "cbx_dateSheet";
            this.cbx_dateSheet.Size = new System.Drawing.Size(92, 21);
            this.cbx_dateSheet.TabIndex = 41;
            // 
            // btn_confirmDate
            // 
            this.btn_confirmDate.Location = new System.Drawing.Point(522, 15);
            this.btn_confirmDate.Name = "btn_confirmDate";
            this.btn_confirmDate.Size = new System.Drawing.Size(87, 32);
            this.btn_confirmDate.TabIndex = 40;
            this.btn_confirmDate.Text = "Valider date";
            this.btn_confirmDate.UseVisualStyleBackColor = true;
            this.btn_confirmDate.Click += new System.EventHandler(this.btn_confirmDate_Click);
            // 
            // lbl_month
            // 
            this.lbl_month.AutoSize = true;
            this.lbl_month.Depth = 0;
            this.lbl_month.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_month.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_month.Location = new System.Drawing.Point(536, 23);
            this.lbl_month.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_month.Name = "lbl_month";
            this.lbl_month.Size = new System.Drawing.Size(0, 19);
            this.lbl_month.TabIndex = 39;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(236, 23);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(161, 19);
            this.materialLabel7.TabIndex = 38;
            this.materialLabel7.Text = "Données du forfait de :";
            // 
            // lbl_newText
            // 
            this.lbl_newText.AutoSize = true;
            this.lbl_newText.Depth = 0;
            this.lbl_newText.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_newText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_newText.Location = new System.Drawing.Point(549, 78);
            this.lbl_newText.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_newText.Name = "lbl_newText";
            this.lbl_newText.Size = new System.Drawing.Size(112, 19);
            this.lbl_newText.TabIndex = 37;
            this.lbl_newText.Text = "Nouvelle saisie";
            this.lbl_newText.Visible = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(426, 78);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(82, 19);
            this.materialLabel6.TabIndex = 36;
            this.materialLabel6.Text = "Total mois";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Red;
            this.btn_Cancel.Location = new System.Drawing.Point(615, 338);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(38, 39);
            this.btn_Cancel.TabIndex = 31;
            this.btn_Cancel.Text = "&X";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Visible = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.Color.Green;
            this.btn_Confirm.Location = new System.Drawing.Point(571, 338);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(38, 39);
            this.btn_Confirm.TabIndex = 30;
            this.btn_Confirm.Text = "&V";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Visible = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_modifyParamsSheet
            // 
            this.btn_modifyParamsSheet.Location = new System.Drawing.Point(403, 332);
            this.btn_modifyParamsSheet.Name = "btn_modifyParamsSheet";
            this.btn_modifyParamsSheet.Size = new System.Drawing.Size(131, 51);
            this.btn_modifyParamsSheet.TabIndex = 29;
            this.btn_modifyParamsSheet.Text = "Modifier";
            this.btn_modifyParamsSheet.UseVisualStyleBackColor = true;
            this.btn_modifyParamsSheet.Click += new System.EventHandler(this.btn_modifyParamsSheet_Click);
            // 
            // tbx_kms
            // 
            this.tbx_kms.Enabled = false;
            this.tbx_kms.Location = new System.Drawing.Point(425, 212);
            this.tbx_kms.Name = "tbx_kms";
            this.tbx_kms.Size = new System.Drawing.Size(94, 20);
            this.tbx_kms.TabIndex = 28;
            // 
            // tbx_overnight
            // 
            this.tbx_overnight.Enabled = false;
            this.tbx_overnight.Location = new System.Drawing.Point(425, 173);
            this.tbx_overnight.Name = "tbx_overnight";
            this.tbx_overnight.Size = new System.Drawing.Size(94, 20);
            this.tbx_overnight.TabIndex = 27;
            // 
            // tbx_relayStages
            // 
            this.tbx_relayStages.Enabled = false;
            this.tbx_relayStages.Location = new System.Drawing.Point(425, 135);
            this.tbx_relayStages.Name = "tbx_relayStages";
            this.tbx_relayStages.Size = new System.Drawing.Size(94, 20);
            this.tbx_relayStages.TabIndex = 26;
            // 
            // tbx_middayMeal
            // 
            this.tbx_middayMeal.Enabled = false;
            this.tbx_middayMeal.Location = new System.Drawing.Point(425, 100);
            this.tbx_middayMeal.Name = "tbx_middayMeal";
            this.tbx_middayMeal.Size = new System.Drawing.Size(94, 20);
            this.tbx_middayMeal.TabIndex = 25;
            // 
            // lbl_euroParRepas
            // 
            this.lbl_euroParRepas.AutoSize = true;
            this.lbl_euroParRepas.Depth = 0;
            this.lbl_euroParRepas.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_euroParRepas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_euroParRepas.Location = new System.Drawing.Point(665, 99);
            this.lbl_euroParRepas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_euroParRepas.Name = "lbl_euroParRepas";
            this.lbl_euroParRepas.Size = new System.Drawing.Size(60, 19);
            this.lbl_euroParRepas.TabIndex = 24;
            this.lbl_euroParRepas.Text = "€/repas";
            // 
            // lbl_euroParNuitRelaisEtapes
            // 
            this.lbl_euroParNuitRelaisEtapes.AutoSize = true;
            this.lbl_euroParNuitRelaisEtapes.Depth = 0;
            this.lbl_euroParNuitRelaisEtapes.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_euroParNuitRelaisEtapes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_euroParNuitRelaisEtapes.Location = new System.Drawing.Point(665, 134);
            this.lbl_euroParNuitRelaisEtapes.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_euroParNuitRelaisEtapes.Name = "lbl_euroParNuitRelaisEtapes";
            this.lbl_euroParNuitRelaisEtapes.Size = new System.Drawing.Size(48, 19);
            this.lbl_euroParNuitRelaisEtapes.TabIndex = 23;
            this.lbl_euroParNuitRelaisEtapes.Text = "€/nuit";
            // 
            // lbl_euroParNuitNuitee
            // 
            this.lbl_euroParNuitNuitee.AutoSize = true;
            this.lbl_euroParNuitNuitee.Depth = 0;
            this.lbl_euroParNuitNuitee.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_euroParNuitNuitee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_euroParNuitNuitee.Location = new System.Drawing.Point(665, 172);
            this.lbl_euroParNuitNuitee.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_euroParNuitNuitee.Name = "lbl_euroParNuitNuitee";
            this.lbl_euroParNuitNuitee.Size = new System.Drawing.Size(48, 19);
            this.lbl_euroParNuitNuitee.TabIndex = 22;
            this.lbl_euroParNuitNuitee.Text = "€/nuit";
            // 
            // lbl_euroKilometre
            // 
            this.lbl_euroKilometre.AutoSize = true;
            this.lbl_euroKilometre.Depth = 0;
            this.lbl_euroKilometre.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_euroKilometre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_euroKilometre.Location = new System.Drawing.Point(665, 211);
            this.lbl_euroKilometre.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_euroKilometre.Name = "lbl_euroKilometre";
            this.lbl_euroKilometre.Size = new System.Drawing.Size(17, 19);
            this.lbl_euroKilometre.TabIndex = 21;
            this.lbl_euroKilometre.Text = "€";
            // 
            // lbl_relaisEtapes
            // 
            this.lbl_relaisEtapes.AutoSize = true;
            this.lbl_relaisEtapes.Depth = 0;
            this.lbl_relaisEtapes.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_relaisEtapes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_relaisEtapes.Location = new System.Drawing.Point(207, 134);
            this.lbl_relaisEtapes.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_relaisEtapes.Name = "lbl_relaisEtapes";
            this.lbl_relaisEtapes.Size = new System.Drawing.Size(204, 19);
            this.lbl_relaisEtapes.TabIndex = 20;
            this.lbl_relaisEtapes.Text = "Relais étapes (nuit et repas) :";
            // 
            // lbl_nuitee
            // 
            this.lbl_nuitee.AutoSize = true;
            this.lbl_nuitee.Depth = 0;
            this.lbl_nuitee.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_nuitee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_nuitee.Location = new System.Drawing.Point(207, 172);
            this.lbl_nuitee.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_nuitee.Name = "lbl_nuitee";
            this.lbl_nuitee.Size = new System.Drawing.Size(141, 19);
            this.lbl_nuitee.TabIndex = 19;
            this.lbl_nuitee.Text = "Nuitée (hôtel seul) :";
            // 
            // lbl_deplacement
            // 
            this.lbl_deplacement.AutoSize = true;
            this.lbl_deplacement.Depth = 0;
            this.lbl_deplacement.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_deplacement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_deplacement.Location = new System.Drawing.Point(207, 211);
            this.lbl_deplacement.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_deplacement.Name = "lbl_deplacement";
            this.lbl_deplacement.Size = new System.Drawing.Size(105, 19);
            this.lbl_deplacement.TabIndex = 18;
            this.lbl_deplacement.Text = "Déplacement :";
            // 
            // lbl_repasMidi
            // 
            this.lbl_repasMidi.AutoSize = true;
            this.lbl_repasMidi.Depth = 0;
            this.lbl_repasMidi.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_repasMidi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_repasMidi.Location = new System.Drawing.Point(207, 99);
            this.lbl_repasMidi.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_repasMidi.Name = "lbl_repasMidi";
            this.lbl_repasMidi.Size = new System.Drawing.Size(91, 19);
            this.lbl_repasMidi.TabIndex = 17;
            this.lbl_repasMidi.Text = "Repas midi :";
            // 
            // tbp_profil
            // 
            this.tbp_profil.Controls.Add(this.tbx_nbAccount);
            this.tbp_profil.Controls.Add(this.tbx_phoneUser);
            this.tbp_profil.Controls.Add(this.tbx_loginUser);
            this.tbp_profil.Controls.Add(this.tbx_lastnameUser);
            this.tbp_profil.Controls.Add(this.tbx_firstnameUser);
            this.tbp_profil.Controls.Add(this.materialLabel1);
            this.tbp_profil.Controls.Add(this.materialLabel2);
            this.tbp_profil.Controls.Add(this.materialLabel3);
            this.tbp_profil.Controls.Add(this.materialLabel4);
            this.tbp_profil.Location = new System.Drawing.Point(4, 22);
            this.tbp_profil.Name = "tbp_profil";
            this.tbp_profil.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_profil.Size = new System.Drawing.Size(933, 483);
            this.tbp_profil.TabIndex = 2;
            this.tbp_profil.Text = "Mon profil";
            this.tbp_profil.UseVisualStyleBackColor = true;
            // 
            // tbx_nbAccount
            // 
            this.tbx_nbAccount.Location = new System.Drawing.Point(904, 4);
            this.tbx_nbAccount.Name = "tbx_nbAccount";
            this.tbx_nbAccount.Size = new System.Drawing.Size(26, 20);
            this.tbx_nbAccount.TabIndex = 37;
            // 
            // tbx_phoneUser
            // 
            this.tbx_phoneUser.Enabled = false;
            this.tbx_phoneUser.Location = new System.Drawing.Point(445, 223);
            this.tbx_phoneUser.Name = "tbx_phoneUser";
            this.tbx_phoneUser.Size = new System.Drawing.Size(212, 20);
            this.tbx_phoneUser.TabIndex = 36;
            // 
            // tbx_loginUser
            // 
            this.tbx_loginUser.Enabled = false;
            this.tbx_loginUser.Location = new System.Drawing.Point(445, 184);
            this.tbx_loginUser.Name = "tbx_loginUser";
            this.tbx_loginUser.Size = new System.Drawing.Size(212, 20);
            this.tbx_loginUser.TabIndex = 35;
            // 
            // tbx_lastnameUser
            // 
            this.tbx_lastnameUser.Enabled = false;
            this.tbx_lastnameUser.Location = new System.Drawing.Point(445, 146);
            this.tbx_lastnameUser.Name = "tbx_lastnameUser";
            this.tbx_lastnameUser.Size = new System.Drawing.Size(212, 20);
            this.tbx_lastnameUser.TabIndex = 34;
            // 
            // tbx_firstnameUser
            // 
            this.tbx_firstnameUser.Enabled = false;
            this.tbx_firstnameUser.Location = new System.Drawing.Point(445, 111);
            this.tbx_firstnameUser.Name = "tbx_firstnameUser";
            this.tbx_firstnameUser.Size = new System.Drawing.Size(212, 20);
            this.tbx_firstnameUser.TabIndex = 33;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(264, 145);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 19);
            this.materialLabel1.TabIndex = 32;
            this.materialLabel1.Text = "Nom :";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(264, 183);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(54, 19);
            this.materialLabel2.TabIndex = 31;
            this.materialLabel2.Text = "Login :";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(264, 222);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(161, 19);
            this.materialLabel3.TabIndex = 30;
            this.materialLabel3.Text = "Numéro de téléphone :";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(264, 110);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(69, 19);
            this.materialLabel4.TabIndex = 29;
            this.materialLabel4.Text = "Prénom :";
            // 
            // frm_utilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 602);
            this.Controls.Add(this.tbc_user);
            this.Controls.Add(this.tbs_user);
            this.Controls.Add(this.btn_deconnexion);
            this.MaximizeBox = false;
            this.Name = "frm_utilisateur";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SafiRepay";
            this.Load += new System.EventHandler(this.Frm_utilisateur_Load);
            this.tbc_user.ResumeLayout(false);
            this.tbp_dashboard.ResumeLayout(false);
            this.tbp_dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logoSafi)).EndInit();
            this.tbp_sheet.ResumeLayout(false);
            this.tbp_sheet.PerformLayout();
            this.tbp_profil.ResumeLayout(false);
            this.tbp_profil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_deconnexion;
        private MaterialSkin.Controls.MaterialTabSelector tbs_user;
        private MaterialSkin.Controls.MaterialTabControl tbc_user;
        private System.Windows.Forms.TabPage tbp_dashboard;
        private System.Windows.Forms.TabPage tbp_sheet;
        private System.Windows.Forms.TabPage tbp_profil;
        private System.Windows.Forms.TextBox tbx_phoneUser;
        private System.Windows.Forms.TextBox tbx_loginUser;
        private System.Windows.Forms.TextBox tbx_lastnameUser;
        private System.Windows.Forms.TextBox tbx_firstnameUser;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TextBox tbx_nbAccount;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel lbl_month;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.Button btn_confirmDate;
        private System.Windows.Forms.ComboBox cbx_dateSheet;
        private MaterialSkin.Controls.MaterialLabel lbl_newText;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_modifyParamsSheet;
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
        private MaterialSkin.Controls.MaterialLabel lbl_repasMidi;
        private System.Windows.Forms.PictureBox pbx_logoSafi;
        private System.Windows.Forms.TextBox tbx_newKms;
        private System.Windows.Forms.TextBox tbx_newOvernight;
        private System.Windows.Forms.TextBox tbx_newRelayStage;
        private System.Windows.Forms.TextBox tbx_newMiddayMeal;
    }
}