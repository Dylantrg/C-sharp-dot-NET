using System;

public class ToDoList
{
    public static string[] strings = new string[10];
    public static int TaskCount = 0;

    public static void AddTask(string task)
    {
        if (TaskCount < strings.Length)
        {
            strings[TaskCount] = task;
            TaskCount++;
        }
        else
        {
            Console.WriteLine("To-Do List is full. Cannot add more tasks.");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}