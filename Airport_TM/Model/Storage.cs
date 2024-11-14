using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport_TM.Model
{
    public class Storage
    {
        private List<Baggage> _baggageList;
        public Storage()
        {
            _baggageList = new List<Baggage>();
        }
        public void AddBaggage(Baggage baggage)
        {
            _baggageList.Add(baggage);
        }
        public int GetBaggageCount()
        {
            return _baggageList.Count;
        }
    }
}
