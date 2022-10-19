using Dados.Contexto;
using Dados.Repositorio;
using Dominio.Contratos.Repositorio;
using Dominio.Contratos.Servico;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico.Utilitarios
{
    public class IoC
    {
        public static void RegistrarServicos(IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<Contexto>(options => {
                options.UseSqlServer(Configuration.GetConnectionString("ApoioFolhaConnection"));
            });

            //services.AddScoped<StoreDataContext, StoreDataContext>();
            services.AddTransient<IEmpresaServico, EmpresaServico>();
            services.AddTransient<IEmpresaRepositorio, EmpresaRepositorio>();
        }
    }
}
