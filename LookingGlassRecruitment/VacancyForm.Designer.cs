namespace LookingGlassRecruitment
{
    partial class VacancyForm
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
            this.lstVacancyDescription = new System.Windows.Forms.ListBox();
            this.lblVacancyID = new System.Windows.Forms.Label();
            this.txtVacancyID = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtEmployerID = new System.Windows.Forms.TextBox();
            this.txtEmployerName = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddVacancy = new System.Windows.Forms.Button();
            this.btnUpdateVacancy = new System.Windows.Forms.Button();
            this.btnDeleteVacancy = new System.Windows.Forms.Button();
            this.btnMarkVacancy = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlAddVacancy = new System.Windows.Forms.Panel();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.btnAddSaveVacancy = new System.Windows.Forms.Button();
            this.cboAddEmployerName = new System.Windows.Forms.ComboBox();
            this.cboAddEmployerID = new System.Windows.Forms.ComboBox();
            this.txtAddSalary = new System.Windows.Forms.TextBox();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.txtAddVacancyID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlUpdateVacancy = new System.Windows.Forms.Panel();
            this.txtUpdateEmployerName = new System.Windows.Forms.TextBox();
            this.txtUpdateStatus = new System.Windows.Forms.TextBox();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnUpdateSaveChanges = new System.Windows.Forms.Button();
            this.txtUpdateSalary = new System.Windows.Forms.TextBox();
            this.txtUpdateDescription = new System.Windows.Forms.TextBox();
            this.txtUpdateVacancyID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ttpVacancy = new System.Windows.Forms.ToolTip(this.components);
            this.pnlAddVacancy.SuspendLayout();
            this.pnlUpdateVacancy.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstVacancyDescription
            // 
            this.lstVacancyDescription.FormattingEnabled = true;
            this.lstVacancyDescription.Location = new System.Drawing.Point(25, 25);
            this.lstVacancyDescription.Name = "lstVacancyDescription";
            this.lstVacancyDescription.Size = new System.Drawing.Size(287, 212);
            this.lstVacancyDescription.TabIndex = 0;
            this.lstVacancyDescription.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstVacancyDescription_MouseUp);
            // 
            // lblVacancyID
            // 
            this.lblVacancyID.AutoSize = true;
            this.lblVacancyID.Location = new System.Drawing.Point(357, 40);
            this.lblVacancyID.Name = "lblVacancyID";
            this.lblVacancyID.Size = new System.Drawing.Size(66, 13);
            this.lblVacancyID.TabIndex = 1;
            this.lblVacancyID.Text = "Vacancy ID:";
            // 
            // txtVacancyID
            // 
            this.txtVacancyID.Location = new System.Drawing.Point(422, 37);
            this.txtVacancyID.Name = "txtVacancyID";
            this.txtVacancyID.Size = new System.Drawing.Size(44, 20);
            this.txtVacancyID.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(360, 70);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Salary:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Employer ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Employer Name:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(422, 67);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(248, 20);
            this.txtDescription.TabIndex = 8;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(422, 107);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(108, 20);
            this.txtStatus.TabIndex = 9;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(422, 137);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(107, 20);
            this.txtSalary.TabIndex = 10;
            // 
            // txtEmployerID
            // 
            this.txtEmployerID.Location = new System.Drawing.Point(422, 177);
            this.txtEmployerID.Name = "txtEmployerID";
            this.txtEmployerID.Size = new System.Drawing.Size(44, 20);
            this.txtEmployerID.TabIndex = 11;
            // 
            // txtEmployerName
            // 
            this.txtEmployerName.Location = new System.Drawing.Point(422, 208);
            this.txtEmployerName.Name = "txtEmployerName";
            this.txtEmployerName.Size = new System.Drawing.Size(248, 20);
            this.txtEmployerName.TabIndex = 12;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(25, 262);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(135, 31);
            this.btnPrevious.TabIndex = 13;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(177, 262);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(135, 31);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddVacancy
            // 
            this.btnAddVacancy.Location = new System.Drawing.Point(329, 262);
            this.btnAddVacancy.Name = "btnAddVacancy";
            this.btnAddVacancy.Size = new System.Drawing.Size(135, 31);
            this.btnAddVacancy.TabIndex = 15;
            this.btnAddVacancy.Text = "Add Vacancy";
            this.btnAddVacancy.UseVisualStyleBackColor = true;
            this.btnAddVacancy.Click += new System.EventHandler(this.btnAddVacancy_Click);
            // 
            // btnUpdateVacancy
            // 
            this.btnUpdateVacancy.Location = new System.Drawing.Point(481, 262);
            this.btnUpdateVacancy.Name = "btnUpdateVacancy";
            this.btnUpdateVacancy.Size = new System.Drawing.Size(135, 31);
            this.btnUpdateVacancy.TabIndex = 16;
            this.btnUpdateVacancy.Text = "Update Vacancy";
            this.btnUpdateVacancy.UseVisualStyleBackColor = true;
            this.btnUpdateVacancy.Click += new System.EventHandler(this.btnUpdateVacancy_Click);
            // 
            // btnDeleteVacancy
            // 
            this.btnDeleteVacancy.Location = new System.Drawing.Point(633, 262);
            this.btnDeleteVacancy.Name = "btnDeleteVacancy";
            this.btnDeleteVacancy.Size = new System.Drawing.Size(135, 31);
            this.btnDeleteVacancy.TabIndex = 17;
            this.btnDeleteVacancy.Text = "Delete Vacancy";
            this.btnDeleteVacancy.UseVisualStyleBackColor = true;
            this.btnDeleteVacancy.Click += new System.EventHandler(this.btnDeleteVacancy_Click);
            // 
            // btnMarkVacancy
            // 
            this.btnMarkVacancy.Location = new System.Drawing.Point(331, 309);
            this.btnMarkVacancy.Name = "btnMarkVacancy";
            this.btnMarkVacancy.Size = new System.Drawing.Size(286, 31);
            this.btnMarkVacancy.TabIndex = 18;
            this.btnMarkVacancy.Text = "Mark Vacancy as Filled";
            this.btnMarkVacancy.UseVisualStyleBackColor = true;
            this.btnMarkVacancy.Click += new System.EventHandler(this.btnMarkVacancy_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(633, 309);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(135, 31);
            this.btnReturn.TabIndex = 19;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlAddVacancy
            // 
            this.pnlAddVacancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddVacancy.Controls.Add(this.btnAddCancel);
            this.pnlAddVacancy.Controls.Add(this.btnAddSaveVacancy);
            this.pnlAddVacancy.Controls.Add(this.cboAddEmployerName);
            this.pnlAddVacancy.Controls.Add(this.cboAddEmployerID);
            this.pnlAddVacancy.Controls.Add(this.txtAddSalary);
            this.pnlAddVacancy.Controls.Add(this.txtAddDescription);
            this.pnlAddVacancy.Controls.Add(this.txtAddVacancyID);
            this.pnlAddVacancy.Controls.Add(this.label2);
            this.pnlAddVacancy.Controls.Add(this.label1);
            this.pnlAddVacancy.Controls.Add(this.label7);
            this.pnlAddVacancy.Controls.Add(this.label8);
            this.pnlAddVacancy.Location = new System.Drawing.Point(18, 348);
            this.pnlAddVacancy.Name = "pnlAddVacancy";
            this.pnlAddVacancy.Size = new System.Drawing.Size(458, 238);
            this.pnlAddVacancy.TabIndex = 20;
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.Location = new System.Drawing.Point(306, 176);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(135, 31);
            this.btnAddCancel.TabIndex = 22;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = true;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // btnAddSaveVacancy
            // 
            this.btnAddSaveVacancy.Location = new System.Drawing.Point(34, 176);
            this.btnAddSaveVacancy.Name = "btnAddSaveVacancy";
            this.btnAddSaveVacancy.Size = new System.Drawing.Size(135, 31);
            this.btnAddSaveVacancy.TabIndex = 21;
            this.btnAddSaveVacancy.Text = "Save Vacancy";
            this.btnAddSaveVacancy.UseVisualStyleBackColor = true;
            this.btnAddSaveVacancy.Click += new System.EventHandler(this.btnAddSaveVacancy_Click);
            // 
            // cboAddEmployerName
            // 
            this.cboAddEmployerName.FormattingEnabled = true;
            this.cboAddEmployerName.Location = new System.Drawing.Point(218, 126);
            this.cboAddEmployerName.Name = "cboAddEmployerName";
            this.cboAddEmployerName.Size = new System.Drawing.Size(196, 21);
            this.cboAddEmployerName.TabIndex = 20;
            // 
            // cboAddEmployerID
            // 
            this.cboAddEmployerID.FormattingEnabled = true;
            this.cboAddEmployerID.Location = new System.Drawing.Point(166, 126);
            this.cboAddEmployerID.Name = "cboAddEmployerID";
            this.cboAddEmployerID.Size = new System.Drawing.Size(44, 21);
            this.cboAddEmployerID.TabIndex = 19;
            // 
            // txtAddSalary
            // 
            this.txtAddSalary.Location = new System.Drawing.Point(166, 94);
            this.txtAddSalary.Name = "txtAddSalary";
            this.txtAddSalary.Size = new System.Drawing.Size(107, 20);
            this.txtAddSalary.TabIndex = 18;
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(166, 62);
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(231, 20);
            this.txtAddDescription.TabIndex = 16;
            // 
            // txtAddVacancyID
            // 
            this.txtAddVacancyID.Location = new System.Drawing.Point(166, 30);
            this.txtAddVacancyID.Name = "txtAddVacancyID";
            this.txtAddVacancyID.Size = new System.Drawing.Size(44, 20);
            this.txtAddVacancyID.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Employer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Salary:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Vacancy ID:";
            // 
            // pnlUpdateVacancy
            // 
            this.pnlUpdateVacancy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpdateVacancy.Controls.Add(this.txtUpdateEmployerName);
            this.pnlUpdateVacancy.Controls.Add(this.txtUpdateStatus);
            this.pnlUpdateVacancy.Controls.Add(this.btnUpdateCancel);
            this.pnlUpdateVacancy.Controls.Add(this.label13);
            this.pnlUpdateVacancy.Controls.Add(this.btnUpdateSaveChanges);
            this.pnlUpdateVacancy.Controls.Add(this.txtUpdateSalary);
            this.pnlUpdateVacancy.Controls.Add(this.txtUpdateDescription);
            this.pnlUpdateVacancy.Controls.Add(this.txtUpdateVacancyID);
            this.pnlUpdateVacancy.Controls.Add(this.label9);
            this.pnlUpdateVacancy.Controls.Add(this.label10);
            this.pnlUpdateVacancy.Controls.Add(this.label11);
            this.pnlUpdateVacancy.Controls.Add(this.label12);
            this.pnlUpdateVacancy.Location = new System.Drawing.Point(18, 615);
            this.pnlUpdateVacancy.Name = "pnlUpdateVacancy";
            this.pnlUpdateVacancy.Size = new System.Drawing.Size(458, 238);
            this.pnlUpdateVacancy.TabIndex = 21;
            // 
            // txtUpdateEmployerName
            // 
            this.txtUpdateEmployerName.Location = new System.Drawing.Point(166, 151);
            this.txtUpdateEmployerName.Name = "txtUpdateEmployerName";
            this.txtUpdateEmployerName.Size = new System.Drawing.Size(231, 20);
            this.txtUpdateEmployerName.TabIndex = 24;
            // 
            // txtUpdateStatus
            // 
            this.txtUpdateStatus.Location = new System.Drawing.Point(166, 77);
            this.txtUpdateStatus.Name = "txtUpdateStatus";
            this.txtUpdateStatus.Size = new System.Drawing.Size(108, 20);
            this.txtUpdateStatus.TabIndex = 23;
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(306, 192);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(135, 31);
            this.btnUpdateCancel.TabIndex = 22;
            this.btnUpdateCancel.Text = "Cancel";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(129, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Status:";
            // 
            // btnUpdateSaveChanges
            // 
            this.btnUpdateSaveChanges.Location = new System.Drawing.Point(34, 192);
            this.btnUpdateSaveChanges.Name = "btnUpdateSaveChanges";
            this.btnUpdateSaveChanges.Size = new System.Drawing.Size(135, 31);
            this.btnUpdateSaveChanges.TabIndex = 21;
            this.btnUpdateSaveChanges.Text = "Save Changes";
            this.btnUpdateSaveChanges.UseVisualStyleBackColor = true;
            this.btnUpdateSaveChanges.Click += new System.EventHandler(this.btnUpdateSaveChanges_Click);
            // 
            // txtUpdateSalary
            // 
            this.txtUpdateSalary.Location = new System.Drawing.Point(166, 115);
            this.txtUpdateSalary.Name = "txtUpdateSalary";
            this.txtUpdateSalary.Size = new System.Drawing.Size(107, 20);
            this.txtUpdateSalary.TabIndex = 18;
            // 
            // txtUpdateDescription
            // 
            this.txtUpdateDescription.Location = new System.Drawing.Point(166, 43);
            this.txtUpdateDescription.Name = "txtUpdateDescription";
            this.txtUpdateDescription.Size = new System.Drawing.Size(231, 20);
            this.txtUpdateDescription.TabIndex = 16;
            // 
            // txtUpdateVacancyID
            // 
            this.txtUpdateVacancyID.Location = new System.Drawing.Point(166, 11);
            this.txtUpdateVacancyID.Name = "txtUpdateVacancyID";
            this.txtUpdateVacancyID.Size = new System.Drawing.Size(44, 20);
            this.txtUpdateVacancyID.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(85, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Employer Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(130, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Salary:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(106, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Description:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(103, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Vacancy ID:";
            // 
            // VacancyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.pnlUpdateVacancy);
            this.Controls.Add(this.pnlAddVacancy);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnMarkVacancy);
            this.Controls.Add(this.btnDeleteVacancy);
            this.Controls.Add(this.btnUpdateVacancy);
            this.Controls.Add(this.btnAddVacancy);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtEmployerName);
            this.Controls.Add(this.txtEmployerID);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtVacancyID);
            this.Controls.Add(this.lblVacancyID);
            this.Controls.Add(this.lstVacancyDescription);
            this.Name = "VacancyForm";
            this.Text = "Vacancy Maintenance";
            this.pnlAddVacancy.ResumeLayout(false);
            this.pnlAddVacancy.PerformLayout();
            this.pnlUpdateVacancy.ResumeLayout(false);
            this.pnlUpdateVacancy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstVacancyDescription;
        private System.Windows.Forms.Label lblVacancyID;
        private System.Windows.Forms.TextBox txtVacancyID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtEmployerID;
        private System.Windows.Forms.TextBox txtEmployerName;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddVacancy;
        private System.Windows.Forms.Button btnUpdateVacancy;
        private System.Windows.Forms.Button btnDeleteVacancy;
        private System.Windows.Forms.Button btnMarkVacancy;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlAddVacancy;
        private System.Windows.Forms.Button btnAddSaveVacancy;
        private System.Windows.Forms.ComboBox cboAddEmployerName;
        private System.Windows.Forms.ComboBox cboAddEmployerID;
        private System.Windows.Forms.TextBox txtAddSalary;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.TextBox txtAddVacancyID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddCancel;
        private System.Windows.Forms.Panel pnlUpdateVacancy;
        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.Button btnUpdateSaveChanges;
        private System.Windows.Forms.TextBox txtUpdateSalary;
        private System.Windows.Forms.TextBox txtUpdateDescription;
        private System.Windows.Forms.TextBox txtUpdateVacancyID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUpdateStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUpdateEmployerName;
        private System.Windows.Forms.ToolTip ttpVacancy;
    }
}