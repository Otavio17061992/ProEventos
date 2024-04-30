using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.APIv5.Models;

namespace ProEventos.APIv5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<EventoController> _logger;
        public  IEnumerable<Eventos> _eventos = new Eventos[]
        {
                new Eventos(){
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "São Paulo",
                Lote = "1 Lote",
                QtdPessoas = 258,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "Foto.png"
            },
                new Eventos(){
                EventoId = 2,
                Tema = "Angular e suas novidades",
                Local = "São Paulo",
                Lote = "1 Lote",
                QtdPessoas = 238,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "AltereiFoto.png"
            }
        };
        
        public EventoController()
        {
           
        }

        // retorna todos os eventos
        [HttpGet]
        public IEnumerable<Eventos> Get()
        {
            return _eventos;
        }

        // retorna evento com base no ID
        [HttpGet("{id}")]
        public IEnumerable<Eventos> Get(int id)
        {
            return _eventos.Where(e => e.EventoId == id);
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
}
