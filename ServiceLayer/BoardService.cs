using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KanbanBoard
    
    {
    
        public class BoardService : IBoardService
        {
            public IBoardFacade BoardF { get; set; }
            public BoardService(IBoardFacade BFacade)
            {
                this.BFacade = BFacade;
            }

            public string CreateBoard(string email, string name)
            {
                try
                {
                    var board = BFacade.CreateBoard(email, name);
                    var response = ServiceFactory.CreateResponse($"{name} Board Created", null);
                    return JsonSerializer.Serialize(response);
                }
                catch (Exception e)
                {
                    var response = ServiceFactory.CreateResponse(null, e.Message);
                    return JsonSerializer.Serialize(response);
                }
            }
            public string DeleteBoard(string email, string name)
            {
                try
                {
                    BFacade.DeleteBoard(email, name);
                    var response = ServiceFactory.CreateResponse($"{name} Board Deleted", null);
                    return JsonSerializer.Serialize(response);
                }
                catch (Exception e)
                {
                    var response = ServiceFactory.CreateResponse(null, e.Message);
                    return JsonSerializer.Serialize(response);
                }

            }
            public string SetColumnLimit(string email, string boardName, int columnOrdinal, int lengthLimit)
            {
                try
                {
                    BFacade.SetColumnLimit(email, boardName, columnOrdinal, lengthLimit);
                    var response = ServiceFactory.CreateResponse("Limit Set", null);
                    return JsonSerializer.Serialize(response);
                }
                catch (Exception e)
                {
                    var response = ServiceFactory.CreateResponse(null, e.Message);
                    return JsonSerializer.Serialize(response);
                }

            }
            
        }

    }