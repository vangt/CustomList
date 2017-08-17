using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> name = new List<int>();
            name.Add(1);
            double dog = 9;
            
            name.RemoveAt(0);
            
            name.Count();
        }
    }
}
