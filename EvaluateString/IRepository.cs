using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluateString
{
    public interface IRepository
    {
        public string[] GetData();
        public void SetData(string[] result);
    }
}
