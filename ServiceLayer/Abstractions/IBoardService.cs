using System;
namespace KanbanBoard
{
    internal interface IBoardService
    {
        IBoardFacade BoardF {get; set;}
        string CreateBoard(string email, string boardName);
        string DeleteBoard(string email, string boardName);
        string SetColumnLimit(string email, string boardName, int column, int limit);
    } 
}