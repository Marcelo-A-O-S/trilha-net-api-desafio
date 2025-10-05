using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using TrilhaApiDesafio.Context;
using TrilhaApiDesafio.Models;

namespace Api.Repositories
{
    public class TarefaRepository : Generics<Tarefa>, ITarefaRepository
    {
        private readonly OrganizadorContext context;
        public TarefaRepository(OrganizadorContext _context) : base(_context)
        {
            this.context = _context;
        }

        public async Task<Tarefa> ObterPorData(DateTime date)
        {
            return await this.context.Tarefas.Where(t => t.Data.Date == date.Date).FirstOrDefaultAsync();
        }

        public async Task<Tarefa> ObterPorStatus(EnumStatusTarefa status)
        {
            return await this.context.Tarefas.Where(t => t.Status == status).FirstOrDefaultAsync();
        }

        public async Task<Tarefa> ObterPorTitulo(string titulo)
        {
            return await this.context.Tarefas.Where(t => t.Titulo.Contains(titulo)).FirstOrDefaultAsync();
        }

        public async Task<List<Tarefa>> ObterTodosPorData(DateTime date)
        {
            return await this.context.Tarefas.Where(t => t.Data == date).ToListAsync();
        }

        public async Task<List<Tarefa>> ObterTodosPorStatus(EnumStatusTarefa status)
        {
            return await this.context.Tarefas.Where(t => t.Status == status).ToListAsync();
        }

        public async Task<List<Tarefa>> ObterTodosPorTitulo(string titulo)
        {
            return await this.context.Tarefas.Where(t => t.Titulo.Contains(titulo)).ToListAsync();
        }
    }
}