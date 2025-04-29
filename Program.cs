using System;
using System.Collections.Generic;

namespace TaskManagerApp
{
    class Program
    {
        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("===== Task Manager =====");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Delete Task");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ViewTasks();
                        break;
                    case "3":
                        DeleteTask();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void AddTask()
        {
            Console.Write("Enter the task description: ");
            string task = Console.ReadLine();
            tasks.Add(task);
            Console.WriteLine("Task added! Press any key to continue...");
            Console.ReadKey();
        }

        static void ViewTasks()
        {
            Console.WriteLine("Current Tasks:");
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void DeleteTask()
        {
            ViewTasks();
            Console.Write("Enter the number of the task to delete: ");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                if (index >= 1 && index <= tasks.Count)
                {
                    tasks.RemoveAt(index - 1);
                    Console.WriteLine("Task deleted.");
                }
                else
                {
                    Console.WriteLine("Invalid task number.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
