using System.Collections.Generic;
using DecadenceV3BLL.DTOs;
using DecadenceV3BLL.Interfaces.Services;
using DecadenceV3BLL.ViewModels;
using DecadenceV3DAL.Interfaces;
using DecadenceV3DAL.UnitOfWork;

namespace DecadenceV3BLL.Services
{
    public class ProjectService: IProjectService
    {
        private readonly IUnitOfWork unitOfWork;

        public ProjectService(AppDbContext context)
        {
            unitOfWork = new UnitOfWork(context);
        }
        public ProjectViewModel GetProjectById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ProjectDto> GetProjects()
        {
            throw new System.NotImplementedException();
        }

        public void AddProject(ProjectDto project)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateProject(ProjectDto project)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteProject(ProjectDto project)
        {
            throw new System.NotImplementedException();
        }
    }
}