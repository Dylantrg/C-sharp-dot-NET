using System;

public class ToDoList
{
    public static string[] tasks = new string[10];
    public static int taskCount = 0;
    public static void addTask()
    {
        Console.WriteLine("Enter the task you want to add:");
        var task = Console.ReadLine();
        if (taskCount < 10 && !string.IsNullOrWhiteSpace(task) && int.TryParse(task, out _) == false)
        {
            Console.WriteLine("Task added: " + task);
            tasks[taskCount] = task;
            taskCount++;
        } else {
            Console.WriteLine("Cannot add more tasks. The to-do list is full.");
        }
    }

    public static void completeTask()
    {
        Console.WriteLine("Enter the task you want to complete:");
        var task = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(task) || !int.TryParse(task, out int taskNumber) || taskNumber < 1 || taskNumber > taskCount)
        {
            Console.WriteLine("Invalid task number. Please enter a valid number between 1 and " + taskCount);
            return;
        }
        for (int i = int.Parse(task) - 1; i < taskCount - 1; i++)
        {
            tasks[i] = tasks[i + 1];
        }
        taskCount--;
        Console.WriteLine("Task completed.");
    }
    public static void viewTasks()
    {
        if (taskCount == 0)
        {
            Console.WriteLine("No tasks in the to-do list.");
            return;
        }
        Console.WriteLine("To-Do List:");
        for (int i = 0; i < taskCount; i++)
        {
            Console.WriteLine((i + 1) + ". " + tasks[i]);
        }
    }


    
}

public class Program
{
    public static void Main(string[] args)
    {
        Boolean running = true;
        while (running)
        {
            Console.WriteLine("To-Do List Application");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Complete Task");
            Console.WriteLine("3. View Tasks");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your choice:");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ToDoList.addTask();
                    break;
                case "2":
                    ToDoList.completeTask();
                    break;
                case "3":
                    ToDoList.viewTasks();
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Exiting the application. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }
        }
    }
}