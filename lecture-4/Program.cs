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

			//MyQueue<string> queue = new MyQueue<string>();
			//queue.Enqueue("this");
			//queue.Enqueue("is");
			//queue.Enqueue("queue");
			//Console.WriteLine(queue.Peek());
			//while (!queue.IsEmpty()) {
			//	Console.WriteLine(queue.Dequeue());
			//}

			MyStack<int> stack = new MyStack<int>();
            for (int i = 1; i < 11; i++)
            {
				stack.Push(i);
            }

			Console.WriteLine("Stack peek: {0}", stack.Peek());
			while (!stack.IsEmpty()) {
				Console.WriteLine(stack.Pop());
			}



			for (int i = 20; i < 25; i++)
			{
				stack.Push(i);
			}
			Console.WriteLine("\nStack count: {0}", stack.Count());
            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }

            stack.Clear(true);
			Console.WriteLine("\nStack count: {0}", stack.Count());
			

			
			for (int i = 20; i < 26; i++)
			{
				stack.Push(i);
			}

			Console.WriteLine("Stack contains 10: {0}", stack.Contains(10));
			Console.WriteLine("Stack contains 22: {0}", stack.Contains(22));
			
			Console.WriteLine("Stack peek: {0}", stack.Peek());
			stack.Reverse();
			Console.WriteLine("Stack peek: {0}", stack.Peek());
			while (!stack.IsEmpty())
			{
				Console.WriteLine(stack.Pop());
			}











			Console.ReadKey();
		}
	}
}
