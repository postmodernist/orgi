using System.Collections.Generic;
using DecadenceV3BLL.DTOs;
using DecadenceV3BLL.ViewModels;

namespace DecadenceV3BLL.Interfaces.Services
{
    public interface IProjectService
    {
        ProjectViewModel GetProjectById(int id);
        IEnumerable<ProjectDto> GetProjects();
        void AddProject(ProjectDto project);
        void UpdateProject(ProjectDto project);
        void DeleteProject(ProjectDto project);
    }
}