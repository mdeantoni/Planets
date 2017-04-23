using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Observer
{
    public interface IObservable<T>
    {
        void AddObserver(IObserver<T> observer);
        void NotifyObservers();
    }
}
