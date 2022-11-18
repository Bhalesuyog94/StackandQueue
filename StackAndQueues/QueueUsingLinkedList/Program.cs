// See https://aka.ms/new-console-template for more information
using QueueUsingLinkedList;

Console.WriteLine("Welcome to Queue");
Queue linkedListQueue = new Queue();
linkedListQueue.Enqueue(56);
linkedListQueue.Enqueue(30);
linkedListQueue.Enqueue(70);
linkedListQueue.Dequeu();
linkedListQueue.Display();
Console.ReadKey();
