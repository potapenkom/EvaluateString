using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluateString
{
    public interface IObserver
    {
        void PerformAction(ref string expression);
    }
}
