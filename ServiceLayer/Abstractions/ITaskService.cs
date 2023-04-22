using System;
namespace KanbanBoard
{
    internal interface ITaskService
    {
        IBoardFacade BoardF {get; set;}
        string AddTask(string email, string boardName, string title, string description, DateTime DueDate);
        string EditTask(string email, string boardName,int taskId, string title, string description, DateTime DueDate);
        string MoveTask(string email, string boardName,int taskId);
    }
}
