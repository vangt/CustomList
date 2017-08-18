using CustomList.Classes;
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
            CustomNewList<int> customList = new CustomNewList<int>();
            List<int> list = new List<int>();
            customList.Add(0);
            customList.Add(1);
            list.Add(1);
            list.Add(2);
            list.Add(2);
            list.Add(2);
            list.Add(2);
        }
    }
}
