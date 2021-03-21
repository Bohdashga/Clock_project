
using System.Collections.Generic;


namespace Clock_project
{
    class CityWorkers : Iterable
    {
        public List<IObserver> workers { get; }

        public CityWorkers()
        {
            workers = new List<IObserver>();
            workers.Add(new Baker());
            workers.Add(new Shoemaker());
            workers.Add(new Barman());
        }



        public IWorkerIterator CreateIterator()
        {
            return new WorkerIterator(this);
        }
    }
}
