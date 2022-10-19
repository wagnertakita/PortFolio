using BundleTransformer.Core.Configuration;
using Dados.Extensions;
using Dados.Mapeamentos;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Dados.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
         : base(options)
        {
            //Configuration.LazyLoadingEnabled = false;
            //Configuration.ProxyCreationEnabled = false;
        }

        #region Propriedades do Sistema
        public DbSet<Empresa> Empresa { get; set; }


        #endregion Propriedades do Sistema

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureDefault(modelBuilder);
            ConfigureMaps(modelBuilder);
        }

        private static void ConfigureDefault(ModelBuilder modelBuilder)
        {
            //modelBuilder.RemovePluralizingTableNameConvention();
            //modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }

        private static void ConfigureMaps(ModelBuilder modelBuilder)
        {
            modelBuilder.RegisterEntityMapping<Empresa, EmpresaMap>();

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["FolhaConnection"].ConnectionString);
        }
         
        public int Salvar()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbUpdateException due) ///<summary>Quando algum erro diferente foi apresentado e for possivel ser trantado incluir a tratativa</summary>
            {
                //armazena a mensagem de erro e as mensagens das duas exceptions interiores
                string mensagens = due.Message + " "
                    + due.InnerException?.Message + " "
                    + due.InnerException?.InnerException?.Message;

                throw;
            }
            catch (InvalidOperationException ioe)
            {

                throw;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public Task<int> SalvarAsync()
        {
            try
            {
                return base.SaveChangesAsync();
            }
            catch (DbUpdateException due) ///<summary>Quando algum erro diferente foi apresentado e for possivel ser trantado incluir a tratativa</summary>
            {
                //armazena a mensagem de erro e as mensagens das duas exceptions interiores
                string mensagens = due.Message + " "
                    + due.InnerException?.Message + " "
                    + due.InnerException?.InnerException?.Message;

                throw;
            }
            catch (InvalidOperationException ioe)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
