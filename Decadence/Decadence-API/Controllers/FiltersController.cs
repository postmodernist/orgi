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
        [HttpGet("{id}")]

        public Filter Get(int id)
        {
            return _filterService.GetFilterById(id);
        }

        // POST api/<FiltersController>
        [HttpPost]
        public int Post([FromBody] Filter filter)
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
