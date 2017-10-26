using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Custom_List
{
    public class CustomList<T> : ICustomList<T>, IEnumerable<T>
        where T : IComparable<T>
    {
        private readonly IList<T> elements;

        public CustomList() : this(Enumerable.Empty<T>())
        {
        }

        public CustomList(IEnumerable<T> collection)
        {
            this.elements = new List<T>(collection);
        }

        public IList<T> Elements => this.elements;

        public void Add(T element)
        {
            this.elements.Add(element);
        }

        public T Remove(int index)
        {
            T element = this.elements[index];
            this.elements.RemoveAt(index);
            return element;
        }

        public bool Contains(T element)
        {
            return elements.Contains(element);
        }

        public void Swap(int index1, int index2)
        {
            T temp = elements[index1];
            elements[index1] = elements[index2];
            elements[index2] = temp;
        }

        public int CountGreaterThan(T element)
        {
            return this.elements.Count(e => e.CompareTo(element) > 0);
        }

        public T Max() => this.elements.Max();
        

        public T Min() => this.elements.Min();
        

        public IEnumerator<T> GetEnumerator()
        {
            return this.elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}