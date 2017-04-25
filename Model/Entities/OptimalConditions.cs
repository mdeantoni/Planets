using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class OptimalConditions
    {
        public int Day { get; set; }

        public OptimalConditions(int day)
        {
            this.Day = day;
        }
    }
}
