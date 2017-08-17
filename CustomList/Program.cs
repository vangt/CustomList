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
            List<string> name = new List<string>();
            name.Add("tim");
            name.Add("joe");

            List<int> num = new List<int>();
            num.Add(1);
            num.Add(2);

            foreach(string i in name)
            {
                Console.WriteLine(i);
            }
            
            Console.ReadLine();
        }
    }
}
