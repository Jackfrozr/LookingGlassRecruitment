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
    public partial class ApplicationForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmApplication;
        private CurrencyManager cmVacancy;
        private CurrencyManager cmEmployer;
        private CurrencyManager cmCandidate;

        /// <summary>
        /// Run all necessary files on load
        /// </summary>
        public ApplicationForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();             //Load values onto textbox and data grid views
            LoadAddApplications();      //Load values onto comboboxes
            LoadToolTips();             //Add text to tooltips
        }

        /// <summary>
        /// Add text to tooltips when selecting button/labels
        /// </summary>
        public void LoadToolTips()
        {
            ttpApplication.SetToolTip(btnAddApplication, "Add an application");
            ttpApplication.SetToolTip(btnDeleteApplication, "Delete an application");
            ttpApplication.SetToolTip(btnReturn, "Return to main menu.");
            ttpApplication.SetToolTip(btnSaveApplication, "Save Application");
            ttpApplication.SetToolTip(btnCancel, "Cancel changes");
        }

        /// <summary>
        /// Add value to the combo boxes in add application
        /// Create a copy of the data table to display candidate full name in combo boxes
        /// </summary>
        private void LoadAddApplications()
        {
            DataTable dtTemp = DM.dtCandidate.Copy();//Create a temporary copy of the data table to display candidate full name
            dtTemp.Columns.Add("FullName", typeof(string), "FirstName + ' ' +LastName");
            cboVacancyDescription.DataSource = DM.dsLookingGlass;
            cboVacancyDescription.DisplayMember = "Vacancy.Description";
            cboVacancyDescription.ValueMember = "Vacancy.Description";
            cboVacancyID.DataSource = DM.dsLookingGlass;
            cboVacancyID.DisplayMember = "Vacancy.VacancyID";
            cboVacancyID.ValueMember = "Vacancy.VacancyID";
            cboCandidateID.DataSource = dtTemp;
            cboCandidateID.DisplayMember = "CandidateID";
            cboCandidateID.ValueMember = "CandidateID";
            cboCandidateName.DataSource = dtTemp;
            cboCandidateName.DisplayMember = "FullName";
        }
        /// <summary>
        /// Declare currency managers
        /// Hide and position the panels.
        /// Disable textbox to make it readonlys
        /// </summary>
        public void BindControls()
        {
            cmApplication = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "Application"];
            cmVacancy = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "Vacancy"];
            cmEmployer = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "Employer"];
            cmCandidate = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "Candidate"];
            //To make it Read-only 
            txtCandidateFullName.Enabled = false;
            txtDescription.Enabled = false;
            txtEmployerName.Enabled = false;
            txtSalary.Enabled = false;
            //Panel related
            pnlAddApplication.Visible = false;
            pnlAddApplication.Left = 310;
            pnlAddApplication.Top = 25;
            //Retrieve datas
            CurrencyHandler(); // Handles all currency managers that needs to be updated frequently.
            txtDescription.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.Description");
            txtEmployerName.DataBindings.Add("Text", DM.dsLookingGlass, "Employer.EmployerName");
            txtSalary.DataBindings.Add("Text", DM.dsLookingGlass, "Vacancy.Salary");
            //Add data grid view data
            dgvApplication.DataSource = DM.dsLookingGlass;
            dgvApplication.DataMember = "Application";
        }
        /// <summary>
        /// Manage currency manager position to display the appropriate textbox data based on the selected fields in the datagridview. (Appropriate textbox data = fullname,) 
        /// </summary>
        public void CurrencyHandler()
        {
            if (cmApplication.Position < DM.dtApplication.Rows.Count)//Do not run if out of bounds
            {
                //Vacancy Position
                int aVacancyID = (Convert.ToInt32(DM.dtApplication.Rows[cmApplication.Position]["VacancyID"]));
                cmVacancy.Position = DM.vacancyView.Find(aVacancyID);

                //Get Employer Name
                int anEmployerID = (Convert.ToInt32(DM.dtVacancy.Rows[cmVacancy.Position]["EmployerID"]));
                cmEmployer.Position = DM.employerView.Find(anEmployerID);

                //Get the candidate
                int aCandidateID = (Convert.ToInt32(DM.dtApplication.Rows[cmApplication.Position]["CandidateID"]));
                cmCandidate.Position = DM.candidateView.Find(aCandidateID);
                string firstName = DM.dtCandidate.Rows[(cmCandidate.Position)]["FirstName"].ToString();
                string lastName = DM.dtCandidate.Rows[(cmCandidate.Position)]["LastName"].ToString();
                string FullName = firstName + " " + lastName;
                txtCandidateFullName.Text = FullName;
            }
        }

        /// <summary>
        /// Exit to main menu
        /// </summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Display hidden panels
        /// Disable unrequired buttons and data grid view
        /// Reset currency manager position, so when user wants to add data, it is not the same as the data in data grid view.
        /// </summary>
        private void btnAddApplication_Click(object sender, EventArgs e)
        {
            pnlAddApplication.Visible = true;
            btnReturn.Enabled = false;
            btnDeleteApplication.Enabled = false;
            dgvApplication.Visible = false;
            //reset currency manager position
            cmVacancy.Position = 0;
            cmCandidate.Position = 0;
        }

        /// <summary>
        /// Hide Add application panel, enables previously disabled buttons
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddApplication.Visible = false;
            btnReturn.Enabled = true;
            dgvApplication.Visible = true;
            btnDeleteApplication.Enabled = true;
            CurrencyHandler();
        }

        /// <summary>
        /// Run currency handler function when mouse is released, it does posses a problem when user hold the click button continuously for no reason.
        /// </summary>
        private void dgvApplication_MouseUp(object sender, EventArgs e)
        {
            CurrencyHandler();
        }

        /// <summary>
        /// Save information from the comboboxes into the databases.
        /// Check if vacancy and candidate meet the requirements
        /// Double for loop used to find if all requirements have been met for each vacancy skill requirements
        /// </summary>
        private void btnSaveApplication_Click(object sender, EventArgs e)
        {
            if ((DM.dtVacancy.Rows[(Convert.ToInt32(cboVacancyID.Text)-1)]["Status"].ToString()) == "filled")
            {
                MessageBox.Show("Candidates can only apply to current vacancies");
            }
            else
            {
                // Check if vacancy and candidate meet the requirements 
                // Double for loop used to find if all requirements have been met for each vacancy skill requirements
                int matchcount = 0; //To count the amount of matches found during the loop
                int matchtotal = 0;//To count the amount of requirements that needs to be met
                int lookForVacancyID = Convert.ToInt32(cboVacancyID.Text);
                int lookForCandidateID = Convert.ToInt32(cboCandidateID.Text);
                foreach (DataRow drVacationSkill in DM.dtVacancySkill.Rows)
                {
                    int VacancyID = Convert.ToInt32(drVacationSkill["VacancyID"]);
                    if (VacancyID == (lookForVacancyID))
                    {
                        int vacancySkillID = Convert.ToInt32(drVacationSkill["SkillID"]);//Convert.ToInt32(DM.dtVacancySkill.Rows[row]["SkillID"]);
                        int vacancyYears = Convert.ToInt32(drVacationSkill["Years"]);//Convert.ToInt32(DM.dtVacancySkill.Rows[row]["Years"]);
                        foreach (DataRow drCandidateSkill in DM.dtCandidateSkill.Rows)
                        {
                            int candidateID = Convert.ToInt32(drCandidateSkill["CandidateID"]);
                            if (candidateID == lookForCandidateID)
                            {
                                int candidateSkillID = Convert.ToInt32(drCandidateSkill["SkillID"]);
                                int candidateYears = Convert.ToInt32(drCandidateSkill["Years"]);
                                if ((candidateSkillID==vacancySkillID)&&(candidateYears>=vacancyYears))
                                {
                                    matchcount++;//A match has been found
                                }
                            }
                        }
                        matchtotal++;
                    }
                }
                // If they do/do not meet requirements
                if ((matchcount==matchtotal)&&(matchcount > 0))
                {
                    try
                    {
                        DataRow newApplicationRow = DM.dtApplication.NewRow();
                        newApplicationRow["VacancyID"] = cboVacancyID.Text;
                        newApplicationRow["CandidateID"] = cboCandidateID.Text;
                        DM.dtApplication.Rows.Add(newApplicationRow);
                        MessageBox.Show("Application added succesfully", "Success");
                        DM.UpdateApplication();
                    }
                    catch (ConstraintException)
                    {
                        MessageBox.Show("This application has already been added.", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("The candidates does not have the experience to apply for the vacancy","Error");
                }
            }
        }

        /// <summary>
        /// Prompt user if they want to delete application, if yes, delete application currently selected from the data grid view
        /// </summary>
        private void btnDeleteApplication_Click(object sender, EventArgs e)
        {
            DataRow deleteApplicationRow = DM.dtApplication.Rows[cmApplication.Position];
            if (MessageBox.Show("Do you want to delete this application? Once deleted it cannot be undone.", "Delete Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    deleteApplicationRow.Delete();
                    DM.UpdateApplication();
                    MessageBox.Show("Application deleted successfully");
                }
                catch
                {
                    MessageBox.Show("Failed to delete application");
                }
            }
        }
    }
}
