using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public interface IProjectRepository
    {
        bool Create(Project project);
        bool Edit(Project project);
        bool Delete(int projectID);
        List<Project> GetAll();
        Project GetByID(int projectID);
    }
}
