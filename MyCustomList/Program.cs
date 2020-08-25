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
            List<int> testList = new List<int>();
            testList.Add(3);
            testList.Add(3);
            testList.Add(3);
            testList.Add(3);
            testList.Add(3);
            testList.Add(3);
            testList.Add(3);
            testList.Add(3);
            testList.Add(3);

            List<int> customList = new List<int>();
            int actual;
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.RemoveAt(3);
            actual = customList.Count;
        }
       
    }
}
