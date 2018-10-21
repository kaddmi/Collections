using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class CrewEnumerator : IEnumerator<Worker>
    {
        private Crew crew;
        private int index;
        private Worker worker;

        public CrewEnumerator(Crew workers)
        {
            crew = workers;
            index = -1;
            worker = default(Worker);
        }

        public Worker Current
        {
            get
            {
                return worker;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public bool MoveNext()
        {
            if (++index >= crew.Count)
            {
                return false;
            }
            else
            {
                worker = crew[index];
            }
            return true;
        }

        public void Reset()
        {
            index = -1;
        }

        void IDisposable.Dispose()
        {

        }


    }
}
