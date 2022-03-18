using System;
using System.Collections.Generic;
using System.Text;

namespace CustomGenericList
{
    public interface ICustomList<T> : IEnumerable<T>
    {
        void AddItem(T data);
        void RemoveItem(T data);
        void Print();
        bool Exists();
    }
}
