using KanbanBoard;

    public class TaskService : ITaskService
    {
        private IBoardFacade BoardF { get; set; }
        public TaskService(IBoardFacade BoardF)
        {
            this.BoardF = BoardF;
        }
        public string AddTask(string email, string boardName, string title, string description, DateTime dueDate)
        {
            try
            {
                var task = BoardF.AddTask(email, boardName, title, description, dueDate);
                var response = new Response("Task Added", null);
                return JsonSerializer.Serialize(response);
            }
            catch (Exception e)
            {
                var response = new Response(null, e.Message);
                return JsonSerializer.Serialize(response);
            }
        }
        public string UpdateTaskTitle(string email, string boardName, int taskId, string title)
        {
            try
            {
                var task = BoardF.UpdateTaskTitle(email, boardName, taskId, title);
                var response = new Response("Title updated", null);
                return JsonSerializer.Serialize(response);
            }
            catch (Exception e)
            {
                var response = new Response(null, e.Message);
                return JsonSerializer.Serialize(response);
            }
        }
        public string UpdateTaskDescription(string email, string boardName, int taskId, string description)
        {
            try
            {
                var task = BoardF.UpdateTaskDescription(email, boardName, taskId, description);
                var response = new Response("description updated", null);
                return JsonSerializer.Serialize(response);
            }
            catch (Exception e)
            {
                var response = new Response(null, e.Message);
                return JsonSerializer.Serialize(response);
            }
        }
        public string UpdateTaskDueDate(string email, string boardName, int taskId, DateTime dueDate)
        {
            try
            {
                var task = BoardF.UpdateTaskDueDate(email, boardName, taskId, dueDate);
                var response = new Response("Due-Date updated", null);
                return JsonSerializer.Serialize(response);
            }
            catch (Exception e)
            {
                var response = new Response(null, e.Message);
                return JsonSerializer.Serialize(response);
            }
        }
        public string MoveTask(string email, string boardName, int taskId)
        {
            try
            {
                var task = BoardF.MoveTask(email, boardName, taskId);
                var response = new Response("Task Advanced", null);
                return JsonSerializer.Serialize(response);
            }
            catch (Exception e)
            {
                var response = new Response(null, e.Message);
                return JsonSerializer.Serialize(response);
            }
        }
       

    }