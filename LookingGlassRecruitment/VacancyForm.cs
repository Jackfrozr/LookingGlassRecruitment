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
    public partial class VacancyForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;
        private CurrencyManager cmEmployer;

        /// <summary>
        /// Initialize
        /// </summary>
        public VacancyForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            loadToolTips();
        }

        /// <summary>
        /// Add text to tooltips when selecting button/labels
        /// </summary>
        public void loadToolTips()
        {
            ttpVacancy.SetToolTip(btnPrevious, "Previous vacancy");
            ttpVacancy.SetToolTip(btnNext, "Next vacancy");
            ttpVacancy.SetToolTip(btnAddVacancy, "Add a vacancy.");
            ttpVacancy.SetToolTip(btnUpdateVacancy, "Update a vacancy.");
            ttpVacancy.SetToolTip(btnDeleteVacancy, "Delete a vacancy.");
            ttpVacancy.SetToolTip(btnReturn, "Return to main menu.");
            ttpVacancy.SetToolTip(btnAddSaveVacancy, "Save vacancy.");
            ttpVacancy.SetToolTip(btnUpdateSaveChanges, "Save changes.");
            ttpVacancy.SetToolTip(btnAddCancel, "Cancel all changes.");
            ttpVacancy.SetToolTip(btnUpdateCancel, "Cancel all changes.");
        }

        /// <summary>
        /// Add values to textbox, list,currency manager
        /// Hide and position panels
        /// Make the textbox read only
        /// </summary>
        public void BindControls()
        {
            //Add value for the text boxes
            txtVacancyID.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.VacancyID");
            txtDescription.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.Description");
            txtSalary.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.Salary");
            txtStatus.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.Status");
            txtEmployerID.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.EmployerID");
            txtEmployerName.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.EmployerName");
            cboAddEmployerName.DataSource = DM.dsLookingGlass;
            cboAddEmployerName.DisplayMember = "Employer.EmployerName";
            cboAddEmployerName.ValueMember = "Employer.EmployerName";
            cboAddEmployerID.DataSource = DM.dsLookingGlass;
            cboAddEmployerID.DisplayMember = "Employer.EmployerID";
            cboAddEmployerID.ValueMember = "Employer.EmployerID";

            //disabling all text Boxes
            txtDescription.Enabled = false;
            txtSalary.Enabled = false;
            txtStatus.Enabled = false;
            txtVacancyID.Enabled = false;
            txtEmployerID.Enabled = false;
            txtEmployerName.Enabled = false;
            txtAddVacancyID.Enabled = false;
            txtUpdateVacancyID.Enabled = false;
            txtUpdateEmployerName.Enabled = false;
            txtUpdateStatus.Enabled = false;

            // Panel Related
            pnlAddVacancy.Visible = false;
            pnlAddVacancy.Left = 280;
            pnlAddVacancy.Top = 15;
            pnlUpdateVacancy.Visible = false;
            pnlUpdateVacancy.Left = 280;
            pnlUpdateVacancy.Top = 15;

            //Displaying Description on the List
            lstVacancyDescription.DataSource = DM.dsLookingGlass;
            lstVacancyDescription.DisplayMember = "Vacancy.Description";
            lstVacancyDescription.ValueMember = "Vacancy.Description";

            //currencymanager
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "VACANCY"];
            cmEmployer = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "Employer"];
        }

        /// <summary>
        /// Close and return to main menu
        /// </summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Previous vacancy
        /// </summary>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        /// <summary>
        /// Next vacancy
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        /// <summary>
        /// Display add vacancy panel
        /// Disable unused buttons
        /// Reset currency manager position
        /// </summary>
        private void btnAddVacancy_Click(object sender, EventArgs e)
        {
            txtAddVacancyID.Text= (currencyManager.Count+1).ToString();
            //Disabling Buttons that are not needed
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnReturn.Enabled = false;
            btnUpdateVacancy.Enabled = false;
            btnDeleteVacancy.Enabled = false;
            lstVacancyDescription.Visible = false;
            btnMarkVacancy.Enabled = false;
            //Display Panel
            pnlAddVacancy.Visible = true;
            //reset currency manager position
            cmEmployer.Position = 0;
        }

        /// <summary>
        /// get employer name on mouse release
        /// </summary>
        private void lstVacancyDescription_MouseUp(object sender, EventArgs e)
        {
            getEmployerName();
        }

        /// <summary>
        /// Find and get employer name
        /// </summary>
        private void getEmployerName()
        {
            int anEmployerID = (Convert.ToInt32(txtEmployerID.Text));
            cmEmployer.Position = DM.employerView.Find(anEmployerID);
            DataRow drEmployer = DM.dtEmployer.Rows[cmEmployer.Position];
            txtEmployerName.Text = drEmployer["EmployerName"].ToString();
            txtUpdateEmployerName.Text = drEmployer["EmployerName"].ToString();
        }

        /// <summary>
        /// enable previously disabled buttons and display hidden list
        /// hide panel
        /// get employer name
        /// </summary>
        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            //Enabling Buttons that are needed
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnReturn.Enabled = true;
            btnUpdateVacancy.Enabled = true;
            btnDeleteVacancy.Enabled = true;
            lstVacancyDescription.Visible = true;
            btnMarkVacancy.Enabled = true;
            //Remove Panel
            pnlAddVacancy.Visible = false;
            getEmployerName();//Reset cmEmployer position
        }

        /// <summary>
        /// Display update vacancy panel
        /// disable unrequired buttons and hide list
        /// </summary>
        private void btnUpdateVacancy_Click(object sender, EventArgs e)
        {
            //Disabling Buttons that are not needed
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnReturn.Enabled = false;
            btnAddVacancy.Enabled = false;
            btnDeleteVacancy.Enabled = false;
            lstVacancyDescription.Visible = false;
            btnMarkVacancy.Enabled = false;
            //Display Panel
            pnlUpdateVacancy.Visible = true;
            //Add values into update panel text boxes
            txtUpdateVacancyID.Text = txtVacancyID.Text;
            txtUpdateDescription.Text = txtDescription.Text;
            txtUpdateSalary.Text = txtSalary.Text;
            txtUpdateStatus.Text = txtStatus.Text;
            txtUpdateEmployerName.Text = txtEmployerName.Text;
        }

        /// <summary>
        /// Hide update vacancy panel
        /// Enable disabled buttons and show list
        /// </summary>
        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            //Enabling Buttons that are needed
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnReturn.Enabled = true;
            btnAddVacancy.Enabled = true;
            btnDeleteVacancy.Enabled = true;
            lstVacancyDescription.Visible = true;
            btnMarkVacancy.Enabled = true;
            //Remove Panel
            pnlUpdateVacancy.Visible = false;
        }

        /// <summary>
        /// Check if fields is empty or not
        /// If not try to add vacancy into database
        /// Catch any error
        /// </summary>
        private void btnAddSaveVacancy_Click(object sender, EventArgs e)
        {
            DataRow newVacancyRow = DM.dtVacancy.NewRow();

            if ((txtAddDescription.Text == "") || (txtAddSalary.Text == ""))
            {
                MessageBox.Show("You must ype in a description and salary.");
            }
            else
            {
                try
                {
                    newVacancyRow["Description"] = txtAddDescription.Text;
                    newVacancyRow["Status"] = "current";
                    newVacancyRow["Salary"] = txtAddSalary.Text;
                    newVacancyRow["EmployerID"] = cboAddEmployerID.Text;
                    DM.dtVacancy.Rows.Add(newVacancyRow);
                    DM.UpdateVacancy();
                    MessageBox.Show("Vacancy added successfully", "Success");
                }
                catch
                {
                    MessageBox.Show("Please Enter The Proper type for each fields");
                }
            }
        }

        /// <summary>
        /// Check if fields is empty or not
        /// If not try to update vacancy in the database
        /// Catch any error
        /// </summary>
        private void btnUpdateSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateVacancyRow = DM.dtVacancy.Rows[currencyManager.Position];

            if ((txtUpdateDescription.Text == "") || (txtUpdateSalary.Text == ""))
            {
                MessageBox.Show("You must ype in a description and salary.");
            }
            else
            {
                try
                {
                    updateVacancyRow["Description"] = txtUpdateDescription.Text;
                    updateVacancyRow["Salary"] = txtUpdateSalary.Text;
                    currencyManager.EndCurrentEdit();
                    DM.UpdateVacancy();
                    MessageBox.Show("Vacancy updated successfully", "Success");
                }
                catch
                {
                    MessageBox.Show("Please Enter The Proper type for each fields");
                }
            }
        }

        /// <summary>
        /// Check if vacancy is in application
        /// If not prompt user to confirm deleteion, if yes, delete vacancy and all skill asign to it
        /// </summary>
        private void btnDeleteVacancy_Click(object sender, EventArgs e)
        {
            DataRow deleteVacancyRow = DM.dtVacancy.Rows[currencyManager.Position];
            int lookForVacancyID = Convert.ToInt32(txtVacancyID.Text);
            int vacancy = 0;//Count amount of vacancy id in application table
            int row = 0;
            foreach (DataRow drApplication in DM.dtApplication.Rows)
            {
                int VacancyID = Convert.ToInt32(drApplication["VacancyID"].ToString());
                if (VacancyID == (lookForVacancyID))
                {
                    vacancy++;
                }
            }
            if (vacancy == 0)
            {
                if (MessageBox.Show("Do you want to delete this vacancy? Once deleted it will disappear from the database permanently.", "Delete Vacancy", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataRow drSkill in DM.dtVacancySkill.Rows)
                    {
                        int VacancyID = Convert.ToInt32(drSkill["VacancyID"].ToString());
                        if (VacancyID == (lookForVacancyID))
                        {
                            try
                            {
                                DataRow deleteVacancySkillRow = DM.dtVacancySkill.Rows[row];
                                deleteVacancySkillRow.Delete();
                            }
                            catch
                            {
                                MessageBox.Show("Something went wrong when trying to delete skill.");
                            }
                        }
                        row++;
                    }
                    DM.UpdateVacancySkill();

                    try
                    {
                        deleteVacancyRow.Delete();
                        DM.UpdateVacancy();
                        MessageBox.Show("Vacancy deleted successfully");
                    }
                    catch
                    {
                        MessageBox.Show("Error occured while deleting Vacancy");
                    }
                }

            }
            else
            {
                MessageBox.Show("You may only delete a vacancy that has no applications");
            }
        }

        /// <summary>
        /// if vacancy is current
        /// mark as filled and then delete all application record linked to the vacancy
        /// </summary>
        private void btnMarkVacancy_Click(object sender, EventArgs e)
        {
            if (txtStatus.Text == "current")
            {
                //Search for vacancy
                int lookForVacancyID = Convert.ToInt32(txtVacancyID.Text);
                int vacancy = 0;
                int count = 0;

                if (vacancy != 0)
                {
                    MessageBox.Show("Deleting application");
                }
                foreach (DataRow drApplication in DM.dtApplication.Rows)
                {
                    int VacancyID = Convert.ToInt32(drApplication["VacancyID"].ToString());
                    if (VacancyID == (lookForVacancyID))
                    {
                        try
                        {
                            vacancy++;
                            DataRow deleteApplicationRow = DM.dtApplication.Rows[count];
                            deleteApplicationRow.Delete();
                            DM.UpdateApplication();
                        }
                        catch
                        {
                            MessageBox.Show("Error occured while deleting application.");
                        }
                    }
                    count++;
                }
                DataRow updateVacancyRow = DM.dtVacancy.Rows[currencyManager.Position];
                updateVacancyRow["Status"] = "filled";
                currencyManager.EndCurrentEdit();
                DM.UpdateVacancy();
                MessageBox.Show("Vacancy marked as filled.");
            }
            else
            {
                MessageBox.Show("The vacancy is already filled");
            }
        }
    }
}
