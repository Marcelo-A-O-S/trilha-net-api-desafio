using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Api.Repositories.Interfaces
{
    public interface IGenerics<T> where T : class
    {
        Task Salvar(T entidade);
        Task Atualizar(T entidade);
        Task Deletar(T entidade);
        Task DeletarPorId(int Id);
        Task<T> BuscarPorId(int Id);
        Task<T> BuscarPor(Expression<Func<T, bool>> predicate);
        Task<List<T>> Listar();
        Task<List<T>> Listar(int? pagina);

    }
}