// See https://aka.ms/new-console-template for more information
using StackUsingLinkedList;

Console.WriteLine("Welcome to Stack");
LinkedListStack linkedListStack = new LinkedListStack();
linkedListStack.Push(70);
linkedListStack.Push(30);
linkedListStack.Push(56);
linkedListStack.Display();
//linkedListStack.Peek();
//linkedListStack.Pop();
linkedListStack.IsEmpty();
linkedListStack.Display();
Console.ReadKey();
