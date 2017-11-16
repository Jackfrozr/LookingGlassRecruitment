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
    public partial class SkillCandidateForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmCandidate;
        private CurrencyManager cmCandidateSkill;
        private CurrencyManager cmSkill;
        private CurrencyManager cmCCS;

        /// <summary>
        /// Intialize stuffs
        /// </summary>
        public SkillCandidateForm(DataModule dm, MainForm mnu)
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
            ttpSkillCandidate.SetToolTip(btnAssignSkill, "Assign selected skill to the selected candidate.");
            ttpSkillCandidate.SetToolTip(btnRemoveSkill, "Remove selected skill from the candidate.");
            ttpSkillCandidate.SetToolTip(btnReturn, "Return to main menu.");
            ttpSkillCandidate.SetToolTip(lblYears, "Number of years the candidate has on the selected skill.");
        }

        /// <summary>
        /// insert values into currency manager
        /// add values to data grid view
        /// </summary>
        public void BindControls()
        {
            cmCandidate = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "Candidate"];
            cmCandidateSkill = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "CandidateSkill"];
            cmSkill = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "Skill"];
            cmCCS = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "Candidate.Candidate_CandidateSkill"];
            dgvCandidate.DataSource = DM.dsLookingGlass;
            dgvCandidate.DataMember = "Candidate";
            dgvSkill.DataSource = DM.dsLookingGlass;
            dgvSkill.DataMember = "Skill";
            dgvCandidateSkill.DataSource = DM.dsLookingGlass;
            dgvCandidateSkill.DataMember = "Candidate.Candidate_CandidateSkill";
        }

        /// <summary>
        /// Return to main menu
        /// </summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Check if years is not empty
        /// Assign skill to candidate
        /// catch format and constraint errors
        /// </summary>
        private void btnAssignSkill_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtYears.Text != "")
                {
                    DataRow newCandidateSkill = DM.dtCandidateSkill.NewRow();
                    newCandidateSkill["CandidateID"] = dgvCandidate["CandidateID", cmCandidate.Position].Value;
                    newCandidateSkill["SkillID"] = dgvSkill["SkillID", cmSkill.Position].Value;
                    newCandidateSkill["Years"] = Convert.ToInt32(txtYears.Text);
                    DM.dsLookingGlass.Tables["CandidateSkill"].Rows.Add(newCandidateSkill);
                    DM.UpdateCandidateSkill();
                    MessageBox.Show("Skill assigned successfully", "Succcess");
                }
                else
                {
                    MessageBox.Show("Please enter a number in years.", "Error");
                }
            }
            catch (ConstraintException)
            {
                MessageBox.Show("This skill has already been assigned to this candidate.", "Error");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a number in years.", "Error");
            }
        }

        /// <summary>
        /// Prompt delete confirmation, yes/no
        /// if yes delete
        /// </summary>
        private void btnRemoveSkill_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to remove this skill? Once remove it cannot be undone.", "Remove Skill", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string CandidateID = DM.dtCandidate.Rows[cmCandidate.Position]["CandidateID"].ToString();
                string SkillID = dgvCandidateSkill.Rows[cmCCS.Position].Cells[1].Value.ToString();
                int row = 0;

                for (int i = 0; i < DM.dtCandidateSkill.Rows.Count; i++)
                {
                    string sID = DM.dtCandidateSkill.Rows[i]["CandidateID"].ToString();
                    string aID = DM.dtCandidateSkill.Rows[i]["SkillID"].ToString();

                    if (CandidateID == sID && SkillID == aID)
                    {
                        row = i;
                    }
                }
                DataRow drSkill = DM.dsLookingGlass.Tables["CandidateSkill"].Rows[row];
                drSkill.Delete();
                DM.UpdateCandidateSkill();
                MessageBox.Show("Skill removed successfully");
            }
        }
    }
}
