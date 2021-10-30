using System;

///<summary>  Create new class called Queue</summary>
public class Queue<T>
{
    /// First Node
    public Node head;
    /// Last Node
    public Node tail;
    /// Number of Nodes
    public int count;

    /// Returns the Queue's Type
    public Type CheckType()
    {
        return typeof(T);
    }
    ///<summary>  Create new class called Node</summary>
    public class Node
    {
        /// Node class props
        public T value = default(T);
        /// Next Node in queue
        public Node next = null;
        /// Constructor
        public Node(T val)
        {
            value = val;
        }
    }

    /// Removes the first node in the queue a returns its value
    public T Dequeue()
    {
        if (head != null)
        {
            T NodeValue = head.value;
            head = head.next;
            count--;
            return NodeValue;
        }
        else
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
    }

    /// Add a new node to the queue
    public void Enqueue(T val)
    {
        Node nNode = new Node(val);
        
        if (head == null)
        {
            head = nNode;
            tail = nNode;
        }
        else
        {
            tail.next = nNode;
            tail = nNode;
        }
        count++;
    }

    /// Returns the nulmber of Nodes
    public int Count()
    {
        return(count);
    }

    /// Returns the value of the first node od the queue
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            return (head.value);
        }
    }

    /// Prints the queue starting from the head
    public void Print()
    {
        if (head == null)
            Console.WriteLine("Queue is empty");
        
        Node tmp = head;

        for(int i = 0; i < count; i++)
        {
            Console.WriteLine(tmp.value);
            tmp = tmp.next;
        }
    }

}
