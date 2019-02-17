using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_17_01
{
    public class OneDimensionArray
    {
        private int[] numbers;
        public OneDimensionArray(int size)
        {
            numbers = new int[size];
        }
        public int this[int index]
        {
            get { return numbers[index]; }
            set { numbers[index] = value * value; }
        }

    }
}
