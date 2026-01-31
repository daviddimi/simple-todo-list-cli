using System;
class Program
{
    static void Main(string[] args)
    {
        string task1 = "";
        bool running = true;
        Console.WriteLine("--- TO DO LIST ---");
        while (running)
        {
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Mark Done");
            Console.WriteLine("3. Remove Task");
            Console.WriteLine("4. View Tasks");
            Console.WriteLine("5. Exit");
            Console.Write("Choose your option (1, 2, 3, 4 or 5): ");

            string taskChoice = Console.ReadLine();

            if (char.TryParse(taskChoice, out char choice))
            {
                if (choice == '1')
                {
                    Console.Write("Add your task:");
                    task1 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("Task added sucessfully!\n");
                }
                else if (choice == '2')
                {
                    if (!string.IsNullOrEmpty(task1))
                    {
                        task1 = "[Done]" + task1;
                        Console.WriteLine();
                        Console.WriteLine("Task marked as done!\n");
                    }
                    else
                        Console.WriteLine();
                    Console.WriteLine("No task available!\n");
                }
                else if (choice == '3')
                {
                    if (!string.IsNullOrEmpty(task1))
                    {
                        task1 = string.Empty;
                        Console.WriteLine();
                        Console.WriteLine("Task removed!\n");
                    }
                    else
                        Console.WriteLine();
                    Console.WriteLine("No task available!\n");
                }
                else if (choice == '4')
                {
                    if (string.IsNullOrEmpty(task1))
                    {
                        Console.WriteLine();
                        Console.WriteLine("No tasks available!\n");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Current tasks: \n{task1}");
                        Console.WriteLine();
                    }
                }
                else if (choice == '5')
                {
                    running = false;
                    Console.WriteLine();
                    Console.WriteLine("Thanks for using my TO-DO List Program");
                    Console.WriteLine("by David Dimitriev\n");

                }
                else
                    Console.WriteLine();
                Console.WriteLine("Invalid choice. Please pick 1, 2, 3 or 4.\n");
            }
            else
                Console.WriteLine();
            Console.WriteLine("Invalid input. Please enter a single number.\n");

        }
    }
}