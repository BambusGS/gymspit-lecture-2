using System;
// https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1?view=netcore-3.1


namespace Lecture4
{
	class MyStack<T>
	{
		private const int INITIAL_CAPACITY = 10;

		private T[] items = new T[INITIAL_CAPACITY];

		private int count = 0;

		private int capacity = INITIAL_CAPACITY;


		public void Push(T item)
		{
			if (count >= capacity) {
				capacity *= 2;
				Array.Resize(ref items, capacity);
			}

			items[count] = item;
			count += 1;
		}


		public T Pop()
		{
			if (!(count > 0)) {
				throw new Exception();
			}

			T item = items[count - 1];
			items[count - 1] = default(T);
			count -= 1;
			return item;
		}


		public T Peek()
		{
			if (!(count > 0)) {
				throw new Exception();
			}

			return items[count - 1];
		}


		public bool IsEmpty()
		{
			return !(count > 0);
		}


		#region MyChanges
		public int Count() => count;    

		/// <summary>
		/// Clear method
		/// </summary>

		public void Clear()
        {
			count = 0;
			capacity = INITIAL_CAPACITY;
			items = new T[INITIAL_CAPACITY];
        }

		/// <summary>
		/// Clear method with boolean specificator whether to garbage collect right after stack reset
		/// </summary>
		public void Clear(bool collector)
        {
			count = 0;
			capacity = INITIAL_CAPACITY;
			items = new T[INITIAL_CAPACITY];
			if (collector) { GC.Collect(); }
		}

		public void Reverse()
        {
			if (count < 1) return;					//don't reverse a one-long stack
            for (int i = 0; i < count / 2; i++)
            {
				T temp = items[i];
				items[i] = items[count-1 - i];		//when COUNT is 1, there is one element, so it starts at 0 and ends at COUNT-1
				items[count-1 - i] = temp;
			}
        }

		public bool Contains(T searchItem)
        {
            for (int i = 0; i < count; i++)
            {
				if(items[i].Equals(searchItem)) { return true; }
            }
			return false;
        }



        #endregion
    }
}
