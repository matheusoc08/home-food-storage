using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Controle_de_estoque.src.Context;
using Controle_de_estoque.src.Models;
using Microsoft.AspNetCore.Mvc;


namespace Controle_de_estoque.src.Controllers
{

    [ApiController]
    [Route("estoque")]
    public class EstoqueController : ControllerBase
    {

        private readonly EstoqueContext _context;

        public EstoqueController(EstoqueContext context)
        {
            _context = context;
        }

        [HttpGet("buscarTodos")]
        public ActionResult<List<EstoqueModel>> buscarTodos()
        {
            List<EstoqueModel> estoque = _context.Estoque.ToList();

            // List<EstoqueModel> estoque = new List<EstoqueModel>();
            // estoque.Add(new EstoqueModel { Id = 1, Nome = "Teste", Descricao = "Teste", Peso = 1.0, Quantidade = 1, Preco = 1.0 });

            return Ok(estoque);
        }

        [HttpGet("buscarItem/{id}")]
        public ActionResult<EstoqueModel> buscarItem(int id)
        {
            EstoqueModel item = _context.Estoque.Find(id);

            if (item == null)
            {
                return NotFound("Item não localizado pelo id informado.");
            }

            return Ok(item);
        }


        [HttpPost("incluir")]
        public ActionResult<EstoqueModel> incluirItem(EstoqueModel item)
        {
            _context.Estoque.Add(item);
            _context.SaveChanges();
            return Created("", item);

        }

        [HttpPut("editar/{id}")]
        public ActionResult<EstoqueModel> editarItem(int id, EstoqueModel item)
        {
            EstoqueModel itemBanco = _context.Estoque.Find(id);

            if (itemBanco == null)
            {
                return NotFound("Item não localizado pelo id informado.");
            }

            itemBanco.Nome = item.Nome;
            itemBanco.Descricao = item.Descricao;
            itemBanco.Peso = item.Peso;
            itemBanco.Quantidade = item.Quantidade;
            itemBanco.Preco = item.Preco;

            _context.Estoque.Update(itemBanco);
            _context.SaveChanges();
            return Ok(item);
        }

        [HttpDelete("deletar/{id}")]
        public ActionResult deletarItem(int id)
        {
            EstoqueModel itemBanco = _context.Estoque.Find(id);

            if (itemBanco == null)
            {
                return NotFound("Item não localizado pelo id informado.");
            }

            _context.Estoque.Remove(itemBanco);
            _context.SaveChanges();
            return Ok("Item removido!");
        }
    }
}