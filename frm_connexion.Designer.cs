namespace SafiRepay
{
    partial class frm_connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_connexion));
            this.pbx_logoSafi = new System.Windows.Forms.PictureBox();
            this.lkl_mdpOublie = new System.Windows.Forms.LinkLabel();
            this.tbx_identifiant = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbx_motDePasse = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_connection = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbl_identifiant = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_motDePasse = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logoSafi)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_logoSafi
            // 
            this.pbx_logoSafi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbx_logoSafi.Image = ((System.Drawing.Image)(resources.GetObject("pbx_logoSafi.Image")));
            this.pbx_logoSafi.Location = new System.Drawing.Point(208, 124);
            this.pbx_logoSafi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbx_logoSafi.Name = "pbx_logoSafi";
            this.pbx_logoSafi.Size = new System.Drawing.Size(93, 104);
            this.pbx_logoSafi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbx_logoSafi.TabIndex = 0;
            this.pbx_logoSafi.TabStop = false;
            // 
            // lkl_mdpOublie
            // 
            this.lkl_mdpOublie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lkl_mdpOublie.AutoSize = true;
            this.lkl_mdpOublie.BackColor = System.Drawing.Color.Transparent;
            this.lkl_mdpOublie.Location = new System.Drawing.Point(204, 438);
            this.lkl_mdpOublie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lkl_mdpOublie.Name = "lkl_mdpOublie";
            this.lkl_mdpOublie.Size = new System.Drawing.Size(140, 16);
            this.lkl_mdpOublie.TabIndex = 3;
            this.lkl_mdpOublie.TabStop = true;
            this.lkl_mdpOublie.Text = "Mot de passe oublié ?";
            this.lkl_mdpOublie.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lkl_mdpOublie_LinkClicked);
            // 
            // tbx_identifiant
            // 
            this.tbx_identifiant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_identifiant.Depth = 0;
            this.tbx_identifiant.Hint = "";
            this.tbx_identifiant.Location = new System.Drawing.Point(145, 306);
            this.tbx_identifiant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_identifiant.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbx_identifiant.Name = "tbx_identifiant";
            this.tbx_identifiant.PasswordChar = '\0';
            this.tbx_identifiant.SelectedText = "";
            this.tbx_identifiant.SelectionLength = 0;
            this.tbx_identifiant.SelectionStart = 0;
            this.tbx_identifiant.Size = new System.Drawing.Size(268, 23);
            this.tbx_identifiant.TabIndex = 0;
            this.tbx_identifiant.UseSystemPasswordChar = false;
            // 
            // tbx_motDePasse
            // 
            this.tbx_motDePasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbx_motDePasse.Depth = 0;
            this.tbx_motDePasse.Hint = "";
            this.tbx_motDePasse.Location = new System.Drawing.Point(145, 367);
            this.tbx_motDePasse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_motDePasse.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbx_motDePasse.Name = "tbx_motDePasse";
            this.tbx_motDePasse.PasswordChar = '*';
            this.tbx_motDePasse.SelectedText = "";
            this.tbx_motDePasse.SelectionLength = 0;
            this.tbx_motDePasse.SelectionStart = 0;
            this.tbx_motDePasse.Size = new System.Drawing.Size(268, 23);
            this.tbx_motDePasse.TabIndex = 1;
            this.tbx_motDePasse.UseSystemPasswordChar = false;
            // 
            // btn_connection
            // 
            this.btn_connection.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_connection.Depth = 0;
            this.btn_connection.Location = new System.Drawing.Point(145, 521);
            this.btn_connection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_connection.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_connection.Name = "btn_connection";
            this.btn_connection.Primary = true;
            this.btn_connection.Size = new System.Drawing.Size(268, 49);
            this.btn_connection.TabIndex = 2;
            this.btn_connection.Text = "Se connecter";
            this.btn_connection.UseVisualStyleBackColor = true;
            this.btn_connection.Click += new System.EventHandler(this.Btn_connection_Click);
            // 
            // lbl_identifiant
            // 
            this.lbl_identifiant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_identifiant.AutoSize = true;
            this.lbl_identifiant.BackColor = System.Drawing.Color.Transparent;
            this.lbl_identifiant.Depth = 0;
            this.lbl_identifiant.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_identifiant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_identifiant.Location = new System.Drawing.Point(140, 283);
            this.lbl_identifiant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_identifiant.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_identifiant.Name = "lbl_identifiant";
            this.lbl_identifiant.Size = new System.Drawing.Size(84, 19);
            this.lbl_identifiant.TabIndex = 5;
            this.lbl_identifiant.Text = "Identifiant :";
            // 
            // lbl_motDePasse
            // 
            this.lbl_motDePasse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_motDePasse.AutoSize = true;
            this.lbl_motDePasse.BackColor = System.Drawing.Color.Transparent;
            this.lbl_motDePasse.Depth = 0;
            this.lbl_motDePasse.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_motDePasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_motDePasse.Location = new System.Drawing.Point(140, 342);
            this.lbl_motDePasse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_motDePasse.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_motDePasse.Name = "lbl_motDePasse";
            this.lbl_motDePasse.Size = new System.Drawing.Size(108, 19);
            this.lbl_motDePasse.TabIndex = 4;
            this.lbl_motDePasse.Text = "Mot de passe :";
            // 
            // frm_connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 626);
            this.Controls.Add(this.lbl_motDePasse);
            this.Controls.Add(this.lbl_identifiant);
            this.Controls.Add(this.btn_connection);
            this.Controls.Add(this.tbx_motDePasse);
            this.Controls.Add(this.tbx_identifiant);
            this.Controls.Add(this.lkl_mdpOublie);
            this.Controls.Add(this.pbx_logoSafi);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frm_connexion";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SafiRepay - Connexion";
            this.Load += new System.EventHandler(this.Frm_connexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logoSafi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_logoSafi;
        private System.Windows.Forms.LinkLabel lkl_mdpOublie;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbx_identifiant;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbx_motDePasse;
        private MaterialSkin.Controls.MaterialRaisedButton btn_connection;
        private MaterialSkin.Controls.MaterialLabel lbl_identifiant;
        private MaterialSkin.Controls.MaterialLabel lbl_motDePasse;
    }
}

