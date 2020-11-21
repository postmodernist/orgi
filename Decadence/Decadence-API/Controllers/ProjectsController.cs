using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Decadence_DAL.Interfaces;
using Decadence_DAL.Entities;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Decadence.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        IProjectService _service;
        public ProjectsController(IProjectService service)
        {
            _service = service;
        }
        // GET: api/<ProjectsController>
        [HttpGet]
        public IEnumerable<Project> Get()
        {
            return _service.GetAllProjects();
        }

        // GET api/<ProjectsController>/5
        [HttpGet("{id}")]
        public Project Get(Guid id)
        {
            return _service.GetProjectById(id);
        }

        // POST api/<ProjectsController>
        [HttpPost]
        public Guid Post([FromBody] Project project)
        {
            return _service.AddProject(project);
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
