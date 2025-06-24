using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Counter
    {
        private int count;

        public Counter(int initialCount)
        {
            count = initialCount;
        }

        public void Increment()
        {
            count = count + 1;
        }

        public void Decrement()
        {
            count = count - 1;
        }

        public int Count
        {
            get { return count; }
        }
    }
}
