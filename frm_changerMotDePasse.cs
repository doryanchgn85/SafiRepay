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

namespace SafiRepay
{
    public partial class frm_changerMotDePasse : MaterialForm
    {
        public frm_changerMotDePasse()
        {
            InitializeComponent();

            tbx_oldPwd.PasswordChar = '*';
            tbx_newPwd.PasswordChar = '*';

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

        private void Frm_changerMotDePasse_Load(object sender, EventArgs e)
        {

        }

        private void Btn_valider_Click(object sender, EventArgs e)
        {
            string oldpass = tbx_oldPwd.Text.Trim();
            string newpass = tbx_newPwd.Text.Trim();


            if (oldpass != null)
            {
                MessageBox.Show("Mot de passe mis à jour !");
            }
            else
            {
                MessageBox.Show("Mot de passe incorrects !");
            }
        }
    }
}
