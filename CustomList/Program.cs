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
            name.Add("1");
            name.Add("1");
            name.Add("1");
            name.Add("1");
            name.Add("1");
            name.Add("1");
            name.Add("1");
            name.Add("1");
            name.Add("1");
            name.Add("1");
            name.Add("1");
            name.Add("1");
            name.Add("1");
            name.Add("1");
            name.Add("1");
            name.Add("1");
            name.Add("1");
            name.Add("1");
            name.RemoveAt(0);
            name.RemoveAt(0);
            name.RemoveAt(0);
            name.RemoveAt(0);
            name.RemoveAt(0);
            name.RemoveAt(0);
            name.Remove("1");
            name.Clear();
            name.Count();
        }
    }
}
