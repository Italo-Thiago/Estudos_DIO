using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace ModuloAPI.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class UsuarioController : ControllerBase
  {
    [HttpGet("ObterDAtaHoraAtual")]
    public IActionResult ObterDataHora()
    {
      var obj = new
      {
        Data = DateTime.Now.ToLongDateString(),
        Hora = DateTime.Now.ToShortTimeString()
      };
      return Ok(obj);
    }

    [HttpGet("Apresentar/{nome}")]
    public IActionResult Apresentar(string nome)
    {
      var mensagem = $"Olá {nome}, seja bem vindo";
      return Ok(new { mensagem });
    }
  }
}