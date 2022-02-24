using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutRepo.Models;

namespace WorkoutRepo.DAO
{
    public interface IRepo
    {
        void AddExercise(Exercise exercise);
        void AddMultipleExercises(List<Exercise> exercises);
        void AddWorkout(Workout workout);


        IList<Exercise> GetExercises();
        IList<Workout> GetWorkouts();
    }
}
