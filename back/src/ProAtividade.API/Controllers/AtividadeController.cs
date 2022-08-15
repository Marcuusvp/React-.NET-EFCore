using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProAtividade.API.models;

namespace ProAtividade.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AtividadeController : ControllerBase
    {
        [HttpGet]
        public Atividade get()
        {
            return new Atividade();
        }

        [HttpGet("{id}")]
        public string get(int id)
        {
            return "Olá";
        }

         [HttpPost]
        public string post()
        {
            return "Olá";
        }

         [HttpPut("{id}")]
        public string Put(int id)
        {
            return "Olá";
        }

         [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "Olá";
        }
    }
}