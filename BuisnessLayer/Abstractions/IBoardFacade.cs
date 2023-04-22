using System;
namespace KanbanBoard
{
    internal interface IBoardFacade
    {
        Dictionary<string, List<IBoard>> UserBoards {get; set;}
        int TaskCounter;
        IBoard CreateBoard(string email, string boardName);
        void DeleteBoard(string email, string boardName);
        List<ITask> GetAllUserInProgressTasks(string email);
        IBoard GetBoard(string email, string boardName);
        void AddTask(string email, string boardName, int taskId, string title, string description, DateTime dueDate);
        void EditTask(string email, string boardName, int taskId, string title, string description, DateTime dueDate);
        void MoveTask(string email, string boardName, int taskId);
    } 
}