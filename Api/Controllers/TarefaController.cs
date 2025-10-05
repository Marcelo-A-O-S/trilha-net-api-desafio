using System.Threading.Tasks;
using Api.DTOs;
using Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using TrilhaApiDesafio.Context;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly ITarefaServices tarefaServices;

        public TarefaController(ITarefaServices _tarefaServices)
        {
            this.tarefaServices = _tarefaServices;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterPorId(int id)
        {
            // TODO: Buscar o Id no banco utilizando o EF
            var tarefa = await this.tarefaServices.BuscarPorId(id);
            // TODO: Validar o tipo de retorno. Se não encontrar a tarefa, retornar NotFound,
            if (tarefa == null)
                return NotFound();
            // caso contrário retornar OK com a tarefa encontrada
            return Ok(tarefa);
        }

        [HttpGet("ObterTodos")]
        public async Task<IActionResult> ObterTodos()
        {
            // TODO: Buscar todas as tarefas no banco utilizando o EF
            var tarefas = await this.tarefaServices.Listar();
            return Ok(tarefas);
        }
        [HttpGet("ObterTodosPorPaginacao")]
        public async Task<IActionResult> ObterTodos(int pagina)
        {
            var tarefas = await this.tarefaServices.Listar(pagina);
            return Ok(tarefas);
        }
        [HttpGet("ObterPorTitulo")]
        public async Task<IActionResult> ObterPorTitulo(string titulo)
        {
            // TODO: Buscar  as tarefas no banco utilizando o EF, que contenha o titulo recebido por parâmetro
            // Dica: Usar como exemplo o endpoint ObterPorData
            var tarefa = await this.tarefaServices.ObterPorTitulo(titulo);
            if(tarefa == null)
                return NotFound();
            
            return Ok(tarefa);
        }
        [HttpGet("ObterTodosPorTitulo")]
        public async Task<IActionResult> ObterTodosPorTitulo(string titulo)
        {
            var tarefas = await this.tarefaServices.ObterTodosPorTitulo(titulo);
            return Ok(tarefas);
        }
        [HttpGet("ObterPorData")]
        public async Task<IActionResult> ObterPorData(DateTime data)
        {
            var tarefa = await this.tarefaServices.ObterPorData(data);
            if (tarefa == null)
                return NotFound();
            return Ok(tarefa);
        }
        [HttpGet("ObterTodosPorData")]
        public async Task<IActionResult> ObterTodosPorData(DateTime data)
        {
            var tarefas = await this.tarefaServices.ObterTodosPorData(data);
            return Ok(tarefas);
        }
        [HttpGet("ObterPorStatus")]
        public async Task<IActionResult> ObterPorStatus(EnumStatusTarefa status)
        {
            // TODO: Buscar  as tarefas no banco utilizando o EF, que contenha o status recebido por parâmetro
            // Dica: Usar como exemplo o endpoint ObterPorData
            var tarefa = await this.tarefaServices.ObterPorStatus(status);
            if(tarefa == null)
                return NotFound();
            
            return Ok(tarefa);
        }
        [HttpGet("ObterTodosPorStatus")]
        public async Task<IActionResult> ObterTodosPorStatus(EnumStatusTarefa status)
        {
            var tarefas = await this.tarefaServices.ObterTodosPorStatus(status);
            return Ok(tarefas);
        }
        [HttpPost]
        public async Task<IActionResult> Criar(TarefaDTO tarefa)
        {
            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });
            var tarefaBanco = new Tarefa();
            tarefaBanco.Id = 0;
            tarefaBanco.Data = tarefa.Data;
            tarefaBanco.Descricao = tarefa.Descricao;
            tarefaBanco.Status = tarefa.Status;
            tarefaBanco.Titulo = tarefa.Titulo;
            // TODO: Adicionar a tarefa recebida no EF e salvar as mudanças (save changes)
            await this.tarefaServices.Salvar(tarefaBanco);
            return CreatedAtAction(nameof(ObterPorId), new { id = tarefaBanco.Id }, tarefaBanco);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Atualizar(int id, TarefaDTO tarefa)
        {
            var tarefaBanco = await tarefaServices.BuscarPorId(id);

            if (tarefaBanco == null)
                return NotFound();

            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });

            // TODO: Atualizar as informações da variável tarefaBanco com a tarefa recebida via parâmetro
            tarefaBanco.Data = tarefa.Data;
            tarefaBanco.Descricao = tarefa.Descricao;
            tarefaBanco.Status = tarefa.Status;
            tarefaBanco.Titulo = tarefa.Titulo;
            // TODO: Atualizar a variável tarefaBanco no EF e salvar as mudanças (save changes)
            await this.tarefaServices.Atualizar(tarefaBanco);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletar(int id)
        {
            var tarefaBanco = await tarefaServices.BuscarPorId(id);

            if (tarefaBanco == null)
                return NotFound();
            await tarefaServices.Deletar(tarefaBanco);
            return NoContent();
        }
    }
}
