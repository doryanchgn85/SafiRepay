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
            this.tbx_oldPwd = new System.Windows.Forms.TextBox();
            this.tbx_newPwd = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.tbx_confirmPwd = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
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
            this.lbl_ancienMotDePasse.TabIndex = 6;
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
            this.lbl_nouveauMotDePasse.TabIndex = 5;
            this.lbl_nouveauMotDePasse.Text = "Nouveau mot de passe :";
            // 
            // tbx_oldPwd
            // 
            this.tbx_oldPwd.Location = new System.Drawing.Point(232, 189);
            this.tbx_oldPwd.Name = "tbx_oldPwd";
            this.tbx_oldPwd.Size = new System.Drawing.Size(175, 20);
            this.tbx_oldPwd.TabIndex = 0;
            // 
            // tbx_newPwd
            // 
            this.tbx_newPwd.Location = new System.Drawing.Point(232, 236);
            this.tbx_newPwd.Name = "tbx_newPwd";
            this.tbx_newPwd.Size = new System.Drawing.Size(175, 20);
            this.tbx_newPwd.TabIndex = 1;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(159, 341);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(110, 60);
            this.btn_confirm.TabIndex = 3;
            this.btn_confirm.Text = "VALIDER";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.Btn_valider_Click);
            // 
            // tbx_confirmPwd
            // 
            this.tbx_confirmPwd.Location = new System.Drawing.Point(232, 281);
            this.tbx_confirmPwd.Name = "tbx_confirmPwd";
            this.tbx_confirmPwd.Size = new System.Drawing.Size(175, 20);
            this.tbx_confirmPwd.TabIndex = 2;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(44, 280);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(105, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Confirmation :";
            // 
            // frm_changerMotDePasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.tbx_confirmPwd);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.tbx_newPwd);
            this.Controls.Add(this.tbx_oldPwd);
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
        private System.Windows.Forms.TextBox tbx_oldPwd;
        private System.Windows.Forms.TextBox tbx_newPwd;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.TextBox tbx_confirmPwd;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}