using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APITESTE2.Context;
using APITESTE2.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APITESTE2.Controllers
{
    [ApiController]
    [Route("[controller])")]
    public class VendaController : ControllerBase
    {
        private readonly VendaContext _context;

        public VendaController(VendaContext context)
        {
            _context = context;
        }

        [HttpPost("Cadastrar vendedor")]
        public IActionResult AddVendedor(Vendedor vendedor)
        {
            _context.Add(vendedor);
            _context.SaveChanges();
            return Ok(vendedor);
        }

        [HttpPost("Cadastro de venda")]
        public IActionResult AddVenda(Venda venda)
        {
            _context.Add(venda);
            _context.SaveChanges();
            return Ok(venda);
        }

        [HttpGet("Obter venda")]
        public IActionResult ObterPorId(int id)
        {
            var venda = _context.Vendas.Find(id);
            if(venda == null) return NotFound();

            return Ok(venda);
        }

        [HttpPut("Atualização de venda")]
        public IActionResult Atualizar(int id, Venda venda)
        {
            var vendasBanco = _context.Vendas.Find(id);

            if (vendasBanco == null)
                return NotFound();

            vendasBanco.ItemVendido = venda.ItemVendido;
            vendasBanco.IdVendedor = venda.IdVendedor;
            vendasBanco.Data = venda.Data;
            vendasBanco.Status = venda.Status;

            _context.Vendas.Update(vendasBanco);
            _context.SaveChanges();

            return Ok(vendasBanco);
        }

    }
}