namespace LinkedListOfT
{
	public class LinkedList<T>
	{
		private class Node
		{
			public T? Data { get; set; }
			public Node? Next { get; set; }

			public override string ToString()
			{
				return Data?.ToString() ?? string.Empty;
			}
		}

		private Node head = new Node();

		private int count = 0;
		public int Count { get { return count; } }

		public T? First
		{
			get
			{
				if (head.Next == null)
					return default;

				return head.Next.Data;
			}
		}
		public T? Last
		{
			get
			{
				if (head.Next == null)
					return default;

				Node current = head;
				while (current.Next != null)
				{
					current = current.Next;
				}
				return current.Data;
			}
		}

		public void Insert(T value)
		{
			Node newNode = new()
			{
				Data = value
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

		public void Append(T value)
		{
			Node newNode = new()
			{
				Data = value
			};

			if (Last == null)
				head.Next = newNode;

			else
			{
				Node current = head;
				while (current.Next != null)
				{
					current = current.Next;
				}
				current.Next = newNode;
			}

			count++;
		}

		public void InsertAt(int index, T value)
		{
			Node newNode = new()
			{
				Data = value
			};

			if (head.Next == null || index == 0)
			{
				newNode.Next = head.Next;
				head.Next = newNode;
			}
			else
			{
				Node current = head;
				for (int i = 0; i < index; i++)
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
				for (int i = 0; i < index; i++)
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

		public T ItemAt(int index)
		{
			Node current = head.Next;

			if (index > 0)
			{
				for (int i = 0; i < index; i++)
				{
					current = current.Next;
				}
				return current.Data;
			}

			return current.Data;
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