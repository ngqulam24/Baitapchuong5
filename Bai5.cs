using System;
using System.Collections.Generic;

public class MyStack<T>
{
    private List<T> stackElements;

    public MyStack()
    {
        stackElements = new List<T>();
    }

    public void Push(T item)
    {
        stackElements.Add(item);
    }

    public T Pop()
    {
        if (stackElements.Count == 0)
            throw new InvalidOperationException("Stack is empty.");

        T topElement = stackElements[stackElements.Count - 1];
        stackElements.RemoveAt(stackElements.Count - 1);
        return topElement;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        // Kiểm tra với số nguyên
        MyStack<int> intStack = new MyStack<int>();
        intStack.Push(10);
        intStack.Push(20);
        intStack.Push(30);
        Console.WriteLine(intStack.Pop()); // Output: 30
        Console.WriteLine(intStack.Pop()); // Output: 20
        Console.WriteLine(intStack.Pop()); // Output: 10

        // Kiểm tra với chuỗi
        MyStack<string> stringStack = new MyStack<string>();
        stringStack.Push("Apple");
        stringStack.Push("Banana");
        stringStack.Push("Cherry");
        Console.WriteLine(stringStack.Pop()); // Output: Cherry
        Console.WriteLine(stringStack.Pop()); // Output: Banana
        Console.WriteLine(stringStack.Pop()); // Output: Apple
    }
}