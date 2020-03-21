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

        /**
         *  Button to register on the app
         *  Try the connection, else error message
         */
        private void Btn_connection_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the text in the two textbox
                string username = tbx_identifiant.Text;
                string pwd = tbx_motDePasse.Text;

                Employee userWantsConnection = Employee.auth(username, pwd);
                // Check if textbox is different of null
                if (userWantsConnection != null)
                {
                    Employee getEmployeeTypeId = Employee.getEmployeeTypeId(username);
                    // Check if the user is an administrator
                    if (getEmployeeTypeId.employee_type_id != 3)
                    {
                        Global.connectedEmployee = userWantsConnection;
                        MaterialForm dashboard = new frm_utilisateur(userWantsConnection);
                        dashboard.Show();
                    }
                    else
                    {
                        Global.connectedEmployee = userWantsConnection;
                        MaterialForm dashboard = new frm_admin(userWantsConnection);
                        dashboard.Show();
                    }
                }
            }
            // Display error message
            catch
            {
                MessageBox.Show("Connexion impossible");
            }
        }

        /**
         *  Form load
         *  Do nothing
         */
        private void Frm_connexion_Load(object sender, EventArgs e)
        {
             
        }

        /**
         *  Redirect on the form passwordLost
         */
        private void Lkl_mdpOublie_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_motDePasseOublie motDePasseOublie = new frm_motDePasseOublie();
            motDePasseOublie.Show();
        }
    }
}
