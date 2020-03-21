using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using SafiRepay.RAO;
using System.Diagnostics;

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

            if (user != null)
            {
                tbx_firstnameUser.Text = user.firstname;
                this.oneUser = user;

                tbx_lastnameUser.Text = user.lastname;
                this.oneUser = user;

                tbx_phoneUser.Text = user.phone;
                this.oneUser = user;

                tbx_loginUser.Text = user.login;
                this.oneUser = user;

                tbx_nbAccount.Text = user.id;
                this.oneUser = user;
            }
        }

        /**
         * When the form load do nothing
         */
        private void Frm_utilisateur_Load(object sender, EventArgs e)
        {

        }

        /**
         * Disconnect the user
         * close the form
         */
        private void Btn_deconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * Active the modification of price
         */
        private void btn_modifyParamsSheet_Click(object sender, EventArgs e)
        {
            tbx_newMiddayMeal.Enabled = true;
            tbx_newRelayStage.Enabled = true;
            tbx_newOvernight.Enabled = true;
            tbx_newKms.Enabled = true;

            lbl_newText.Visible = true;
            tbx_newMiddayMeal.Visible = true;
            tbx_newRelayStage.Visible = true;
            tbx_newOvernight.Visible = true;
            tbx_newKms.Visible = true;

            btn_Cancel.Visible = true;
            btn_Confirm.Visible = true;
        }

        /**
         * This button confirm the modification of the price
         */
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            btn_Cancel.Visible = false;
            btn_Confirm.Visible = false;

            tbx_newMiddayMeal.Enabled = false;
            tbx_newRelayStage.Enabled = false;
            tbx_newOvernight.Enabled = false;
            tbx_newKms.Enabled = false;

            int middayMeal = Convert.ToInt32(tbx_newMiddayMeal.Text) + Convert.ToInt32(tbx_middayMeal.Text);
            int relayStage = Convert.ToInt32(tbx_newRelayStage.Text) + Convert.ToInt32(tbx_relayStages.Text);
            int overnight = Convert.ToInt32(tbx_newOvernight.Text) + Convert.ToInt32(tbx_overnight.Text);
            int employee_id = Convert.ToInt32(tbx_nbAccount.Text);

            CultureInfo cultureInfo = CultureInfo.GetCultureInfo("fr-FR");

            decimal kms = ConvertDecimal(tbx_newKms.Text, tbx_kms.Text, cultureInfo);

            PackageType modifyValues = PackageType.modifyPackageType(employee_id, middayMeal, relayStage, overnight, kms);
            
            this.getPrice();

            MessageBox.Show("Modifications prises en compte.");

            lbl_newText.Visible = false;
            tbx_newMiddayMeal.Visible = false;
            tbx_newRelayStage.Visible = false;
            tbx_newOvernight.Visible = false;
            tbx_newKms.Visible = false;
        }

        /**
         * This button cancel the modification
         */
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            btn_Cancel.Visible = false;
            btn_Confirm.Visible = false;

            lbl_newText.Visible = false;
            tbx_newMiddayMeal.Visible = false;
            tbx_newRelayStage.Visible = false;
            tbx_newOvernight.Visible = false;
            tbx_newKms.Visible = false;
        }

        /**
         * GetPrice Method
         * Get th eprice in function of the user connected
         */
        private void getPrice()
        {
            int employee_id = Convert.ToInt32(tbx_nbAccount.Text);

            string date = cbx_dateSheet.Text;

            PackageType getPackageType = PackageType.getPackageType(employee_id, date);

            tbx_middayMeal.Text = Convert.ToString(getPackageType.middayMeal);
            tbx_relayStages.Text = Convert.ToString(getPackageType.relayStage);
            tbx_overnight.Text = Convert.ToString(getPackageType.overnight);
            tbx_kms.Text = Convert.ToString(getPackageType.kms);
        }

        /**
         * Return the kms in a decimal number
         */
        public decimal ConvertDecimal(string newKms1, string oldKms1, IFormatProvider formatProvider)
        {
            if (!decimal.TryParse(tbx_newKms.Text, NumberStyles.Any, formatProvider, out decimal newKms))
            {
                return 0M;
            }

            if (!decimal.TryParse(tbx_kms.Text, NumberStyles.Any, formatProvider, out decimal oldKms))
            {
                return 0M;
            }

            return newKms * 45 / 100 + oldKms;
        }

        /**
         * Button to show total prices on the month when the date was selected
         */
        private void btn_confirmDate_Click(object sender, EventArgs e)
        {
            getPrice();
        }
    }
}
