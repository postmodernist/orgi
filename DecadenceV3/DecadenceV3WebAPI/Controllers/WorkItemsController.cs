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
    public class WorkItemsController : ControllerBase
    {
        private readonly IWorkItemService _workItemService;

        public WorkItemsController(AppDbContext context)
        {
            _workItemService = new WorkItemService(context);
        }
        // GET: api/<WorkItemsController>
        [HttpGet]
        public IEnumerable<WorkItemDto> Get()
        {
            return _workItemService.GetWorkItems();
        }

        // GET api/<WorkItemsController>/5
        [HttpGet("{id}")]
        public WorkItemViewModel Get(int id)
        {
            return _workItemService.GetWokItemById(id);
        }

        // POST api/<WorkItemsController>
        [HttpPost]
        public void Post([FromBody] WorkItemDto workItem)
        {
            _workItemService.AddWorkItem(workItem);
        }

        // PUT api/<WorkItemsController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] WorkItemDto workItem)
        {
            _workItemService.UpdateWorkItem(workItem);
        }

        // DELETE api/<WorkItemsController>/5
        [HttpDelete("{id}")]
        public void Delete(WorkItemDto workItem)
        {
            _workItemService.DeleteWorkItem(workItem);
        }
    }
}
