using System;
namespace KanbanBoard
{
    internal interface IUserService
    {
        IUserFacade UserF {get; set;}
        IBoardFacade BoardF {get; set;}
        string Register(string email, string password);
        string Login(string email, string password);
        string Logout(string email);
        string GetAllInProgressTasks(string email);

    }
}
