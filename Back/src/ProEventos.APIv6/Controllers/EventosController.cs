using Microsoft.AspNetCore.Mvc;

namespace ProEventos.APIv6.Controllers;

[ApiController]
[Route("[api/controller]")]
public class EventosController : ControllerBase
{
 private readonly DataContext _context;
        
        public EventosController(DataContext context)
        {
            this._context = context;
           
        }

        // retorna todos os eventos
        [HttpGet]
        public IEnumerable<Eventos> Get()
        {
            return _context.Eventos;
        }

        // retorna evento com base no ID
        [HttpGet("{id}")]
        public Eventos Get(int id)
        {
            return  _context.Eventos.FirstOrDefault(e => e.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
           return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id )
        {
           return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id )
        {
           return $"Exemplo de Delete com id = {id}";
        }
}
