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
            CustomNewList<string> customList = new CustomNewList<string>() { "A", "B", "C", "C", "D", "C", "E", "C"};
            CustomNewList<string> customListTwo = new CustomNewList<string>() { "C", "C", "E", "A", "R"};
            List<string> list = new List<string>() { "A", "B", "C", "C", "D", "C", "E", "C" };

            customList.Remove("C");
            list.Remove("C");

        }
    }
}
