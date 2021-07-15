using System;
using System.Collections.Generic;
class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        if (myLList.First == null || myLList.First.Value >= n)
        {
            myLList.AddFirst(n);
            return myLList.First;
        }
        LinkedListNode<int> node = myLList.First;
        while (node.Next != null)
        {
            if (node.Next.Value >= n)
            {
                node = myLList.AddAfter(node, n);
                return node;
            }
            node = node.Next;
        }
        node = myLList.AddLast(n);
        return node;
    }
}
