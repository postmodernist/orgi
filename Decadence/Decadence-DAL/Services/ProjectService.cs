using Decadence_DAL.Entities;
using Decadence_DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace Decadence_DAL.Services
{
    public class ProjectService : IProjectService
    {
        IUnitOfWork _unitOfWork;

        public ProjectService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public int AddProject(Project project)
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

        public Project GetProjectById(int id)
        {
            return _unitOfWork.ProjectRepository.Get(id);
        }

        public IEnumerable<Project> GetAllProjects()
        {
            return _unitOfWork.ProjectRepository.GetAll();
        }
    }
}