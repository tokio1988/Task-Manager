using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TaskManagerWorking
{
    class ConsoleCommand
    {
        public List<TaskModel> taskModels { get; set; }
        public ConsoleCommand()
        {
            
            taskModels = new List<TaskModel>();
        }
        public void AddTask()
        {
            Console.WriteLine("Proszę wprowadzić dane w następującycm formacie");
            Console.WriteLine($"Opis, data rozpoczęcia, data zakończenia (opcjonalne), zadanie całoddniowe [true/false], ważne [true/false]");
            var text = Console.ReadLine();

            var dateToCreateTaskModel = text.Split(",");
            if (dateToCreateTaskModel.Length == 4 | dateToCreateTaskModel.Length == 5)
            {
                Console.WriteLine("Dziękuję. Dane podano w prawidłowym formacie");
                
                var description = dateToCreateTaskModel[0];
                var startDate = DateTime.Parse(dateToCreateTaskModel[1]);
                var endDate = DateTime.Parse(dateToCreateTaskModel[2]);
                var isAllDay = bool.Parse(dateToCreateTaskModel[3]);
                var isImportant = bool.Parse(dateToCreateTaskModel[4]);
                taskModels.Add(new TaskModel { _description = description, _startDate = startDate, _endDate = endDate, _isAllDay = isAllDay, _isImportant = isImportant });
            }
            else
            {
                Console.WriteLine("Dane podano w błędnym formacie");
            }
        }

        public void ShowTasks()
        {
            foreach(var taskmodel in taskModels)
            {
                Console.WriteLine($"{taskmodel._description}, {taskmodel._startDate}, {taskmodel._endDate},{taskmodel._isAllDay},{taskmodel._isImportant}");
            }
            
        }
        public void SaveTask() 
        {
            
        }

        public void RemoveTask()
        {

        }
    }
}
