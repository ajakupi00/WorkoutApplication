using System;
using WorkoutRepo.Models;
using WorkoutRepo.DAO;
using System.Collections.Generic;
using System.Collections;
using System.Numerics;
using WorkoutRepo;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepo repo = RepoFactory.GetRepo();
            Exercise benchpress = new Exercise()
            {
                ExerciseName = "Benchpress",
                Date = DateTime.Now,
                Sets = new List<Set>()
                {
                    new Set()
                    {
                        Reps = 12,
                        Weight = 40
                    },
                    new Set()
                    {
                        Reps = 8,
                        Weight = 60
                    },
                    new Set()
                    {
                        Reps = 8,
                        Weight = 72.5
                    }
                },
            };
            Exercise squat = new Exercise()
            {
                ExerciseName = "Barbell Squat",
                Date = DateTime.Now,
                Sets = new List<Set>()
                {
                    new Set()
                    {
                        Reps = 12,
                        Weight = 80
                    },
                    new Set()
                    {
                        Reps = 8,
                        Weight = 90.5
                    },
                    new Set()
                    {
                        Reps = 5,
                        Weight = 125
                    }
                },
            };
            Workout workout = new Workout()
            {
                Date = DateTime.Now,
                Exercises = new List<Exercise>() { benchpress, squat },
                Quality = IndexOfQuality.EXCELLENT
            };
            repo.AddWorkout(workout);
            IList<Workout> workouts = repo.GetWorkouts();
            workouts.ToList().ForEach(w => Console.WriteLine(w));

        }
    }
}
