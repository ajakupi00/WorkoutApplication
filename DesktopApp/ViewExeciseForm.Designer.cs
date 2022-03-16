namespace DesktopApp
{
    partial class ViewExeciseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewExeciseForm));
            this.cbDates = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvSets = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnReps = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbDates
            // 
            this.cbDates.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDates.FormattingEnabled = true;
            this.cbDates.Location = new System.Drawing.Point(16, 47);
            this.cbDates.Name = "cbDates";
            this.cbDates.Size = new System.Drawing.Size(236, 25);
            this.cbDates.TabIndex = 0;
            this.cbDates.SelectionChangeCommitted += new System.EventHandler(this.cbDates_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.5F);
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sets:";
            // 
            // lvSets
            // 
            this.lvSets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnReps,
            this.columnWeight});
            this.lvSets.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lvSets.HideSelection = false;
            this.lvSets.Location = new System.Drawing.Point(16, 136);
            this.lvSets.Name = "lvSets";
            this.lvSets.Size = new System.Drawing.Size(473, 209);
            this.lvSets.TabIndex = 3;
            this.lvSets.UseCompatibleStateImageBehavior = false;
            this.lvSets.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "Number";
            // 
            // columnReps
            // 
            this.columnReps.Text = "Reps";
            // 
            // columnWeight
            // 
            this.columnWeight.Text = "Weight";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnClose.Location = new System.Drawing.Point(507, 420);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 31);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ViewExeciseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 463);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lvSets);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbDates);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewExeciseForm";
            this.Text = "Exercise Name";
            this.Load += new System.EventHandler(this.ViewExeciseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvSets;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnReps;
        private System.Windows.Forms.ColumnHeader columnWeight;
        private System.Windows.Forms.Button btnClose;
    }
}