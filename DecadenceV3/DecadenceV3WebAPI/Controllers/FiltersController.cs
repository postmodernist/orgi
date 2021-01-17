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

namespace DecadenceV3WebAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class FiltersController : ControllerBase
    {
        private readonly IFilterService _filterService;

        public FiltersController(AppDbContext context ,IMapper mapper)
        {
            _filterService = new FilterService(context, mapper);
        }
        // GET: api/<FiltersController>
        [HttpGet]
        public IEnumerable<FilterDto> Get()
        {
            return _filterService.GetFilters();
        }

        // GET api/<FiltersController>/5
        [HttpGet("{id}")]
        public FilterDto Get(int id)
        {
            return _filterService.GetFilterById(id);
        }

        // POST api/<FiltersController>
        [HttpPost]
        public void Post([FromBody] FilterDto filter)
        {
            _filterService.AddFilter(filter);
        }

        // PUT api/<FiltersController>/5
        [HttpPut]
        public void Put([FromBody] FilterDto filter)
        {
            _filterService.UpdateFilter(filter);
        }

        // DELETE api/<FiltersController>/5
        [HttpDelete]
        public void Delete(FilterDto filter)
        {
            _filterService.DeleteFilter(filter);
        }
    }
}
