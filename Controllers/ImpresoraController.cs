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
    [Route("api/Impresora")]
    public class ImpresoraController : Controller
    {

        private readonly AplicationDbContext Db;


        public ImpresoraController(AplicationDbContext Db)
        {
            this.Db = Db;


        }

        [HttpGet]

        public async Task<ActionResult<List<Impresora>>> Get()
        {

            //return await Db.Impresoras.Include(x => x.Id_tipo).ToList();
            return await Db.Impresoras.ToListAsync();




        }

        [HttpGet("primero")]

        public ActionResult<Impresora> GetPrimerAutor()

        {

            return Db.Impresoras.FirstOrDefault();
        }



        [HttpGet("{id}", Name = "GetImpresora")]
        public async Task<ActionResult<Impresora>> GetAction(int id)
        {
            var company = await Db.Impresoras.FirstOrDefaultAsync(x => x.Id == id);

            if (company == null)
            {
                return NotFound();
            }



            return company;

        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Impresora Impresora)

        {



            Db.Impresoras.Add(Impresora);
            await Db.SaveChangesAsync();

            return new CreatedAtRouteResult("GetImpresora", new { id = Impresora.Id, Impresora });



        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Impresora UpdateImpresora)
        {


            if (UpdateImpresora.Id != id)
            {
                return BadRequest("no corresponde el id");
            }




            Db.Update(UpdateImpresora);
            await Db.SaveChangesAsync();
            return Ok();


        }
    }

}
