namespace LookingGlassRecruitment
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.btnSkillCandidate = new System.Windows.Forms.Button();
            this.btnApplication = new System.Windows.Forms.Button();
            this.btnSkillVacancy = new System.Windows.Forms.Button();
            this.btnVacancy = new System.Windows.Forms.Button();
            this.btnCandidate = new System.Windows.Forms.Button();
            this.btnEmployer = new System.Windows.Forms.Button();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCandidates = new System.Windows.Forms.Button();
            this.btnVacancies = new System.Windows.Forms.Button();
            this.ttpMainMenu = new System.Windows.Forms.ToolTip(this.components);
            this.grpMaintenance.SuspendLayout();
            this.grpReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpMaintenance.Controls.Add(this.btnSkillCandidate);
            this.grpMaintenance.Controls.Add(this.btnApplication);
            this.grpMaintenance.Controls.Add(this.btnSkillVacancy);
            this.grpMaintenance.Controls.Add(this.btnVacancy);
            this.grpMaintenance.Controls.Add(this.btnCandidate);
            this.grpMaintenance.Controls.Add(this.btnEmployer);
            this.grpMaintenance.Location = new System.Drawing.Point(48, 45);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.Size = new System.Drawing.Size(297, 432);
            this.grpMaintenance.TabIndex = 0;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "Maintenance";
            // 
            // btnSkillCandidate
            // 
            this.btnSkillCandidate.BackColor = System.Drawing.SystemColors.Control;
            this.btnSkillCandidate.Location = new System.Drawing.Point(27, 273);
            this.btnSkillCandidate.Name = "btnSkillCandidate";
            this.btnSkillCandidate.Size = new System.Drawing.Size(246, 43);
            this.btnSkillCandidate.TabIndex = 5;
            this.btnSkillCandidate.Text = "Assign Skill to a Candidate";
            this.btnSkillCandidate.UseVisualStyleBackColor = false;
            this.btnSkillCandidate.Click += new System.EventHandler(this.btnSkillCandidate_Click);
            // 
            // btnApplication
            // 
            this.btnApplication.BackColor = System.Drawing.SystemColors.Control;
            this.btnApplication.Location = new System.Drawing.Point(27, 333);
            this.btnApplication.Name = "btnApplication";
            this.btnApplication.Size = new System.Drawing.Size(246, 43);
            this.btnApplication.TabIndex = 4;
            this.btnApplication.Text = "Application Maintenance";
            this.btnApplication.UseVisualStyleBackColor = false;
            this.btnApplication.Click += new System.EventHandler(this.btnApplication_Click);
            // 
            // btnSkillVacancy
            // 
            this.btnSkillVacancy.BackColor = System.Drawing.SystemColors.Control;
            this.btnSkillVacancy.Location = new System.Drawing.Point(27, 213);
            this.btnSkillVacancy.Name = "btnSkillVacancy";
            this.btnSkillVacancy.Size = new System.Drawing.Size(246, 43);
            this.btnSkillVacancy.TabIndex = 3;
            this.btnSkillVacancy.Text = "Assign Skill to a Vacancy";
            this.btnSkillVacancy.UseVisualStyleBackColor = false;
            this.btnSkillVacancy.Click += new System.EventHandler(this.btnSkillVacancy_Click);
            // 
            // btnVacancy
            // 
            this.btnVacancy.BackColor = System.Drawing.SystemColors.Control;
            this.btnVacancy.Location = new System.Drawing.Point(27, 153);
            this.btnVacancy.Name = "btnVacancy";
            this.btnVacancy.Size = new System.Drawing.Size(246, 43);
            this.btnVacancy.TabIndex = 2;
            this.btnVacancy.Text = "Vacancy Maintenance";
            this.btnVacancy.UseVisualStyleBackColor = false;
            this.btnVacancy.Click += new System.EventHandler(this.btnVacancy_Click);
            // 
            // btnCandidate
            // 
            this.btnCandidate.BackColor = System.Drawing.SystemColors.Control;
            this.btnCandidate.Location = new System.Drawing.Point(27, 93);
            this.btnCandidate.Name = "btnCandidate";
            this.btnCandidate.Size = new System.Drawing.Size(246, 43);
            this.btnCandidate.TabIndex = 1;
            this.btnCandidate.Text = "Candidate Maintenance";
            this.btnCandidate.UseVisualStyleBackColor = false;
            this.btnCandidate.Click += new System.EventHandler(this.btnCandidate_Click);
            // 
            // btnEmployer
            // 
            this.btnEmployer.BackColor = System.Drawing.SystemColors.Control;
            this.btnEmployer.Location = new System.Drawing.Point(27, 33);
            this.btnEmployer.Name = "btnEmployer";
            this.btnEmployer.Size = new System.Drawing.Size(246, 43);
            this.btnEmployer.TabIndex = 0;
            this.btnEmployer.Text = "Employer Maintenance";
            this.btnEmployer.UseVisualStyleBackColor = false;
            this.btnEmployer.Click += new System.EventHandler(this.btnEmployer_Click);
            // 
            // grpReport
            // 
            this.grpReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpReport.Controls.Add(this.btnExit);
            this.grpReport.Controls.Add(this.btnCandidates);
            this.grpReport.Controls.Add(this.btnVacancies);
            this.grpReport.Location = new System.Drawing.Point(430, 45);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(297, 432);
            this.grpReport.TabIndex = 1;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Reporting";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(22, 333);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(246, 43);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCandidates
            // 
            this.btnCandidates.BackColor = System.Drawing.SystemColors.Control;
            this.btnCandidates.Location = new System.Drawing.Point(22, 93);
            this.btnCandidates.Name = "btnCandidates";
            this.btnCandidates.Size = new System.Drawing.Size(246, 43);
            this.btnCandidates.TabIndex = 1;
            this.btnCandidates.Text = "Candidates";
            this.btnCandidates.UseVisualStyleBackColor = false;
            this.btnCandidates.Click += new System.EventHandler(this.btnCandidates_Click);
            // 
            // btnVacancies
            // 
            this.btnVacancies.BackColor = System.Drawing.SystemColors.Control;
            this.btnVacancies.Location = new System.Drawing.Point(22, 33);
            this.btnVacancies.Name = "btnVacancies";
            this.btnVacancies.Size = new System.Drawing.Size(246, 43);
            this.btnVacancies.TabIndex = 0;
            this.btnVacancies.Text = "Vacancies";
            this.btnVacancies.UseVisualStyleBackColor = false;
            this.btnVacancies.Click += new System.EventHandler(this.btnVacancies_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.grpMaintenance);
            this.Name = "MainForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpMaintenance.ResumeLayout(false);
            this.grpReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.Button btnEmployer;
        private System.Windows.Forms.Button btnApplication;
        private System.Windows.Forms.Button btnSkillVacancy;
        private System.Windows.Forms.Button btnVacancy;
        private System.Windows.Forms.Button btnCandidate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCandidates;
        private System.Windows.Forms.Button btnVacancies;
        private System.Windows.Forms.Button btnSkillCandidate;
        private System.Windows.Forms.ToolTip ttpMainMenu;
    }
}

