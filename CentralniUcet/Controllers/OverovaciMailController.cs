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
    public class OverovaciMailController : Controller
    {
        private readonly AppDbContext Context;

        public OverovaciMailController(AppDbContext context)
        {
            Context = context;
        }
    }
}
