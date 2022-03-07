using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutRepo.DAO;

namespace WorkoutRepo.Models
{

    public class ExerciseManager
    {
        IRepo repo = RepoFactory.GetRepo();
        HashSet<Exercise> exercises;
        public ExerciseManager()
        {
            exercises = repo.GetExercises().ToHashSet();
        }
        public void AddExecise(Exercise exercise)
        {

        }

    }
}
