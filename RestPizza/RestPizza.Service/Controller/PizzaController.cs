using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestPizza.Library;


namespace RestPizza.Service.Controllers
{
    [EnableCors("Restricted")]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class PizzaController : Controller
    {
        private static List<PizzaPie> _pies = new List<PizzaPie>();

        [EnableCors("Restricted")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_pies);
        }

        [HttpPost]
        public IActionResult Post([FromBody]PizzaPie pie)
        {
            try
            {
                _pies.Add(new PizzaPie(pie.Name));

                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}