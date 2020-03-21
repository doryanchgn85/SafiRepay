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

            // Modify the maxLenght of some textbox
            tbx_hireDateYear.MaxLength = 4;
            tbx_hireDateMonth.MaxLength = 2;
            tbx_hireDateDay.MaxLength = 2;
            tbx_phone.MaxLength = 10;   
        }

        /**
         * Close the form and disconnected the user
         */
        private void Btn_deconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
            Form connexion = new frm_connexion();
            connexion.Show();
        }

        /**
         * Get all employees when the form load
         * Display in a datagridview
         */
        private void Frm_admin_Load(object sender, EventArgs e)
        {
            List<Employee> employee = Employee.getAllEmployee();
            foreach (Employee oneEmployee in employee)
            {
                dgv_listAccount.Rows.Add(oneEmployee.lastname, oneEmployee.firstname);
            }
        }


        /**
         * Open a groupbox to create an employee
         */
        private void btn_createAccount_Click(object sender, EventArgs e)
        {
            gbx_createAccountEmployee.Visible = true;
            gbx_researchAccount.Visible = false;
            gbx_modifyAccountEmployee.Visible = false;
        }

        /**
         * Open a groupbox to research an employee to modify it
         */
        private void btn_modifyAccount_Click(object sender, EventArgs e)
        {
            gbx_createAccountEmployee.Visible = false;
            gbx_researchAccount.Visible = true;
        }

        /**
         * Research an employee by his login
         * Display his informations
         */
        private void btn_researchAccount_Click(object sender, EventArgs e)
        {
            gbx_createAccountEmployee.Visible = false;

            try
            {
                string login = tbx_researchAccount.Text;

                Employee userResearch = Employee.researchEmployee(login);
                if (userResearch != null)
                {
                    gbx_modifyAccountEmployee.Visible = true;
                    tbx_modifyLastname.Text = Convert.ToString(userResearch.lastname);
                    tbx_modifyFirstname.Text = Convert.ToString(userResearch.firstname);
                    tbx_modifyPostalCode.Text = Convert.ToString(userResearch.postalCode);
                    tbx_modifyCity.Text = Convert.ToString(userResearch.city);
                    tbx_modifyAddress.Text = Convert.ToString(userResearch.address);
                    tbx_modifyPhone.Text = Convert.ToString(userResearch.phone);
                    tbx_modifyHireDate.Text = Convert.ToString(userResearch.hireDate);
                    tbx_modifyLogin.Text = Convert.ToString(userResearch.login);

                    if (userResearch.activation == 1)
                    {
                        cbx_modifyActivation.Checked = true;
                    }
                    else
                    {
                        cbx_modifyActivation.Checked = false;
                    }
                }
            }
            // Else display a error message
            catch
            {
                MessageBox.Show("Erreur lors de la recherche");
            }
        }

        /**
         * Button to confirm all modifications of an employee 
         */
        private void btn_modifyAccountEmployee_Click(object sender, EventArgs e)
        {
            String login = tbx_researchAccount.Text;
            String firstname = tbx_modifyFirstname.Text;
            String lastname = tbx_modifyLastname.Text;
            String postalCode = tbx_modifyPostalCode.Text;
            String city = tbx_modifyCity.Text;
            String address = tbx_modifyAddress.Text;
            String phone = tbx_modifyPhone.Text;
            int typeAccount = cbx_modifyTypeAccount.SelectedIndex + 1;
            int activation;

            if (cbx_modifyActivation.Checked == true)
            {
                activation = 1;
            }
            else
            {
                activation = 0;
            }

            Employee modifyAccount = Employee.modifyEmployee(login, lastname, firstname, address, city, postalCode, phone, activation, typeAccount);
            MessageBox.Show("Modification effectué avec succès");
            gbx_modifyAccountEmployee.Visible = false;
            gbx_researchAccount.Visible = false;
        }

        /**
         * Button to confirm the creation of an employee
         */
        private void btn_createAccountConfirmation_Click(object sender, EventArgs e)
        {
            string firstname = tbx_firstname.Text;
            string lastname = tbx_lastname.Text;
            int district = cbx_district.SelectedIndex + 1;
            string login = tbx_login.Text;
            string pwd = tbx_pwd.Text;
            string pwdConfirm = tbx_confirmationPwd.Text;
            string address = tbx_address.Text;
            string postalCode = tbx_postalCode.Text;
            string city = tbx_city.Text;
            string phone = tbx_phone.Text;
            string hireDateDay = tbx_hireDateDay.Text;
            string hireDateMonth = tbx_hireDateMonth.Text;
            string hireDateYear = tbx_hireDateYear.Text;
            int typeAccount = cbx_typeAccount.SelectedIndex + 1;
            int activation = 0;

            if (cbx_activeAccount.Checked == true)
            {
                activation = 1;
            }
            else
            {
                activation = 0;
            }

            // Check if the two textbox of password was the same to continue the creation
            if (pwd != pwdConfirm)
            { 
                MessageBox.Show("Les mots de passe saisis ne sont pas identiques.");
            }
            // Check if the password < 8 characters
            if (pwd.Length < 8)
            {
                MessageBox.Show("Votre mot de passe doit comporter au minimum 8 caractères. ");
            }
            // And now make the creation of the employee
            else
            {
                Employee createAccount = Employee.createAccountEmployee(activation, firstname, lastname, pwd, login, address, postalCode, city, phone, hireDateDay, hireDateMonth, hireDateYear, district, typeAccount);
                MessageBox.Show("Nouveau compte crée avec succès.");
                gbx_createAccountEmployee.Visible = false;
            }
        }
    }
}

    