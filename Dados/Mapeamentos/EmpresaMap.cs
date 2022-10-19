using Dados.Extensions;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dados.Mapeamentos
{
    public class EmpresaMap : IEntityMappingConfiguration<Empresa>
    {
        public void Map(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("Empresa");
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).HasColumnName("Id");
            builder.Property(m => m.Nome).IsRequired().HasMaxLength(64);           
        }
    }
}
