using System;
namespace KanbanBoard
{
    internal interface IUserFacade
    {
        Dictionary<string, IUser> Users {get; set;}
        void Register(string email, string password);
        IUser Login(string email, string password);
        IUser Logout(string email);
        IUser GetUser(string email);
        bool IsLoggedIn(string email);

    } 
}