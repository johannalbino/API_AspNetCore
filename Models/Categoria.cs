using APIIntroducao.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIIntroducao
{
    public class Categoria
    {
        public Categoria()
        {
            Produto = new List<Produto>();
        }
        public int ID { get; set; }

        [StringLength(30)]
        public String Nome { get; set; }

        public List<Produto>Produto { get; set; }

    }
}
