using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkoutRepo.DAO;
using WorkoutRepo.Models;

namespace DesktopApp
{
    public partial class mainForm : Form
    {
        private IRepo repo = RepoFactory.GetRepo();
        private List<Exercise> exercises;
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            UpdateMainForm();
        }

        private void UpdateMainForm()
        {
            lbExercises.Items.Clear();
            exercises = repo.GetExercises().ToList();
            foreach (Exercise ex in exercises)
            {
                lbExercises.Items.Add($"{ex.ExerciseName}");
            }
        }

        private void btnViewExercise_Click(object sender, EventArgs e)
        {
            if (lbExercises.SelectedItem == null)
            {
                return;
            }
            string name = lbExercises.SelectedItem.ToString();
            Exercise selectedExercise = new Exercise();
            selectedExercise = exercises.FirstOrDefault(ex => ex.ExerciseName == name);
            ViewExeciseForm execiseForm = new ViewExeciseForm(selectedExercise);
            execiseForm.Show();
        }

        private void btnAddExercise_Click(object sender, EventArgs e)
        {
            AddExerciseForm exerciseForm = new AddExerciseForm(exercises);
            exerciseForm.Show();
        }

        private void btnAddWorkout_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateMainForm();
        }
    }
}
