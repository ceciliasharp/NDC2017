using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public int Amount { get; set; }

        public void Add(int i)
        {
            Amount = AddHelper.Add(Amount, i);
        }


        public void Subtract(int i)
        {
            Amount = AddHelper.Add(Amount, -1 * i);
        }

        public void Divide(int i)
        {
            if (i < 0)
                throw new ArgumentOutOfRangeException();
            Amount /= i;
        }
    }
}
