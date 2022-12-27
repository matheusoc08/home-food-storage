using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Controle_de_estoque.src.Context;
using Controle_de_estoque.src.Models;
using Microsoft.AspNetCore.Mvc;

namespace Controle_de_estoque.Controllers
{
    [ApiController]
    [Route("lista")]
    public class ListaController : ControllerBase
    {

        private readonly EstoqueContext _context;

        public ListaController(EstoqueContext context)
        {
            _context = context;
        }

        [HttpPost("incluir")]
        public ActionResult<ListaModel> incluirItem(ListaModel item)
        {
            _context.Lista.Add(item);
            _context.SaveChanges();
            return CreatedAtAction(null, item);
        }

        [HttpGet("buscarTodos")]
        public ActionResult<List<ListaModel>> buscarTodos()
        {
            List<ListaModel> lista = _context.Lista.ToList();
            return Ok(lista);
        }

        [HttpGet("buscar/{id}")]
        public ActionResult<ListaModel> buscarItem(int id)
        {
            ListaModel item = _context.Lista.Find(id);

            if (item == null) return NotFound("Item não encontrado pelo id informado.");

            return Ok(item);
        }

        [HttpPut("editar/{id}")]
        public ActionResult<ListaModel> editarItem(int id, ListaModel item)
        {
            ListaModel itemBanco = _context.Lista.Find(id);

            if (itemBanco == null) return NotFound("Item não encontrado pelo id informado.");

            itemBanco.Nome = item.Nome;
            itemBanco.Descricao = item.Descricao;
            itemBanco.Peso = item.Peso;
            itemBanco.Quantidade = item.Quantidade;
            itemBanco.Preco = item.Preco;

            _context.Update(itemBanco);
            _context.SaveChanges();

            return Ok(itemBanco);
        }

        [HttpDelete("delete/{id}")]
        public ActionResult<ListaModel> deletarItem(int id)
        {
            ListaModel item = _context.Lista.Find(id);

            if (item == null) return NotFound("Item não encontrado pelo id informado.");
            _context.Lista.Remove(item);
            _context.SaveChanges();
            return Ok("Item removido!");
        }



    }
}