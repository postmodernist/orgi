using System.Collections.Generic;
using AutoMapper;
using System.Linq;
using System.Threading.Tasks;
using DecadenceV3BLL.DTOs;
using DecadenceV3BLL.Interfaces.Services;
using DecadenceV3BLL.ViewModels;
using DecadenceV3DAL.Entities;
using DecadenceV3DAL.Interfaces;
using DecadenceV3DAL.UnitOfWork;

namespace DecadenceV3BLL.Services
{
    public class ProjectService: IProjectService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;
        public ProjectService(AppDbContext context , IMapper mapper)
        {
            unitOfWork = new UnitOfWork(context);
            _mapper = mapper;
        }
        public async Task<ProjectViewModel> GetProjectById(int id)
        {
            var view = _mapper.Map<ProjectViewModel>(await unitOfWork.ProjectRepository.GetEntityById(id));
            var tasks = _mapper.Map<IEnumerable<WorkItemDto>>(await unitOfWork.WorkItemRepository.GetEntities());
            view.Tasks = from t in tasks
                         where t.ProjectId.Equals(view.Id)
                         select t;
            return view;
        }

        public async Task<IEnumerable<ProjectDto>> GetProjects()
        {
            return _mapper.Map<IEnumerable<ProjectDto>>(await unitOfWork.ProjectRepository.GetEntities());
        }

        public async Task AddProject(ProjectDto project)
        {
            var item = _mapper.Map<Project>(project);
            await unitOfWork.ProjectRepository.Add(item);
        }

        public async Task UpdateProject(ProjectDto project)
        {
            var item = _mapper.Map<Project>(project);
            await unitOfWork.ProjectRepository.Update(item);
        }

        public async Task DeleteProject(ProjectDto project)
        {
            var item = _mapper.Map<Project>(project);
            await unitOfWork.ProjectRepository.Delete(item);
        }
    }
}