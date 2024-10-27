using System;
using System.Collections.Generic;
using System.Text;
using ObserverPattern.Observer;

namespace ObserverPattern.Subject
{
    public class Cat
    {
        public void Miao()
        {
            new Baby().Cry();
            new Mouse().Run();
        }

        public void MiaoObserver()
        {
            foreach (var observer in _observers)
            {
                observer.Action();
            }
        }

        private IList<IObserver> _observers = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            this._observers.Add(observer);
        }

        public event Action MiaoHandler;
         public void MiaoHanldEvent()
        {
            if(MiaoHandler != null)
            {
                foreach (Action action in MiaoHandler.GetInvocationList())
                {
                    action();
                }
            }
        }
    }
}
