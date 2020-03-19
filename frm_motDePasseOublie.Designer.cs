namespace SafiRepay
{
    partial class frm_motDePasseOublie
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
            this.lbl_resignerAdresseMail = new MaterialSkin.Controls.MaterialLabel();
            this.tbx_reinitialiserMotDePasse = new System.Windows.Forms.TextBox();
            this.btn_validerReinitialiserMotDePasse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_resignerAdresseMail
            // 
            this.lbl_resignerAdresseMail.AutoSize = true;
            this.lbl_resignerAdresseMail.BackColor = System.Drawing.Color.Transparent;
            this.lbl_resignerAdresseMail.Depth = 0;
            this.lbl_resignerAdresseMail.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_resignerAdresseMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_resignerAdresseMail.Location = new System.Drawing.Point(27, 90);
            this.lbl_resignerAdresseMail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_resignerAdresseMail.Name = "lbl_resignerAdresseMail";
            this.lbl_resignerAdresseMail.Size = new System.Drawing.Size(510, 19);
            this.lbl_resignerAdresseMail.TabIndex = 2;
            this.lbl_resignerAdresseMail.Text = "Veuillez renseigner votre adresse mail pour réinitialiser votre mot de passe";
            // 
            // tbx_reinitialiserMotDePasse
            // 
            this.tbx_reinitialiserMotDePasse.Location = new System.Drawing.Point(53, 155);
            this.tbx_reinitialiserMotDePasse.Name = "tbx_reinitialiserMotDePasse";
            this.tbx_reinitialiserMotDePasse.Size = new System.Drawing.Size(455, 20);
            this.tbx_reinitialiserMotDePasse.TabIndex = 0;
            // 
            // btn_validerReinitialiserMotDePasse
            // 
            this.btn_validerReinitialiserMotDePasse.Location = new System.Drawing.Point(221, 227);
            this.btn_validerReinitialiserMotDePasse.Name = "btn_validerReinitialiserMotDePasse";
            this.btn_validerReinitialiserMotDePasse.Size = new System.Drawing.Size(127, 54);
            this.btn_validerReinitialiserMotDePasse.TabIndex = 1;
            this.btn_validerReinitialiserMotDePasse.Text = "&VALIDER";
            this.btn_validerReinitialiserMotDePasse.UseVisualStyleBackColor = true;
            this.btn_validerReinitialiserMotDePasse.Click += new System.EventHandler(this.Btn_validerReinitialiserMotDePasse_Click);
            // 
            // frm_motDePasseOublie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 315);
            this.Controls.Add(this.btn_validerReinitialiserMotDePasse);
            this.Controls.Add(this.tbx_reinitialiserMotDePasse);
            this.Controls.Add(this.lbl_resignerAdresseMail);
            this.MaximizeBox = false;
            this.Name = "frm_motDePasseOublie";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mot de passe oublié";
            this.Load += new System.EventHandler(this.Frm_motDePasseOublie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_resignerAdresseMail;
        private System.Windows.Forms.TextBox tbx_reinitialiserMotDePasse;
        private System.Windows.Forms.Button btn_validerReinitialiserMotDePasse;
    }
}