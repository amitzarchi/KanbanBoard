using System;
namespace KanbanBoard
{
    internal interface IUser
    {
        string Email {get; set;}
        string Password {get; set;}
        bool LoggedIn {get; set;}
        void Login(string password);
        void Logout();      
    } 
}