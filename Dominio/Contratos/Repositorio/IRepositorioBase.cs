using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Contratos.Repositorio
{
    public interface IRepositorioBase<T>
    {
        void Inserir(T entity);
        void Alterar(T entity);
        void Excluir(T entity);
        T ObterPorId(int id);
        IQueryable<T> Selecionar(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
        IQueryable<T> SelecionarTodos(params Expression<Func<T, object>>[] includes);
        int Salvar();

        //Os Metodos async deverão ser implementado de acordo com sua necessidade de utilização de processos paralelos
        Task<bool> InserirAsync(T entidade);
        Task<bool> AlterarAsync(T entity);
        Task<bool> ExcluirAsync(T entity);
        Task<T> ObterPorIdAsync(int id);
        Task<int> SalvarAsync();
    }
}
