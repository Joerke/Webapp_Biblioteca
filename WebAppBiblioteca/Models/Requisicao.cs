using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppBiblioteca.Models
{
    public class Requisicao
    {
        public int RequisicaoId { get; set; }
        public int LivroId { get; set; }
        public int AlunoId { get; set; }
        public DateTime DataRequisicao { get; set; }
        public DateTime DataEntrega { get; set; }

    }
}