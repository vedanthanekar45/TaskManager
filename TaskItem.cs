using System;

public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool isCompleted { get; set; }
    public string category { get; set; }
    public DateTime createdAt { get; set; }
}