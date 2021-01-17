using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public ProjectsController(AppDbContext context)
        {
            _projectService = new ProjectService(context);
        }
        // GET: api/<ProjectsController>
        [HttpGet]
        public IEnumerable<ProjectDto> Get()
        {
            return _projectService.GetProjects();
        }

        // GET api/<ProjectsController>/5
        [HttpGet("{id}")]
        public ProjectViewModel Get(int id)
        {
            return _projectService.GetProjectById(id);
        }

        // POST api/<ProjectsController>
        [HttpPost]
        public void Post([FromBody] ProjectDto project)
        {
            _projectService.AddProject(project);
        }

        // PUT api/<ProjectsController>/5
        [HttpPut]
        public void Put([FromBody] ProjectDto project)
        {
            _projectService.UpdateProject(project);
        }

        // DELETE api/<ProjectsController>/5
        [HttpDelete]
        public void Delete(ProjectDto project)
        {
            _projectService.DeleteProject(project);
        }
    }
}
