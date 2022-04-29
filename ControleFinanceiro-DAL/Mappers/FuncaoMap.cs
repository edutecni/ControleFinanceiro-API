using ControleFinanceiro_BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFinanceiro_DAL.Mappers
{
    public class FuncaoMap : IEntityTypeConfiguration<Funcao>
    {
        public void Configure(EntityTypeBuilder<Funcao> builder)
        {
            builder.Property(f => f.Id).ValueGeneratedOnAdd();
            builder.Property(f => f.Descricao).IsRequired().HasMaxLength(50);

            builder.HasData(
                    new Funcao
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Administrador",
                        NormalizedName = "ADMINISTRADOR",
                        Descricao = "Admnistrador do sistema"
                    },

                    new Funcao
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = "Usuario",
                        NormalizedName = "USUARIO",
                        Descricao = "Usuario do sistema"
                    }
                );

            builder.ToTable("Funcoes");
        }
    }
}
