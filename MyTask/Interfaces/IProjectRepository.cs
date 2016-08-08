using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public interface IProjectRepository
    {
        List<Project> GetAll();
        Project GetByID(int projectID);
        Project Create(Project project);
        Project Edit(Project project);
        bool Delete(int projectID);

        int GetProjectTasksSum(int projectID);

    }
}
