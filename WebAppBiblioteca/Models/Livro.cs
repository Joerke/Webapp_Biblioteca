using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppBiblioteca.Models
{
    public class Livro
    {
        public int LivroId { get; set; }
        public int CategoriaId { get; set; }
        public string Isbn { get; set; }
        public string Titulo { get; set; }
        public Decimal Preco { get; set; }
        public DateTime DataPublicao { get; set; }
        public string NumeroExemplares { get; set; }

    }
}