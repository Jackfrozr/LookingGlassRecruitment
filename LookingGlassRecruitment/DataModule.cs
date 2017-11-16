using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace LookingGlassRecruitment
{
    public partial class DataModule : Form
    {
        public DataTable dtEmployer;
        public DataTable dtVacancy;
        public DataTable dtApplication;
        public DataTable dtCandidate;
        public DataTable dtSkill;
        public DataTable dtCandidateSkill;
        public DataTable dtVacancySkill;
        public DataView employerView;
        public DataView skillView;
        public DataView candidateView;
        public DataView vacancyView;

        /// <summary>
        /// Load stuff in datamodule
        /// </summary>
        public DataModule()
        {
            InitializeComponent();
            dsLookingGlass.EnforceConstraints = false;
            //Data adapter
            daEmployer.Fill(dsLookingGlass);
            daVacancy.Fill(dsLookingGlass);
            daCandidate.Fill(dsLookingGlass);
            daApplication.Fill(dsLookingGlass);
            daCandidateSkill.Fill(dsLookingGlass);
            daSkill.Fill(dsLookingGlass);
            daVacancySkill.Fill(dsLookingGlass);
            //Data table
            dtEmployer = dsLookingGlass.Tables["Employer"];
            dtVacancy = dsLookingGlass.Tables["Vacancy"];
            dtCandidate = dsLookingGlass.Tables["Candidate"];
            dtApplication = dsLookingGlass.Tables["Application"];
            dtCandidateSkill = dsLookingGlass.Tables["CandidateSkill"];
            dtVacancySkill = dsLookingGlass.Tables["VacancySkill"];
            dtSkill = dsLookingGlass.Tables["Skill"];

            dsLookingGlass.EnforceConstraints = true;
            //view
            employerView = new DataView(dtEmployer);
            employerView.Sort = "EmployerID";
            skillView = new DataView(dtSkill);
            skillView.Sort = "SkillID";
            vacancyView = new DataView(dtVacancy);
            vacancyView.Sort = "VacancyID";
            candidateView = new DataView(dtCandidate);
            candidateView.Sort = "CandidateID";
        }

        /// <summary>
        /// Save all changes into database
        /// </summary>
        public void UpdateEmployer()
        {
            daEmployer.Update(dtEmployer);
        }

        /// <summary>
        /// Save all changes into database
        /// </summary>
        public void UpdateCandidate()
        {
            daCandidate.Update(dtCandidate);
        }

        /// <summary>
        /// Save all changes into database
        /// </summary>
        public void UpdateVacancy()
        {
            daVacancy.Update(dtVacancy);
        }

        /// <summary>
        /// Save all changes into database
        /// </summary>
        public void UpdateCandidateSkill()
        {
            daCandidateSkill.Update(dtCandidateSkill);
        }

        /// <summary>
        /// Save all changes into database
        /// </summary>
        public void UpdateVacancySkill()
        {
            daVacancySkill.Update(dtVacancySkill);
        }

        /// <summary>
        /// Save all changes into database
        /// </summary>
        public void UpdateApplication()
        {
            daApplication.Update(dtApplication);
        }
    }
}
