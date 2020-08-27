using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>//"I want to use a custom-built list class that stores its values..."
    {   //Member variables have/has a/an...
        
        private T[] _items = new T[5];
        private int _count;
        private int _capacity;
        
        //Properties
        public int _Count//"I want a Count property...so that I can get a count..."
        {
            get
            {
                return _count;
            }
        }

        public int _Capacity//"I want a Capacity property...so that I can publicly see..."
        {
            get
            {
                return _capacity;
            }
            
        }

        public T this[int i]//"I want to create a C# indexer..."
        {
            get { return _items[i]; }
            set { _items[i] = value; }
        }

        //public void CreateCustomList()
        //{
        //    _items[0] = _dog;
        //    _items[1] = _dog;
        //    //Methods do something.
         
        //}
      
        public void Add(T item)
        {
           
            if(_count == _capacity)
            {
                //create new temporary array
                T[] tempArray = new T[_capacity];
                //move _items' Values to temp
                for (int i = 0; i < length; i++)
                {
                    tempArray = _items;
                }
                //make _items bigger
                _items = new T[16];
                //move values back to items
                for (int i = 0; i < length; i++)
                {

                }
            }
            _items[_count] = item;
            _count++;
        }

        public void Remove()
        {

        }
    }
}
