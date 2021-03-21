

namespace Clock_project
{
    interface IWorkerIterator
    {
        IObserver Next();
        bool HasNext();
    }
}
