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
using System.Net.Http;
using System.Diagnostics;

using MaterialSkin;
using MaterialSkin.Controls;
using SafiRepay.RAO;


namespace SafiRepay
{
    public partial class frm_connexion : MaterialForm
    {
        public frm_connexion()
        {
            InitializeComponent();

            tbx_motDePasse.PasswordChar = '*';

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

        private void Btn_connection_Click(object sender, EventArgs e)
        {
            try
            {
                string username = tbx_identifiant.Text;
                string pwd = tbx_motDePasse.Text;

                Employee userWantsConnection = Employee.auth(username, pwd);
                if (userWantsConnection != null)
                {
                    Global.connectedEmployee = userWantsConnection;
                    MaterialForm dashboard = new frm_admin(userWantsConnection);
                    dashboard.Show();
                }
            }
            catch
            {
                MessageBox.Show("Connexion impossible");
            }
        }

        private void Frm_connexion_Load(object sender, EventArgs e)
        {
             
        }

        private void Lkl_mdpOublie_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_motDePasseOublie motDePasseOublie = new frm_motDePasseOublie();
            motDePasseOublie.Show();
        }
    }
}
