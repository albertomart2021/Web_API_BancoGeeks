using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web_API_BancoGeeks.Context;
using Web_API_BancoGeeks.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web_API_BancoGeeks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FibonacciController : ControllerBase
    {

        private readonly AppDbContext context;

        public FibonacciController(AppDbContext context)
        {
            this.context = context;

        }


        // GET: api/<FibonacciController>
        [HttpGet]
        public IEnumerable<Fibonacci> Get()
        {
            return context.Fibonacci.ToList();
        }

        // GET api/<FibonacciController>/5
        [HttpGet("{id}")]
        public Fibonacci Get(int id)
        {
            var fibonacci = context.Fibonacci.FirstOrDefault(p => p.id == id);
            return fibonacci;
        }

        // POST api/<FibonacciController>
        [HttpPost]
        public ActionResult Post([FromBody] Fibonacci fibonacci)
        {
            try
            {
                context.Fibonacci.Add(fibonacci);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }


        }

        // PUT api/<FibonacciController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Fibonacci fibonacci)
        {
            if (fibonacci.id == id)
            {
                context.Entry(fibonacci).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }

        }

        // DELETE api/<FibonacciController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
