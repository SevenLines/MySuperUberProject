using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Models
{
    public enum RaspisItemTypes { Lection, Practice, Lab }
    public enum Frequency
    {
        Odd = 1,
        Even = 2,
        EveryWeek = 3
    }

    public class Auditory
    {
        public int id { get; set; }

        public override string ToString()
        {
            return $"{id}";
        }

        public String Group { get; set; }
        public RaspisItemTypes Type { get; set; }
        public String Teacher { get; set; }
        public String Discipline { get; set; }
        public int Count { get; set; }

        public Frequency Freq { get; set; }

        public int Pair { get; set; }
        public int Day { get; set; }
    }
}
