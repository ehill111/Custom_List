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

            CustomList<string> customList = new CustomList<string>();
            string broom;
            string mop;
            string rag;
            string bucket;
            string sponge;
            

            //Act
            customList.Add("broom");
            customList.Add("mop");
            customList.Add("rag");
            customList.Add("bucket");
            customList.Add("sponge");
            customList.Add("mop");
            
            customList.RemoveAll("mop");


            //Assert
            string expected = mop;
            string actual;
        }
       
    }
}
