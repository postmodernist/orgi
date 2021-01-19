using System.Collections.Generic;
using System.Threading.Tasks;
using DecadenceV3BLL.DTOs;
using DecadenceV3BLL.ViewModels;

namespace DecadenceV3BLL.Interfaces.Services
{
    public interface IProjectService
    {
        Task<ProjectViewModel> GetProjectById(int id);
        Task<IEnumerable<ProjectDto>> GetProjects();
        Task AddProject(ProjectDto project);
        Task UpdateProject(ProjectDto project);
        Task DeleteProject(ProjectDto project);
    }
}