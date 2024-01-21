using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StatCalc.Services
{
    internal class FileManager
    {
        private readonly string path;

        public FileManager()
        {
            path = @"..\..\Data\data.txt";
        }
        public double[] ReadData()
        {
            var buff = string.Empty;
            using (var fs = new FileStream(path, FileMode.Open))
            using (var sr = new StreamReader(fs))
                buff = sr.ReadToEnd();

            string[] parts = buff.Trim().Split('\n');
            double[] data = new double[parts.Length]; 
            
             for(int i = 0; i< parts.Length; i++)
            {
                data[i] = Convert.ToDouble(parts[i]);
            }
            return data;
        }
        public  void SaveData(double[] data)
        {
            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            using (var sw = new StreamWriter(fs))
                foreach(var item in data)
                {
                    sw.WriteLine(item.ToString());
                }
        }
        public void AddData(double[] data)
        {
            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            using (var sw = new StreamWriter(fs))
                foreach (var item in data)
                {
                    sw.WriteLine(item.ToString());
                }
        }
    }
}
