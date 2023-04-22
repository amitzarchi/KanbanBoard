using System;
namespace KanbanBoard
{
    internal interface IBoard
    {
        string Name {get; set;}
        List<ITask> Tasks {get; set;}
        int[] ColumnsCurrentLength {get; set;}
        int[] ColumnsMaxLength {get; set;} 

        void AddTask(string title, string description, DateTime dueDate);
        void EditTask(int taskId, string title, string description, DateTime DueDate);
        void MoveTask(int taskId);
        List<ITask> GetAllInProgress(string email);
    } 
}