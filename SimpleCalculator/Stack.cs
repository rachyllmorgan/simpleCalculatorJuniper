using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Stack
    {
        public int last { get; set; }
        public string lastq { get; set; }

        public Stack(Evaluate eval)
        {
            last = eval.last;
            lastq = eval.lastq;
        }
    }
}
