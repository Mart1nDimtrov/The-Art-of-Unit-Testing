using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class MemCalculator
    {
        private int sum = 0;
        public void Add(int number)
        {
            this.sum += number;
        }
        public int  Sum()
        {
            int temp = this.sum;
            this.sum = 0;
            return temp;
        }
    }
}
