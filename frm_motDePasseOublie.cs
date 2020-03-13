using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;

namespace SafiRepay
{
    public partial class frm_motDePasseOublie : MaterialForm
    {
        public frm_motDePasseOublie()
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
        }

        private void Frm_motDePasseOublie_Load(object sender, EventArgs e)
        {

        }

        private void Btn_validerReinitialiserMotDePasse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Un nouveau mot de passe vous a été envoyé, consultez vos mails.");
        }
    }
}
