using CentralniUcet.Data;
using CentralniUcet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace CentralniUcet.Controllers
{
    [Route("Apl/[controller]")]
    [ApiController]
    public class AutentifikaceController : ControllerBase
    {
        private readonly AppDbContext Context;

        public AutentifikaceController(AppDbContext context)
        {
            Context = context;
        }

        [HttpGet("{veta}")]
        public async Task<ActionResult<Autentifikace>> GetAutentifikace(int veta)
        {
            var row = await Context.Autentifikace.FirstOrDefaultAsync(r => r.Veta == veta);
            if (row == null)
            {
                return NotFound();
            }

            return row;
        }
    }
}
