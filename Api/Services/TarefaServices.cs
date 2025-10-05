using System.Linq.Expressions;
using Api.Repositories.Interfaces;
using Api.Services.Interfaces;
using TrilhaApiDesafio.Models;

namespace Api.Services
{
    public class TarefaServices : ITarefaServices
    {
        public readonly ITarefaRepository tarefaRepository;
        public TarefaServices(ITarefaRepository _tarefaRepository)
        {
            this.tarefaRepository = _tarefaRepository;
        }
        public async Task Atualizar(Tarefa entidade)
        {
            await this.tarefaRepository.Atualizar(entidade);
        }

        public async Task<Tarefa> BuscarPor(Expression<Func<Tarefa, bool>> predicate)
        {
            return await this.tarefaRepository.BuscarPor(predicate);
        }

        public async Task<Tarefa> BuscarPorId(int Id)
        {
            return await this.tarefaRepository.BuscarPorId(Id);
        }

        public async Task Deletar(Tarefa entidade)
        {
            await this.tarefaRepository.Deletar(entidade);
        }

        public async Task DeletarPorId(int Id)
        {
            await this.tarefaRepository.DeletarPorId(Id);
        }

        public async Task<List<Tarefa>> Listar()
        {
            return await this.tarefaRepository.Listar();
        }

        public async Task<List<Tarefa>> Listar(int? pagina)
        {
            return await this.tarefaRepository.Listar(pagina);
        }

        public async Task<Tarefa> ObterPorData(DateTime date)
        {
            return await this.tarefaRepository.ObterPorData(date);
        }

        public async Task<Tarefa> ObterPorStatus(EnumStatusTarefa status)
        {
            return await this.tarefaRepository.ObterPorStatus(status);
        }

        public async Task<Tarefa> ObterPorTitulo(string titulo)
        {
            return await this.tarefaRepository.ObterPorTitulo(titulo);
        }

        public async Task<List<Tarefa>> ObterTodosPorData(DateTime date)
        {
            return await this.tarefaRepository.ObterTodosPorData(date);
        }

        public async Task<List<Tarefa>> ObterTodosPorStatus(EnumStatusTarefa status)
        {
            return await this.tarefaRepository.ObterTodosPorStatus(status);
        }

        public async Task<List<Tarefa>> ObterTodosPorTitulo(string titulo)
        {
            return await this.tarefaRepository.ObterTodosPorTitulo(titulo);
        }

        public async Task Salvar(Tarefa entidade)
        {
            if (entidade.Id == 0)
            {
                await this.tarefaRepository.Salvar(entidade);
            }
            else
            {
                await this.tarefaRepository.Atualizar(entidade);
            }
        }
    }
}