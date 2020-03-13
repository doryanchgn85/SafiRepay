namespace SafiRepay
{
    partial class frm_changerMotDePasse
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
            this.lbl_ancienMotDePasse = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_nouveauMotDePasse = new MaterialSkin.Controls.MaterialLabel();
            this.tbx_ancienMotDePasse = new System.Windows.Forms.TextBox();
            this.tbx_nouveauMotDePasse = new System.Windows.Forms.TextBox();
            this.btn_valider = new System.Windows.Forms.Button();
            this.lbl_changerSonMotDePasse = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lbl_ancienMotDePasse
            // 
            this.lbl_ancienMotDePasse.AutoSize = true;
            this.lbl_ancienMotDePasse.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ancienMotDePasse.Depth = 0;
            this.lbl_ancienMotDePasse.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_ancienMotDePasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_ancienMotDePasse.Location = new System.Drawing.Point(44, 188);
            this.lbl_ancienMotDePasse.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_ancienMotDePasse.Name = "lbl_ancienMotDePasse";
            this.lbl_ancienMotDePasse.Size = new System.Drawing.Size(158, 19);
            this.lbl_ancienMotDePasse.TabIndex = 0;
            this.lbl_ancienMotDePasse.Text = "Ancien mot de passe :";
            // 
            // lbl_nouveauMotDePasse
            // 
            this.lbl_nouveauMotDePasse.AutoSize = true;
            this.lbl_nouveauMotDePasse.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nouveauMotDePasse.Depth = 0;
            this.lbl_nouveauMotDePasse.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_nouveauMotDePasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_nouveauMotDePasse.Location = new System.Drawing.Point(44, 235);
            this.lbl_nouveauMotDePasse.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_nouveauMotDePasse.Name = "lbl_nouveauMotDePasse";
            this.lbl_nouveauMotDePasse.Size = new System.Drawing.Size(171, 19);
            this.lbl_nouveauMotDePasse.TabIndex = 1;
            this.lbl_nouveauMotDePasse.Text = "Nouveau mot de passe :";
            // 
            // tbx_ancienMotDePasse
            // 
            this.tbx_ancienMotDePasse.Location = new System.Drawing.Point(232, 189);
            this.tbx_ancienMotDePasse.Name = "tbx_ancienMotDePasse";
            this.tbx_ancienMotDePasse.Size = new System.Drawing.Size(175, 20);
            this.tbx_ancienMotDePasse.TabIndex = 2;
            // 
            // tbx_nouveauMotDePasse
            // 
            this.tbx_nouveauMotDePasse.Location = new System.Drawing.Point(232, 236);
            this.tbx_nouveauMotDePasse.Name = "tbx_nouveauMotDePasse";
            this.tbx_nouveauMotDePasse.Size = new System.Drawing.Size(175, 20);
            this.tbx_nouveauMotDePasse.TabIndex = 3;
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(159, 341);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(110, 60);
            this.btn_valider.TabIndex = 4;
            this.btn_valider.Text = "VALIDER";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.Btn_valider_Click);
            // 
            // lbl_changerSonMotDePasse
            // 
            this.lbl_changerSonMotDePasse.AutoSize = true;
            this.lbl_changerSonMotDePasse.BackColor = System.Drawing.Color.Transparent;
            this.lbl_changerSonMotDePasse.Depth = 0;
            this.lbl_changerSonMotDePasse.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_changerSonMotDePasse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_changerSonMotDePasse.Location = new System.Drawing.Point(-4, 95);
            this.lbl_changerSonMotDePasse.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_changerSonMotDePasse.Name = "lbl_changerSonMotDePasse";
            this.lbl_changerSonMotDePasse.Size = new System.Drawing.Size(222, 19);
            this.lbl_changerSonMotDePasse.TabIndex = 5;
            this.lbl_changerSonMotDePasse.Text = "CHANGER SON MOT DE PASSE";
            // 
            // frm_changerMotDePasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.lbl_changerSonMotDePasse);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.tbx_nouveauMotDePasse);
            this.Controls.Add(this.tbx_ancienMotDePasse);
            this.Controls.Add(this.lbl_nouveauMotDePasse);
            this.Controls.Add(this.lbl_ancienMotDePasse);
            this.MaximizeBox = false;
            this.Name = "frm_changerMotDePasse";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Changer son mot de passe";
            this.Load += new System.EventHandler(this.Frm_changerMotDePasse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_ancienMotDePasse;
        private MaterialSkin.Controls.MaterialLabel lbl_nouveauMotDePasse;
        private System.Windows.Forms.TextBox tbx_ancienMotDePasse;
        private System.Windows.Forms.TextBox tbx_nouveauMotDePasse;
        private System.Windows.Forms.Button btn_valider;
        private MaterialSkin.Controls.MaterialLabel lbl_changerSonMotDePasse;
    }
}