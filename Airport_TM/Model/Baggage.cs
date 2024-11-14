using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_TM.Model
{
    public class Baggage
    {
        public int _id { get; set; }
        public double _weight { get; set; }

        public Baggage(int id, double weight)
        {
            _id = id;
            _weight = weight;
        }
    }
}
