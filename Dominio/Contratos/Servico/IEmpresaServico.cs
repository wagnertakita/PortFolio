using Dominio.Contratos.Repositorio;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Contratos.Servico
{
    public interface IEmpresaServico
    {
        Empresa ObterPorId(int id, [FromServices] IEmpresaRepositorio _empresaRepositorio2);
        IList<Empresa> Listar();
    }
}
