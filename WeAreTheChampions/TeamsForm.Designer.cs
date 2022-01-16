namespace WeAreTheChampions
{
    partial class TeamsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clbTeamColor = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.lstTeams = new System.Windows.Forms.ListBox();
            this.btnTeamEdit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Controls.Add(this.clbTeamColor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTeamName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit Team";
            // 
            // clbTeamColor
            // 
            this.clbTeamColor.FormattingEnabled = true;
            this.clbTeamColor.Location = new System.Drawing.Point(116, 72);
            this.clbTeamColor.Name = "clbTeamColor";
            this.clbTeamColor.Size = new System.Drawing.Size(162, 89);
            this.clbTeamColor.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Colors";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(116, 36);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(162, 22);
            this.txtTeamName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TeamName";
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddTeam.Location = new System.Drawing.Point(12, 296);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(123, 43);
            this.btnAddTeam.TabIndex = 1;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = false;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // lstTeams
            // 
            this.lstTeams.BackColor = System.Drawing.Color.Teal;
            this.lstTeams.FormattingEnabled = true;
            this.lstTeams.ItemHeight = 16;
            this.lstTeams.Location = new System.Drawing.Point(313, 12);
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.Size = new System.Drawing.Size(348, 324);
            this.lstTeams.TabIndex = 2;
            this.lstTeams.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstTeams_KeyDown);
            // 
            // btnTeamEdit
            // 
            this.btnTeamEdit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTeamEdit.Location = new System.Drawing.Point(158, 296);
            this.btnTeamEdit.Name = "btnTeamEdit";
            this.btnTeamEdit.Size = new System.Drawing.Size(149, 43);
            this.btnTeamEdit.TabIndex = 3;
            this.btnTeamEdit.Text = "Edit";
            this.btnTeamEdit.UseVisualStyleBackColor = false;
            this.btnTeamEdit.Click += new System.EventHandler(this.btnTeamEdit_Click);
            // 
            // TeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 352);
            this.Controls.Add(this.btnTeamEdit);
            this.Controls.Add(this.lstTeams);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.groupBox1);
            this.Name = "TeamsForm";
            this.Text = "TeamsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.ListBox lstTeams;
        private System.Windows.Forms.Button btnTeamEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clbTeamColor;
    }
}