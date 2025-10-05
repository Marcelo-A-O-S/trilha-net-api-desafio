using System.Linq.Expressions;
using Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using TrilhaApiDesafio.Context;

namespace Api.Repositories
{
    public class Generics<T> : IGenerics<T> where T : class
    {
        private readonly OrganizadorContext context;
        public Generics(OrganizadorContext _context)
        {
            this.context = _context;
        }
        public async Task Deletar(T entidade)
        {
            this.context.Set<T>().Remove(entidade);
            await this.context.SaveChangesAsync();
        }

        public async Task DeletarPorId(int Id)
        {
            var entidade = await this.context.Set<T>().FindAsync(Id);
            if (entidade != null)
            {
                this.context.Set<T>().Remove(entidade);
                await this.context.SaveChangesAsync();
            }
        }

        public async Task<T> BuscarPor(Expression<Func<T, bool>> predicate)
        {
            return await this.context.Set<T>().Where(predicate).FirstOrDefaultAsync();
        }

        public async Task<T> BuscarPorId(int Id)
        {
            return await this.context.Set<T>().FindAsync(Id);
        }

        public async Task<List<T>> Listar()
        {
            return await this.context.Set<T>().ToListAsync();
        }

        public async Task<List<T>> Listar(int? pagina)
        {
            var query = this.context.Set<T>().AsQueryable();
            int itensPorPagina = 10;
            if (pagina != null)
            {
                query = query.Skip(((int)pagina - 1) * itensPorPagina).Take(itensPorPagina);
            }
            return await query.ToListAsync();
        }

        public async Task Salvar(T entidade)
        {
            await this.context.Set<T>().AddAsync(entidade);
            await this.context.SaveChangesAsync();
        }

        public async Task Atualizar(T entidade)
        {
            this.context.Set<T>().Update(entidade);
            await this.context.SaveChangesAsync();

        }
    }
}