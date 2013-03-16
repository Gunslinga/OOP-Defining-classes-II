using System;

namespace _3DPoint
{
    interface IList<T>
    {
        void Add(T element);
        void RemoveAt(int index);
        void Clear();
        void Insert(int index, T element);
    }
}
