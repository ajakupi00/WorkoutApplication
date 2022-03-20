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

            IRepo repo = RepoFactory.GetRepo();
            try
            {
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
