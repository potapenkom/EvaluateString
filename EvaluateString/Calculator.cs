using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluateString
{
    public class Calculator : ISubject
    {
        string[] _exprassion;

        public SortedDictionary<int, IObserver> _observers = new SortedDictionary<int, IObserver>();

        public Calculator(string[] exprassion)
        {
            _exprassion = exprassion;
            _observers.Add(1, new BracketsObserver());
            _observers.Add(2, new DivToMultiObserver());
            _observers.Add(3, new MulObserver());
            _observers.Add(4, new SubToSumObserver());
            _observers.Add(5, new SumObserver());
        }

        public void Attach(int priority, IObserver observer)
        {
            _observers.Add(priority, observer);
        }

        public void Detach(int priority)
        {
            _observers.Remove(priority);
        }

        public string[] Notify()
        {

            string[] result = new string[_exprassion.Length];

            for (int i = 0; i < _exprassion.Length; i++)
            {
                var exp = _exprassion[i].Replace(" ", "");
                foreach (KeyValuePair<int, IObserver> observer in _observers)
                {
                    observer.Value.PerformAction(ref exp);
                }
                result[i] = exp;
            }
            return result;
        }

    }
}
