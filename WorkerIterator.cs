using System;
using System.Collections.Generic;

namespace Clock_project
{
    class WorkerIterator : IWorkerIterator
    {
        private CityWorkers workers;
        private int index;

        public WorkerIterator(CityWorkers cityWorkers)
        {
            workers = cityWorkers;
            index = -1;
        }

        public IObserver Next()
        {
            if(HasNext())
            {
                index++;
                return workers.workers[index];
            }    
            return null;
        }

        public bool HasNext()
        {
            return index < workers.workers.Count - 1;
        }
    }
}
