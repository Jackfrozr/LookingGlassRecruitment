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
    public partial class SkillVacancyForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private CurrencyManager cmVacancy;
        private CurrencyManager cmVacancySkill;
        private CurrencyManager cmSkill;
        private CurrencyManager cmVVS;
        private DataTable dt = new DataTable();
        private CurrencyManager cmDt;

        /// <summary>
        /// Intialize stuffs
        /// </summary>
        public SkillVacancyForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            BindControls();
            loadToolTips();
        }

        /// <summary>
        /// Put values into data grid view and currency manager
        /// </summary>
        public void BindControls()
        {
            cmVacancy = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "Vacancy"];
            cmVacancySkill = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "VacancySkill"];
            cmSkill = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "Skill"];
            cmDt = (CurrencyManager)this.BindingContext[dt];
            cmVVS = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "Vacancy.Vacancy_VacancySkill"];
            dgvVacancy.DataSource = DM.dsLookingGlass;
            dgvVacancy.DataMember = "Vacancy";
            dgvSkill.DataSource = DM.dsLookingGlass;
            dgvSkill.DataMember = "Skill";
            dgvVacancySkill.DataSource = DM.dsLookingGlass;
            dgvVacancySkill.DataMember = "Vacancy.Vacancy_VacancySkill";
        }

        /// <summary>
        /// Add text to tooltips when selecting button/labels
        /// </summary>
        public void loadToolTips()
        {
            ttpVacancySkill.SetToolTip(btnAssignSkill, "Assign selected skill to the selected vacancy.");
            ttpVacancySkill.SetToolTip(btnRemoveSkill, "Remove selected skill from the vacancy.");
            ttpVacancySkill.SetToolTip(btnReturn, "Return to main menu.");
            ttpVacancySkill.SetToolTip(lblYears, "Number of years on the selected skill required for the vacancy.");
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
        /// Assign skill to vacancy
        /// catch format and constraint errors
        /// </summary>
        private void btnAssignSkill_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtYears.Text != "")
                {
                    DataRow newVacancySkill = DM.dtVacancySkill.NewRow();
                    newVacancySkill["VacancyID"] = dgvVacancy["VacancyID", cmVacancy.Position].Value;
                    newVacancySkill["SkillID"] = dgvSkill["SkillID", cmSkill.Position].Value;
                    newVacancySkill["Years"] = Convert.ToInt32(txtYears.Text);
                    DM.dsLookingGlass.Tables["VacancySkill"].Rows.Add(newVacancySkill);
                    DM.UpdateVacancySkill();
                    MessageBox.Show("Skill assigned successfully");
                }
                else
                {
                    MessageBox.Show("Please enter a number in years.", "Error");
                }
            }
            catch (ConstraintException)
            {
                MessageBox.Show("This skill has already been assigned to this vacancy.", "Error");
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
                string VacancyID = DM.dtVacancy.Rows[cmVacancy.Position]["VacancyID"].ToString();
                string SkillID = dgvVacancySkill.Rows[cmVVS.Position].Cells[1].Value.ToString();
                int row = 0;

                for (int i = 0; i < DM.dtVacancySkill.Rows.Count; i++)
                {
                    string sID = DM.dtVacancySkill.Rows[i]["VacancyID"].ToString();
                    string aID = DM.dtVacancySkill.Rows[i]["SkillID"].ToString();

                    if (VacancyID == sID && SkillID == aID)
                    {
                        row = i;
                    }
                }
                DataRow drSkill = DM.dsLookingGlass.Tables["VacancySkill"].Rows[row];
                drSkill.Delete();
                DM.UpdateVacancySkill();
                MessageBox.Show("Skill removed successfully");
            }
        }
    }
}
