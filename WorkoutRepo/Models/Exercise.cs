using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutRepo.Models
{
    public class Exercise : IComparable<Exercise>
    {
        private const char del = '§';
        private const char repsJoiner = '-';
        private static int id_generator = 1;
        private int id;
        private const string date_format = "dd.mm.yyyy";

        public Exercise()
        {
            id = id_generator++;
        }
        public int Id { get => id;}
        public string ExerciseName { get; set; }
        public List<Set> Sets { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
         => $"{id}. {ExerciseName}: {string.Join(", ", Sets.ConvertAll(set => set.ToString()))} ({Date.ToString(date_format)})";

        internal string FormatForFileLine()
         => $"{id}{del}{ExerciseName}{del}{string.Join($"{repsJoiner}", Sets.ConvertAll(set => set.FormatForFileLine()))}{del}{Date.ToString(date_format)}";
        internal static Exercise ParseFromFileLine(string line)
        {
            string[] details = line.Split(del);
            return new Exercise
            {
                ExerciseName = details[1],
                Sets = setsConverter(details[2]),
                Date = DateTime.ParseExact(details[3], date_format, null)
            };
        }

        private static List<Set> setsConverter(string line)
        {
            List<Set> sets = new List<Set>();
            string[] details = line.Split(repsJoiner);
            foreach (var d in details)
            {
                sets.Add(Set.ParseFromFileLine(d));
            }
            return sets;
        }

        public int CompareTo(Exercise other) => ExerciseName.CompareTo(other.ExerciseName);

        public override bool Equals(object obj)
        {
            return obj is Exercise exercise &&
                   ExerciseName == exercise.ExerciseName;
        }

        public override int GetHashCode() => ExerciseName.GetHashCode();
    }
}
