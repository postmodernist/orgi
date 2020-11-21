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
    public class FiltersController : ControllerBase
    {
        private IFilterService _filterService;

        public FiltersController(IFilterService service)
        {
            _filterService = service;
        }
        // GET: api/<FiltersController>
        [HttpGet]
        public IEnumerable<Filter> Get()
        {
            return _filterService.GetAllFilters();
        }

        // GET api/<FiltersController>/5
        [HttpGet]
        public Filter Get(Guid id)
        {
            return _filterService.GetFilterById(id);
        }

        // POST api/<FiltersController>
        [HttpPost]
        public Guid Post([FromBody] Filter filter)
        {
            return _filterService.AddFilter(filter);
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
