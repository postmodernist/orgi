using System;
using System.Collections.Generic;
using Decadence_DAL.Entities;
using Decadence_DAL.Interfaces;

namespace Decadence_DAL.Services
{
    public class ProjectService: IProjectService
    {
        IUnitOfWork _unitOfWork;

        public ProjectService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Guid AddProject(Project project)
        {
            return _unitOfWork.ProjectRepository.Add(project);
        }

        public void UpdateProject(Project project)
        {
            _unitOfWork.ProjectRepository.Update(project);
        }

        public void DeleteProject(Project project)
        {
            _unitOfWork.ProjectRepository.Delete(project);
        }

        public Project GetProjectById(Guid id)
        {
            return _unitOfWork.ProjectRepository.Get(id);
        }

        public IEnumerable<Project> GetAllProjects()
        {
            return _unitOfWork.ProjectRepository.GetAll();
        }
    }
}