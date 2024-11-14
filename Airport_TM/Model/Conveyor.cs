using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Airport_TM.Model
{
    public class Conveyor
    {
        public double time { get; set; } = 0;
        public Randoms rand { get; set; }
        public int _stopweight { get; set; }
        public int number { get; set; } = 0;

        public Conveyor(int number, int stopweight)
        {
            _stopweight = stopweight;
            rand = new Randoms(number);
        }

        public void Handler(Baggage baggage)
        {
            if (baggage._weight > _stopweight)
                number++;
            else
            {
                time += baggage._weight * 0.1f;
                time += rand.Random(1, 6);
            }
        }
    }
}
