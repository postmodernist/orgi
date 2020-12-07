using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DecadenceV2_DAL.Entities;
using DecadenceV2_DAL.Interfaces.IServices;
using DecadenceV2_DAL.Services;
using DecadenceV2_DAL.UnitOfWork;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Decadence_V2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FiltersController : ControllerBase
    {
        private IFilterService _filterService;

        public FiltersController(AppDataContext context)
        {
            _filterService = new FilterService(context);
        }
        // GET: api/<FiltersController>
        [HttpGet]
        public IEnumerable<Filter> Get()
        {
            return _filterService.GetAllFilters();
        }

        // GET api/<FiltersController>/5
        [HttpGet("{id}")]

        public Filter Get(int id)
        {
            return _filterService.GetFilterById(id);
        }

        // POST api/<FiltersController>
        [HttpPost]
        public void Post([FromBody] Filter filter)
        {
            _filterService.AddFilter(filter);
        }

        // PUT api/<FiltersController>/5
        [HttpPut]
        public void Put([FromBody] Filter filter)
        {
            _filterService.UpdateFilter(filter);
        }

        // DELETE api/<FiltersController>/5
        [HttpDelete]
        public void Delete(Filter filter)
        {
            _filterService.DeleteFilter(filter);
        }
    }
}
