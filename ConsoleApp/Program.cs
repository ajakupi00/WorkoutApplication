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
            ErrorDelegate onError = Inform;
            Exercise bench = new Exercise()
            {
                Id = 1,
                ExerciseName = "Bench",
                Sets = new Dictionary<DateTime, List<Set>>()
                {
                    {DateTime.Now, new List<Set>()
                    {
                        new Set()
                        {
                            Id = 1,Reps = 12, Weight = 40
                        },
                        new Set
                        {
                            Id = 2, Reps = 4, Weight = 120
                        }
                    }
                    },
                     {DateTime.Now.AddDays(1), new List<Set>()
                    {
                        new Set()
                        {
                            Id = 1,Reps = 12, Weight = 40
                        },
                        new Set
                        {
                            Id = 2, Reps = 4, Weight = 120
                        }
                    }

                }
            }
            };
            IRepo repo = RepoFactory.GetRepo();
            try
            {
                repo.AddExercise(bench);
                repo.GetExercises().ToList().ForEach(e => Console.WriteLine(e));
            }
            catch (Exception e)
            {
                onError(e.Message);
            }


        }

        private static void Inform(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private delegate void ErrorDelegate(string message);
    }
}
