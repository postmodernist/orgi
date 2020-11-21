using System;
using System.Collections.Generic;
using Decadence_DAL.Entities;

namespace Decadence_DAL.Interfaces.Database.IServices
{
    public interface IProjectService
    {
        Guid AddProject(Project project);
        void UpdateProject(Project project);
        void DeleteProject(Project project);
        Project GetProjectById(Guid id);
        IEnumerable<Project> GetAllProjects();
    }
}