namespace DesktopApp
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.btnAddWorkout = new System.Windows.Forms.Button();
            this.btnAddExercise = new System.Windows.Forms.Button();
            this.btnViewExercise = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbExercises = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddWorkout
            // 
            this.btnAddWorkout.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddWorkout.Location = new System.Drawing.Point(16, 596);
            this.btnAddWorkout.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddWorkout.Name = "btnAddWorkout";
            this.btnAddWorkout.Size = new System.Drawing.Size(183, 55);
            this.btnAddWorkout.TabIndex = 0;
            this.btnAddWorkout.Text = "Add Workout";
            this.btnAddWorkout.UseVisualStyleBackColor = true;
            this.btnAddWorkout.Click += new System.EventHandler(this.btnAddWorkout_Click);
            // 
            // btnAddExercise
            // 
            this.btnAddExercise.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddExercise.Location = new System.Drawing.Point(207, 596);
            this.btnAddExercise.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddExercise.Name = "btnAddExercise";
            this.btnAddExercise.Size = new System.Drawing.Size(183, 55);
            this.btnAddExercise.TabIndex = 1;
            this.btnAddExercise.Text = "Add Exercise";
            this.btnAddExercise.UseVisualStyleBackColor = true;
            this.btnAddExercise.Click += new System.EventHandler(this.btnAddExercise_Click);
            // 
            // btnViewExercise
            // 
            this.btnViewExercise.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnViewExercise.Location = new System.Drawing.Point(397, 596);
            this.btnViewExercise.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewExercise.Name = "btnViewExercise";
            this.btnViewExercise.Size = new System.Drawing.Size(183, 55);
            this.btnViewExercise.TabIndex = 2;
            this.btnViewExercise.Text = "View Exercise";
            this.btnViewExercise.UseVisualStyleBackColor = true;
            this.btnViewExercise.Click += new System.EventHandler(this.btnViewExercise_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Exercises";
            // 
            // lbExercises
            // 
            this.lbExercises.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbExercises.FormattingEnabled = true;
            this.lbExercises.ItemHeight = 32;
            this.lbExercises.Location = new System.Drawing.Point(29, 47);
            this.lbExercises.Margin = new System.Windows.Forms.Padding(4);
            this.lbExercises.Name = "lbExercises";
            this.lbExercises.ScrollAlwaysVisible = true;
            this.lbExercises.Size = new System.Drawing.Size(585, 292);
            this.lbExercises.TabIndex = 5;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Location = new System.Drawing.Point(908, 625);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(135, 28);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // mainForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 666);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lbExercises);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewExercise);
            this.Controls.Add(this.btnAddExercise);
            this.Controls.Add(this.btnAddWorkout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mainForm";
            this.Text = "Workout Application";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddWorkout;
        private System.Windows.Forms.Button btnAddExercise;
        private System.Windows.Forms.Button btnViewExercise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbExercises;
        private System.Windows.Forms.Button btnRefresh;
    }
}

