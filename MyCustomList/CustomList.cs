using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>//"I want to use a custom-built list class that stores its values..."
    {   //Member variables have/has a/an...

        private T[] _items; //= new T[5];
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

        public CustomList()
        {
            _items = new T[4];
            _count = 0;
            _capacity = 4;
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
                T[] tempArray = new T[_capacity * 2];
                //move _items' Values to temp
                for (int i = 0; i < _capacity; i++)
                {
                    tempArray[i] = _items[i];
                }
                _items = tempArray;
                _capacity = _capacity * 2;
               
            }
            _items[_count] = item;
            _count++;
        }
              
        public void Remove()
        {

        }

        public override string ToString()//Override the ToString method.
        {
            return this._items.ToString();
        }

        public void CombineLists() 

        {   
            _items <int> _one = new _items<int>() { 1, 3, 5 };//Couldn't get rid of errors.
            _items<int> _two = new _items<int>() { 2, 4, 6 };
            _items<int> _oneAndTwo = new _items<int>();
            _one.AddRange(_two);
            _oneAndTwo = _one.AddRange(_two);
        }
        
        public void SubtractList()
        {
                        
        }

    }
}
