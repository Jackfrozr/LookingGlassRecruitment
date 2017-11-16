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
    public partial class MainForm : Form
    {
        private DataModule DM;                                  // Reference to the form that holds the data components
        private EmployerForm frmEmployer;                       // Reference to the respective form, in this case the employer
        private CandidateForm frmCandidate;
        private VacancyForm frmVacancy;
        private SkillVacancyForm frmSkillVacancy;
        private SkillCandidateForm frmsSkillCandidate;
        private ApplicationForm frmApplication;
        private VacanciesForm frmVacancies;
        private CandidatesForm frmCandidates;

        /// <summary>
        /// Iniatialize form
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            LoadToolTips();                                     // Initialize tooltips texts
        }

        /// <summary>
        /// Create datamodule
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule();  
        }

        /// <summary>
        /// Exit the program/application
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Add text to tooltips when selecting button
        /// </summary>
        private void LoadToolTips()
        {
            ttpMainMenu.SetToolTip(btnEmployer, "Add, update or delete an employer.");
            ttpMainMenu.SetToolTip(btnCandidate, "Add, update or delete a candidate.");
            ttpMainMenu.SetToolTip(btnVacancy, "Add, update, fill or delete a vacancy.");
            ttpMainMenu.SetToolTip(btnSkillVacancy, "Assign a skill to a vacancy.");
            ttpMainMenu.SetToolTip(btnSkillCandidate, "Assign a skill to a candidate.");
            ttpMainMenu.SetToolTip(btnApplication, "Add or delete an application.");
            ttpMainMenu.SetToolTip(btnVacancies, "Print or display vacancies report.");
            ttpMainMenu.SetToolTip(btnCandidates, "Print or display candidates report.");
            ttpMainMenu.SetToolTip(btnExit, "Exit the application.");
        }

        /// <summary>
        /// Clicking the button will take you to the employer form
        /// </summary>
        private void btnEmployer_Click(object sender, EventArgs e)
        {
            if (frmEmployer == null)
            {
                frmEmployer = new EmployerForm(DM, this);
            }
            frmEmployer.ShowDialog();
        }

        /// <summary>
        /// Clicking the button will take you to the candidate form
        /// </summary>
        private void btnCandidate_Click(object sender, EventArgs e)
        {
            if (frmCandidate == null)
            {
                frmCandidate = new CandidateForm(DM, this);
            }
            frmCandidate.ShowDialog();
        }

        /// <summary>
        /// Clicking the button will take you to the candidates form
        /// </summary>
        private void btnCandidates_Click(object sender, EventArgs e)
        {
            if (frmCandidates == null)
            {
                frmCandidates = new CandidatesForm(DM, this);
            }
            frmCandidates.ShowDialog();
        }

        /// <summary>
        /// Clicking the button will take you to the vacancies form
        /// </summary>
        private void btnVacancies_Click(object sender, EventArgs e)
        {
            if (frmVacancies == null)
            {
                frmVacancies = new VacanciesForm(DM, this);
            }
            frmVacancies.ShowDialog();
        }

        /// <summary>
        /// Clicking the button will take you to the vacancy form
        /// </summary>
        private void btnVacancy_Click(object sender, EventArgs e)
        {
            if (frmVacancy == null)
            {
                frmVacancy = new VacancyForm(DM, this);
            }
            frmVacancy.ShowDialog();
        }

        /// <summary>
        /// Clicking the button will take you to the skill vacancy form which assigns a skill to a vacancy.
        /// </summary>
        private void btnSkillVacancy_Click(object sender, EventArgs e)
        {
            if (frmSkillVacancy == null)
            {
                frmSkillVacancy = new SkillVacancyForm(DM, this);
            }
            frmSkillVacancy.ShowDialog();
        }

        /// <summary>
        /// Clicking the button will take you to the skill candidate form which assigns a skill to a candidate.
        /// </summary>
        private void btnSkillCandidate_Click(object sender, EventArgs e)
        {
            if (frmsSkillCandidate == null)
            {
                frmsSkillCandidate = new SkillCandidateForm(DM, this);
            }
            frmsSkillCandidate.ShowDialog();
        }

        /// <summary>
        /// Clicking the button will take you the application form.
        /// </summary>
        private void btnApplication_Click(object sender, EventArgs e)
        {
            if (frmApplication == null)
            {
                frmApplication = new ApplicationForm(DM, this);
            }
            frmApplication.ShowDialog();
        }
    }

}
