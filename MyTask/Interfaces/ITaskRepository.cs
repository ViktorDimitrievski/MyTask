using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;


namespace Interfaces
{
    public interface  ITaskRepository
    {
        List<Task> GetAll();
        List<Task> GetByAssignee(string userID);
        List<Task> GetAllByProject(int projectID);
        Task GetByID(int ID);
        Task Create(Task taks);
        bool Edit(Task task);
        bool Delete(int taskID);

        string GetAssignee(int taskID);
        bool ChangeTaskStatus(int taskID , string changeTaskStatus);

    }
}
