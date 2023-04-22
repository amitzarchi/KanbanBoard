using System;
namespace KanbanBoard
{
    internal interface ITask
    {
        int Id {get; set;}
        string Title {get; set;}
        string Description {get; set;}
        DateTime CreationTime {get; set;}
        DateTime DueDate {get; set;}
        int Column {get; set;}
        void EditTask(string title, string description, DateTime dueDate);
        void MoveTask();

    } 
}