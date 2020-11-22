using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Decadence_DAL.Entities;
using Decadence_DAL.Interfaces;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Decadence.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabelsController : ControllerBase
    {
        private ILabelService _labelService;

        public LabelsController(ILabelService labelService)
        {
            _labelService = labelService;
        }
        // GET: api/<LabelsController>
        [HttpGet]
        public IEnumerable<Label> Get()
        {
            return _labelService.GetAllLabels();
        }

        // GET api/<LabelsController>/5
        [HttpGet("{id}")]
        public Label Get(Guid id)
        {
            return _labelService.GetLabelById(id);
        }

        // POST api/<LabelsController>
        [HttpPost]
        public Guid Post([FromBody] Label label)
        {
            return _labelService.AddLabel(label);
        }

        // PUT api/<LabelsController>/5
        [HttpPut]
        public void Put([FromBody] Label label)
        {
            _labelService.UpdateLabel(label);
        }

        // DELETE api/<LabelsController>/5
        [HttpDelete]
        public void Delete(Label label)
        {
            _labelService.DeleteLabel(label);
        }
    }
}
