namespace LookingGlassRecruitment
{
    partial class ApplicationForm
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
            this.dgvApplication = new System.Windows.Forms.DataGridView();
            this.btnAddApplication = new System.Windows.Forms.Button();
            this.btnDeleteApplication = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtEmployerName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtCandidateFullName = new System.Windows.Forms.TextBox();
            this.pnlAddApplication = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveApplication = new System.Windows.Forms.Button();
            this.cboCandidateName = new System.Windows.Forms.ComboBox();
            this.cboVacancyDescription = new System.Windows.Forms.ComboBox();
            this.cboCandidateID = new System.Windows.Forms.ComboBox();
            this.cboVacancyID = new System.Windows.Forms.ComboBox();
            this.lblCandidateID = new System.Windows.Forms.Label();
            this.lblVacancyID = new System.Windows.Forms.Label();
            this.ttpApplication = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplication)).BeginInit();
            this.pnlAddApplication.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvApplication
            // 
            this.dgvApplication.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplication.Location = new System.Drawing.Point(36, 30);
            this.dgvApplication.Name = "dgvApplication";
            this.dgvApplication.Size = new System.Drawing.Size(245, 373);
            this.dgvApplication.TabIndex = 0;
            this.dgvApplication.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvApplication_MouseUp);
            // 
            // btnAddApplication
            // 
            this.btnAddApplication.Location = new System.Drawing.Point(455, 444);
            this.btnAddApplication.Name = "btnAddApplication";
            this.btnAddApplication.Size = new System.Drawing.Size(132, 35);
            this.btnAddApplication.TabIndex = 1;
            this.btnAddApplication.Text = "Add Application";
            this.btnAddApplication.UseVisualStyleBackColor = true;
            this.btnAddApplication.Click += new System.EventHandler(this.btnAddApplication_Click);
            // 
            // btnDeleteApplication
            // 
            this.btnDeleteApplication.Location = new System.Drawing.Point(612, 444);
            this.btnDeleteApplication.Name = "btnDeleteApplication";
            this.btnDeleteApplication.Size = new System.Drawing.Size(132, 35);
            this.btnDeleteApplication.TabIndex = 2;
            this.btnDeleteApplication.Text = "Delete Application";
            this.btnDeleteApplication.UseVisualStyleBackColor = true;
            this.btnDeleteApplication.Click += new System.EventHandler(this.btnDeleteApplication_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(612, 497);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(132, 35);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employer Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Salary:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Candidate Full Name:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(484, 127);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(158, 20);
            this.txtDescription.TabIndex = 8;
            // 
            // txtEmployerName
            // 
            this.txtEmployerName.Location = new System.Drawing.Point(484, 170);
            this.txtEmployerName.Name = "txtEmployerName";
            this.txtEmployerName.Size = new System.Drawing.Size(230, 20);
            this.txtEmployerName.TabIndex = 9;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(484, 213);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(109, 20);
            this.txtSalary.TabIndex = 10;
            // 
            // txtCandidateFullName
            // 
            this.txtCandidateFullName.Location = new System.Drawing.Point(484, 256);
            this.txtCandidateFullName.Name = "txtCandidateFullName";
            this.txtCandidateFullName.Size = new System.Drawing.Size(251, 20);
            this.txtCandidateFullName.TabIndex = 11;
            // 
            // pnlAddApplication
            // 
            this.pnlAddApplication.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddApplication.Controls.Add(this.btnCancel);
            this.pnlAddApplication.Controls.Add(this.btnSaveApplication);
            this.pnlAddApplication.Controls.Add(this.cboCandidateName);
            this.pnlAddApplication.Controls.Add(this.cboVacancyDescription);
            this.pnlAddApplication.Controls.Add(this.cboCandidateID);
            this.pnlAddApplication.Controls.Add(this.cboVacancyID);
            this.pnlAddApplication.Controls.Add(this.lblCandidateID);
            this.pnlAddApplication.Controls.Add(this.lblVacancyID);
            this.pnlAddApplication.Location = new System.Drawing.Point(26, 232);
            this.pnlAddApplication.Name = "pnlAddApplication";
            this.pnlAddApplication.Size = new System.Drawing.Size(441, 307);
            this.pnlAddApplication.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(298, 264);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 35);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveApplication
            // 
            this.btnSaveApplication.Location = new System.Drawing.Point(9, 264);
            this.btnSaveApplication.Name = "btnSaveApplication";
            this.btnSaveApplication.Size = new System.Drawing.Size(132, 35);
            this.btnSaveApplication.TabIndex = 4;
            this.btnSaveApplication.Text = "Save Application";
            this.btnSaveApplication.UseVisualStyleBackColor = true;
            this.btnSaveApplication.Click += new System.EventHandler(this.btnSaveApplication_Click);
            // 
            // cboCandidateName
            // 
            this.cboCandidateName.FormattingEnabled = true;
            this.cboCandidateName.Location = new System.Drawing.Point(201, 152);
            this.cboCandidateName.Name = "cboCandidateName";
            this.cboCandidateName.Size = new System.Drawing.Size(161, 21);
            this.cboCandidateName.TabIndex = 3;
            // 
            // cboVacancyDescription
            // 
            this.cboVacancyDescription.FormattingEnabled = true;
            this.cboVacancyDescription.Location = new System.Drawing.Point(201, 119);
            this.cboVacancyDescription.Name = "cboVacancyDescription";
            this.cboVacancyDescription.Size = new System.Drawing.Size(161, 21);
            this.cboVacancyDescription.TabIndex = 2;
            // 
            // cboCandidateID
            // 
            this.cboCandidateID.FormattingEnabled = true;
            this.cboCandidateID.Location = new System.Drawing.Point(129, 152);
            this.cboCandidateID.Name = "cboCandidateID";
            this.cboCandidateID.Size = new System.Drawing.Size(64, 21);
            this.cboCandidateID.TabIndex = 1;
            // 
            // cboVacancyID
            // 
            this.cboVacancyID.FormattingEnabled = true;
            this.cboVacancyID.Location = new System.Drawing.Point(129, 119);
            this.cboVacancyID.Name = "cboVacancyID";
            this.cboVacancyID.Size = new System.Drawing.Size(64, 21);
            this.cboVacancyID.TabIndex = 0;
            // 
            // lblCandidateID
            // 
            this.lblCandidateID.AutoSize = true;
            this.lblCandidateID.Location = new System.Drawing.Point(72, 154);
            this.lblCandidateID.Name = "lblCandidateID";
            this.lblCandidateID.Size = new System.Drawing.Size(58, 13);
            this.lblCandidateID.TabIndex = 7;
            this.lblCandidateID.Text = "Candidate:";
            // 
            // lblVacancyID
            // 
            this.lblVacancyID.AutoSize = true;
            this.lblVacancyID.Location = new System.Drawing.Point(80, 120);
            this.lblVacancyID.Name = "lblVacancyID";
            this.lblVacancyID.Size = new System.Drawing.Size(52, 13);
            this.lblVacancyID.TabIndex = 6;
            this.lblVacancyID.Text = "Vacancy:";
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlAddApplication);
            this.Controls.Add(this.txtCandidateFullName);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtEmployerName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteApplication);
            this.Controls.Add(this.btnAddApplication);
            this.Controls.Add(this.dgvApplication);
            this.Name = "ApplicationForm";
            this.Text = "Application Maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplication)).EndInit();
            this.pnlAddApplication.ResumeLayout(false);
            this.pnlAddApplication.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvApplication;
        private System.Windows.Forms.Button btnAddApplication;
        private System.Windows.Forms.Button btnDeleteApplication;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtEmployerName;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtCandidateFullName;
        private System.Windows.Forms.Panel pnlAddApplication;
        private System.Windows.Forms.Label lblCandidateID;
        private System.Windows.Forms.Label lblVacancyID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveApplication;
        private System.Windows.Forms.ComboBox cboCandidateName;
        private System.Windows.Forms.ComboBox cboVacancyDescription;
        private System.Windows.Forms.ComboBox cboCandidateID;
        private System.Windows.Forms.ComboBox cboVacancyID;
        private System.Windows.Forms.ToolTip ttpApplication;
    }
}