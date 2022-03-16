using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkoutRepo.Models;

namespace DesktopApp
{
    public partial class AddExerciseForm : Form
    {
        private List<Exercise> exercises;
        public AddExerciseForm(List<Exercise> exercises)
        {
            InitializeComponent();
            this.exercises = exercises;
        }

        private void btnCheckName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbExerciseName.Text.Trim()))
            {
                MessageBox.Show("Exercise name is empty");
                return;
            }
            foreach (var ex in exercises)
            {
                if (ex.ExerciseName == tbExerciseName.Text)
                {
                    MessageBox.Show($"{ex.ExerciseName} already exists!");
                    tbExerciseName.Clear();
                    return;
                }
            }
            btnCheckName.BackColor = Color.Green;
            btnCheckName.ForeColor = Color.White;
        }

        private void tbExerciseName_TextChanged(object sender, EventArgs e)
        {
            btnCheckName.BackColor = SystemColors.Control;
            btnCheckName.ForeColor = SystemColors.ControlText;
        }
    }
}
