using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluateString
{
    public interface ISubject
    {
        void Attach(int priority, IObserver observer);

        void Detach(int priority);

        string[] Notify();
    }
}
