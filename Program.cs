using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        var service = new TaskService();
        service.AddTask("Learn C#", "Work");
        service.AddTask("Gym", "Personal");

        var tasks = service.GetAllTasks();

        foreach (var t in tasks)
        {
            Console.WriteLine($"{t.Id} - {t.Title} - {t.isCompleted}");
        }
    }
}