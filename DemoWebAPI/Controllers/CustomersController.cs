using DemoLibrary.Commands;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<CustomersController>
        [HttpGet]
        public async Task<IEnumerable<Customer>> Get()
        {
            return await _mediator.Send(new GetCustomersQuery());
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public async Task<Customer> Get(int id)
        {
            return await _mediator.Send(new GetCustomerByIdQuery(id));
        }

        // POST api/<CustomersController>
        [HttpPost]
        public async Task<Customer> Post([FromBody] Customer customer)
        {
            return await _mediator.Send(new CreateCustomerCommand(customer.FirstName, customer.LastName, customer.Addresses, customer.EmailAddresses, customer.PhoneNumbers));
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateCustomerCommand command)
        {
            command.Id = id;

            var result = await _mediator.Send(command);

            if (!result)
                return BadRequest();

            return Ok();
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteCustomerCommand(id);

            var result = await _mediator.Send(command);

            if (!result)
                return BadRequest();

            return NoContent();
        }
    }
}
