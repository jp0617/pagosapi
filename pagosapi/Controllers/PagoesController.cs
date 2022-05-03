using Microsoft.AspNetCore.Mvc;
using pagosapi.Data;
using pagosapi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pagosapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagoesController : ControllerBase
    {
        private dbapi _dbapi;
        public PagoesController(dbapi dbapi)
        {
            _dbapi = dbapi;
        }
        // GET: api/<PagoesController>
        [HttpGet]
        public IQueryable<pago> Get()
        {
            return _dbapi.pago;
        }

        // GET api/<PagoesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PagoesController>
        [HttpPost]
        public ActionResult Post(pago pago)
        {
            logistica log = new logistica();
            _dbapi.pago.Add(pago);
            _dbapi.SaveChanges();
            log.id_pago = pago.id;
            _dbapi.logistica.Add(log);
            _dbapi.SaveChanges();
            return Ok("Pago registrado");
        }

        // PUT api/<PagoesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PagoesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
