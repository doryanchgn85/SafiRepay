using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using SafiRepay.RAO;

namespace SafiRepay
{
    public partial class frm_utilisateur : MaterialForm
    {
        public Employee oneUser { get; set; }
        public frm_utilisateur(Employee user)
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

            tbx_prenomUtilisateur.Enabled = false;
            tbx_nomUtilisateur.Enabled = false;
            tbx_middayMeal.Enabled = false;

            tbx_middayMeal.Enabled = false;
            tbx_relayStages.Enabled = false;
            tbx_overnight.Enabled = false;
            tbx_kms.Enabled = false;

            if (user != null)
            {
                tbx_prenomUtilisateur.Text = user.firstname;
                this.oneUser = user;

                tbx_nomUtilisateur.Text = user.lastname;
                this.oneUser = user;

                tbx_telUtilisateur.Text = user.phone;
                this.oneUser = user;

                tbx_login.Text = user.login;
                this.oneUser = user;

                tbx_nbAccount.Text = user.id;
                this.oneUser = user;
            }
        }

        private void Frm_utilisateur_Load(object sender, EventArgs e)
        {
            int employee_id = Convert.ToInt32(tbx_nbAccount.Text);
            PackageType getPackageType = PackageType.getPackageType(employee_id);

            tbx_middayMeal.Text = Convert.ToString(getPackageType   .middayMeal);
            tbx_relayStages.Text = Convert.ToString(getPackageType.relayStage);
            tbx_overnight.Text = Convert.ToString(getPackageType.overnight);
            tbx_kms.Text = Convert.ToString(getPackageType.kms);

        }

        private void Btn_deconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_modifierMotDePasseProfil_Click(object sender, EventArgs e)
        {
            frm_changerMotDePasse changerMotDePasse = new frm_changerMotDePasse();
            changerMotDePasse.Show();
        }

        private void Tbx_repasMidi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_modifierParametresForfait_Click(object sender, EventArgs e)
        {
            tbx_middayMeal.Enabled = true;
            tbx_relayStages.Enabled = true;
            tbx_overnight.Enabled = true;
            tbx_kms.Enabled = true;

            btn_Cancel.Visible = true;
            btn_Confirm.Visible = true;
        }

        private void btn_Valid_Click(object sender, EventArgs e)
        {
            btn_Cancel.Visible = false;
            btn_Confirm.Visible = false;

            tbx_middayMeal.Enabled = false;
            tbx_relayStages.Enabled = false;
            tbx_overnight.Enabled = false;
            tbx_kms.Enabled = false;

            int middayMeal = Convert.ToInt32(tbx_middayMeal.Text);
            int relayStage = Convert.ToInt32(tbx_relayStages.Text);
            int overnight = Convert.ToInt32(tbx_overnight.Text);
            int kms = Convert.ToInt32(tbx_kms.Text);

            int employee_id = Convert.ToInt32(tbx_nbAccount.Text);
            PackageType modifyValues = PackageType.modifyPackageType(employee_id, middayMeal, relayStage, overnight, kms);

            MessageBox.Show("Modifications prises en compte.");
        }

        private void btn_Anul_Click(object sender, EventArgs e)
        {
            btn_Cancel.Visible = false;
            btn_Confirm.Visible = false;

            tbx_middayMeal.Enabled = false;
            tbx_relayStages.Enabled = false;
            tbx_overnight.Enabled = false;
            tbx_kms.Enabled = false;
        }
    }
}
