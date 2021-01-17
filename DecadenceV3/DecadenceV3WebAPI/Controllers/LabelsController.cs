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
    public class LabelsController : ControllerBase
    {
        private readonly ILabelService _labelService;

        public LabelsController(AppDbContext context, IMapper mapper)
        {
            _labelService = new LabelService(context , mapper);
        }
        // GET: api/<LabelsController>
        [HttpGet]
        public IEnumerable<LabelDto> Get()
        {
            return _labelService.GetLabels();
        }

        // GET api/<LabelsController>/5
        [HttpGet("{id}")]
        public LabelViewModel Get(int id)
        {
            return _labelService.GetLabelById(id);
        }

        // POST api/<LabelsController>
        [HttpPost]
        public void Post([FromBody] LabelDto label)
        {
            _labelService.AddLabel(label);
        }

        // PUT api/<LabelsController>/5
        [HttpPut]
        public void Put([FromBody] LabelDto label)
        {
            _labelService.UpdateLabel(label);
        }

        // DELETE api/<LabelsController>/5
        [HttpDelete]
        public void Delete(LabelDto label)
        {
            _labelService.DeleteLabel(label);
        }
    }
}
