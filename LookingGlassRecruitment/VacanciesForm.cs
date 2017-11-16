using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace LookingGlassRecruitment
{
    public partial class VacanciesForm : Form
    {
        private DataModule DM;
        private MainForm frmMenu;
        private int amountOfVacanciesPrinted, pagesAmountExpected;
        private DataRow[] vacanciesForPrint;

        /// <summary>
        /// Iniatilize
        /// </summary>
        public VacanciesForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm;
            frmMenu = mnu;
            loadToolTips();
        }

        /// <summary>
        /// Add text to tooltips when selecting button
        /// </summary>
        private void loadToolTips()
        {
            ttpVacancies.SetToolTip(btnPrintVacancies, "Open or print vacancies report.");
            ttpVacancies.SetToolTip(btnReturn, "Return to main menu");
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
        private void btnPrintVacancies_Click(object sender, EventArgs e)
        {
            amountOfVacanciesPrinted = 0;
            string strFilter = "";
            string strSort = "VacancyID";
            vacanciesForPrint = DM.dsLookingGlass.Tables["VACANCY"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            pagesAmountExpected = vacanciesForPrint.Length;
            try
            {
                prvVacancies.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Error occured, Please resart the application","Error");
            }
        }

        /// <summary>
        /// Load and Display the appropriate text into the print preview dialogs
        /// </summary>
        private void printVacancies_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFarHeading = 0;
            Font textFont = new Font("Arial", 12, FontStyle.Regular);
            Font headingFont = new Font("Arial", 12, FontStyle.Regular);
            Font headingFont2 = new Font("Arial", 14, FontStyle.Bold);
            DataRow drVacancy = vacanciesForPrint[amountOfVacanciesPrinted];
            CurrencyManager cmSkill;
            CurrencyManager cmEmployer;
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
            
            // get the employer record matching the cat id from the visit record
            int anEmployerID = Convert.ToInt32(drVacancy["EmployerID"]);
            cmEmployer.Position = DM.employerView.Find(anEmployerID);
            DataRow drEmployer = DM.dtEmployer.Rows[cmEmployer.Position];

            // Format into currency http://stackoverflow.com/questions/1017139/changing-the-currency-via-code-in-c-sharp
            decimal salary = Convert.ToDecimal(drVacancy["Salary"]);
            NumberFormatInfo nzd = (NumberFormatInfo)CultureInfo.CurrentCulture.NumberFormat.Clone();
            nzd.CurrencySymbol = "NZ$";
            string money = string.Format(nzd, "{0:c}", salary);

            //Draw string
            g.DrawString("Vacancies", headingFont2, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;

            g.DrawString("Vacancy ID:", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            g.DrawString(drVacancy["VacancyID"].ToString(), headingFont, brush, rightMargin - headingRightMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            g.DrawString("Description:", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            g.DrawString(drVacancy["Description"].ToString(), headingFont, brush, rightMargin - headingRightMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            g.DrawString("Employer Name:", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            g.DrawString(drEmployer["EmployerName"].ToString(), headingFont, brush, rightMargin - headingRightMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            g.DrawString("Status:", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            g.DrawString(drVacancy["Status"].ToString(), headingFont, brush, rightMargin - headingRightMargin,
                 topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;

            g.DrawString("Salary:", headingFont, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            g.DrawString(money, headingFont, brush, rightMargin - headingRightMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;

            g.DrawString("Skills", headingFont2, brush, leftMargin + headingLeftMargin,
                topMargin + (linesSoFarHeading * textFont.Height));
            linesSoFarHeading++;
            linesSoFarHeading++;
            linesSoFarHeading++;
            DataRow[] drSkills = drVacancy.GetChildRows(DM.dtVacancy.ChildRelations["VACANCY_VACANCYSKILL"]);

            if (drSkills.Length == 0)
            {
                g.DrawString("No skill has been assigned to this vacancy.", headingFont, brush, leftMargin + headingLeftMargin,
                    topMargin + (linesSoFarHeading * textFont.Height));
            }
            else
            {
                foreach (DataRow drVacancySkill in drSkills)
                {
                    int aSkillID = Convert.ToInt32(drVacancySkill["SkillID"].ToString());
                    cmSkill.Position = DM.skillView.Find(aSkillID);
                    DataRow drSkill = DM.dtSkill.Rows[cmSkill.Position];

                    g.DrawString(drSkill["Description"].ToString() +":" , headingFont, brush,
                                leftMargin + headingLeftMargin, topMargin +
                                (linesSoFarHeading * textFont.Height));
                    g.DrawString(drVacancySkill["Years"] + " Years", headingFont, brush,
                                rightMargin - headingRightMargin, topMargin +
                                (linesSoFarHeading * textFont.Height));
                    linesSoFarHeading++;
                }
                linesSoFarHeading++; 
            }
            amountOfVacanciesPrinted++;

            if (!(amountOfVacanciesPrinted == pagesAmountExpected))
            {
                e.HasMorePages = true;
            }
        }
    }
}
