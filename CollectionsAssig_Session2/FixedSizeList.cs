using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAssig_Session2
{
    internal class FixedSizeList<T>
        //list : 
        //Capacity
        //Count
        //elements
    {

        //Attributes
        private T[] Elements;
        private int _Count;


        //Properties
        public int Capacity { get; private set; }
        public int count { get { return _Count; } }

        //Constructor
        public FixedSizeList(int _Capacity)
        {

            if (_Capacity <= 0)
            {
                throw new ArgumentException("Capacity Must be grater than 0");
            }

            Capacity = _Capacity;
            Elements = new T[_Capacity];   
            _Count = 0;
        }

        //3.Implement an Add method that adds an element to the list, but throws an exception if the list is already full.

        public void AddElement(T item)
        {
            if (_Count >= Capacity)
            {
                throw new InvalidOperationException("The list is Full , Count >= Capacity");
            }
            else
            {
                Elements[_Count] = item;
                _Count++;
            }

        }

        //4.Implement a Get method that retrieves an element at a specific index in the list but throws an exception for invalid indices.

        public T Get(int index) { 

            if ( index < 0 || index > _Count)
            {
                throw new Exception(" Index out of Range ");
            }
        
         return Elements[index];
        }
    }
}
