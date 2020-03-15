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

            tbx_dateEmbaucheAnnee.MaxLength = 4;
            tbx_dateEmbaucheMois.MaxLength = 2;
            tbx_dateEmbaucheJour.MaxLength = 2;

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
            string login = tbx_login.Text;
            string pwd = tbx_mdp.Text;
            string pwdConfirm = tbx_confirmationMdp.Text;
            string adresse = tbx_adresse.Text;
            string CP = tbx_CP.Text;
            string ville = tbx_ville.Text;
            string tel = tbx_telephone.Text;
            string dateEmbaucheJour = tbx_dateEmbaucheJour.Text;
            string dateEmbaucheMois = tbx_dateEmbaucheMois.Text;
            string dateEmbaucheAnnee = tbx_dateEmbaucheAnnee.Text;
            int activation = 0;

            if(cbx_activeCompte.Checked == true)
            {
                activation = 1;
            }
            else
            {
                activation = 0;
            }

            if(prenom == null && nom == null && login == null && adresse == null && CP == null && ville == null && tel == null)
            {
                MessageBox.Show("Veuillez renseigner tous les champs.");
            }
            if(pwd != pwdConfirm)
            {
                MessageBox.Show("Les mots de passe saisis ne sont pas identiques.");
            }
            else
            {
                Employee createAccount = Employee.createAccountEmployee(activation, prenom, nom, pwd, login, adresse, CP, ville, tel, dateEmbaucheJour, dateEmbaucheMois, dateEmbaucheAnnee, region);
                MessageBox.Show("Nouveau compte crée avec succès.");
                gbx_creerCompteEmployee.Visible = false;
            }
        }

        private void Btn_modifierMotDePasseAdmin_Click(object sender, EventArgs e)
        {
            frm_changerMotDePasse changerMotDePasse = new frm_changerMotDePasse();
            changerMotDePasse.Show();
        }

        private void btn_creerCompteEmployee_Click(object sender, EventArgs e)
        {
            gbx_creerCompteEmployee.Visible = true;
        }


        private void tbx_modifierCompteEmploye_Click(object sender, EventArgs e)
        {
            gbx_rechercheCompte.Visible = true;
        }

        private void btn_rechercherCompte_Click(object sender, EventArgs e)
        {
            gbx_modifierCompteEmploye.Visible = false;

            try
            {
                string login = tbx_rechercherCompte.Text;

                Employee userResearch = Employee.researchEmployee(login);
                if (userResearch != null)
                {
                    gbx_modifierCompteEmploye.Visible = true;
                    tbx_ModifierNom.Text = Convert.ToString(userResearch.lastname);
                    tbx_ModifierPrenom.Text = Convert.ToString(userResearch.firstname);
                    tbx_ModifierCP.Text = Convert.ToString(userResearch.postalCode);
                    tbx_ModifierVille.Text = Convert.ToString(userResearch.city);
                    tbx_ModifierAdresse.Text = Convert.ToString(userResearch.address);
                    tbx_ModifierTel.Text = Convert.ToString(userResearch.phone);
                    tbx_ModifierDateEmbauche.Text = Convert.ToString(userResearch.hireDate);
                    tbx_ModifierLogin.Text = Convert.ToString(userResearch.login);

                    if (userResearch.activation == 1)
                    {
                        cbx_ModifierActivation.Checked = true;
                    }
                    else
                    {
                        cbx_ModifierActivation.Checked = false;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erreur lors de la recherche");
            }
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            String login = tbx_ModifierLogin.Text;
            String firstname = tbx_ModifierNom.Text;
            String lastname = tbx_ModifierPrenom.Text;
            String postalCode = tbx_ModifierCP.Text;
            String city = tbx_ModifierVille.Text;
            String address = tbx_ModifierAdresse.Text;
            String phone = tbx_ModifierTel.Text;

            int activation = 0;
            
            if (cbx_activeCompte.Checked == true)
            {
                activation = 1;
            }
            else
            {
                activation = 0;
            }

            Employee modifyAccount = Employee.modifyEmployee(login, lastname, firstname, address, city, postalCode, phone, activation);
            MessageBox.Show("Modification effectué avec succès");
            gbx_modifierCompteEmploye.Visible = false;
            gbx_rechercheCompte.Visible = false;
        }

        private void tbp_listeComptes_Click(object sender, EventArgs e)
        {
            
        }

        private void tbp_modifierCompte_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel10_Click(object sender, EventArgs e)
        {

        }
        private void dgv_listeComptes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tbx_nomCompte_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tbx_prenomCompte_TextChanged(object sender, EventArgs e)
        {

        }
    }
}