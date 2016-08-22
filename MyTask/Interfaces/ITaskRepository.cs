using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;


namespace Interfaces
{
    public interface  ITaskRepository
    {
        bool Create(Task taks);
        bool Edit(Task task);
        bool Delete(int taskID);
        List<Task> GetAll();
        Task GetByID(int ID);
        List<Task> GetByAssignee(string userID);
        List<Task> GetAllByProject(int projectID);

        string GetAssignee(int taskID);
        bool ChangeTaskStatus(int taskID , string changeTaskStatus);

    }
}
