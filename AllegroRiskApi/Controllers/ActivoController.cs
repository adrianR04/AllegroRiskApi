using System.Collections.Generic;
using AllegroRiskApi.Model;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace AllegroRiskApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivoController : ControllerBase
    {
        private Context context;
        public ActivoController() {
            context = new Context();
        }
        // GET: api/Activo
        [HttpGet]
        public IEnumerable<Activo> Get()
        {
            var activos = context.Activo.Find(_ => true).ToList();
            return activos;
        }

        // GET: api/Activo/5
        [HttpGet("{id}", Name = "Get")]
        public IEnumerable<Activo> Get(string id)
        {
            return context.Activo.Find(x => x.id == id).ToList();
        }

        // POST: api/Activo
        [HttpPost]
        public void Post([FromBody] Activo value)
        {
            context.Activo.InsertOne(value);
        }

        // PUT: api/Activo/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
