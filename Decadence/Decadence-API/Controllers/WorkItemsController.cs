using Decadence_DAL.Entities;
using Decadence_DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Decadence.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkItemsController : ControllerBase
    {
        IWorkItemService _service;
        public WorkItemsController(IWorkItemService service)
        {
            _service = service;
        }
        // GET: api/<WorkItemsController>
        [HttpGet]
        public IEnumerable<WorkItem> Get()
        {
            return _service.GetAllWorkItems();
        }

        // GET api/<WorkItemsController>/5
        [HttpGet("{id}")]
        public WorkItem Get(int id)
        {
            return _service.GetWorkItemById(id);
        }

        // POST api/<WorkItemsController>
        [HttpPost]
        public int Post([FromBody] WorkItem item)
        {
            return _service.AddWorkItem(item);
        }

        // PUT api/<WorkItemsController>/5
        [HttpPut]
        public void Put([FromBody] WorkItem item)
        {
            _service.UpdateWorkItem(item);
        }

        // DELETE api/<WorkItemsController>/5
        [HttpDelete]
        public void Delete(WorkItem item)
        {
            _service.DeleteWorkItem(item);
        }
    }
}
