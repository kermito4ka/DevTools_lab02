using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Wintellect.PowerCollections
{
	public class Stack<T> : IEnumerable<T>
	{
		private T[] Array;
		public int capacity = 0;
		public int count = 0;

		public int Capacity
		{
			get { return capacity; } set { capacity = value; }
		}
		public int Count
		{
			get { return count; } set { count = value; }
		}

		public Stack(int count)
		{
			Array = new T[count];
			Capacity = count;
		}

		public void Push(T data)
		{
			if (Count == Capacity)
			{
				throw new Exception("Capacity of Stack is full");
			}
			Array[Count++] = data;
		}

		public T Pop()
		{
			if (Count == 0)
			{
				throw new Exception("No elements in stack");
			}

			T returnItem = Array[--Count];
			Array[Count] = default(T);

			return returnItem;
		}

		public T Top()
		{
			if (Count == 0)
			{
				throw new Exception("No value gained");
			}

			return Array[Count - 1];
		}

		public IEnumerator<T> GetEnumerator()
		{
			for (int i = Count - 1; i >= 0; i--)
				yield return Array[i];
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}