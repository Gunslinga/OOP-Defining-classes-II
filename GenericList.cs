using System;

namespace _3DPoint
{
    public class GenericList<T> : IList<T>
    {
        private T[] _list;
        private int currentIndex = 0;

        public GenericList(int capacity)
        {
            _list = new T[capacity];
        }

        public void AutoGrow()
        {
            T[] temp = new T[_list.Length * 2];
            Array.Copy(_list, 0, temp, 0, _list.Length);
            _list = temp;
        }

        public void Add(T element)
        {
            if (currentIndex >= _list.Length)
            {
                 AutoGrow();
            }
            _list[currentIndex] = element;
            currentIndex++;
        }

        public void RemoveAt(int index)
        {
            _list[index] = default(T);
        }

        public void Clear()
        {
            for (int i = 0; i < _list.Length; i++)
            {
                _list[i] = default(T);
            }
        }

        public void Insert(int index, T element)
        {
            if (index >= 0 && index < _list.Length)
            {
                _list[index] = element;
            }
            else
            {
                throw new IndexOutOfRangeException("Enter valid index");
            }
        }

        public T this[int index]
        {
            get
            {
                if (index >= _list.Length)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }
                T result = _list[index];
                return result;
            }
        }

        public T Min<T>() where T : System.IComparable<T>, IComparable
        {
            dynamic min = _list[0];
            for (int i = 0; i < _list.Length; i++)
            {
                T tempValue = (dynamic)this._list[i];
                if (tempValue.CompareTo(min) < 0)
                {
                    min = _list[i];
                }
            }
            return min;
        }

        public int Length
        {
            get { return _list.Length; }
        }
    }
}
