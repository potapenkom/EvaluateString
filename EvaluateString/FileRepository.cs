using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EvaluateString
{
    public class FileRepository : IRepository
    {
        private string _expression;

        public FileRepository(string expression)
        {
            _expression = expression;
        }

        public string[] GetData()
        {
            using (FileStream fstream = File.OpenRead(_expression))
            {
                string[] lines = File.ReadAllLines(_expression);
                return lines;
            }
        }

        public void SetData(string[] result)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Result");
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            using (FileStream fstream = new FileStream(@"C:\Result\note.txt", FileMode.OpenOrCreate))
            {
                string[] lines = File.ReadLines(_expression).ToArray();
                for (int i = 0; i < lines.Length; i++)
                {
                    if (Validator.Valid(result[i]))
                    {
                        string line = $"{lines[i].ToString()} = {result[i].ToString()}\n";
                        byte[] array = System.Text.Encoding.Default.GetBytes(line);
                        fstream.Write(array, 0, array.Length);
                    }
                    else
                    {
                        string line = $"{lines[i].ToString()} = error in expression\n";
                        byte[] array = System.Text.Encoding.Default.GetBytes(line);
                        fstream.Write(array, 0, array.Length);
                    }
                }
            }
        }
    }
}
