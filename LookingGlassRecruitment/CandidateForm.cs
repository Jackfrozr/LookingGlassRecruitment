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
    public partial class CandidateForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        /// <summary>
        ///  Run all necessary files on load
        /// </summary>
        public CandidateForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            loadToolTips();
        }

        /// <summary>
        /// Add values to textbox, list
        /// Hide and position panels
        /// Make the textbox read only
        /// </summary>
        public void BindControls()
        {
            // Retrieve and display data
            lstCandidateName.DataSource = DM.dsLookingGlass;
            lstCandidateName.DisplayMember = "Candidate.LastName";
            lstCandidateName.ValueMember = "Candidate.LastName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "CANDIDATE"];
            txtCandidateID.DataBindings.Add("Text", DM.dsLookingGlass, "Candidate.CandidateID");
            txtLastName.DataBindings.Add("Text", DM.dsLookingGlass, "Candidate.LastName");
            txtFirstName.DataBindings.Add("Text", DM.dsLookingGlass, "Candidate.FirstName");
            txtStreetAddress.DataBindings.Add("Text", DM.dsLookingGlass, "Candidate.StreetAddress");
            txtSuburb.DataBindings.Add("Text", DM.dsLookingGlass, "Candidate.Suburb");
            txtPhoneNumber.DataBindings.Add("Text", DM.dsLookingGlass, "Candidate.PhoneNumber");
            // Panel Related
            pnlAddCandidate.Visible = false;
            pnlAddCandidate.Left = 236;
            pnlAddCandidate.Top = 15;
            pnlUpdateCandidate.Visible = false;
            pnlUpdateCandidate.Left = 236;
            pnlUpdateCandidate.Top = 0;
            // Make text box read only
            txtCandidateID.Enabled = false;
            txtLastName.Enabled = false;
            txtFirstName.Enabled = false;
            txtStreetAddress.Enabled = false;
            txtSuburb.Enabled = false;
            txtPhoneNumber.Enabled = false;
        }

        /// <summary>
        /// Add text to tooltips when selecting button/labels
        /// </summary>
        private void loadToolTips()
        {
            ttpCandidate.SetToolTip(btnPrevious, "Previous candidate");
            ttpCandidate.SetToolTip(btnNext, "Next candidate");
            ttpCandidate.SetToolTip(btnAddCandidate, "Add a candidate.");
            ttpCandidate.SetToolTip(btnUpdateCandidate, "Update a candidate.");
            ttpCandidate.SetToolTip(btnDeleteCandidate, "Delete a candidate.");
            ttpCandidate.SetToolTip(btnReturn, "Return to main menu.");
            ttpCandidate.SetToolTip(btnAddSaveCandidate, "Save candidate.");
            ttpCandidate.SetToolTip(btnUpdateSaveChanges, "Save changes.");
            ttpCandidate.SetToolTip(btnAddCancel, "Cancel all changes.");
            ttpCandidate.SetToolTip(btnUpdateCancel, "Cancel all changes.");
            ttpCandidate.SetToolTip(lblCandidateID, "A candidate's ID");
            ttpCandidate.SetToolTip(lblFirstName, "An candidate's first name");
            ttpCandidate.SetToolTip(lblLastName, "An candidate's last name");
            ttpCandidate.SetToolTip(lblStreetAddress, "An candidate's street address");
            ttpCandidate.SetToolTip(lblSuburb, "An candidate's suburb");
            ttpCandidate.SetToolTip(lblPhoneNumber, "An candidate's phone number");
        }

        /// <summary>
        /// Return to main menu
        /// </summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Previous candidate
        /// </summary>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        /// <summary>
        /// Next Candidate
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        /// <summary>
        /// Disable unused buttons and hide the unused list
        /// Display add candidate panel
        /// </summary>
        private void btnAddCandidate_Click(object sender, EventArgs e)
        {
            //Disabling Buttons that are not needed
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnReturn.Enabled = false;
            btnUpdateCandidate.Enabled = false;
            btnDeleteCandidate.Enabled = false;
            lstCandidateName.Visible = false;
            //Display Panel
            pnlAddCandidate.Visible = true;
        }

        /// <summary>
        /// Display previously hidden list and enables previously disabled button
        /// Hide add candidate panel
        /// </summary>
        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            //Enabling Buttons that are needed
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnReturn.Enabled = true;
            btnUpdateCandidate.Enabled = true;
            btnDeleteCandidate.Enabled = true;
            lstCandidateName.Visible = true;
            //Remove Panel
            pnlAddCandidate.Visible = false;
        }

        /// <summary>
        /// Check if fields are empty
        /// if not inser new row into database
        /// if error appears, catch it
        /// </summary>
        private void btnAddSaveCandidate_Click(object sender, EventArgs e)
        {
            DataRow newCandidateRow = DM.dtCandidate.NewRow();

            if ((txtAddFirstName.Text == "") || (txtAddLastName.Text == "") || (txtAddStreetAddress.Text == "") || (txtAddSuburb.Text == "") || (txtAddPhoneNumber.Text == ""))
            {
                MessageBox.Show("You must ype in an candidate first name, last name, street address, suburb and phone number.");
            }
            else
            {
                try
                {
                    newCandidateRow["LastName"] = txtAddLastName.Text;
                    newCandidateRow["FirstName"] = txtAddFirstName.Text;
                    newCandidateRow["StreetAddress"] = txtAddStreetAddress.Text;
                    newCandidateRow["Suburb"] = txtAddSuburb.Text;
                    newCandidateRow["PhoneNumber"] = txtAddPhoneNumber.Text;
                    DM.dtCandidate.Rows.Add(newCandidateRow);
                    MessageBox.Show("Candidate Added Successfully", "Success");
                    DM.UpdateCandidate();
                }
                catch
                {
                    MessageBox.Show("Please Enter The Proper type for each fields");
                }
            }
        }

        /// <summary>
        /// Display hidden update candidate panel
        /// Disable unused button and hide candidate list
        /// Add values into update panel textboxes
        /// </summary>
        private void btnUpdateCandidate_Click(object sender, EventArgs e)
        {
            //Disabling Buttons that are not needed
            txtUpdateCandidateID.Enabled = false;
            btnPrevious.Enabled = false;
            btnNext.Enabled = false;
            btnReturn.Enabled = false;
            btnAddCandidate.Enabled = false;
            btnDeleteCandidate.Enabled = false;
            lstCandidateName.Visible = false;
            //Display Panel
            pnlUpdateCandidate.Visible = true;
            //Textbox
            txtUpdateCandidateID.Text=txtCandidateID.Text;
            txtUpdateLastName.Text = txtLastName.Text;
            txtUpdateFirstName.Text = txtFirstName.Text;
            txtUpdateStreetAddress.Text = txtStreetAddress.Text;
            txtUpdateSuburb.Text = txtSuburb.Text;
            txtUpdatePhoneNumber.Text = txtPhoneNumber.Text;
        }

        /// <summary>
        /// Hide previously displayed panel
        /// Enable previously disabled buttons and display previously hidden list
        /// </summary>
        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            //Enabling Buttons that are needed
            btnPrevious.Enabled = true;
            btnNext.Enabled = true;
            btnReturn.Enabled = true;
            btnAddCandidate.Enabled = true;
            btnDeleteCandidate.Enabled = true;
            lstCandidateName.Visible = true;
            //Remove Panel
            pnlUpdateCandidate.Visible = false;
        }

        /// <summary>
        /// Check if fields are blank
        /// If not blank, update candidate rows in the database
        /// Catch error
        /// </summary>
        private void btnUpdateSaveChanges_Click(object sender, EventArgs e)
        {
            DataRow updateCandidateRow = DM.dtCandidate.Rows[currencyManager.Position];

            if ((txtUpdateFirstName.Text == "") || (txtUpdateLastName.Text == "") || (txtUpdateStreetAddress.Text == "") || (txtUpdateSuburb.Text == "") || (txtUpdatePhoneNumber.Text == ""))
            {
                MessageBox.Show("You must ype in an candidate name, phone number, street address and suburb");
            }
            else
            {
                try
                {
                    updateCandidateRow["LastName"] = txtUpdateLastName.Text;
                    updateCandidateRow["FirstName"] = txtUpdateFirstName.Text;
                    updateCandidateRow["StreetAddress"] = txtUpdateStreetAddress.Text;
                    updateCandidateRow["Suburb"] = txtUpdateSuburb.Text;
                    updateCandidateRow["PhoneNumber"] = txtUpdatePhoneNumber.Text;
                    currencyManager.EndCurrentEdit();
                    DM.UpdateCandidate();
                    MessageBox.Show("Candidate updated Successfully", "Success");
                }
                catch
                {
                    MessageBox.Show("Please Enter The Proper type for each fields");
                }
            }
        }

        /// <summary>
        /// Check if candidate is in the application table
        /// If no candidate, prompt user for delete confirmation
        /// If yes, delete candidate and its skill from the database
        /// </summary>
        private void btnDeleteCandidate_Click(object sender, EventArgs e)
        {
            DataRow deleteCandidateRow = DM.dtCandidate.Rows[currencyManager.Position];
            int lookForCandidateID = Convert.ToInt32(txtCandidateID.Text);
            int candidate = 0;//Count amount of candidate id in application table
            int row = 0;
            foreach (DataRow drApplication in DM.dtApplication.Rows)
            {
                int CandidateID = Convert.ToInt32(drApplication["CandidateID"].ToString());
                if (CandidateID == (lookForCandidateID))
                {
                    candidate++;
                }
            }
            if (candidate == 0)
            {
                if (MessageBox.Show("Do you want to delete this candidate? Once deleted it will disappear from the database permanently.", "Delete Candidate", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataRow drSkill in DM.dtCandidateSkill.Rows)
                    {
                        int CandidateID = Convert.ToInt32(drSkill["CandidateID"].ToString());
                        if (CandidateID == (lookForCandidateID))
                        {
                            try
                            {
                                DataRow deleteCandidateSkillRow = DM.dtCandidateSkill.Rows[row];
                                deleteCandidateSkillRow.Delete();
                            }
                            catch
                            {
                                MessageBox.Show("Something went wrong when trying to delete skill.");
                            }
                        }
                        row++;
                    }
                    DM.UpdateCandidateSkill();

                    try
                    {
                        deleteCandidateRow.Delete();
                        DM.UpdateCandidate();
                        MessageBox.Show("Candidate deleted successfully.");
                    }
                    catch
                    {
                        MessageBox.Show("Something went wrong when trying to delete candidate.");
                    }
                }
            }
            else
            {
                MessageBox.Show("You may only delete candidate who have no application");
            }
        }
    }
}
