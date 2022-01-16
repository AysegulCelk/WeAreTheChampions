namespace WeAreTheChampions
{
    partial class ColorsForm
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
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.btnColorEdit = new System.Windows.Forms.Button();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.txtColorName = new System.Windows.Forms.TextBox();
            this.nudColorBlue = new System.Windows.Forms.NumericUpDown();
            this.nudColorGreen = new System.Windows.Forms.NumericUpDown();
            this.nudColorRed = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstColor = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColorBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColorGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColorRed)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Controls.Add(this.pbColor);
            this.groupBox1.Controls.Add(this.btnColorEdit);
            this.groupBox1.Controls.Add(this.btnAddColor);
            this.groupBox1.Controls.Add(this.txtColorName);
            this.groupBox1.Controls.Add(this.nudColorBlue);
            this.groupBox1.Controls.Add(this.nudColorGreen);
            this.groupBox1.Controls.Add(this.nudColorRed);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pbColor
            // 
            this.pbColor.Location = new System.Drawing.Point(91, 67);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(29, 28);
            this.pbColor.TabIndex = 2;
            this.pbColor.TabStop = false;
            // 
            // btnColorEdit
            // 
            this.btnColorEdit.Location = new System.Drawing.Point(91, 247);
            this.btnColorEdit.Name = "btnColorEdit";
            this.btnColorEdit.Size = new System.Drawing.Size(82, 26);
            this.btnColorEdit.TabIndex = 1;
            this.btnColorEdit.Text = "Edit";
            this.btnColorEdit.UseVisualStyleBackColor = true;
            this.btnColorEdit.Click += new System.EventHandler(this.btnColorEdit_Click);
            // 
            // btnAddColor
            // 
            this.btnAddColor.Location = new System.Drawing.Point(6, 247);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Size = new System.Drawing.Size(75, 23);
            this.btnAddColor.TabIndex = 1;
            this.btnAddColor.Text = "Add";
            this.btnAddColor.UseVisualStyleBackColor = true;
            this.btnAddColor.Click += new System.EventHandler(this.btnAddColor_Click);
            // 
            // txtColorName
            // 
            this.txtColorName.Location = new System.Drawing.Point(91, 40);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(125, 22);
            this.txtColorName.TabIndex = 1;
            // 
            // nudColorBlue
            // 
            this.nudColorBlue.Location = new System.Drawing.Point(7, 206);
            this.nudColorBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudColorBlue.Name = "nudColorBlue";
            this.nudColorBlue.Size = new System.Drawing.Size(68, 22);
            this.nudColorBlue.TabIndex = 1;
            // 
            // nudColorGreen
            // 
            this.nudColorGreen.Location = new System.Drawing.Point(7, 155);
            this.nudColorGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudColorGreen.Name = "nudColorGreen";
            this.nudColorGreen.Size = new System.Drawing.Size(68, 22);
            this.nudColorGreen.TabIndex = 1;
            // 
            // nudColorRed
            // 
            this.nudColorRed.Location = new System.Drawing.Point(7, 101);
            this.nudColorRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudColorRed.Name = "nudColorRed";
            this.nudColorRed.Size = new System.Drawing.Size(68, 22);
            this.nudColorRed.TabIndex = 1;
            this.nudColorRed.ValueChanged += new System.EventHandler(this.nudColorRed_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Blue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Green";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Color Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red";
            // 
            // lstColor
            // 
            this.lstColor.BackColor = System.Drawing.SystemColors.Info;
            this.lstColor.FormattingEnabled = true;
            this.lstColor.ItemHeight = 16;
            this.lstColor.Location = new System.Drawing.Point(12, 337);
            this.lstColor.Name = "lstColor";
            this.lstColor.Size = new System.Drawing.Size(252, 84);
            this.lstColor.TabIndex = 1;
            this.lstColor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstColor_KeyDown);
            // 
            // ColorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeAreTheChampions.Properties.Resources.renklerinanlamlariblog;
            this.ClientSize = new System.Drawing.Size(292, 450);
            this.Controls.Add(this.lstColor);
            this.Controls.Add(this.groupBox1);
            this.Name = "ColorsForm";
            this.Text = "ColorsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColorBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColorGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudColorRed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnColorEdit;
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.TextBox txtColorName;
        private System.Windows.Forms.NumericUpDown nudColorBlue;
        private System.Windows.Forms.NumericUpDown nudColorGreen;
        private System.Windows.Forms.NumericUpDown nudColorRed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstColor;
        private System.Windows.Forms.PictureBox pbColor;
    }
}