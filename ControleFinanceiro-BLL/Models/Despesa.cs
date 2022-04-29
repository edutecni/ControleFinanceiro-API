using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro_BLL.Models
{
    public class Despesa
    {
        public int DespesaId { get; set; }
        public int CartaoId { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public int Dia { get; set; }
        public int MesId { get; set; }
        public int Ano { get; set; }
        public string UsuarioId { get; set; }

        public Cartao Cartao { get; set; }
        public int CategoriaId { get; set; }
        //Atributo Navegacional
        public Categoria Categoria { get; set; }
        public Mes Mes { get; set; }
        public Usuario Usuario { get; set; }
    }
}
