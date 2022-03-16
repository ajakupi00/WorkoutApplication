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
            this.lblExerciseName = new System.Windows.Forms.Label();
            this.tbExerciseName = new System.Windows.Forms.TextBox();
            this.btnCheckName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblExerciseName
            // 
            this.lblExerciseName.AutoSize = true;
            this.lblExerciseName.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.lblExerciseName.Location = new System.Drawing.Point(12, 20);
            this.lblExerciseName.Name = "lblExerciseName";
            this.lblExerciseName.Size = new System.Drawing.Size(121, 23);
            this.lblExerciseName.TabIndex = 0;
            this.lblExerciseName.Text = "Exercise Name";
            // 
            // tbExerciseName
            // 
            this.tbExerciseName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbExerciseName.Location = new System.Drawing.Point(16, 46);
            this.tbExerciseName.Name = "tbExerciseName";
            this.tbExerciseName.Size = new System.Drawing.Size(317, 25);
            this.tbExerciseName.TabIndex = 1;
            this.tbExerciseName.TextChanged += new System.EventHandler(this.tbExerciseName_TextChanged);
            // 
            // btnCheckName
            // 
            this.btnCheckName.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnCheckName.Location = new System.Drawing.Point(339, 46);
            this.btnCheckName.Name = "btnCheckName";
            this.btnCheckName.Size = new System.Drawing.Size(127, 25);
            this.btnCheckName.TabIndex = 2;
            this.btnCheckName.Text = "Check Name";
            this.btnCheckName.UseVisualStyleBackColor = true;
            this.btnCheckName.Click += new System.EventHandler(this.btnCheckName_Click);
            // 
            // AddExerciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 462);
            this.Controls.Add(this.btnCheckName);
            this.Controls.Add(this.tbExerciseName);
            this.Controls.Add(this.lblExerciseName);
            this.Name = "AddExerciseForm";
            this.Text = "AddExerciseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExerciseName;
        private System.Windows.Forms.TextBox tbExerciseName;
        private System.Windows.Forms.Button btnCheckName;
    }
}