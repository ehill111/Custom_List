using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>//"...I want to use a custom-built list class that stores its values..."
    {   //Member variables have/has a/an...
        CustomList<T> _customList;
        private int _count;
        private int _capacity;
        public T _dog;

        //Properties
        public int _Count//"...I want a Count property...so that I can get a count..."
        {
            get
            {
                return _count;
            }
        }

        public int _Capacity//"...I want a Capacity property...so that I can publicly see..."
        {
            get
            {
                return _capacity;
            }
        }

        public void CreateCustomList()
        {
            //Methods do something.
            _customList = new CustomList<T>();
            _customList.Add(_dog);//Check on usage of T
            _customList.Add(_dog);
            _customList.Add(_dog);
            _customList.Add(_dog);
            _customList.Add(_dog);
        }

      



        public void Add(T item)
        {

        }

        public void Remove()
        {

        }
    }
}
