﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro_BLL.Models
{
    public class Tipo
    {
        public int TipoId { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Categoria> Categorias { get; set; }
    }
}
