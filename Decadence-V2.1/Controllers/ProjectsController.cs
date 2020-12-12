using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DecadenceV2_1_DAL.Entities;
using DecadenceV2_1_DAL.Interfaces.IServices;
using DecadenceV2_1_DAL.Services;
using DecadenceV2_1_DAL.UnitOfWork;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Decadence_V2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        IProjectService _service;
        public ProjectsController(AppDataContext context)
        {
            _service = new ProjectService(context);
        }
        // GET: api/<ProjectsController>
        [HttpGet]
        public IEnumerable<Project> Get()
        {
            return _service.GetAllProjects();
        }

        // GET api/<ProjectsController>/5
        [HttpGet("{id}")]
        public Project Get(int id)
        {
            return _service.GetProjectById(id);
        }

        // POST api/<ProjectsController>
        [HttpPost]
        public void Post([FromBody] Project project)
        {
            _service.AddProject(project);
        }

        // PUT api/<ProjectsController>/5
        [HttpPut]
        public void Put([FromBody] Project project)
        {
            _service.UpdateProject(project);
        }

        // DELETE api/<ProjectsController>/5
        [HttpDelete]
        public void Delete(Project project)
        {
            _service.DeleteProject(project);
        }
    }
}
