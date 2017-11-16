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
    public partial class CandidatesForm : Form
    {

        private DataModule DM;
        private MainForm frmMenu;
        private int amountOfCandidatesPrinted, pagesAmountExpected;
        private DataRow[] candidatesForPrint;

        /// <summary>
        /// Run/declare all neccessary stuff 
        /// </summary>
        public CandidatesForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            loadToolTips();
        }

        /// <summary>
        /// Add text to tooltips when selecting button/labels
        /// </summary>
        private void loadToolTips()
        {
            ttpCandidates.SetToolTip(btnPrintCandidates, "Open or print candidates report.");
            ttpCandidates.SetToolTip(btnReturn, "Return to main menu");
        }

        /// <summary>
        /// Load and Display the appropriate text into the print preview dialogs
        /// </summary>
        private void printCandidates_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 12, FontStyle.Regular);
            Font headingFont = new Font("Arial", 12, FontStyle.Regular);
            Font headingFont2 = new Font("Arial", 14, FontStyle.Bold);
            DataRow drCandidate = candidatesForPrint[amountOfCandidatesPrinted];
            CurrencyManager cmSkill;
            CurrencyManager cmVacancy;
            CurrencyManager cmEmployer;
            cmVacancy = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "VACANCY"];
            cmSkill = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "SKILL"];
            cmEmployer = (CurrencyManager)this.BindingContext[DM.dsLookingGlass, "EMPLOYER"];
            Brush brush = new SolidBrush(Color.Black);
            //margins
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;
            int headingRightMargin = 400;
            string fullname = drCandidate["LastName"].ToString() +" "+ drCandidate["FirstName"].ToString();
            
            //Draw
            g.DrawString("Candidate ID:\t"+ drCandidate["CandidateID"].ToString(), headingFont2, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;

            g.DrawString(fullname, headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            g.DrawString(drCandidate["StreetAddress"].ToString(), headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            g.DrawString(drCandidate["Suburb"].ToString(), headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;

            g.DrawString("Skills:", headingFont2, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            DataRow[] drSkills = drCandidate.GetChildRows(DM.dtCandidate.ChildRelations["CANDIDATE_CANDIDATESKILL"]);

            if (drSkills.Length == 0)
            {
                g.DrawString("No skills have been allocated to this candidate.", headingFont, brush, leftMargin + headingLeftMargin,
                    topMargin + (linesSoFarHeading * textFont.Height));
                linesSoFarHeading++;
                linesSoFarHeading++;
                linesSoFarHeading++;
            }
            else
            {
                foreach (DataRow drCandidateSkill in drSkills)
                {
                    int aSkillID = Convert.ToInt32(drCandidateSkill["SkillID"].ToString());
                    cmSkill.Position = DM.skillView.Find(aSkillID);
                    DataRow drSkill = DM.dtSkill.Rows[cmSkill.Position];

                    g.DrawString(drSkill["Description"].ToString() + ":", headingFont, brush,
                                leftMargin + headingLeftMargin, topMargin +
                                (linesSoFarHeading * textFont.Height));
                    g.DrawString(drCandidateSkill["Years"] + "  Years", headingFont, brush,
                                rightMargin - headingRightMargin, topMargin +
                                (linesSoFarHeading * textFont.Height));
                    linesSoFarHeading++;
                }
                linesSoFarHeading++;
                linesSoFarHeading++;
            }

            g.DrawString("Current Vacancy Application:", headingFont2, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;

            DataRow[] drCandidateApplication = drCandidate.GetChildRows(DM.dtCandidate.ChildRelations["CANDIDATE_APPLICATION"]);

            if (drCandidateApplication.Length == 0)
            {
                g.DrawString("No applications have been made by this candidate.", headingFont, brush, leftMargin + headingLeftMargin,
                    topMargin + (linesSoFarHeading * textFont.Height));
            }
            else
            {
                foreach (DataRow drApplication in drCandidateApplication)
                {
                    int aVacancyID = Convert.ToInt32(drApplication["VacancyID"].ToString());
                    cmVacancy.Position = DM.vacancyView.Find(aVacancyID);
                    DataRow drVacancy = DM.dtVacancy.Rows[cmVacancy.Position];
                    int anEmployerID = Convert.ToInt32(drVacancy["EmployerID"]);
                    cmEmployer.Position = DM.employerView.Find(anEmployerID);
                    DataRow drEmployer = DM.dtEmployer.Rows[cmEmployer.Position];


                    g.DrawString("Vacancy ID:  "+drVacancy["VacancyID"].ToString() + "  "+ drEmployer["EmployerName"].ToString(), headingFont, brush,
                                leftMargin + headingLeftMargin, topMargin +
                                (linesSoFarHeading * textFont.Height));
                }
                linesSoFarHeading++;
            }

            amountOfCandidatesPrinted++;

            if (!(amountOfCandidatesPrinted == pagesAmountExpected))
            {
                e.HasMorePages = true;
            }
        }

        /// <summary>
        /// Return to main menu
        /// </summary>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Open print preview dialog
        /// </summary>
        private void btnPrintCandidates_Click(object sender, EventArgs e)
        {
            amountOfCandidatesPrinted = 0;
            string strFilter = "";
            string strSort = "CandidateID";
            candidatesForPrint = DM.dsLookingGlass.Tables["CANDIDATE"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            pagesAmountExpected = candidatesForPrint.Length;
            try
            {
                prvCandidates.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Error occured, Please resart the application", "Error");
            }
        }
    }
}
