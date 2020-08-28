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

            _items<int> one = new _items<int>() { 1, 3, 5 };
            _items<int> two = new _items<int>() { 2, 4, 6 };
            one.AddRange(two);



        }

    }
}
