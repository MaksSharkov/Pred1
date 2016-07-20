using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pred1
{
    class TestType : IEnumerable, IEnumerator
    {
        int[] numbers;
        int index = -1;

        public TestType(uint size)
        {
            numbers = new int[size];
        }

        public int this[int sindex]
        {
            set
            {
                numbers[sindex] = value;
            }
        }


        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (index == numbers.Length - 1)
            {
                Reset();
                return false;
            }

            index++;
            return true;
        }

        public void Reset()
        {
            index = -1;
        }

        public object Current
        {
            get
            {
                return numbers[index];
            }
        }
    }
}
