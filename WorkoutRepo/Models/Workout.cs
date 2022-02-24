using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutRepo.Models
{
    public enum IndexOfQuality
    {
        AWFUL, BAD, AVG, GOOD, EXCELLENT, NONE
    }
    public class Workout
    {
        private const char del = '#';
        private const char exerciseJoiner = '@';
        private static int num_of_exercises = 0;
        private static int id_generator = 1;
        private int id;
        public Workout()
        {
            num_of_exercises++;
            id = id_generator++;
        }
        private const string date_format = "dd:mm:yyyy";
        public List<Exercise> Exercises { get; set; }
        public DateTime Date { get; set; }
        public IndexOfQuality Quality { get; set; }
        public int Id { get => id; }
        public override string ToString()
            => $"{id}. Workout({Date.ToString(date_format)}):\n" +
                $"\t{string.Join("\n\t", Exercises.ConvertAll(e => e.ToString()))}\n" +
                $"\tQuality: {Quality}";

        internal string FormatForFileLine()
            => $"{id}{del}{Date.ToString(date_format)}{del}" +
            $"{string.Join($"{exerciseJoiner}", Exercises.ConvertAll(e => e.FormatForFileLine()))}" +
            $"{del}{Quality}";
        internal static Workout ParseFromFileLine(string line)
        {
            string[] details = line.Split(del);
            return new Workout
            {
                Date = DateTime.ParseExact(details[1], date_format, null),
                Exercises = exerciseConverter(details[2]),
                Quality = qualityConverter(details[3])
            };
        }

        private static IndexOfQuality qualityConverter(string v)
        {
            if (v == "AWFUL")
                return IndexOfQuality.AWFUL;
            else if (v == "BAD")
                return IndexOfQuality.BAD;
            else if (v == "AVG")
                return IndexOfQuality.AVG;
            else if (v == "GOOD")
                return IndexOfQuality.GOOD;
            else if (v == "EXCELLENT")
                return IndexOfQuality.EXCELLENT;
            else
                return IndexOfQuality.NONE;
        }

        private static List<Exercise> exerciseConverter(string line)
        {
            List<Exercise> exercises = new List<Exercise>();
            string[] details = line.Split(exerciseJoiner);
            foreach (var d in details)
            {
                exercises.Add(Exercise.ParseFromFileLine(d));
            }
            return exercises;
        }
    }
}
