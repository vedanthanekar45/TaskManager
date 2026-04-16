using System;
using System.Collections.Generic;
using System.Linq;

public class TaskService
{
    List<TaskItem> tasks = new List<TaskItem>();
    private int nextId = 1;

    public void AddTask (string Title, string Category)
    {
        TaskItem task = new TaskItem();
        task.Id = nextId++;
        task.Title = Title;
        task.isCompleted = false;
        task.category = Category;
        task.createdAt = DateTime.Now;

        tasks.Add(task);
    }


    public List<TaskItem> GetAllTasks()
    {
        return tasks.ToList();
    }

    public void MarkAsCompleted (int id)
    {
        var task = tasks.FirstOrDefault(t => t.Id == id);
        if (task != null)
        {
            task.isCompleted = true;
        }
    }

    public void DeleteTask (int id)
    {
        var task = tasks.FirstOrDefault(t => t.Id == id);
        if (task != null)
        {
            tasks.Remove(task);
        }
    }

    public List<TaskItem> GetCompletedTasks ()
    {
        return tasks.Where(t => t.isCompleted).ToList();
    }

    public List<TaskItem> GetPendingTasks()
    {
        return tasks.Where(t => !t.isCompleted).ToList();
    }

    public List<TaskItem> GetRecentTasks (int n)
    {
        return tasks.Where(t => t.createdAt > DateTime.Now.AddDays(-n)).OrderByDescending(t => t.createdAt).ToList();
    }
}