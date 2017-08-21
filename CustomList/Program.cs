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
            CustomNewList<string> customList = new CustomNewList<string>() { "tim", "joe", "mark" };
            CustomNewList<string> customListTwo = new CustomNewList<string>() { "peter", "paul", "dao" };
            List<string> list = new List<string>();

            CustomNewList<string> customListThree = new CustomNewList<string>();

            customListThree = customList + customListTwo;

        }
    }
}
