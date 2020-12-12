using System.Collections.Generic;
using DecadenceV2_1_DAL.Entities;

namespace DecadenceV2_1_DAL.Interfaces.IServices
{
    public interface IProjectService
    {
        void AddProject(Project project);
        void UpdateProject(Project project);
        void DeleteProject(Project project);
        Project GetProjectById(int id);
        IEnumerable<Project> GetAllProjects();
    }
}