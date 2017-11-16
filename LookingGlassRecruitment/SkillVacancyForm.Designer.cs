namespace LookingGlassRecruitment
{
    partial class SkillVacancyForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVacancy = new System.Windows.Forms.DataGridView();
            this.dgvVacancySkill = new System.Windows.Forms.DataGridView();
            this.dgvSkill = new System.Windows.Forms.DataGridView();
            this.btnAssignSkill = new System.Windows.Forms.Button();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.lblYears = new System.Windows.Forms.Label();
            this.btnRemoveSkill = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.ttpVacancySkill = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancySkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkill)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVacancy
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvVacancy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVacancy.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvVacancy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacancy.Location = new System.Drawing.Point(105, 12);
            this.dgvVacancy.Name = "dgvVacancy";
            this.dgvVacancy.Size = new System.Drawing.Size(566, 243);
            this.dgvVacancy.TabIndex = 0;
            // 
            // dgvVacancySkill
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgvVacancySkill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVacancySkill.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvVacancySkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacancySkill.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvVacancySkill.Location = new System.Drawing.Point(12, 275);
            this.dgvVacancySkill.Name = "dgvVacancySkill";
            this.dgvVacancySkill.Size = new System.Drawing.Size(335, 216);
            this.dgvVacancySkill.TabIndex = 1;
            // 
            // dgvSkill
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvSkill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSkill.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkill.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvSkill.Location = new System.Drawing.Point(511, 275);
            this.dgvSkill.Name = "dgvSkill";
            this.dgvSkill.Size = new System.Drawing.Size(261, 216);
            this.dgvSkill.TabIndex = 2;
            // 
            // btnAssignSkill
            // 
            this.btnAssignSkill.Location = new System.Drawing.Point(367, 275);
            this.btnAssignSkill.Name = "btnAssignSkill";
            this.btnAssignSkill.Size = new System.Drawing.Size(123, 38);
            this.btnAssignSkill.TabIndex = 3;
            this.btnAssignSkill.Text = "Assign Skill";
            this.btnAssignSkill.UseVisualStyleBackColor = true;
            this.btnAssignSkill.Click += new System.EventHandler(this.btnAssignSkill_Click);
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(405, 366);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(65, 20);
            this.txtYears.TabIndex = 4;
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(364, 369);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(37, 13);
            this.lblYears.TabIndex = 5;
            this.lblYears.Text = "Years:";
            // 
            // btnRemoveSkill
            // 
            this.btnRemoveSkill.Location = new System.Drawing.Point(367, 453);
            this.btnRemoveSkill.Name = "btnRemoveSkill";
            this.btnRemoveSkill.Size = new System.Drawing.Size(123, 38);
            this.btnRemoveSkill.TabIndex = 6;
            this.btnRemoveSkill.Text = "Remove Skill";
            this.btnRemoveSkill.UseVisualStyleBackColor = true;
            this.btnRemoveSkill.Click += new System.EventHandler(this.btnRemoveSkill_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(649, 511);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(123, 38);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // SkillVacancyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemoveSkill);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.btnAssignSkill);
            this.Controls.Add(this.dgvSkill);
            this.Controls.Add(this.dgvVacancySkill);
            this.Controls.Add(this.dgvVacancy);
            this.Name = "SkillVacancyForm";
            this.Text = "Assign Skill to a Vacancy";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacancySkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVacancy;
        private System.Windows.Forms.DataGridView dgvVacancySkill;
        private System.Windows.Forms.DataGridView dgvSkill;
        private System.Windows.Forms.Button btnAssignSkill;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Button btnRemoveSkill;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ToolTip ttpVacancySkill;
    }
}