using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SeguroMundial3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeguroMundial3.Controllers
{
    [ApiController]
    [Route("api/Historial")]
    public class HistorialController : Controller
    {

        private readonly AplicationDbContext Db;


        public HistorialController(AplicationDbContext Db)
        {
            this.Db = Db;


        }

        [HttpGet]

        public async Task<ActionResult<List<Historial>>> Get()
        {
            return await Db.Historials.ToListAsync();




        }

        [HttpGet("primero")]

        public ActionResult<Historial> GetPrimerAutor()

        {

            return Db.Historials.FirstOrDefault();
        }



        [HttpGet("{id}", Name = "GetHistorial")]
        public async Task<ActionResult<Historial>> GetAction(int id)
        {
            var company = await Db.Historials.FirstOrDefaultAsync(x => x.Id == id);

            if (company == null)
            {
                return NotFound();
            }



            return company;

        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Historial Historial)

        {



            Db.Historials.Add(Historial);
            await Db.SaveChangesAsync();

            return new CreatedAtRouteResult("GetHistorial", new { id = Historial.Id, Historial });



        }

       
    }
}
