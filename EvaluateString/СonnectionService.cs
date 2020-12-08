using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluateString
{
   public class СonnectionService
    {
        IRepository _repository;
        Calculator _calculator;

        public СonnectionService(IRepository repository)
        {
            _repository = repository;
            _calculator = new Calculator(this._repository.GetData());
        }

        public void Process()
        {
            string[] result = _calculator.Notify();
            this._repository.SetData(result);
        }

    }
}
