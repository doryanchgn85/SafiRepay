namespace SafiRepay
{
    partial class frm_admin
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
            this.tbc_safiRepay = new MaterialSkin.Controls.MaterialTabControl();
            this.tbp_accueil = new System.Windows.Forms.TabPage();
            this.lbl_fluctuationNbDerniersMois = new System.Windows.Forms.Label();
            this.tbp_listeComptes = new System.Windows.Forms.TabPage();
            this.dgv_listeComptes = new System.Windows.Forms.DataGridView();
            this.cln_nomListeComtpes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_prenomListeCompte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbp_modifierCompte = new System.Windows.Forms.TabPage();
            this.gbx_rechercheCompte = new System.Windows.Forms.GroupBox();
            this.btn_rechercherCompte = new System.Windows.Forms.Button();
            this.tbx_rechercherCompte = new System.Windows.Forms.TextBox();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.tbx_modifierCompteEmploye = new System.Windows.Forms.Button();
            this.btn_creerCompteEmployee = new System.Windows.Forms.Button();
            this.gbx_creerCompteEmployee = new System.Windows.Forms.GroupBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.tbx_dateEmbaucheAnnee = new System.Windows.Forms.TextBox();
            this.tbx_dateEmbaucheMois = new System.Windows.Forms.TextBox();
            this.tbx_dateEmbaucheJour = new System.Windows.Forms.TextBox();
            this.tbx_telephone = new System.Windows.Forms.TextBox();
            this.tbx_ville = new System.Windows.Forms.TextBox();
            this.tbx_CP = new System.Windows.Forms.TextBox();
            this.tbx_adresse = new System.Windows.Forms.TextBox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.tbx_confirmationMdp = new System.Windows.Forms.TextBox();
            this.tbx_mdp = new System.Windows.Forms.TextBox();
            this.tbx_login = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cbx_region = new System.Windows.Forms.ComboBox();
            this.lbl_nomCompte = new MaterialSkin.Controls.MaterialLabel();
            this.btn_creerCompte = new System.Windows.Forms.Button();
            this.lbl_prenomCompte = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cbx_activeCompte = new MaterialSkin.Controls.MaterialCheckBox();
            this.tbx_nomCompte = new System.Windows.Forms.TextBox();
            this.lbl_activeCompte = new MaterialSkin.Controls.MaterialLabel();
            this.tbx_prenomCompte = new System.Windows.Forms.TextBox();
            this.tbp_profil = new System.Windows.Forms.TabPage();
            this.btn_modifierMotDePasseAdmin = new System.Windows.Forms.Button();
            this.tbx_telProfilAdmin = new System.Windows.Forms.TextBox();
            this.tbx_nomProfilAdmin = new System.Windows.Forms.TextBox();
            this.tbx_prenomProfilAdmin = new System.Windows.Forms.TextBox();
            this.lbl_nomProfilAdmin = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_telProfilAdmin = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_prenomProfilAdmin = new MaterialSkin.Controls.MaterialLabel();
            this.tbs_admin = new MaterialSkin.Controls.MaterialTabSelector();
            this.btn_deconnexion = new System.Windows.Forms.Button();
            this.tbx_ModifierPrenom = new System.Windows.Forms.TextBox();
            this.materialLabel26 = new MaterialSkin.Controls.MaterialLabel();
            this.tbx_ModifierNom = new System.Windows.Forms.TextBox();
            this.cbx_ModifierActivation = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel24 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.materialLabel23 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel22 = new MaterialSkin.Controls.MaterialLabel();
            this.tbx_ModifierLogin = new System.Windows.Forms.TextBox();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.tbx_ModifierAdresse = new System.Windows.Forms.TextBox();
            this.tbx_ModifierCP = new System.Windows.Forms.TextBox();
            this.tbx_ModifierVille = new System.Windows.Forms.TextBox();
            this.tbx_ModifierTel = new System.Windows.Forms.TextBox();
            this.tbx_ModifierDateEmbauche = new System.Windows.Forms.TextBox();
            this.gbx_modifierCompteEmploye = new System.Windows.Forms.GroupBox();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.tbc_safiRepay.SuspendLayout();
            this.tbp_accueil.SuspendLayout();
            this.tbp_listeComptes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeComptes)).BeginInit();
            this.tbp_modifierCompte.SuspendLayout();
            this.gbx_rechercheCompte.SuspendLayout();
            this.gbx_creerCompteEmployee.SuspendLayout();
            this.tbp_profil.SuspendLayout();
            this.gbx_modifierCompteEmploye.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_safiRepay
            // 
            this.tbc_safiRepay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbc_safiRepay.Controls.Add(this.tbp_accueil);
            this.tbc_safiRepay.Controls.Add(this.tbp_listeComptes);
            this.tbc_safiRepay.Controls.Add(this.tbp_modifierCompte);
            this.tbc_safiRepay.Controls.Add(this.tbp_profil);
            this.tbc_safiRepay.Depth = 0;
            this.tbc_safiRepay.Location = new System.Drawing.Point(0, 93);
            this.tbc_safiRepay.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbc_safiRepay.Name = "tbc_safiRepay";
            this.tbc_safiRepay.SelectedIndex = 0;
            this.tbc_safiRepay.Size = new System.Drawing.Size(848, 627);
            this.tbc_safiRepay.TabIndex = 0;
            // 
            // tbp_accueil
            // 
            this.tbp_accueil.Controls.Add(this.lbl_fluctuationNbDerniersMois);
            this.tbp_accueil.Location = new System.Drawing.Point(4, 22);
            this.tbp_accueil.Name = "tbp_accueil";
            this.tbp_accueil.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_accueil.Size = new System.Drawing.Size(840, 601);
            this.tbp_accueil.TabIndex = 0;
            this.tbp_accueil.Text = "Acceuil";
            this.tbp_accueil.UseVisualStyleBackColor = true;
            // 
            // lbl_fluctuationNbDerniersMois
            // 
            this.lbl_fluctuationNbDerniersMois.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_fluctuationNbDerniersMois.AutoSize = true;
            this.lbl_fluctuationNbDerniersMois.Location = new System.Drawing.Point(8, 3);
            this.lbl_fluctuationNbDerniersMois.Name = "lbl_fluctuationNbDerniersMois";
            this.lbl_fluctuationNbDerniersMois.Size = new System.Drawing.Size(58, 13);
            this.lbl_fluctuationNbDerniersMois.TabIndex = 3;
            this.lbl_fluctuationNbDerniersMois.Text = "Bienvenue";
            // 
            // tbp_listeComptes
            // 
            this.tbp_listeComptes.Controls.Add(this.dgv_listeComptes);
            this.tbp_listeComptes.Location = new System.Drawing.Point(4, 22);
            this.tbp_listeComptes.Name = "tbp_listeComptes";
            this.tbp_listeComptes.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_listeComptes.Size = new System.Drawing.Size(840, 601);
            this.tbp_listeComptes.TabIndex = 1;
            this.tbp_listeComptes.Text = "Liste des comptes";
            this.tbp_listeComptes.UseVisualStyleBackColor = true;
            this.tbp_listeComptes.Click += new System.EventHandler(this.tbp_listeComptes_Click);
            // 
            // dgv_listeComptes
            // 
            this.dgv_listeComptes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listeComptes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_nomListeComtpes,
            this.cln_prenomListeCompte});
            this.dgv_listeComptes.Location = new System.Drawing.Point(138, 87);
            this.dgv_listeComptes.Name = "dgv_listeComptes";
            this.dgv_listeComptes.Size = new System.Drawing.Size(452, 221);
            this.dgv_listeComptes.TabIndex = 0;
            this.dgv_listeComptes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listeComptes_CellContentClick);
            // 
            // cln_nomListeComtpes
            // 
            this.cln_nomListeComtpes.HeaderText = "Nom";
            this.cln_nomListeComtpes.Name = "cln_nomListeComtpes";
            this.cln_nomListeComtpes.Width = 200;
            // 
            // cln_prenomListeCompte
            // 
            this.cln_prenomListeCompte.HeaderText = "Prénom";
            this.cln_prenomListeCompte.Name = "cln_prenomListeCompte";
            this.cln_prenomListeCompte.Width = 200;
            // 
            // tbp_modifierCompte
            // 
            this.tbp_modifierCompte.Controls.Add(this.gbx_modifierCompteEmploye);
            this.tbp_modifierCompte.Controls.Add(this.gbx_rechercheCompte);
            this.tbp_modifierCompte.Controls.Add(this.tbx_modifierCompteEmploye);
            this.tbp_modifierCompte.Controls.Add(this.btn_creerCompteEmployee);
            this.tbp_modifierCompte.Controls.Add(this.gbx_creerCompteEmployee);
            this.tbp_modifierCompte.Location = new System.Drawing.Point(4, 22);
            this.tbp_modifierCompte.Name = "tbp_modifierCompte";
            this.tbp_modifierCompte.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_modifierCompte.Size = new System.Drawing.Size(840, 601);
            this.tbp_modifierCompte.TabIndex = 2;
            this.tbp_modifierCompte.Text = "Les comptes";
            this.tbp_modifierCompte.UseVisualStyleBackColor = true;
            this.tbp_modifierCompte.Click += new System.EventHandler(this.tbp_modifierCompte_Click);
            // 
            // gbx_rechercheCompte
            // 
            this.gbx_rechercheCompte.Controls.Add(this.materialLabel13);
            this.gbx_rechercheCompte.Controls.Add(this.btn_rechercherCompte);
            this.gbx_rechercheCompte.Controls.Add(this.tbx_rechercherCompte);
            this.gbx_rechercheCompte.Controls.Add(this.materialLabel12);
            this.gbx_rechercheCompte.Location = new System.Drawing.Point(8, 195);
            this.gbx_rechercheCompte.Name = "gbx_rechercheCompte";
            this.gbx_rechercheCompte.Size = new System.Drawing.Size(230, 181);
            this.gbx_rechercheCompte.TabIndex = 14;
            this.gbx_rechercheCompte.TabStop = false;
            this.gbx_rechercheCompte.Text = "Rechercher un compte à modifier";
            this.gbx_rechercheCompte.Visible = false;
            // 
            // btn_rechercherCompte
            // 
            this.btn_rechercherCompte.Location = new System.Drawing.Point(25, 141);
            this.btn_rechercherCompte.Name = "btn_rechercherCompte";
            this.btn_rechercherCompte.Size = new System.Drawing.Size(179, 26);
            this.btn_rechercherCompte.TabIndex = 32;
            this.btn_rechercherCompte.Text = "RECHERCHER";
            this.btn_rechercherCompte.UseVisualStyleBackColor = true;
            this.btn_rechercherCompte.Click += new System.EventHandler(this.btn_rechercherCompte_Click);
            // 
            // tbx_rechercherCompte
            // 
            this.tbx_rechercherCompte.Location = new System.Drawing.Point(25, 89);
            this.tbx_rechercherCompte.Name = "tbx_rechercherCompte";
            this.tbx_rechercherCompte.Size = new System.Drawing.Size(179, 20);
            this.tbx_rechercherCompte.TabIndex = 32;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(21, 38);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(183, 19);
            this.materialLabel12.TabIndex = 32;
            this.materialLabel12.Text = "Rechercher le compte de :";
            // 
            // tbx_modifierCompteEmploye
            // 
            this.tbx_modifierCompteEmploye.Location = new System.Drawing.Point(8, 94);
            this.tbx_modifierCompteEmploye.Name = "tbx_modifierCompteEmploye";
            this.tbx_modifierCompteEmploye.Size = new System.Drawing.Size(230, 80);
            this.tbx_modifierCompteEmploye.TabIndex = 13;
            this.tbx_modifierCompteEmploye.Text = "MODIFIER UN COMPTE";
            this.tbx_modifierCompteEmploye.UseVisualStyleBackColor = true;
            this.tbx_modifierCompteEmploye.Click += new System.EventHandler(this.tbx_modifierCompteEmploye_Click);
            // 
            // btn_creerCompteEmployee
            // 
            this.btn_creerCompteEmployee.Location = new System.Drawing.Point(8, 8);
            this.btn_creerCompteEmployee.Name = "btn_creerCompteEmployee";
            this.btn_creerCompteEmployee.Size = new System.Drawing.Size(230, 80);
            this.btn_creerCompteEmployee.TabIndex = 12;
            this.btn_creerCompteEmployee.Text = "CRÉER UN COMPTE";
            this.btn_creerCompteEmployee.UseVisualStyleBackColor = true;
            this.btn_creerCompteEmployee.Click += new System.EventHandler(this.btn_creerCompteEmployee_Click);
            // 
            // gbx_creerCompteEmployee
            // 
            this.gbx_creerCompteEmployee.Controls.Add(this.materialLabel11);
            this.gbx_creerCompteEmployee.Controls.Add(this.materialLabel10);
            this.gbx_creerCompteEmployee.Controls.Add(this.tbx_dateEmbaucheAnnee);
            this.gbx_creerCompteEmployee.Controls.Add(this.tbx_dateEmbaucheMois);
            this.gbx_creerCompteEmployee.Controls.Add(this.tbx_dateEmbaucheJour);
            this.gbx_creerCompteEmployee.Controls.Add(this.tbx_telephone);
            this.gbx_creerCompteEmployee.Controls.Add(this.tbx_ville);
            this.gbx_creerCompteEmployee.Controls.Add(this.tbx_CP);
            this.gbx_creerCompteEmployee.Controls.Add(this.tbx_adresse);
            this.gbx_creerCompteEmployee.Controls.Add(this.materialLabel9);
            this.gbx_creerCompteEmployee.Controls.Add(this.materialLabel8);
            this.gbx_creerCompteEmployee.Controls.Add(this.materialLabel7);
            this.gbx_creerCompteEmployee.Controls.Add(this.materialLabel6);
            this.gbx_creerCompteEmployee.Controls.Add(this.materialLabel5);
            this.gbx_creerCompteEmployee.Controls.Add(this.tbx_confirmationMdp);
            this.gbx_creerCompteEmployee.Controls.Add(this.tbx_mdp);
            this.gbx_creerCompteEmployee.Controls.Add(this.tbx_login);
            this.gbx_creerCompteEmployee.Controls.Add(this.materialLabel4);
            this.gbx_creerCompteEmployee.Controls.Add(this.materialLabel3);
            this.gbx_creerCompteEmployee.Controls.Add(this.materialLabel2);
            this.gbx_creerCompteEmployee.Controls.Add(this.cbx_region);
            this.gbx_creerCompteEmployee.Controls.Add(this.lbl_nomCompte);
            this.gbx_creerCompteEmployee.Controls.Add(this.btn_creerCompte);
            this.gbx_creerCompteEmployee.Controls.Add(this.lbl_prenomCompte);
            this.gbx_creerCompteEmployee.Controls.Add(this.materialLabel1);
            this.gbx_creerCompteEmployee.Controls.Add(this.cbx_activeCompte);
            this.gbx_creerCompteEmployee.Controls.Add(this.tbx_nomCompte);
            this.gbx_creerCompteEmployee.Controls.Add(this.lbl_activeCompte);
            this.gbx_creerCompteEmployee.Controls.Add(this.tbx_prenomCompte);
            this.gbx_creerCompteEmployee.Location = new System.Drawing.Point(244, 6);
            this.gbx_creerCompteEmployee.Name = "gbx_creerCompteEmployee";
            this.gbx_creerCompteEmployee.Size = new System.Drawing.Size(590, 589);
            this.gbx_creerCompteEmployee.TabIndex = 12;
            this.gbx_creerCompteEmployee.TabStop = false;
            this.gbx_creerCompteEmployee.Text = "Créer un compte employée";
            this.gbx_creerCompteEmployee.Visible = false;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(233, 352);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(15, 19);
            this.materialLabel11.TabIndex = 31;
            this.materialLabel11.Text = "/";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(187, 353);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(15, 19);
            this.materialLabel10.TabIndex = 30;
            this.materialLabel10.Text = "/";
            this.materialLabel10.Click += new System.EventHandler(this.materialLabel10_Click);
            // 
            // tbx_dateEmbaucheAnnee
            // 
            this.tbx_dateEmbaucheAnnee.Location = new System.Drawing.Point(252, 352);
            this.tbx_dateEmbaucheAnnee.Name = "tbx_dateEmbaucheAnnee";
            this.tbx_dateEmbaucheAnnee.Size = new System.Drawing.Size(45, 20);
            this.tbx_dateEmbaucheAnnee.TabIndex = 29;
            // 
            // tbx_dateEmbaucheMois
            // 
            this.tbx_dateEmbaucheMois.Location = new System.Drawing.Point(203, 352);
            this.tbx_dateEmbaucheMois.Name = "tbx_dateEmbaucheMois";
            this.tbx_dateEmbaucheMois.Size = new System.Drawing.Size(27, 20);
            this.tbx_dateEmbaucheMois.TabIndex = 28;
            // 
            // tbx_dateEmbaucheJour
            // 
            this.tbx_dateEmbaucheJour.Location = new System.Drawing.Point(160, 352);
            this.tbx_dateEmbaucheJour.Name = "tbx_dateEmbaucheJour";
            this.tbx_dateEmbaucheJour.Size = new System.Drawing.Size(27, 20);
            this.tbx_dateEmbaucheJour.TabIndex = 27;
            // 
            // tbx_telephone
            // 
            this.tbx_telephone.Location = new System.Drawing.Point(115, 314);
            this.tbx_telephone.Name = "tbx_telephone";
            this.tbx_telephone.Size = new System.Drawing.Size(149, 20);
            this.tbx_telephone.TabIndex = 26;
            // 
            // tbx_ville
            // 
            this.tbx_ville.Location = new System.Drawing.Point(100, 280);
            this.tbx_ville.Name = "tbx_ville";
            this.tbx_ville.Size = new System.Drawing.Size(149, 20);
            this.tbx_ville.TabIndex = 25;
            // 
            // tbx_CP
            // 
            this.tbx_CP.Location = new System.Drawing.Point(100, 245);
            this.tbx_CP.Name = "tbx_CP";
            this.tbx_CP.Size = new System.Drawing.Size(149, 20);
            this.tbx_CP.TabIndex = 24;
            // 
            // tbx_adresse
            // 
            this.tbx_adresse.Location = new System.Drawing.Point(100, 212);
            this.tbx_adresse.Name = "tbx_adresse";
            this.tbx_adresse.Size = new System.Drawing.Size(149, 20);
            this.tbx_adresse.TabIndex = 23;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(22, 351);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(132, 19);
            this.materialLabel9.TabIndex = 22;
            this.materialLabel9.Text = "Date d\'embauche :";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(22, 313);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(87, 19);
            this.materialLabel8.TabIndex = 21;
            this.materialLabel8.Text = "Téléphone :";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(22, 279);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(47, 19);
            this.materialLabel7.TabIndex = 20;
            this.materialLabel7.Text = "Ville :";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(22, 244);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(36, 19);
            this.materialLabel6.TabIndex = 19;
            this.materialLabel6.Text = "CP :";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(22, 211);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(72, 19);
            this.materialLabel5.TabIndex = 18;
            this.materialLabel5.Text = "Adresse :";
            // 
            // tbx_confirmationMdp
            // 
            this.tbx_confirmationMdp.Location = new System.Drawing.Point(252, 171);
            this.tbx_confirmationMdp.Name = "tbx_confirmationMdp";
            this.tbx_confirmationMdp.Size = new System.Drawing.Size(149, 20);
            this.tbx_confirmationMdp.TabIndex = 17;
            // 
            // tbx_mdp
            // 
            this.tbx_mdp.Location = new System.Drawing.Point(140, 137);
            this.tbx_mdp.Name = "tbx_mdp";
            this.tbx_mdp.Size = new System.Drawing.Size(149, 20);
            this.tbx_mdp.TabIndex = 16;
            // 
            // tbx_login
            // 
            this.tbx_login.Location = new System.Drawing.Point(93, 100);
            this.tbx_login.Name = "tbx_login";
            this.tbx_login.Size = new System.Drawing.Size(149, 20);
            this.tbx_login.TabIndex = 15;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(22, 170);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(224, 19);
            this.materialLabel4.TabIndex = 14;
            this.materialLabel4.Text = "Confirmation du mot de passe : ";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(22, 136);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(112, 19);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "Mot de passe : ";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(22, 99);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(58, 19);
            this.materialLabel2.TabIndex = 12;
            this.materialLabel2.Text = "Login : ";
            // 
            // cbx_region
            // 
            this.cbx_region.FormattingEnabled = true;
            this.cbx_region.Items.AddRange(new object[] {
            "Ile de France",
            "Centre Val de Loire",
            "Bretagne",
            "Pays de la Loire",
            "Normandie",
            "Hauts de France",
            "Grand Est",
            "Bourgogne Franche Comté",
            "Nouvelle Aquitaine",
            "Occitanie",
            "Auvergne Rhone Alpes",
            "Provence Alpes Cote d\'Azur",
            "Corse",
            "Mayotte",
            "La Reunion",
            "Guyane",
            "Guadeloupe",
            "Martinique"});
            this.cbx_region.Location = new System.Drawing.Point(93, 392);
            this.cbx_region.Name = "cbx_region";
            this.cbx_region.Size = new System.Drawing.Size(221, 21);
            this.cbx_region.TabIndex = 11;
            // 
            // lbl_nomCompte
            // 
            this.lbl_nomCompte.AutoSize = true;
            this.lbl_nomCompte.Depth = 0;
            this.lbl_nomCompte.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_nomCompte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_nomCompte.Location = new System.Drawing.Point(22, 61);
            this.lbl_nomCompte.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_nomCompte.Name = "lbl_nomCompte";
            this.lbl_nomCompte.Size = new System.Drawing.Size(54, 19);
            this.lbl_nomCompte.TabIndex = 1;
            this.lbl_nomCompte.Text = "Nom : ";
            // 
            // btn_creerCompte
            // 
            this.btn_creerCompte.Location = new System.Drawing.Point(436, 518);
            this.btn_creerCompte.Name = "btn_creerCompte";
            this.btn_creerCompte.Size = new System.Drawing.Size(148, 65);
            this.btn_creerCompte.TabIndex = 10;
            this.btn_creerCompte.Text = "CRÉER";
            this.btn_creerCompte.UseVisualStyleBackColor = true;
            this.btn_creerCompte.Click += new System.EventHandler(this.Btn_creerCompte_Click);
            // 
            // lbl_prenomCompte
            // 
            this.lbl_prenomCompte.AutoSize = true;
            this.lbl_prenomCompte.Depth = 0;
            this.lbl_prenomCompte.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_prenomCompte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_prenomCompte.Location = new System.Drawing.Point(22, 22);
            this.lbl_prenomCompte.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_prenomCompte.Name = "lbl_prenomCompte";
            this.lbl_prenomCompte.Size = new System.Drawing.Size(69, 19);
            this.lbl_prenomCompte.TabIndex = 2;
            this.lbl_prenomCompte.Text = "Prénom :";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(22, 392);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(63, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Région :";
            // 
            // cbx_activeCompte
            // 
            this.cbx_activeCompte.AutoSize = true;
            this.cbx_activeCompte.Depth = 0;
            this.cbx_activeCompte.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbx_activeCompte.ForeColor = System.Drawing.Color.Transparent;
            this.cbx_activeCompte.Location = new System.Drawing.Point(93, 497);
            this.cbx_activeCompte.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_activeCompte.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbx_activeCompte.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbx_activeCompte.Name = "cbx_activeCompte";
            this.cbx_activeCompte.Ripple = true;
            this.cbx_activeCompte.Size = new System.Drawing.Size(26, 30);
            this.cbx_activeCompte.TabIndex = 8;
            this.cbx_activeCompte.UseVisualStyleBackColor = true;
            // 
            // tbx_nomCompte
            // 
            this.tbx_nomCompte.Location = new System.Drawing.Point(93, 62);
            this.tbx_nomCompte.Name = "tbx_nomCompte";
            this.tbx_nomCompte.Size = new System.Drawing.Size(149, 20);
            this.tbx_nomCompte.TabIndex = 4;
            this.tbx_nomCompte.TextChanged += new System.EventHandler(this.Tbx_nomCompte_TextChanged);
            // 
            // lbl_activeCompte
            // 
            this.lbl_activeCompte.AutoSize = true;
            this.lbl_activeCompte.Depth = 0;
            this.lbl_activeCompte.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_activeCompte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_activeCompte.Location = new System.Drawing.Point(22, 501);
            this.lbl_activeCompte.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_activeCompte.Name = "lbl_activeCompte";
            this.lbl_activeCompte.Size = new System.Drawing.Size(55, 19);
            this.lbl_activeCompte.TabIndex = 7;
            this.lbl_activeCompte.Text = "Activé ";
            // 
            // tbx_prenomCompte
            // 
            this.tbx_prenomCompte.Location = new System.Drawing.Point(93, 23);
            this.tbx_prenomCompte.Name = "tbx_prenomCompte";
            this.tbx_prenomCompte.Size = new System.Drawing.Size(149, 20);
            this.tbx_prenomCompte.TabIndex = 6;
            this.tbx_prenomCompte.TextChanged += new System.EventHandler(this.Tbx_prenomCompte_TextChanged);
            // 
            // tbp_profil
            // 
            this.tbp_profil.Controls.Add(this.btn_modifierMotDePasseAdmin);
            this.tbp_profil.Controls.Add(this.tbx_telProfilAdmin);
            this.tbp_profil.Controls.Add(this.tbx_nomProfilAdmin);
            this.tbp_profil.Controls.Add(this.tbx_prenomProfilAdmin);
            this.tbp_profil.Controls.Add(this.lbl_nomProfilAdmin);
            this.tbp_profil.Controls.Add(this.lbl_telProfilAdmin);
            this.tbp_profil.Controls.Add(this.lbl_prenomProfilAdmin);
            this.tbp_profil.Location = new System.Drawing.Point(4, 22);
            this.tbp_profil.Name = "tbp_profil";
            this.tbp_profil.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_profil.Size = new System.Drawing.Size(840, 601);
            this.tbp_profil.TabIndex = 3;
            this.tbp_profil.Text = "Profil";
            this.tbp_profil.UseVisualStyleBackColor = true;
            // 
            // btn_modifierMotDePasseAdmin
            // 
            this.btn_modifierMotDePasseAdmin.Location = new System.Drawing.Point(908, 388);
            this.btn_modifierMotDePasseAdmin.Name = "btn_modifierMotDePasseAdmin";
            this.btn_modifierMotDePasseAdmin.Size = new System.Drawing.Size(229, 82);
            this.btn_modifierMotDePasseAdmin.TabIndex = 8;
            this.btn_modifierMotDePasseAdmin.Text = "MODIFIER MON MOT DE PASSE";
            this.btn_modifierMotDePasseAdmin.UseVisualStyleBackColor = true;
            this.btn_modifierMotDePasseAdmin.Click += new System.EventHandler(this.Btn_modifierMotDePasseAdmin_Click);
            // 
            // tbx_telProfilAdmin
            // 
            this.tbx_telProfilAdmin.Location = new System.Drawing.Point(908, 228);
            this.tbx_telProfilAdmin.Name = "tbx_telProfilAdmin";
            this.tbx_telProfilAdmin.Size = new System.Drawing.Size(229, 20);
            this.tbx_telProfilAdmin.TabIndex = 7;
            // 
            // tbx_nomProfilAdmin
            // 
            this.tbx_nomProfilAdmin.Location = new System.Drawing.Point(908, 154);
            this.tbx_nomProfilAdmin.Name = "tbx_nomProfilAdmin";
            this.tbx_nomProfilAdmin.Size = new System.Drawing.Size(229, 20);
            this.tbx_nomProfilAdmin.TabIndex = 5;
            // 
            // tbx_prenomProfilAdmin
            // 
            this.tbx_prenomProfilAdmin.Location = new System.Drawing.Point(908, 83);
            this.tbx_prenomProfilAdmin.Name = "tbx_prenomProfilAdmin";
            this.tbx_prenomProfilAdmin.Size = new System.Drawing.Size(229, 20);
            this.tbx_prenomProfilAdmin.TabIndex = 4;
            // 
            // lbl_nomProfilAdmin
            // 
            this.lbl_nomProfilAdmin.AutoSize = true;
            this.lbl_nomProfilAdmin.Depth = 0;
            this.lbl_nomProfilAdmin.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_nomProfilAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_nomProfilAdmin.Location = new System.Drawing.Point(789, 153);
            this.lbl_nomProfilAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_nomProfilAdmin.Name = "lbl_nomProfilAdmin";
            this.lbl_nomProfilAdmin.Size = new System.Drawing.Size(50, 19);
            this.lbl_nomProfilAdmin.TabIndex = 3;
            this.lbl_nomProfilAdmin.Text = "Nom :";
            // 
            // lbl_telProfilAdmin
            // 
            this.lbl_telProfilAdmin.AutoSize = true;
            this.lbl_telProfilAdmin.Depth = 0;
            this.lbl_telProfilAdmin.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_telProfilAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_telProfilAdmin.Location = new System.Drawing.Point(789, 227);
            this.lbl_telProfilAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_telProfilAdmin.Name = "lbl_telProfilAdmin";
            this.lbl_telProfilAdmin.Size = new System.Drawing.Size(87, 19);
            this.lbl_telProfilAdmin.TabIndex = 1;
            this.lbl_telProfilAdmin.Text = "Téléphone :";
            // 
            // lbl_prenomProfilAdmin
            // 
            this.lbl_prenomProfilAdmin.AutoSize = true;
            this.lbl_prenomProfilAdmin.Depth = 0;
            this.lbl_prenomProfilAdmin.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_prenomProfilAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_prenomProfilAdmin.Location = new System.Drawing.Point(789, 82);
            this.lbl_prenomProfilAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_prenomProfilAdmin.Name = "lbl_prenomProfilAdmin";
            this.lbl_prenomProfilAdmin.Size = new System.Drawing.Size(69, 19);
            this.lbl_prenomProfilAdmin.TabIndex = 0;
            this.lbl_prenomProfilAdmin.Text = "Prénom :";
            // 
            // tbs_admin
            // 
            this.tbs_admin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbs_admin.BaseTabControl = this.tbc_safiRepay;
            this.tbs_admin.Depth = 0;
            this.tbs_admin.Location = new System.Drawing.Point(0, 64);
            this.tbs_admin.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbs_admin.Name = "tbs_admin";
            this.tbs_admin.Size = new System.Drawing.Size(860, 23);
            this.tbs_admin.TabIndex = 1;
            // 
            // btn_deconnexion
            // 
            this.btn_deconnexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deconnexion.Location = new System.Drawing.Point(763, 34);
            this.btn_deconnexion.Name = "btn_deconnexion";
            this.btn_deconnexion.Size = new System.Drawing.Size(85, 24);
            this.btn_deconnexion.TabIndex = 2;
            this.btn_deconnexion.Text = "Déconnexion";
            this.btn_deconnexion.UseVisualStyleBackColor = true;
            this.btn_deconnexion.Click += new System.EventHandler(this.Btn_deconnexion_Click);
            // 
            // tbx_ModifierPrenom
            // 
            this.tbx_ModifierPrenom.Location = new System.Drawing.Point(93, 23);
            this.tbx_ModifierPrenom.Name = "tbx_ModifierPrenom";
            this.tbx_ModifierPrenom.Size = new System.Drawing.Size(149, 20);
            this.tbx_ModifierPrenom.TabIndex = 6;
            // 
            // materialLabel26
            // 
            this.materialLabel26.AutoSize = true;
            this.materialLabel26.Depth = 0;
            this.materialLabel26.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel26.Location = new System.Drawing.Point(22, 324);
            this.materialLabel26.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel26.Name = "materialLabel26";
            this.materialLabel26.Size = new System.Drawing.Size(55, 19);
            this.materialLabel26.TabIndex = 7;
            this.materialLabel26.Text = "Activé ";
            // 
            // tbx_ModifierNom
            // 
            this.tbx_ModifierNom.Location = new System.Drawing.Point(93, 62);
            this.tbx_ModifierNom.Name = "tbx_ModifierNom";
            this.tbx_ModifierNom.Size = new System.Drawing.Size(149, 20);
            this.tbx_ModifierNom.TabIndex = 4;
            // 
            // cbx_ModifierActivation
            // 
            this.cbx_ModifierActivation.AutoSize = true;
            this.cbx_ModifierActivation.Depth = 0;
            this.cbx_ModifierActivation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbx_ModifierActivation.ForeColor = System.Drawing.Color.Transparent;
            this.cbx_ModifierActivation.Location = new System.Drawing.Point(86, 320);
            this.cbx_ModifierActivation.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_ModifierActivation.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbx_ModifierActivation.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbx_ModifierActivation.Name = "cbx_ModifierActivation";
            this.cbx_ModifierActivation.Ripple = true;
            this.cbx_ModifierActivation.Size = new System.Drawing.Size(26, 30);
            this.cbx_ModifierActivation.TabIndex = 8;
            this.cbx_ModifierActivation.UseVisualStyleBackColor = true;
            // 
            // materialLabel24
            // 
            this.materialLabel24.AutoSize = true;
            this.materialLabel24.Depth = 0;
            this.materialLabel24.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel24.Location = new System.Drawing.Point(22, 22);
            this.materialLabel24.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel24.Name = "materialLabel24";
            this.materialLabel24.Size = new System.Drawing.Size(69, 19);
            this.materialLabel24.TabIndex = 2;
            this.materialLabel24.Text = "Prénom :";
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(289, 382);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(148, 65);
            this.btn_modifier.TabIndex = 10;
            this.btn_modifier.Text = "MODIFIER";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // materialLabel23
            // 
            this.materialLabel23.AutoSize = true;
            this.materialLabel23.Depth = 0;
            this.materialLabel23.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel23.Location = new System.Drawing.Point(22, 61);
            this.materialLabel23.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel23.Name = "materialLabel23";
            this.materialLabel23.Size = new System.Drawing.Size(54, 19);
            this.materialLabel23.TabIndex = 1;
            this.materialLabel23.Text = "Nom : ";
            // 
            // materialLabel22
            // 
            this.materialLabel22.AutoSize = true;
            this.materialLabel22.Depth = 0;
            this.materialLabel22.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel22.Location = new System.Drawing.Point(22, 99);
            this.materialLabel22.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel22.Name = "materialLabel22";
            this.materialLabel22.Size = new System.Drawing.Size(58, 19);
            this.materialLabel22.TabIndex = 12;
            this.materialLabel22.Text = "Login : ";
            // 
            // tbx_ModifierLogin
            // 
            this.tbx_ModifierLogin.Location = new System.Drawing.Point(93, 100);
            this.tbx_ModifierLogin.Name = "tbx_ModifierLogin";
            this.tbx_ModifierLogin.Size = new System.Drawing.Size(149, 20);
            this.tbx_ModifierLogin.TabIndex = 15;
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel19.Location = new System.Drawing.Point(22, 137);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(72, 19);
            this.materialLabel19.TabIndex = 18;
            this.materialLabel19.Text = "Adresse :";
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel18.Location = new System.Drawing.Point(22, 170);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(99, 19);
            this.materialLabel18.TabIndex = 19;
            this.materialLabel18.Text = "Code Postal :";
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(22, 205);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(47, 19);
            this.materialLabel17.TabIndex = 20;
            this.materialLabel17.Text = "Ville :";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(22, 239);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(87, 19);
            this.materialLabel16.TabIndex = 21;
            this.materialLabel16.Text = "Téléphone :";
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(22, 277);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(132, 19);
            this.materialLabel15.TabIndex = 22;
            this.materialLabel15.Text = "Date d\'embauche :";
            // 
            // tbx_ModifierAdresse
            // 
            this.tbx_ModifierAdresse.Location = new System.Drawing.Point(100, 138);
            this.tbx_ModifierAdresse.Name = "tbx_ModifierAdresse";
            this.tbx_ModifierAdresse.Size = new System.Drawing.Size(149, 20);
            this.tbx_ModifierAdresse.TabIndex = 23;
            // 
            // tbx_ModifierCP
            // 
            this.tbx_ModifierCP.Location = new System.Drawing.Point(127, 171);
            this.tbx_ModifierCP.Name = "tbx_ModifierCP";
            this.tbx_ModifierCP.Size = new System.Drawing.Size(149, 20);
            this.tbx_ModifierCP.TabIndex = 24;
            // 
            // tbx_ModifierVille
            // 
            this.tbx_ModifierVille.Location = new System.Drawing.Point(100, 206);
            this.tbx_ModifierVille.Name = "tbx_ModifierVille";
            this.tbx_ModifierVille.Size = new System.Drawing.Size(149, 20);
            this.tbx_ModifierVille.TabIndex = 25;
            // 
            // tbx_ModifierTel
            // 
            this.tbx_ModifierTel.Location = new System.Drawing.Point(115, 240);
            this.tbx_ModifierTel.Name = "tbx_ModifierTel";
            this.tbx_ModifierTel.Size = new System.Drawing.Size(149, 20);
            this.tbx_ModifierTel.TabIndex = 26;
            // 
            // tbx_ModifierDateEmbauche
            // 
            this.tbx_ModifierDateEmbauche.Location = new System.Drawing.Point(160, 278);
            this.tbx_ModifierDateEmbauche.Name = "tbx_ModifierDateEmbauche";
            this.tbx_ModifierDateEmbauche.Size = new System.Drawing.Size(137, 20);
            this.tbx_ModifierDateEmbauche.TabIndex = 29;
            // 
            // gbx_modifierCompteEmploye
            // 
            this.gbx_modifierCompteEmploye.Controls.Add(this.tbx_ModifierDateEmbauche);
            this.gbx_modifierCompteEmploye.Controls.Add(this.tbx_ModifierTel);
            this.gbx_modifierCompteEmploye.Controls.Add(this.tbx_ModifierVille);
            this.gbx_modifierCompteEmploye.Controls.Add(this.tbx_ModifierCP);
            this.gbx_modifierCompteEmploye.Controls.Add(this.tbx_ModifierAdresse);
            this.gbx_modifierCompteEmploye.Controls.Add(this.materialLabel15);
            this.gbx_modifierCompteEmploye.Controls.Add(this.materialLabel16);
            this.gbx_modifierCompteEmploye.Controls.Add(this.materialLabel17);
            this.gbx_modifierCompteEmploye.Controls.Add(this.materialLabel18);
            this.gbx_modifierCompteEmploye.Controls.Add(this.materialLabel19);
            this.gbx_modifierCompteEmploye.Controls.Add(this.tbx_ModifierLogin);
            this.gbx_modifierCompteEmploye.Controls.Add(this.materialLabel22);
            this.gbx_modifierCompteEmploye.Controls.Add(this.materialLabel23);
            this.gbx_modifierCompteEmploye.Controls.Add(this.btn_modifier);
            this.gbx_modifierCompteEmploye.Controls.Add(this.materialLabel24);
            this.gbx_modifierCompteEmploye.Controls.Add(this.cbx_ModifierActivation);
            this.gbx_modifierCompteEmploye.Controls.Add(this.tbx_ModifierNom);
            this.gbx_modifierCompteEmploye.Controls.Add(this.materialLabel26);
            this.gbx_modifierCompteEmploye.Controls.Add(this.tbx_ModifierPrenom);
            this.gbx_modifierCompteEmploye.Location = new System.Drawing.Point(244, 8);
            this.gbx_modifierCompteEmploye.Name = "gbx_modifierCompteEmploye";
            this.gbx_modifierCompteEmploye.Size = new System.Drawing.Size(443, 453);
            this.gbx_modifierCompteEmploye.TabIndex = 32;
            this.gbx_modifierCompteEmploye.TabStop = false;
            this.gbx_modifierCompteEmploye.Text = "Modifier un compte employé";
            this.gbx_modifierCompteEmploye.Visible = false;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(90, 63);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(35, 13);
            this.materialLabel13.TabIndex = 33;
            this.materialLabel13.Text = "(login)";
            // 
            // frm_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 732);
            this.Controls.Add(this.btn_deconnexion);
            this.Controls.Add(this.tbs_admin);
            this.Controls.Add(this.tbc_safiRepay);
            this.MaximizeBox = false;
            this.Name = "frm_admin";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SafiRepay";
            this.Load += new System.EventHandler(this.Frm_admin_Load);
            this.tbc_safiRepay.ResumeLayout(false);
            this.tbp_accueil.ResumeLayout(false);
            this.tbp_accueil.PerformLayout();
            this.tbp_listeComptes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeComptes)).EndInit();
            this.tbp_modifierCompte.ResumeLayout(false);
            this.gbx_rechercheCompte.ResumeLayout(false);
            this.gbx_rechercheCompte.PerformLayout();
            this.gbx_creerCompteEmployee.ResumeLayout(false);
            this.gbx_creerCompteEmployee.PerformLayout();
            this.tbp_profil.ResumeLayout(false);
            this.tbp_profil.PerformLayout();
            this.gbx_modifierCompteEmploye.ResumeLayout(false);
            this.gbx_modifierCompteEmploye.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tbc_safiRepay;
        private System.Windows.Forms.TabPage tbp_accueil;
        private System.Windows.Forms.TabPage tbp_listeComptes;
        private System.Windows.Forms.TabPage tbp_modifierCompte;
        private MaterialSkin.Controls.MaterialTabSelector tbs_admin;
        private System.Windows.Forms.Button btn_deconnexion;
        private System.Windows.Forms.Label lbl_fluctuationNbDerniersMois;
        private System.Windows.Forms.TextBox tbx_prenomCompte;
        private System.Windows.Forms.TextBox tbx_nomCompte;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lbl_prenomCompte;
        private MaterialSkin.Controls.MaterialLabel lbl_nomCompte;
        private MaterialSkin.Controls.MaterialCheckBox cbx_activeCompte;
        private MaterialSkin.Controls.MaterialLabel lbl_activeCompte;
        private System.Windows.Forms.Button btn_creerCompte;
        private System.Windows.Forms.TabPage tbp_profil;
        private System.Windows.Forms.DataGridView dgv_listeComptes;
        private System.Windows.Forms.Button btn_modifierMotDePasseAdmin;
        private System.Windows.Forms.TextBox tbx_telProfilAdmin;
        private System.Windows.Forms.TextBox tbx_nomProfilAdmin;
        private System.Windows.Forms.TextBox tbx_prenomProfilAdmin;
        private MaterialSkin.Controls.MaterialLabel lbl_nomProfilAdmin;
        private MaterialSkin.Controls.MaterialLabel lbl_telProfilAdmin;
        private MaterialSkin.Controls.MaterialLabel lbl_prenomProfilAdmin;
        private System.Windows.Forms.ComboBox cbx_region;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_nomListeComtpes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_prenomListeCompte;
        private System.Windows.Forms.Button btn_creerCompteEmployee;
        private System.Windows.Forms.GroupBox gbx_creerCompteEmployee;
        private System.Windows.Forms.TextBox tbx_confirmationMdp;
        private System.Windows.Forms.TextBox tbx_mdp;
        private System.Windows.Forms.TextBox tbx_login;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.TextBox tbx_telephone;
        private System.Windows.Forms.TextBox tbx_ville;
        private System.Windows.Forms.TextBox tbx_CP;
        private System.Windows.Forms.TextBox tbx_adresse;
        private System.Windows.Forms.TextBox tbx_dateEmbaucheJour;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private System.Windows.Forms.TextBox tbx_dateEmbaucheAnnee;
        private System.Windows.Forms.TextBox tbx_dateEmbaucheMois;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private System.Windows.Forms.Button tbx_modifierCompteEmploye;
        private System.Windows.Forms.GroupBox gbx_rechercheCompte;
        private System.Windows.Forms.TextBox tbx_rechercherCompte;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private System.Windows.Forms.Button btn_rechercherCompte;
        private System.Windows.Forms.GroupBox gbx_modifierCompteEmploye;
        private System.Windows.Forms.TextBox tbx_ModifierDateEmbauche;
        private System.Windows.Forms.TextBox tbx_ModifierTel;
        private System.Windows.Forms.TextBox tbx_ModifierVille;
        private System.Windows.Forms.TextBox tbx_ModifierCP;
        private System.Windows.Forms.TextBox tbx_ModifierAdresse;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private System.Windows.Forms.TextBox tbx_ModifierLogin;
        private MaterialSkin.Controls.MaterialLabel materialLabel22;
        private MaterialSkin.Controls.MaterialLabel materialLabel23;
        private System.Windows.Forms.Button btn_modifier;
        private MaterialSkin.Controls.MaterialLabel materialLabel24;
        private MaterialSkin.Controls.MaterialCheckBox cbx_ModifierActivation;
        private System.Windows.Forms.TextBox tbx_ModifierNom;
        private MaterialSkin.Controls.MaterialLabel materialLabel26;
        private System.Windows.Forms.TextBox tbx_ModifierPrenom;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
    }
}