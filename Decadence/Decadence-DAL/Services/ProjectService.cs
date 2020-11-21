using System;
using System.Collections.Generic;
using Decadence_DAL.Entities;
using Decadence_DAL.Interfaces;

namespace Decadence_DAL.Services
{
    public class ProjectService: IProjectRepository
    {
        IUnitOfWork _unitOfWork;

        public ProjectService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Guid Add(Project project)
        {
            return _unitOfWork.ProjectRepository.Add(project);
        }

        public void Update(Project project)
        {
            _unitOfWork.ProjectRepository.Update(project);
        }

        public void Delete(Project project)
        {
            _unitOfWork.ProjectRepository.Delete(project);
        }

        public Project Get(Guid id)
        {
            return _unitOfWork.ProjectRepository.Get(id);
        }

        public IEnumerable<Project> GetAll()
        {
            return _unitOfWork.ProjectRepository.GetAll();
        }
    }
}