using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutRepo.Models;

namespace WorkoutRepo.DAO
{
    class FileRepo : IRepo
    {
        private const string dir = @"c:/temp";
        private const string pathExercises = dir +  @"/exercises.txt";
        private const string pathWorkouts = dir +  @"/workouts.txt";

        public FileRepo()
        {
            Directory.CreateDirectory(dir);
            if (!File.Exists(pathExercises))
            {
                File.Create(pathExercises).Close();
            }
            if (!File.Exists(pathWorkouts))
            {
                File.Create(pathWorkouts).Close();
            }
        }

        public void AddExercise(Exercise exercise)
        {
            IList<Exercise> exercises = GetExercises();
            exercises.Add(exercise);
            File.WriteAllLines(pathExercises, exercises.Select(e => e.FormatForFileLine()));
        }

        public void AddMultipleExercises(List<Exercise> exercises)
        {
            IList<Exercise> orginalExercises = GetExercises();
            exercises.ForEach(e => orginalExercises.Add(e));
            File.WriteAllLines(pathExercises, orginalExercises.Select(e => e.FormatForFileLine()));
        }

        public void AddWorkout(Workout workout)
        {
            AddMultipleExercises(workout.Exercises);
            IList<Workout> workouts = GetWorkouts();
            workouts.Add(workout);
            File.WriteAllLines(pathWorkouts, workouts.Select(w => w.FormatForFileLine()));

        }

        public IList<Exercise> GetExercises()
        {
            IList<Exercise> exercises = new List<Exercise>();
            string[] lines = File.ReadAllLines(pathExercises);
            lines.ToList().ForEach(line => exercises.Add(Exercise.ParseFromFileLine(line)));
            return exercises;
        }

        public IList<Workout> GetWorkouts()
        {
            IList<Workout> workouts = new List<Workout>();
            string[] lines = File.ReadAllLines(pathWorkouts);
            lines.ToList().ForEach(line => workouts.Add(Workout.ParseFromFileLine(line)));
            return workouts;
        }
    }
}
