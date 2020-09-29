using System;
// https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1?view=netcore-3.1


namespace Lecture4
{
	class MyQueue<T>
	{
		class MyQueueNode
		{
			public T Item { get; }
			public MyQueueNode Next { get; set; }


			public MyQueueNode(T item, MyQueueNode next)
			{
				Item = item;
				Next = next;
			}
		}

		private MyQueueNode first = null;

		private MyQueueNode last = null;

		public void Enqueue(T item)
		{
			MyQueueNode node = new MyQueueNode(item, null);
			if (first == null) {
				first = node;
			}
			if (last != null) {
				last.Next = node;
			}
			last = node;
		}


		public T Dequeue()
		{
			if (first == null) {
				throw new Exception();
			}

			if (first == last) {
				last = null;
			}

			T item = first.Item;
			first = first.Next;
			return item;
		}


		public T Peek()
		{
			if (first == null) {
				throw new Exception();
			}

			return first.Item;
		}


		public bool IsEmpty()
		{
			return first == null;
		}



        #region MyFunctions
		public int Count()
        {
			int num = 0;
			MyQueueNode node = first;
			while(node != null)
            {
				node = node.Next;
				num++;
            }
			return num;
        }

		public void Clear()
        {
			if (first == null) return;

			while(first.Next != null)
            {
				first = first.Next;
			}
			first = null;
			last = null;
        }
		
		public void Clear(bool collect)
        {
			if (first == null) return;

			while(first.Next != null)
            {
				first = first.Next;
			}
			first = null;
			last = null;

			if (collect) GC.Collect();
        }


		public void Reverse()		//actually works for queues ranging from 1 to many elements
        {
			if (first == null || first.Next == null) return;

            //MyQueueNode test1 = last, test2 = first;
            MyQueueNode node1 = null, node2 = first, node3 = first.Next;
			last = first;
			while(node2 != null) 
			{ 
				//Console.WriteLine("Before {0} {1} {2}", node1.Item, node2.Item, node3.Item);
				node3 = node2.Next;
				node2.Next = node1;
				node1 = node2;
				node2 = node3;
				//Console.WriteLine("After {0} {1} {2}", node1.Item, node2.Item, node3.Item);
			}	//exits with lastNode; null; null
            first = node1;

            //Console.WriteLine(test1.GetHashCode().Equals(first.GetHashCode()));
            //Console.WriteLine(test2.GetHashCode().Equals(last.GetHashCode())); //was to ensure, that the objects are the same
		}

        #endregion

    }
}
