using AutoMapper;
using NetCoreUygulama.Api.DTOs;
using Microsoft.AspNetCore.Mvc;
using NetCoreUygulama.Core.Models;
using NetCoreUygulama.Core.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreUygulama.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IService<Person> _personService;
        private readonly IMapper _mapper;

        public PersonController(IService<Person> personService, IMapper mapper)
        {
            _personService = personService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var persons = await _personService.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<PersonDTO>>(persons));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var person = await _personService.GetByIdAsync(id);

            return Ok(_mapper.Map<PersonDTO>(person));
        }
        [HttpPost]
        public async Task<IActionResult> Save(PersonDTO personDTO)
        {
            var newPerson = await _personService.AddAsync(_mapper.Map<Person>(personDTO));
            return Created(string.Empty, _mapper.Map<PersonDTO>(newPerson));
        }

        [HttpPut]
        public IActionResult Update(PersonDTO personDTO)
        {
            var person = _personService.Update(_mapper.Map<Person>(personDTO));
            return NoContent();
        }
        [HttpDelete("{id}")]

        public IActionResult Remove(int id)
        {
            var person = _personService.GetByIdAsync(id).Result;
            _personService.Remove(person);
            return NoContent();

        }
    }
}
