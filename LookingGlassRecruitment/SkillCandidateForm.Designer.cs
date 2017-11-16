namespace LookingGlassRecruitment
{
    partial class SkillCandidateForm
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
            this.dgvCandidate = new System.Windows.Forms.DataGridView();
            this.dgvCandidateSkill = new System.Windows.Forms.DataGridView();
            this.btnAssignSkill = new System.Windows.Forms.Button();
            this.lblYears = new System.Windows.Forms.Label();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.dgvSkill = new System.Windows.Forms.DataGridView();
            this.btnRemoveSkill = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.ttpSkillCandidate = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateSkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkill)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCandidate
            // 
            this.dgvCandidate.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCandidate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidate.Location = new System.Drawing.Point(73, 15);
            this.dgvCandidate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCandidate.Name = "dgvCandidate";
            this.dgvCandidate.Size = new System.Drawing.Size(883, 302);
            this.dgvCandidate.TabIndex = 0;
            // 
            // dgvCandidateSkill
            // 
            this.dgvCandidateSkill.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCandidateSkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidateSkill.Location = new System.Drawing.Point(16, 348);
            this.dgvCandidateSkill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCandidateSkill.Name = "dgvCandidateSkill";
            this.dgvCandidateSkill.Size = new System.Drawing.Size(453, 267);
            this.dgvCandidateSkill.TabIndex = 1;
            // 
            // btnAssignSkill
            // 
            this.btnAssignSkill.Location = new System.Drawing.Point(500, 350);
            this.btnAssignSkill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAssignSkill.Name = "btnAssignSkill";
            this.btnAssignSkill.Size = new System.Drawing.Size(155, 47);
            this.btnAssignSkill.TabIndex = 2;
            this.btnAssignSkill.Text = "Assign Skill";
            this.btnAssignSkill.UseVisualStyleBackColor = true;
            this.btnAssignSkill.Click += new System.EventHandler(this.btnAssignSkill_Click);
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(497, 468);
            this.lblYears.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(49, 17);
            this.lblYears.TabIndex = 3;
            this.lblYears.Text = "Years:";
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(552, 464);
            this.txtYears.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(83, 22);
            this.txtYears.TabIndex = 4;
            // 
            // dgvSkill
            // 
            this.dgvSkill.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSkill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkill.Location = new System.Drawing.Point(680, 350);
            this.dgvSkill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvSkill.Name = "dgvSkill";
            this.dgvSkill.Size = new System.Drawing.Size(349, 266);
            this.dgvSkill.TabIndex = 5;
            // 
            // btnRemoveSkill
            // 
            this.btnRemoveSkill.Location = new System.Drawing.Point(500, 569);
            this.btnRemoveSkill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveSkill.Name = "btnRemoveSkill";
            this.btnRemoveSkill.Size = new System.Drawing.Size(155, 47);
            this.btnRemoveSkill.TabIndex = 6;
            this.btnRemoveSkill.Text = "Remove Skill";
            this.btnRemoveSkill.UseVisualStyleBackColor = true;
            this.btnRemoveSkill.Click += new System.EventHandler(this.btnRemoveSkill_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(876, 630);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(153, 46);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // SkillCandidateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemoveSkill);
            this.Controls.Add(this.dgvSkill);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.btnAssignSkill);
            this.Controls.Add(this.dgvCandidateSkill);
            this.Controls.Add(this.dgvCandidate);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SkillCandidateForm";
            this.Text = "Assign Skill to a Candidate";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidateSkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCandidate;
        private System.Windows.Forms.DataGridView dgvCandidateSkill;
        private System.Windows.Forms.Button btnAssignSkill;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.DataGridView dgvSkill;
        private System.Windows.Forms.Button btnRemoveSkill;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ToolTip ttpSkillCandidate;
    }
}