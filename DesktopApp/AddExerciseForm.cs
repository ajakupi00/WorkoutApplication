using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkoutRepo;
using WorkoutRepo.DAO;
using WorkoutRepo.Models;

namespace DesktopApp
{
    public partial class AddExerciseForm : Form
    {
        private IRepo repo = RepoFactory.GetRepo();
        private static int exerciseId;
        private List<Exercise> exercises;
        private int setsCounter = 1;
        private List<Set> sets = new List<Set>();
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

        private void AddExerciseForm_Load(object sender, EventArgs e)
        {
            IncrementSetsText();
            UpdateExerciseId();
        }

        private void UpdateExerciseId()
        {
            int counter = repo.GetExercises().ToList().Count();
            exerciseId = counter;
        }

        private void IncrementSetsText()
        {
            lblSets.Text = $"{setsCounter}.Set";
        }

        private void btnAddSet_Click(object sender, EventArgs e)
        {
            if (numReps.Value == 0)
            {
                MessageBox.Show("Fill the sets field.");
                return;
            }
            sets.Add(new Set { Id = setsCounter, Reps = short.Parse(numReps.Value.ToString()), Weight = double.Parse(numWeight.Value.ToString()) });
            ResetNumericValues();
            setsCounter++;
            IncrementSetsText();
        }

        private void ResetNumericValues()
        {
            numReps.Value = 0;
            numWeight.Value = 0;
        }

        private void btnResetSet_Click(object sender, EventArgs e)
        {
            ResetNumericValues();
        }

        private void btnResetAllSets_Click(object sender, EventArgs e)
        {
            sets.Clear();
            setsCounter = 1;
            IncrementSetsText();
        }

        private void tbnGiveUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetNumericValues();
            calendarDate.SelectionEnd = DateTime.Today;
            tbExerciseName.Text = "";
        }

        private void btnAddExercise_Click(object sender, EventArgs e)
        {

            Exercise exercise = new Exercise()
            {
                Id = ++exerciseId,
                ExerciseName = tbExerciseName.Text
            };
            exercise.Sets = new Dictionary<DateTime, List<Set>>();
            exercise.Sets.Add(calendarDate.SelectionEnd, sets);
            repo.AddExercise(exercise);
            MessageBox.Show("Succesfuly added the exercise!");
            this.Close();
        }
    }
}
