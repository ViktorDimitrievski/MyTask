using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Interfaces;
using System.Data.Entity;

namespace Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private Database db = new Database();

        public bool Create(Project project)
        {
            bool status = false;
            if(project != null)
            {
                project.DateCreated = DateTime.Now;
                db.Project.Add(project);
                db.SaveChanges();
                status = true;
            }
            return status;
        }

        public bool Edit(Project project)
        {
            bool status = false;
            if(project != null)
            {
                db.Project.Attach(project);
                project.DateCreated = DateTime.Now;
                db.Entry(project).State = EntityState.Modified;
                db.SaveChanges();
                status = true;
            }
            return status;
        }

        public bool Delete(int ProjectID)
        {
            bool status = false;
            Project dbProject = db.Project.FirstOrDefault(p => p.ID == ProjectID);
            if(dbProject != null)
            {
                db.SaveChanges();
                status = true;
            }
            return status;
        }

        public List<Project> GetAll()
        {
            return db.Project.ToList();
        }

        public Project GetByID(int ProjectID)
        {
            return db.Project.FirstOrDefault(p => p.ID == ProjectID);
        }
    }
}
