using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIIntroducao.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIIntroducao.Controllers
{
    [Route("api/Categoria/{CategoriaId}/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly AppDbContext context;

        public ProdutoController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Produto> Get(int categoriaId)
        {
            return context.Produto.ToList().Where(x => x.CategoriaId == categoriaId);
        }
    }
}