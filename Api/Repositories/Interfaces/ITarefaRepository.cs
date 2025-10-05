using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrilhaApiDesafio.Models;

namespace Api.Repositories.Interfaces
{
    public interface ITarefaRepository : IGenerics<Tarefa>
    {
        Task<Tarefa> ObterPorTitulo(string titulo);
        Task<Tarefa> ObterPorStatus(EnumStatusTarefa status);
        Task<Tarefa> ObterPorData(DateTime date);
        Task<List<Tarefa>> ObterTodosPorTitulo(string titulo);
        Task<List<Tarefa>> ObterTodosPorStatus(EnumStatusTarefa status);
        Task<List<Tarefa>> ObterTodosPorData(DateTime date);
    }
}