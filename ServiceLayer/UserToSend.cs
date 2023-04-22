using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntroSE.Kanban.Backend.ServiceLayer.Abstractions;

namespace IntroSE.Kanban.Backend.ServiceLayer
{
    internal class UserToSend : IUserToSend
    {
        public string Email { get; set; }

        public UserToSend(string email)
        {
            Email = email;
        }
    }
}
