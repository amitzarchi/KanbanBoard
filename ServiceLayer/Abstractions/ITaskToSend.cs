    public interface ITaskToSend
    {
        int Id { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        DateTime CreationTime { get; set; }
        DateTime DueDate { get; set; }
    }
