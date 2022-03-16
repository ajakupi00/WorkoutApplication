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
    public partial class ViewExeciseForm : Form
    {
        private Exercise exercise;
        private DateTime selectedDate;
        private const string date_format = "dd.MM.yyyy";

        public ViewExeciseForm(Exercise selectedExercise)
        {
            InitializeComponent();
            exercise = selectedExercise;
            this.Text = selectedExercise.ExerciseName;
        }

        private void ViewExeciseForm_Load(object sender, EventArgs e)
        {
            foreach (var date in exercise.Sets.Keys)
            {
                cbDates.Items.Add(date.ToString(date_format));
            }
            cbDates.Text = "Select available dates..";
        }

        private void FillListView()
        {
            foreach (var item in exercise.Sets[selectedDate])
            {
                string[] details = { item.Id.ToString(), item.Reps.ToString(), $"{item.Weight.ToString()}kg" };
                var listViewItem = new ListViewItem(details);
                lvSets.Items.Add(listViewItem);
                cbDates.Text = "Find available dates..";
            }
        }


        private void cbDates_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lvSets.Items.Clear();
            DateTime date = DateTime.Parse(cbDates.SelectedItem.ToString());
            selectedDate = date;
            FillListView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
