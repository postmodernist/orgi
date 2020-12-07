using System.Collections.Generic;
using DecadenceV2_DAL.Entities;
using DecadenceV2_DAL.Interfaces;
using DecadenceV2_DAL.Interfaces.IServices;
using DecadenceV2_DAL.UnitOfWork;

namespace DecadenceV2_DAL.Services
{
    public class ProjectService: IProjectService
    {
        IUnitOfWork _unitOfWork;

        public ProjectService(AppDataContext context)
        {
            _unitOfWork = new UnitOfWork.UnitOfWork(context);
        }
        public void AddProject(Project project)
        {
             _unitOfWork.ProjectRepository.Add(project);
        }

        public void UpdateProject(Project project)
        {
            _unitOfWork.ProjectRepository.Update(project);
        }

        public void DeleteProject(Project project)
        {
            _unitOfWork.ProjectRepository.Delete(project);
        }

        public Project GetProjectById(int id)
        {
            return _unitOfWork.ProjectRepository.GetById(id);
        }

        public IEnumerable<Project> GetAllProjects()
        {
            return _unitOfWork.ProjectRepository.GetAll();
        }
    }
}