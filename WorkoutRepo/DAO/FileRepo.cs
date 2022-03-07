using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutRepo.Events;
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
            HashSet<Exercise> exercises = GetExercises().ToHashSet();
            if (exercises.Contains(exercise))
            {
                Exercise updatedExercise = updateExercise(exercises, exercise);
                exercises.Remove(exercise);
                exercises.Add(updatedExercise);
            }
            else
            {
                exercises.Add(exercise);

            }
            File.WriteAllLines(pathExercises, exercises.Select(e => e.FormatForFileLine()));
        }

        private Exercise updateExercise(HashSet<Exercise> exercises, Exercise exercise)
        {
            Exercise e = new Exercise();
            exercises.TryGetValue(exercise, out e);
            Exercise updatedExercise = new Exercise();
            updatedExercise.ExerciseName = e.ExerciseName;
            updatedExercise.Id = e.Id;
            updatedExercise.Sets = new Dictionary<DateTime, List<Set>>();
            for (int i = 0; i < e.Sets.Count; i++)
            {
                updatedExercise.Sets.Add(e.Sets.ElementAt(i).Key, e.Sets.ElementAt(i).Value);
            }
            for (int i = 0; i < exercise.Sets.Count; i++)
            {
                string date = exercise.Sets.ElementAt(i).Key.ToString("dd.MM.yyyy");
                if (!updatedExercise.Sets.ContainsKey(DateTime.Parse(date)))
                {
                    updatedExercise.Sets.Add(exercise.Sets.ElementAt(i).Key, exercise.Sets.ElementAt(i).Value); 
                }
            }

            return updatedExercise;
        }

        public void AddMultipleExercises(List<Exercise> exercises)
        {
            HashSet<Exercise> orginalExercises = GetExercises().ToHashSet();
            foreach (var e in exercises)
            {
                if (orginalExercises.Contains(e))
                {
                    Exercise updatedExercise = updateExercise(orginalExercises, e);
                    orginalExercises.Remove(e);
                    orginalExercises.Add(updatedExercise);
                }
                else
                {
                    orginalExercises.Add(e);
                }
            }
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
                foreach (var line in lines)
                {
                    try
                    {
                        exercises.Add(Exercise.ParseFromFileLine(line));
                    }
                    catch (Exception e)
                    {
                    Console.WriteLine(e.Message);
                    }
                }
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
