using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DecadenceV3BLL.DTOs;
using DecadenceV3BLL.Interfaces.Services;
using DecadenceV3BLL.Services;
using DecadenceV3BLL.ViewModels;
using DecadenceV3DAL.UnitOfWork;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DecadenceV3WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectsController(AppDbContext context, IMapper mapper)
        {
            _projectService = new ProjectService(context , mapper);
        }
        // GET: api/<ProjectsController>
        [HttpGet]
        public async Task<IEnumerable<ProjectDto>> Get()
        {
            return await _projectService.GetProjects();
        }

        // GET api/<ProjectsController>/5
        [HttpGet("{id}")]
        public async Task<ProjectViewModel>Get(int id)
        {
            return await _projectService.GetProjectById(id);
        }

        // POST api/<ProjectsController>
        [HttpPost]
        public async Task Post([FromBody] ProjectDto project)
        {
            await _projectService.AddProject(project);
        }

        // PUT api/<ProjectsController>/5
        [HttpPut]
        public async Task Put([FromBody] ProjectDto project)
        {
            await _projectService.UpdateProject(project);
        }

        // DELETE api/<ProjectsController>/5
        [HttpDelete]
        public async Task Delete(ProjectDto project)
        {
            await _projectService.DeleteProject(project);
        }
    }
}
