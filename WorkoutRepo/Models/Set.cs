using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutRepo
{
    public class Set
    {
        private static int id_generator = 1;
        private int id;
        private const string weight_unit = "kg";
        private const char del = '_';
        public Set()
        {
            id = id_generator++;
        }
        public short Reps { get; set; }
        public double Weight { get; set; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
            => $"|{id}. set: {Reps} x {Weight}{weight_unit}|";

        internal string FormatForFileLine()
         => $"{id}{del}{Reps}{del}{Weight}{del}{weight_unit}";

        internal static Set ParseFromFileLine(string line)
        {
            string[] details = line.Split(del);
            return new Set
            {
                Reps = short.Parse(details[1]),
                Weight = double.Parse(details[2])

            };
        }
    }
}
