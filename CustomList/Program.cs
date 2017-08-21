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
            CustomNewList<int> customList = new CustomNewList<int>() { 1,2,3,4,5,6,2,3,4};
            CustomNewList<int> customListTwo = new CustomNewList<int>() { 1,2,3,3};
            List<string> list = new List<string>() { "A", "B", "C", "C", "D", "C", "E", "C" };
            CustomNewList<int> customListThree = new CustomNewList<int>();

            customListThree = customList - customListTwo;
        }
    }
}
