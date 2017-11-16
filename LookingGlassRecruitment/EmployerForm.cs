using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LookingGlassRecruitment
{
    public partial class EmployerForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        /// <summary>
        ///  Run all necessary files on load
        /// </summary>
        public EmployerForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            LoadToolTips();
        }

        /// <summary>
        /// Add value to the text boxes
        /// Disabling text Boxes
        /// Displaying Employer Name on the List
        /// Moving the panel add employer to designated position
        /// </summary>
        public void BindControls()
        {
            //Add value to the text boxes
            txtEmployerID.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.EmployerID");
            txtEmployerName.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.EmployerName");
            txtStreetAddress.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.Street Address");
            txtSuburb.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.Suburb");
            txtPhoneNumber.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.PhoneNumber");
            //Disabling text Boxes
            txtEmployerID.Enabled = false;
            txtEmployerName.Enabled = false;
            txtStreetAddress.Enabled = false;
            txtSuburb.Enabled = false;
            txtPhoneNumber.Enabled = false;
            //Displaying Employer Name on the List
            lstEmployer.DataSource = DM.dsLookingGlass;
            lstEmployer.DisplayMember = "Employer.EmployerName";
            lstEmployer.ValueMember = "Employer.EmployerName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "EMPLOYER"];
            //Moving the Add employer panel to designated position
            pnlAddEmployer.Left = 320;
            pnlAddEmployer.Top = 25;
            pnlUpdateEmployer.Left = 321;
            pnlUpdateEmployer.Top = 5;
        }

        /// <summary>
        /// Add text to tooltips when selecting button/labels
        /// </summary>
        private void LoadToolTips()
        {
            ttpEmployer.SetToolTip(btnPrevious, "Previous Employer");
            ttpEmployer.SetToolTip(btnNext, "Next Employer");
            ttpEmployer.SetToolTip(btnAddEmployer, "Add an employer.");
            ttpEmployer.SetToolTip(btnUpdateEmployer, "Update an employer.");
            ttpEmployer.SetToolTip(btnDeleteEmployer, "Delete an employer.");
            ttpEmployer.SetToolTip(btnReturn, "Return to main menu.");
            ttpEmployer.SetToolTip(btnAddSaveEmployer, "Save employer.");
            ttpEmployer.SetToolTip(btnUpdateSaveEmployer, "Save changes.");
            ttpEmployer.SetToolTip(btnCancel, "Cancel all changes.");
            ttpEmployer.SetToolTip(btnUpdateEmployerCancel, "Cancel all changes.");
            ttpEmployer.SetToolTip(lblEmployerID, "An employer's ID");
            ttpEmployer.SetToolTip(lblEmployerName, "An employer's name");
            ttpEmployer.SetToolTip(lblPhoneNumber, "An employer's phone number");
            ttpEmployer.SetToolTip(lblStreetAddress, "An employer's street address");
            ttpEmployer.SetToolTip(lblSuburb, "An employer's suburb");
        }

        /// <summary>
        /// Move list to Previous employer
        /// </summary>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        /// <summary>
        /// Move list to next employer
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        /// <summary>
        /// Close form and exit to main menu
        /// </summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Disable non required buttons and list
        /// Display hidden panels
        /// </summary>
        private void btnAddEmployer_Click(object sender, EventArgs e)
        {
            //Disabling Buttons that are not needed
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnReturn.Enabled = false;
            btnUpdateEmployer.Enabled = false;
            btnDeleteEmployer.Enabled = false;
            lstEmployer.Visible = false;
            //Display Panel
            pnlAddEmployer.Visible = true;
        }

        /// <summary>
        /// Enable all required buttons
        /// Hide unused panels
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Enabling Buttons that are needed
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnReturn.Enabled = true;
            btnUpdateEmployer.Enabled = true;
            btnDeleteEmployer.Enabled = true;
            lstEmployer.Visible = true;
            //Remove Panel
            pnlAddEmployer.Visible = false;
        }

        /// <summary>
        /// Disable unrequired buttons and list
        /// Display hidden update employer panel
        /// Add values into update employer text boxes
        /// </summary>
        private void btnUpdateEmployer_Click(object sender, EventArgs e)
        {
            if (pnlUpdateEmployer.Visible == false) // If Update Employer Panel is not visible run this script, reason: panel will keep jumping y+20 without this condition
            {
                //Disabling Buttons that are not needed
                btnPrevious.Enabled = false;
                btnNext.Enabled = false;
                btnReturn.Enabled = false;
                btnAddEmployer.Enabled = false;
                btnDeleteEmployer.Enabled = false;
                lstEmployer.Visible = false;
                //Display Panel
                pnlUpdateEmployer.Visible = true;
                pnlButton.Location = new Point(pnlButton.Location.X, pnlButton.Location.Y+20); // Move Buttons downard to make space, Code modified from .http://stackoverflow.com/questions/8369999/c-sharp-change-the-location-of-an-object-programatically
                //Add values
                txtUpdateEmployerID.Text = txtEmployerID.Text;
                txtUpdateEmployerName.Text = txtEmployerName.Text;
                txtUpdateStreetAddress.Text = txtStreetAddress.Text;
                txtUpdateSuburb.Text = txtSuburb.Text;
                txtUpdatePhoneNumber.Text = txtPhoneNumber.Text;
            }
        }

        /// <summary>
        /// Enables previously disabled buttons and list
        /// Hide unused panels
        /// </summary>
        private void btnUpdateEmployerCancel_Click(object sender, EventArgs e)
        {
            //Enabling Buttons that are needed
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnReturn.Enabled = true;
            btnAddEmployer.Enabled = true;
            btnDeleteEmployer.Enabled = true;
            lstEmployer.Visible = true;
            //Remove Panel
            pnlUpdateEmployer.Visible = false;
            pnlButton.Location = new Point(pnlButton.Location.X, pnlButton.Location.Y - 20);// Move Buttons to original position
        }

        /// <summary>
        /// Save information from the textbox to the dataset and database
        /// </summary>
        private void btnAddSaveEmployer_Click(object sender, EventArgs e)
        {
            DataRow newEmployerRow = DM.dtEmployer.NewRow();

            if ((txtAddEmployerName.Text=="") || (txtAddPhoneNumber.Text=="") || (txtAddStreetAddress.Text=="") || (txtAddSuburb.Text==""))
            {
                MessageBox.Show("You must ype in an employer name, phone number, street address and suburb");
            }
            else
            {
                try
                {
                    newEmployerRow["EmployerName"] = txtAddEmployerName.Text;
                    newEmployerRow["Street Address"] = txtAddStreetAddress.Text;//There is a space in between street and address
                    newEmployerRow["Suburb"] = txtAddSuburb.Text;
                    newEmployerRow["PhoneNumber"] = txtAddPhoneNumber.Text;
                    DM.dtEmployer.Rows.Add(newEmployerRow);
                    MessageBox.Show("Employer Added Successfully", "Success");
                    DM.UpdateEmployer();
                }
                catch
                {
                    MessageBox.Show("Please Enter The Proper type for each fields");
                }
            }
        }

        /// <summary>
        /// Update information from the database to the ones written in the text boxes
        /// </summary>
        private void btnUpdateSaveEmployer_Click(object sender, EventArgs e)
        {
            if ((txtUpdateEmployerName.Text == "") || (txtUpdatePhoneNumber.Text == "") || (txtUpdateStreetAddress.Text == "") || (txtUpdateSuburb.Text == ""))
            {
                MessageBox.Show("You must ype in an employer name, phone number, street address and suburb");
            }
            else
            {
                try
                {
                    DataRow updateEmployerRow = DM.dtEmployer.Rows[currencyManager.Position];
                    updateEmployerRow["EmployerName"] = txtUpdateEmployerName.Text;
                    updateEmployerRow["Street Address"] = txtUpdateStreetAddress.Text;//There is a space in between street and address
                    updateEmployerRow["Suburb"] = txtUpdateSuburb.Text;
                    updateEmployerRow["PhoneNumber"] = txtUpdatePhoneNumber.Text;
                    DM.UpdateEmployer();
                    MessageBox.Show("Employer Updated Successfully", "Success");
                }
                catch
                {
                    MessageBox.Show("Please Enter The Proper type for each fields");
                }
            }
        }

        /// <summary>
        /// Delete the selected information from database
        /// Prompt user for confirmation on deletion, yes/no
        /// Check if there is any vacancy
        /// </summary>
        private void btnDeleteEmployer_Click(object sender, EventArgs e)
        {
            DataRow deleteEmployerRow = DM.dtEmployer.Rows[currencyManager.Position];
            int lookForEmployerID = Convert.ToInt32(txtEmployerID.Text);
            int vacancy = 0;//To count amount of employer id in Vacancy table
            foreach (DataRow drVacancy in DM.dtVacancy.Rows)
            {
                int EmployerID=Convert.ToInt32(drVacancy["EmployerID"].ToString());
                if (EmployerID==(lookForEmployerID))
                {
                    vacancy++;
                }
            }
            if(vacancy==0) //Employer has no vacancy
            {
                if (MessageBox.Show("Do you want to delete this employer? Once deleted it will disappear from the database.", "Delete Employer", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        deleteEmployerRow.Delete();
                        DM.UpdateEmployer();
                        MessageBox.Show("Employer Deleted Successfully");
                    }
                    catch
                    {
                        MessageBox.Show("An error has occured, something went wrong during deletion.");
                    }
                }
            }
            else
            {
                MessageBox.Show("You may only delete employers who have no vacancies");
            }
        }
    }
}
