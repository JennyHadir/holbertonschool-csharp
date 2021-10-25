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
        T value = default(T);
        /// Next Node in queue
        public Node next = null;
        /// Constructor
        public Node(T val)
        {
            value = val;
        }
    }

    /// Add a new node to the queue
    public Node Enqueue(T val)
    {
        Node nNode = new Node(val);
        
        if (head == null)
        {
            head = nNode;
        }
        else
        {
            nNode.next = head;
            tail = nNode;
        }
        count++;
        return head;
    }

    /// Returns the nulmber of Nodes
    public int Count()
    {
        return(count);
    }

}
