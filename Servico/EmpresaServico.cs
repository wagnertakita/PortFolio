using Dominio.Contratos.Repositorio;
using Dominio.Contratos.Servico;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Servico
{
    public class EmpresaServico : IEmpresaServico
    {
        private readonly IEmpresaRepositorio _empresaRepositorio;

        public EmpresaServico(IEmpresaRepositorio empresaRepositorio)
        {
            _empresaRepositorio = empresaRepositorio;
        }

        public IList<Empresa> Listar()
        {
            throw new NotImplementedException();
        }

        public Empresa ObterPorId(int id, [FromServices] IEmpresaRepositorio _empresaRepositorio2)
        {
            return _empresaRepositorio2.ObterPorId(id);
        }

    }
}
