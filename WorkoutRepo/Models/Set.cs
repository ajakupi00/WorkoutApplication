using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutRepo
{
    public class Set
    {

        private const string weight_unit = "kg";
        private const char del = '_';
        
        public short Reps { get; set; }
        public double Weight { get; set; }
        public int Id { get; set; }

        public override string ToString()
            => $"|{Id}. set: {Reps} x {Weight}{weight_unit}|";

        internal string FormatForFileLine()
         => $"{Id}{del}{Reps}{del}{Weight}{del}{weight_unit}";

        internal static Set ParseFromFileLine(string line)
        {
            string[] details = line.Split(del);
            return new Set
            {
                Id = int.Parse(details[0]),
                Reps = short.Parse(details[1]),
                Weight = double.Parse(details[2])

            };
        }
    }
}
