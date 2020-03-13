using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SafiRepay.RAO;

using MaterialSkin;
using MaterialSkin.Controls;
using System.Diagnostics;

namespace SafiRepay
{
    public partial class frm_admin : MaterialForm
    {
        public Employee oneUser { get; set;}

        public frm_admin(Employee user)
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800, Primary.BlueGrey800,
                Primary.BlueGrey800, Accent.LightBlue200,
                TextShade.WHITE
            );

            if (user != null)
            {
                tbx_prenomProfilAdmin.Text = user.firstname;
                this.oneUser = user;

                tbx_nomProfilAdmin.Text = user.lastname;
                this.oneUser = user;

                tbx_telProfilAdmin.Text = user.phone;
                this.oneUser = user;
            }
        }

        private void Btn_deconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
            Form connexion = new frm_connexion();
            connexion.Show();
        }

        private void Frm_admin_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_creerCompte_Click(object sender, EventArgs e)
        {
            string prenom = tbx_prenomCompte.Text;
            string nom = tbx_nomCompte.Text;
            int region = cbx_region.SelectedIndex + 1;
            
            if(tbx_prenomCompte.Text != null && tbx_nomCompte.Text != null && cbx_region.Text != null)
            {
                Employee createAccount = Employee.createAccountEmployee(prenom, nom, region);
                MessageBox.Show("Nouveau compte crée avec succès.");
            }
        }

        private void Tbx_nomCompte_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tbx_prenomCompte_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_modifierMotDePasseAdmin_Click(object sender, EventArgs e)
        {
            frm_changerMotDePasse changerMotDePasse = new frm_changerMotDePasse();
            changerMotDePasse.Show();
        }

        private void dgv_listeComptes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_modifierCompte_Click(object sender, EventArgs e)
        {
            
        }
    }
}