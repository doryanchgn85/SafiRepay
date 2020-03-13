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
            tbx_repasMidi.Enabled = false;

            tbx_repasMidi.Enabled = false;
            tbx_relaisEtapes.Enabled = false;
            tbx_nuitee.Enabled = false;
            tbx_kilometrage.Enabled = false;

            if (user != null)
            {
                tbx_prenomUtilisateur.Text = user.firstname;
                this.oneUser = user;

                tbx_nomUtilisateur.Text = user.lastname;
                this.oneUser = user;

                tbx_telUtilisateur.Text = user.phone;
                this.oneUser = user;
            }
        }

        private void Frm_utilisateur_Load(object sender, EventArgs e)
        {
            /*List<PackageType> packageType = PackageType.showPrices();
            foreach(PackageType OnePackageType in packageType)
            {
                dataGridView1.Rows.Add(OnePackageType.name, OnePackageType.amountMax);
            }*/
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
            tbx_repasMidi.Enabled = true;
            tbx_relaisEtapes.Enabled = true;
            tbx_nuitee.Enabled = true;
            tbx_kilometrage.Enabled = true;

            btn_Anul.Visible = true;
            btn_Valid.Visible = true;
        }

        private void btn_Valid_Click(object sender, EventArgs e)
        {
            btn_Anul.Visible = false;
            btn_Valid.Visible = false;

            tbx_repasMidi.Enabled = false;
            tbx_relaisEtapes.Enabled = false;
            tbx_nuitee.Enabled = false;
            tbx_kilometrage.Enabled = false;
        }

        private void btn_Anul_Click(object sender, EventArgs e)
        {
            btn_Anul.Visible = false;
            btn_Valid.Visible = false;

            tbx_repasMidi.Enabled = false;
            tbx_relaisEtapes.Enabled = false;
            tbx_nuitee.Enabled = false;
            tbx_kilometrage.Enabled = false;
        }
    }
}
