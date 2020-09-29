using System;


namespace Lecture4
{
	class Program
	{
		static void Main(string[] args)
		{
            //Person a = new Person();
            //a.firstName = "First";
            //a.lastName = "Last";
            //a.age = 42;

            //Person b = new Person();
            //b.firstName = "Tsrif";
            //b.lastName = "Tsal";
            //b.age = 24;

            //MyList<Person> list = new MyList<Person>();
            //list.Add(a);
            //list.Add(b);
            //Console.WriteLine(list.Count());
            //Console.WriteLine(list.Get(0) == a);
            //Console.WriteLine(list.Get(1) == b);
            //Console.WriteLine(list.Get(0).firstName);
            //Console.WriteLine(list.Get(0).lastName);
            //Console.WriteLine(list.Get(0).age);

            //MyList<int> intList = new MyList<int>();
            //intList.Add(15);
            //intList.Add(16);
            //intList.Add(31);
            //Console.WriteLine(intList.Count());
            //for (int i = 0; i < intList.Count(); i += 1) {
            //	Console.WriteLine(intList.Get(i));
            //}

            //MyLinkedList<int> linkList = new MyLinkedList<int>();
            //linkList.AddFirst(1);
            //linkList.AddLast(3);
            //linkList.AddAfter(2, linkList.GetFirst());

            //Console.WriteLine(linkList.Count());
            //for (var node = linkList.GetFirst(); node != null; node = node.next) {
            //	Console.WriteLine(node.Item);
            //}

            MyQueue<int> queue = new MyQueue<int>();
            for (int i = 100; i < 120; i++)
            {
                queue.Enqueue(i);
            }
            Console.WriteLine("Queue (100-119) peek before: {0}", queue.Peek());
            Console.WriteLine("Queue (100-119) length: {0}", queue.Count());
            //queue.Clear();

            Console.WriteLine("Queue (100-119) contains 99: {0}", queue.Contains(99));
            Console.WriteLine("Queue (100-119) contains 100: {0}", queue.Contains(100));
            Console.WriteLine("Queue (100-119) contains 119: {0}", queue.Contains(119));
            Console.WriteLine("Queue (100-119) contains 120: {0}", queue.Contains(120));
            
            queue.Reverse();
            while (!queue.IsEmpty())
            {
                Console.WriteLine(queue.Dequeue());
            }



            Console.Write("\n------------------\n");

            MyStack<int> stack = new MyStack<int>();
            for (int i = 1; i < 11; i++)
            {
				stack.Push(i);
            }

			Console.WriteLine("Stack (1-10) peek: {0}", stack.Peek());
			while (!stack.IsEmpty()) {
				Console.WriteLine(stack.Pop());
			}



			for (int i = 20; i < 25; i++)
			{
				stack.Push(i);
			}
			Console.WriteLine("\nStack (20-24) count: {0}", stack.Count());
            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }

            stack.Clear(true);
			Console.WriteLine("\nStack count after clear: {0}", stack.Count());
			

			
			for (int i = 20; i < 26; i++)
			{
				stack.Push(i);
			}

			Console.WriteLine("Stack (20-25) contains 10: {0}", stack.Contains(10));
			Console.WriteLine("Stack (20-25) contains 22: {0}", stack.Contains(22));
			
			Console.WriteLine("Stack (20-25) peek before: {0}", stack.Peek());
			stack.Reverse();
			Console.WriteLine("Stack (20-25) peek after reversed: {0}", stack.Peek());
			while (!stack.IsEmpty())
			{
				Console.WriteLine(stack.Pop());
			}











			Console.ReadKey();
		}
	}
}
