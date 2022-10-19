using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Contratos.Repositorio
{
    public interface IEmpresaRepositorio
    {
        Empresa ObterPorId(int id);
    }
}
