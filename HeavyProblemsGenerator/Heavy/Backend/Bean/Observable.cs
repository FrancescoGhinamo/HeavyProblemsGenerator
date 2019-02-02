using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeavyProblemsGenerator.Heavy.Backend.Bean
{
    public abstract class Observable
    {
        public IObserver obs { get; }
        public Observable(IObserver observer)
        {
            obs = observer;
        }

        public void NotifyObserver(int v)
        {
            obs.UpdateFromObservable(v);
        }
    }
}
