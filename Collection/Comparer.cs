using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class Comparer : IComparer<Worker>
    {
        public int Compare(Worker w1, Worker w2)
        {
            if (w1.WorkPosition.CompareTo(w2.WorkPosition) > 0)
                return 1;
            if (w1.WorkPosition.CompareTo(w2.WorkPosition) < 0)
                return -1;
            else return 0;
        }
    }
}
