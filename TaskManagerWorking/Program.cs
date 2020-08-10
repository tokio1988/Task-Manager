using System;
using System.Collections.Generic;
using System.Data;
using TaskManagerWorking;

namespace TaskManagerWorking
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string command = null;
            ConsoleCommand consoleCommand = new ConsoleCommand();

            do
            {
                Console.WriteLine("Proszę wpisać komendę");
                command = Console.ReadLine();
                
                if (command.ToLower() == "add")
                {
                    consoleCommand.AddTask();
                }
                else if (command.ToLower() == "show")
                {
                    consoleCommand.ShowTasks();
                }
                else if (command.ToLower() == "remove")
                {

                }
                else if (command.ToLower() == "save")
                {

                }
                else
                {
                    Console.WriteLine("Błędna komenda");
                }

            } while (command.ToLower() != "exit");

            Console.WriteLine("Wyłączono task managera");
            Console.ReadKey();

            
        }
    }
}
