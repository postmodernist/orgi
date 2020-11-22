using Decadence_DAL.Entities;
using System;
using System.Collections.Generic;

namespace Decadence_DAL.Interfaces
{
    public interface IProjectService
    {
        int AddProject(Project project);
        void UpdateProject(Project project);
        void DeleteProject(Project project);
        Project GetProjectById(int id);
        IEnumerable<Project> GetAllProjects();
    }
}