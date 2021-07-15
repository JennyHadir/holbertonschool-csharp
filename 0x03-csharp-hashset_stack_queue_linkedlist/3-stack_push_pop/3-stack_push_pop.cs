﻿using System;
using System.Collections.Generic;
class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        int items = 0;
        foreach (var item in aStack)
            items++;
        Console.WriteLine("Number of items: {0}", items);
        if (items == 0)
            Console.WriteLine("Stack is empty");
        else
            Console.WriteLine("Top item:" + aStack.Peek());
        Console.WriteLine("Stack contains " + search +": " + aStack.Contains(search));
        do
        {
            aStack.Pop();
        } while (aStack.Contains(search));
        aStack.Push(newItem);
        return aStack;
    }
}

