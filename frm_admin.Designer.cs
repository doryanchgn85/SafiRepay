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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_admin));
            this.tbc_safiRepay = new MaterialSkin.Controls.MaterialTabControl();
            this.tbp_accueil = new System.Windows.Forms.TabPage();
            this.lbl_fluctuationNbDerniersMois = new System.Windows.Forms.Label();
            this.lbl_nbFraisValideSupprime = new System.Windows.Forms.Label();
            this.pbx_chart1 = new System.Windows.Forms.PictureBox();
            this.pbx_chart = new System.Windows.Forms.PictureBox();
            this.tbp_listeComptes = new System.Windows.Forms.TabPage();
            this.dgv_listeComptes = new System.Windows.Forms.DataGridView();
            this.cln_nomListeComtpes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_prenomListeCompte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_ficheFraisValideesCetteSemaine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbp_modifierCompte = new System.Windows.Forms.TabPage();
            this.cbx_region = new System.Windows.Forms.ComboBox();
            this.btn_creerCompte = new System.Windows.Forms.Button();
            this.btn_modifierCompte = new System.Windows.Forms.Button();
            this.cbx_activeCompte = new MaterialSkin.Controls.MaterialCheckBox();
            this.lbl_activeCompte = new MaterialSkin.Controls.MaterialLabel();
            this.tbx_prenomCompte = new System.Windows.Forms.TextBox();
            this.tbx_nomCompte = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_prenomCompte = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_nomCompte = new MaterialSkin.Controls.MaterialLabel();
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
            this.tbc_safiRepay.SuspendLayout();
            this.tbp_accueil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_chart)).BeginInit();
            this.tbp_listeComptes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeComptes)).BeginInit();
            this.tbp_modifierCompte.SuspendLayout();
            this.tbp_profil.SuspendLayout();
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
            this.tbc_safiRepay.Location = new System.Drawing.Point(-1, 87);
            this.tbc_safiRepay.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbc_safiRepay.Name = "tbc_safiRepay";
            this.tbc_safiRepay.SelectedIndex = 0;
            this.tbc_safiRepay.Size = new System.Drawing.Size(1287, 598);
            this.tbc_safiRepay.TabIndex = 0;
            // 
            // tbp_accueil
            // 
            this.tbp_accueil.Controls.Add(this.lbl_fluctuationNbDerniersMois);
            this.tbp_accueil.Controls.Add(this.lbl_nbFraisValideSupprime);
            this.tbp_accueil.Controls.Add(this.pbx_chart1);
            this.tbp_accueil.Controls.Add(this.pbx_chart);
            this.tbp_accueil.Location = new System.Drawing.Point(4, 22);
            this.tbp_accueil.Name = "tbp_accueil";
            this.tbp_accueil.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_accueil.Size = new System.Drawing.Size(1279, 572);
            this.tbp_accueil.TabIndex = 0;
            this.tbp_accueil.Text = "Acceuil";
            this.tbp_accueil.UseVisualStyleBackColor = true;
            // 
            // lbl_fluctuationNbDerniersMois
            // 
            this.lbl_fluctuationNbDerniersMois.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_fluctuationNbDerniersMois.AutoSize = true;
            this.lbl_fluctuationNbDerniersMois.Location = new System.Drawing.Point(815, 459);
            this.lbl_fluctuationNbDerniersMois.Name = "lbl_fluctuationNbDerniersMois";
            this.lbl_fluctuationNbDerniersMois.Size = new System.Drawing.Size(238, 13);
            this.lbl_fluctuationNbDerniersMois.TabIndex = 3;
            this.lbl_fluctuationNbDerniersMois.Text = "Fluctuation du nombre de frais les 3 derniers mois";
            // 
            // lbl_nbFraisValideSupprime
            // 
            this.lbl_nbFraisValideSupprime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nbFraisValideSupprime.AutoSize = true;
            this.lbl_nbFraisValideSupprime.Location = new System.Drawing.Point(272, 459);
            this.lbl_nbFraisValideSupprime.Name = "lbl_nbFraisValideSupprime";
            this.lbl_nbFraisValideSupprime.Size = new System.Drawing.Size(274, 13);
            this.lbl_nbFraisValideSupprime.TabIndex = 2;
            this.lbl_nbFraisValideSupprime.Text = "Nombre de frais validé / supprimé les dernières semaines";
            // 
            // pbx_chart1
            // 
            this.pbx_chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbx_chart1.Image = ((System.Drawing.Image)(resources.GetObject("pbx_chart1.Image")));
            this.pbx_chart1.Location = new System.Drawing.Point(731, 56);
            this.pbx_chart1.Name = "pbx_chart1";
            this.pbx_chart1.Size = new System.Drawing.Size(400, 300);
            this.pbx_chart1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbx_chart1.TabIndex = 1;
            this.pbx_chart1.TabStop = false;
            // 
            // pbx_chart
            // 
            this.pbx_chart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbx_chart.Image = ((System.Drawing.Image)(resources.GetObject("pbx_chart.Image")));
            this.pbx_chart.Location = new System.Drawing.Point(215, 56);
            this.pbx_chart.Name = "pbx_chart";
            this.pbx_chart.Size = new System.Drawing.Size(400, 300);
            this.pbx_chart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbx_chart.TabIndex = 0;
            this.pbx_chart.TabStop = false;
            // 
            // tbp_listeComptes
            // 
            this.tbp_listeComptes.Controls.Add(this.dgv_listeComptes);
            this.tbp_listeComptes.Location = new System.Drawing.Point(4, 22);
            this.tbp_listeComptes.Name = "tbp_listeComptes";
            this.tbp_listeComptes.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_listeComptes.Size = new System.Drawing.Size(1279, 572);
            this.tbp_listeComptes.TabIndex = 1;
            this.tbp_listeComptes.Text = "Liste des comptes";
            this.tbp_listeComptes.UseVisualStyleBackColor = true;
            // 
            // dgv_listeComptes
            // 
            this.dgv_listeComptes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listeComptes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_nomListeComtpes,
            this.cln_prenomListeCompte,
            this.cln_ficheFraisValideesCetteSemaine});
            this.dgv_listeComptes.Location = new System.Drawing.Point(220, 111);
            this.dgv_listeComptes.Name = "dgv_listeComptes";
            this.dgv_listeComptes.Size = new System.Drawing.Size(744, 221);
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
            // cln_ficheFraisValideesCetteSemaine
            // 
            this.cln_ficheFraisValideesCetteSemaine.HeaderText = "Fiche de frais validées cette semaine";
            this.cln_ficheFraisValideesCetteSemaine.Name = "cln_ficheFraisValideesCetteSemaine";
            this.cln_ficheFraisValideesCetteSemaine.Width = 300;
            // 
            // tbp_modifierCompte
            // 
            this.tbp_modifierCompte.Controls.Add(this.cbx_region);
            this.tbp_modifierCompte.Controls.Add(this.btn_creerCompte);
            this.tbp_modifierCompte.Controls.Add(this.btn_modifierCompte);
            this.tbp_modifierCompte.Controls.Add(this.cbx_activeCompte);
            this.tbp_modifierCompte.Controls.Add(this.lbl_activeCompte);
            this.tbp_modifierCompte.Controls.Add(this.tbx_prenomCompte);
            this.tbp_modifierCompte.Controls.Add(this.tbx_nomCompte);
            this.tbp_modifierCompte.Controls.Add(this.materialLabel1);
            this.tbp_modifierCompte.Controls.Add(this.lbl_prenomCompte);
            this.tbp_modifierCompte.Controls.Add(this.lbl_nomCompte);
            this.tbp_modifierCompte.Location = new System.Drawing.Point(4, 22);
            this.tbp_modifierCompte.Name = "tbp_modifierCompte";
            this.tbp_modifierCompte.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_modifierCompte.Size = new System.Drawing.Size(1279, 572);
            this.tbp_modifierCompte.TabIndex = 2;
            this.tbp_modifierCompte.Text = "Les comptes";
            this.tbp_modifierCompte.UseVisualStyleBackColor = true;
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
            this.cbx_region.Location = new System.Drawing.Point(439, 261);
            this.cbx_region.Name = "cbx_region";
            this.cbx_region.Size = new System.Drawing.Size(221, 21);
            this.cbx_region.TabIndex = 11;
            // 
            // btn_creerCompte
            // 
            this.btn_creerCompte.Location = new System.Drawing.Point(516, 375);
            this.btn_creerCompte.Name = "btn_creerCompte";
            this.btn_creerCompte.Size = new System.Drawing.Size(144, 44);
            this.btn_creerCompte.TabIndex = 10;
            this.btn_creerCompte.Text = "Créer";
            this.btn_creerCompte.UseVisualStyleBackColor = true;
            this.btn_creerCompte.Click += new System.EventHandler(this.Btn_creerCompte_Click);
            // 
            // btn_modifierCompte
            // 
            this.btn_modifierCompte.Location = new System.Drawing.Point(347, 375);
            this.btn_modifierCompte.Name = "btn_modifierCompte";
            this.btn_modifierCompte.Size = new System.Drawing.Size(144, 44);
            this.btn_modifierCompte.TabIndex = 9;
            this.btn_modifierCompte.Text = "Modifier";
            this.btn_modifierCompte.UseVisualStyleBackColor = true;
            this.btn_modifierCompte.Click += new System.EventHandler(this.btn_modifierCompte_Click);
            // 
            // cbx_activeCompte
            // 
            this.cbx_activeCompte.AutoSize = true;
            this.cbx_activeCompte.Depth = 0;
            this.cbx_activeCompte.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbx_activeCompte.ForeColor = System.Drawing.Color.Transparent;
            this.cbx_activeCompte.Location = new System.Drawing.Point(439, 310);
            this.cbx_activeCompte.Margin = new System.Windows.Forms.Padding(0);
            this.cbx_activeCompte.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbx_activeCompte.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbx_activeCompte.Name = "cbx_activeCompte";
            this.cbx_activeCompte.Ripple = true;
            this.cbx_activeCompte.Size = new System.Drawing.Size(26, 30);
            this.cbx_activeCompte.TabIndex = 8;
            this.cbx_activeCompte.UseVisualStyleBackColor = true;
            // 
            // lbl_activeCompte
            // 
            this.lbl_activeCompte.AutoSize = true;
            this.lbl_activeCompte.Depth = 0;
            this.lbl_activeCompte.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_activeCompte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_activeCompte.Location = new System.Drawing.Point(368, 314);
            this.lbl_activeCompte.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_activeCompte.Name = "lbl_activeCompte";
            this.lbl_activeCompte.Size = new System.Drawing.Size(55, 19);
            this.lbl_activeCompte.TabIndex = 7;
            this.lbl_activeCompte.Text = "Activé ";
            // 
            // tbx_prenomCompte
            // 
            this.tbx_prenomCompte.Location = new System.Drawing.Point(439, 175);
            this.tbx_prenomCompte.Name = "tbx_prenomCompte";
            this.tbx_prenomCompte.Size = new System.Drawing.Size(149, 20);
            this.tbx_prenomCompte.TabIndex = 6;
            this.tbx_prenomCompte.TextChanged += new System.EventHandler(this.Tbx_prenomCompte_TextChanged);
            // 
            // tbx_nomCompte
            // 
            this.tbx_nomCompte.Location = new System.Drawing.Point(439, 214);
            this.tbx_nomCompte.Name = "tbx_nomCompte";
            this.tbx_nomCompte.Size = new System.Drawing.Size(149, 20);
            this.tbx_nomCompte.TabIndex = 4;
            this.tbx_nomCompte.TextChanged += new System.EventHandler(this.Tbx_nomCompte_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(368, 261);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(63, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Région :";
            // 
            // lbl_prenomCompte
            // 
            this.lbl_prenomCompte.AutoSize = true;
            this.lbl_prenomCompte.Depth = 0;
            this.lbl_prenomCompte.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_prenomCompte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_prenomCompte.Location = new System.Drawing.Point(368, 174);
            this.lbl_prenomCompte.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_prenomCompte.Name = "lbl_prenomCompte";
            this.lbl_prenomCompte.Size = new System.Drawing.Size(69, 19);
            this.lbl_prenomCompte.TabIndex = 2;
            this.lbl_prenomCompte.Text = "Prénom :";
            // 
            // lbl_nomCompte
            // 
            this.lbl_nomCompte.AutoSize = true;
            this.lbl_nomCompte.Depth = 0;
            this.lbl_nomCompte.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_nomCompte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_nomCompte.Location = new System.Drawing.Point(368, 213);
            this.lbl_nomCompte.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_nomCompte.Name = "lbl_nomCompte";
            this.lbl_nomCompte.Size = new System.Drawing.Size(54, 19);
            this.lbl_nomCompte.TabIndex = 1;
            this.lbl_nomCompte.Text = "Nom : ";
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
            this.tbp_profil.Size = new System.Drawing.Size(1279, 572);
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
            this.tbs_admin.Size = new System.Drawing.Size(1286, 23);
            this.tbs_admin.TabIndex = 1;
            // 
            // btn_deconnexion
            // 
            this.btn_deconnexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deconnexion.Location = new System.Drawing.Point(1189, 34);
            this.btn_deconnexion.Name = "btn_deconnexion";
            this.btn_deconnexion.Size = new System.Drawing.Size(85, 24);
            this.btn_deconnexion.TabIndex = 2;
            this.btn_deconnexion.Text = "Déconnexion";
            this.btn_deconnexion.UseVisualStyleBackColor = true;
            this.btn_deconnexion.Click += new System.EventHandler(this.Btn_deconnexion_Click);
            // 
            // frm_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 684);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbx_chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_chart)).EndInit();
            this.tbp_listeComptes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeComptes)).EndInit();
            this.tbp_modifierCompte.ResumeLayout(false);
            this.tbp_modifierCompte.PerformLayout();
            this.tbp_profil.ResumeLayout(false);
            this.tbp_profil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tbc_safiRepay;
        private System.Windows.Forms.TabPage tbp_accueil;
        private System.Windows.Forms.TabPage tbp_listeComptes;
        private System.Windows.Forms.TabPage tbp_modifierCompte;
        private MaterialSkin.Controls.MaterialTabSelector tbs_admin;
        private System.Windows.Forms.Button btn_deconnexion;
        private System.Windows.Forms.Label lbl_nbFraisValideSupprime;
        private System.Windows.Forms.PictureBox pbx_chart1;
        private System.Windows.Forms.PictureBox pbx_chart;
        private System.Windows.Forms.Label lbl_fluctuationNbDerniersMois;
        private System.Windows.Forms.TextBox tbx_prenomCompte;
        private System.Windows.Forms.TextBox tbx_nomCompte;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lbl_prenomCompte;
        private MaterialSkin.Controls.MaterialLabel lbl_nomCompte;
        private MaterialSkin.Controls.MaterialCheckBox cbx_activeCompte;
        private MaterialSkin.Controls.MaterialLabel lbl_activeCompte;
        private System.Windows.Forms.Button btn_creerCompte;
        private System.Windows.Forms.Button btn_modifierCompte;
        private System.Windows.Forms.TabPage tbp_profil;
        private System.Windows.Forms.DataGridView dgv_listeComptes;
        private System.Windows.Forms.Button btn_modifierMotDePasseAdmin;
        private System.Windows.Forms.TextBox tbx_telProfilAdmin;
        private System.Windows.Forms.TextBox tbx_nomProfilAdmin;
        private System.Windows.Forms.TextBox tbx_prenomProfilAdmin;
        private MaterialSkin.Controls.MaterialLabel lbl_nomProfilAdmin;
        private MaterialSkin.Controls.MaterialLabel lbl_telProfilAdmin;
        private MaterialSkin.Controls.MaterialLabel lbl_prenomProfilAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_nomListeComtpes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_prenomListeCompte;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_ficheFraisValideesCetteSemaine;
        private System.Windows.Forms.ComboBox cbx_region;
    }
}