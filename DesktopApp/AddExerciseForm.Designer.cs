namespace DesktopApp
{
    partial class AddExerciseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExerciseForm));
            this.lblExerciseName = new System.Windows.Forms.Label();
            this.tbExerciseName = new System.Windows.Forms.TextBox();
            this.btnCheckName = new System.Windows.Forms.Button();
            this.calendarDate = new System.Windows.Forms.MonthCalendar();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblSets = new System.Windows.Forms.Label();
            this.numReps = new System.Windows.Forms.NumericUpDown();
            this.lblReps = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.numWeight = new System.Windows.Forms.NumericUpDown();
            this.lblWeightUnit = new System.Windows.Forms.Label();
            this.btnAddSet = new System.Windows.Forms.Button();
            this.btnResetSet = new System.Windows.Forms.Button();
            this.btnResetAllSets = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.tbnGiveUp = new System.Windows.Forms.Button();
            this.btnAddExercise = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numReps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExerciseName
            // 
            this.lblExerciseName.AutoSize = true;
            this.lblExerciseName.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Underline);
            this.lblExerciseName.Location = new System.Drawing.Point(16, 25);
            this.lblExerciseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExerciseName.Name = "lblExerciseName";
            this.lblExerciseName.Size = new System.Drawing.Size(149, 30);
            this.lblExerciseName.TabIndex = 0;
            this.lblExerciseName.Text = "Exercise Name";
            // 
            // tbExerciseName
            // 
            this.tbExerciseName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbExerciseName.Location = new System.Drawing.Point(21, 57);
            this.tbExerciseName.Margin = new System.Windows.Forms.Padding(4);
            this.tbExerciseName.Name = "tbExerciseName";
            this.tbExerciseName.Size = new System.Drawing.Size(495, 30);
            this.tbExerciseName.TabIndex = 1;
            this.tbExerciseName.TextChanged += new System.EventHandler(this.tbExerciseName_TextChanged);
            // 
            // btnCheckName
            // 
            this.btnCheckName.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnCheckName.Location = new System.Drawing.Point(524, 56);
            this.btnCheckName.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckName.Name = "btnCheckName";
            this.btnCheckName.Size = new System.Drawing.Size(169, 31);
            this.btnCheckName.TabIndex = 2;
            this.btnCheckName.Text = "Check Name";
            this.btnCheckName.UseVisualStyleBackColor = true;
            this.btnCheckName.Click += new System.EventHandler(this.btnCheckName_Click);
            // 
            // calendarDate
            // 
            this.calendarDate.Location = new System.Drawing.Point(21, 138);
            this.calendarDate.Name = "calendarDate";
            this.calendarDate.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Underline);
            this.lblDate.Location = new System.Drawing.Point(16, 99);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(57, 30);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // lblSets
            // 
            this.lblSets.AutoSize = true;
            this.lblSets.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Underline);
            this.lblSets.Location = new System.Drawing.Point(309, 99);
            this.lblSets.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSets.Name = "lblSets";
            this.lblSets.Size = new System.Drawing.Size(105, 30);
            this.lblSets.TabIndex = 5;
            this.lblSets.Text = "Add N.set";
            // 
            // numReps
            // 
            this.numReps.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.numReps.Location = new System.Drawing.Point(381, 155);
            this.numReps.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numReps.Name = "numReps";
            this.numReps.Size = new System.Drawing.Size(273, 25);
            this.numReps.TabIndex = 6;
            // 
            // lblReps
            // 
            this.lblReps.AutoSize = true;
            this.lblReps.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblReps.Location = new System.Drawing.Point(310, 152);
            this.lblReps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReps.Name = "lblReps";
            this.lblReps.Size = new System.Drawing.Size(46, 23);
            this.lblReps.TabIndex = 7;
            this.lblReps.Text = "Reps";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWeight.Location = new System.Drawing.Point(310, 196);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(64, 23);
            this.lblWeight.TabIndex = 8;
            this.lblWeight.Text = "Weight";
            // 
            // numWeight
            // 
            this.numWeight.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.numWeight.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numWeight.Location = new System.Drawing.Point(381, 199);
            this.numWeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numWeight.Name = "numWeight";
            this.numWeight.Size = new System.Drawing.Size(273, 25);
            this.numWeight.TabIndex = 9;
            this.numWeight.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // lblWeightUnit
            // 
            this.lblWeightUnit.AutoSize = true;
            this.lblWeightUnit.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblWeightUnit.Location = new System.Drawing.Point(660, 201);
            this.lblWeightUnit.Name = "lblWeightUnit";
            this.lblWeightUnit.Size = new System.Drawing.Size(26, 19);
            this.lblWeightUnit.TabIndex = 10;
            this.lblWeightUnit.Text = "kg";
            // 
            // btnAddSet
            // 
            this.btnAddSet.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnAddSet.Location = new System.Drawing.Point(314, 252);
            this.btnAddSet.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSet.Name = "btnAddSet";
            this.btnAddSet.Size = new System.Drawing.Size(186, 31);
            this.btnAddSet.TabIndex = 11;
            this.btnAddSet.Text = "Add Set";
            this.btnAddSet.UseVisualStyleBackColor = true;
            this.btnAddSet.Click += new System.EventHandler(this.btnAddSet_Click);
            // 
            // btnResetSet
            // 
            this.btnResetSet.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnResetSet.Location = new System.Drawing.Point(508, 252);
            this.btnResetSet.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetSet.Name = "btnResetSet";
            this.btnResetSet.Size = new System.Drawing.Size(185, 31);
            this.btnResetSet.TabIndex = 12;
            this.btnResetSet.Text = "Reset Set";
            this.btnResetSet.UseVisualStyleBackColor = true;
            this.btnResetSet.Click += new System.EventHandler(this.btnResetSet_Click);
            // 
            // btnResetAllSets
            // 
            this.btnResetAllSets.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnResetAllSets.Location = new System.Drawing.Point(315, 291);
            this.btnResetAllSets.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetAllSets.Name = "btnResetAllSets";
            this.btnResetAllSets.Size = new System.Drawing.Size(378, 31);
            this.btnResetAllSets.TabIndex = 13;
            this.btnResetAllSets.Text = "Reset All Sets";
            this.btnResetAllSets.UseVisualStyleBackColor = true;
            this.btnResetAllSets.Click += new System.EventHandler(this.btnResetAllSets_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnResetForm.Location = new System.Drawing.Point(376, 418);
            this.btnResetForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(355, 31);
            this.btnResetForm.TabIndex = 14;
            this.btnResetForm.Text = "Reset All";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // tbnGiveUp
            // 
            this.tbnGiveUp.BackColor = System.Drawing.Color.Brown;
            this.tbnGiveUp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tbnGiveUp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbnGiveUp.Location = new System.Drawing.Point(13, 418);
            this.tbnGiveUp.Margin = new System.Windows.Forms.Padding(4);
            this.tbnGiveUp.Name = "tbnGiveUp";
            this.tbnGiveUp.Size = new System.Drawing.Size(355, 31);
            this.tbnGiveUp.TabIndex = 15;
            this.tbnGiveUp.Text = "Close";
            this.tbnGiveUp.UseVisualStyleBackColor = false;
            this.tbnGiveUp.Click += new System.EventHandler(this.tbnGiveUp_Click);
            // 
            // btnAddExercise
            // 
            this.btnAddExercise.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAddExercise.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold);
            this.btnAddExercise.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAddExercise.Location = new System.Drawing.Point(13, 457);
            this.btnAddExercise.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddExercise.Name = "btnAddExercise";
            this.btnAddExercise.Size = new System.Drawing.Size(718, 45);
            this.btnAddExercise.TabIndex = 16;
            this.btnAddExercise.Text = "Add Exercise";
            this.btnAddExercise.UseVisualStyleBackColor = false;
            this.btnAddExercise.Click += new System.EventHandler(this.btnAddExercise_Click);
            // 
            // AddExerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 515);
            this.Controls.Add(this.btnAddExercise);
            this.Controls.Add(this.tbnGiveUp);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnResetAllSets);
            this.Controls.Add(this.btnResetSet);
            this.Controls.Add(this.btnAddSet);
            this.Controls.Add(this.lblWeightUnit);
            this.Controls.Add(this.numWeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblReps);
            this.Controls.Add(this.numReps);
            this.Controls.Add(this.lblSets);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.calendarDate);
            this.Controls.Add(this.btnCheckName);
            this.Controls.Add(this.tbExerciseName);
            this.Controls.Add(this.lblExerciseName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddExerciseForm";
            this.Text = "Add New Exercise";
            this.Load += new System.EventHandler(this.AddExerciseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numReps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExerciseName;
        private System.Windows.Forms.TextBox tbExerciseName;
        private System.Windows.Forms.Button btnCheckName;
        private System.Windows.Forms.MonthCalendar calendarDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblSets;
        private System.Windows.Forms.NumericUpDown numReps;
        private System.Windows.Forms.Label lblReps;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.NumericUpDown numWeight;
        private System.Windows.Forms.Label lblWeightUnit;
        private System.Windows.Forms.Button btnAddSet;
        private System.Windows.Forms.Button btnResetSet;
        private System.Windows.Forms.Button btnResetAllSets;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button tbnGiveUp;
        public System.Windows.Forms.Button btnAddExercise;
    }
}