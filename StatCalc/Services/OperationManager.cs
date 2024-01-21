using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatCalc.Services
{
    internal class OperationManager
    {
        private readonly FileManager _fileManager;

      

        public OperationManager()
        {
            _fileManager = new FileManager();
        }

        public void DisplayData()
        {
            var data = _fileManager.ReadData();
            Console.WriteLine("Вхідні дані");
            foreach(var item in data)
            {
                Console.WriteLine($"  ->  {item}");
            }
        }

        public void DisplayAverage(double a)
        {
            var data = _fileManager.ReadData();
            Console.WriteLine($" -> Result = {a}");
        }
        public void DisplayError(double a)
        {
            var data = _fileManager.ReadData();
            Console.WriteLine($" -> {data.Max()} - {data.Min()} / 2 = {a}");
        }
        public double CalcAverage()
        {
            var data = _fileManager.ReadData();

            double sum = 0;
            foreach(var item in data)
            {
                sum += item;
            }
            var result = sum / data.Length;
            return result;
        }
        public double ErrorAverage()
        {
            var data = _fileManager.ReadData();
            var numMax = data.Max();
            var numMin = data.Min();

            //..
            return numMax - numMin / 2;
        }

        public void SaveError(double a)
        {
            var data = _fileManager.ReadData();
            Array.Resize(ref data, data.Length + 1);
            data[data.Length - 1] = a;
            _fileManager.SaveData(data);
        }
    }
}
