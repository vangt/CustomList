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
            CustomNewList<int> customList = new CustomNewList<int>() { 9,9};
            CustomNewList<int> customListTwo = new CustomNewList<int>() { 1,1,1,1};
            List<string> list = new List<string>() { "A", "B", "C", "C", "D", "C", "E", "C" };
            CustomNewList<int> customListThree = new CustomNewList<int>();

            customListThree = customList.Zip(customListTwo);
        }
    }
}
