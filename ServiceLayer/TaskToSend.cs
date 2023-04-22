using System;

    public class TaskToSend: ITaskToSend
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime DueDate { get; set; }
        public TaskToSend(int id, string title,string description, DateTime creationTime, DateTime dueDate)
        {
            Id = id;
            Title = title;
            Description = description;    
            CreationTime = creationTime;
            DueDate = dueDate;
            Description = description;
        }
    }