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
        private const char setsJoiner = '>';
        private const char dateJoiner = '<';
        private const string date_format = "dd.MM.yyyy";

        public int Id { get; set; }
        public string ExerciseName { get; set; }
        public Dictionary<DateTime, List<Set>> Sets { get; set; } 

        public override string ToString()
         => $"{Id}. {ExerciseName}: {string.Join(",", Sets.Select(kv => $"Date: {kv.Key.ToString(date_format)} - Sets: {string.Join(",", kv.Value.ConvertAll(e => e.ToString()))}"))}";
        internal string FormatForFileLine()
         => $"{Id}{del}{ExerciseName}{del}{string.Join($"{setsJoiner}", Sets.Select(kv => $"{kv.Key.ToString(date_format)}{dateJoiner}{string.Join($"{repsJoiner}", kv.Value.ConvertAll(e => e.FormatForFileLine()))}"))}";
        internal static Exercise ParseFromFileLine(string line)
        {
            string[] details = line.Split(del);
            return new Exercise
            {
                Id = int.Parse(details[0]),
                ExerciseName = details[1],
                Sets = setsConverter(details[2]) 
            };
        }

        private static Dictionary<DateTime, List<Set>> setsConverter(string line)
        {
            /*
             * 23.12.2001§1_12_60_kg§2_8_66_kg§3_4_90_kg-
             * 25.12.2001§1_12_60_kg§2_8_66_kg§3_4_90_kg
            */
            Dictionary<DateTime, List<Set>> sets = new Dictionary<DateTime, List<Set>>();
            string[] details = line.Split(setsJoiner);

            foreach (var d in details)
            {
                string[] dt = d.Split(dateJoiner);
                string[] dtt = dt[1].Split(repsJoiner);
                List<Set> st = new List<Set>();
                foreach (var s in dtt)
                {
                    st.Add(Set.ParseFromFileLine(s));
                }
                try
                {
                    sets.Add(DateTime.ParseExact(dt[0], date_format, null), st);
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }

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
