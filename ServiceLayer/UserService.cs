using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using KanbanBoard;

namespace KanbanBoard
    
    {
    
        public class UserService : IUserService
        {
            public IUserFacade UserF {get; set;}
            public IBoardFacade BoardF {get; set;}
            public UserService(IUserFacade UserF, IBoardFacade BoardF)
            {
                this.UserF = UserF;
                this.BoardF = BoardF;
            }
        }
        public string Register(string email, string password)
        {
            try
            {
                var user = new UserToSend(UserF.Register(email, password).Email);
                var response = new Response(JsonSerializer.Serialize(user), null);
                return JsonSerializer.Serialize(response);
            }
            catch (Exception e)
            {
                var response = new Response(null, e.Message);
                return JsonSerializer.Serialize(response);

            }
        }
        public string Login(string email, string password)
        {
            try
            {
                var user = new UserToSend(UserF.Login(email, password).Email);
                var response = new Response(JsonSerializer.Serialize(user), null);
                return JsonSerializer.Serialize(response);
            }
            catch (Exception e)
            {
                var response = new Response(null, e.Message);
                return JsonSerializer.Serialize(response);

            }
        }
        public string LogOut(string email)
        {
            try
            {
                UserF.Logout(email);
                var response = new Response("logged Out", null);
                return JsonSerializer.Serialize(response);
            }
            catch (Exception e)
            {
                var response = new Response(null, e.Message);
                return JsonSerializer.Serialize(response);

            }
        }
        public string GetAllInProgressTasks(string email)
        {
            try
            {
                List<var> tasks = BoardF.GetAllUserInProgressTasks(email);
                List<ITaskToSend> tasksToSend = new LinkedList<>();
                foreach (ITask t in tasks) {
                    var tToSend = new TaskToSend(t.Email);
                    tasksToSend.Add(tToSend);
                }
                var response = new Response(JsonSerializer.Serialize(tasksToSend), null);
                return JsonSerializer.Serialize(response);
            }
            catch (Exception e)
            {
                var response = new Response(null, e.Message);
                return JsonSerializer.Serialize(response);

            }
        }
    }

