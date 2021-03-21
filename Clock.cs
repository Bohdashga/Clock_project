using System;


namespace Clock_project
{
    class Clock : IObserable
    {
        public int Time { get; private set; }

        public static Clock clock = new Clock();

        public CityWorkers cityWorkers { get; private set; }

        private Clock(int Time = 0)
        {
            this.Time = Time;
            cityWorkers = new CityWorkers();
        }

        public static Clock GetInstance()
        {
            return clock;
        }

        public void NextHour()
        {
            Time++;

            if (Time > 23)
                Time = 0;

            Console.WriteLine("\nCurrent time is " + Time);

            Notify();
        }

        public void AddObserver(IObserver observer)
        {
            cityWorkers.workers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            cityWorkers.workers.Remove(observer);
        }

        public void Notify()
        {
            IWorkerIterator workerIterator = cityWorkers.CreateIterator();

            
            while(workerIterator.HasNext())
            {
                workerIterator.Next().Update(Time);
            }
        }
    }
}
