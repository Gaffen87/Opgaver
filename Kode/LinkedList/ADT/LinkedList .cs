namespace ADT
{
	public class LinkedList
	{
		private class Node
		{
            public object? Data { get; set; }
			public Node? Next { get; set; }

			public override string ToString()
			{
				return Data?.ToString() ?? string.Empty;
			}
		}

		private Node head = new	Node();

		private int count = 0;
		public int Count { get { return count; } }

		public object First 
		{
			get 
			{
				if (head.Next == null)
					return null;

				return head.Next.Data;
			}
		}
		public object Last
		{
			get
			{
				if (head.Next == null)
					return null;

				Node current = head;
				while (current.Next != null)
				{
					current = current.Next;
				}
				return current.Data;
			}
		}

		public void Insert(object o)
		{
			Node newNode = new()
			{
				Data = o
			};

			if (First == null)
				head.Next = newNode;

			else
			{
				newNode.Next = head.Next;
				head.Next = newNode;
			}

			count++;
		}

		public void Append(object o)
		{
			Node newNode = new()
			{ 
				Data = o 
			};

			if (Last == null)
				head.Next = newNode;

			else
			{
				Node current = head;
				while ( current.Next != null )
				{
					current = current.Next;
				}
				current.Next = newNode;
			}

			count++;
		}

		public void InsertAt(int index, object o)
		{
			Node newNode = new()
			{
				Data = o
			};

			if (head.Next == null || index == 0)
			{
				newNode.Next = head.Next;
				head.Next = newNode;
			}
			else
			{
				Node current = head;
				for(int i = 0; i < index; i++)
				{
					current = current.Next;
				}
				newNode.Next = current.Next;
				current.Next = newNode;
			}

			count++;
		}

		public void DeleteAt(int index)
		{
			Node current = head.Next;
			Node previous = head;

			if (index != 0)
			{
				for (int i = 0; i < index;i++)
				{
					current = current.Next;
					previous = previous.Next;
				}
				previous.Next = current.Next;
			}
			else
			{
				head.Next = head.Next?.Next;
			}

				count--;
		}

		public object? ItemAt(int index)
		{
			Node current = head.Next;

			if (index > 0)
			{
				for (int i = 0; i < index; i++)
				{
					current = current.Next;
				}
				return current?.Data;
			}

			return current?.Data;
		}

		public override string ToString()
		{
			string result = "";
			Node current = head.Next;

			while (current != null)
			{
				result += current.Data.ToString() + "\n";
				current = current.Next;
			}

			return result.TrimEnd('\n');
		}
	}
}