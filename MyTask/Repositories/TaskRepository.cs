using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;
using Interfaces;

namespace Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private Database db = new Database();

        public bool Create(Task task)
        {
            bool status = false;
            if(task != null)
            {
                task.DateCreated = DateTime.Now;
                db.Task.Add(task);
                db.SaveChanges();
                status = true;
            }
            return status;
        }

        public bool Edit(Task task)
        {
            bool status = false;
            if(task != null)
            {
                Task dbTask = db.Task.FirstOrDefault(c => c.ID == task.ID);
                db.Entry(dbTask).CurrentValues.SetValues(task);
                db.SaveChanges();
                status = true;
            }
            return status;
        }

        public bool Delete(int TaskID)
        {
            bool status = false;
            Task dbTask = db.Task.FirstOrDefault(c => c.ID == TaskID);
            if(dbTask != null)
            {
                db.SaveChanges();
                status = true;
            }
            return status;
        }

        public List<Task> GetAll()
        {
            return db.Task.ToList();
        }

        public Task GetByID(int TaskID)
        {
            return db.Task.FirstOrDefault(t => t.ID == TaskID);
        }

        public List<Task> GetAllByProject(int projectID)
        {
            return db.Task.Where(t => t.ProjectID == projectID).ToList();
        }

        public List<Task> GetByAssignee(string userID)
        {
            throw new NotImplementedException();
        }

        public string GetAssignee(int taskID)
        {
            throw new NotImplementedException();
        }

        public bool ChangeTaskStatus(int taskID , string changeTaskStatus)
        {
            throw new NotImplementedException();
        }
    }
}

