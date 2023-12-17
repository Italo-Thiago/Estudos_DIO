using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entities;

namespace ModuloAPI.Context
{
  public class AgendaContext : DbContext
  {
    // Usa o método DbContextOptions do objeto "AgendaContext", passando como parâmetro options, que herda as options da classe DbContext
    public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
    {

    }
    // Instância a Entidade "Contato" usando o método DbSet do objeto "Contato"
    public DbSet<Contato> Contatos { get; set; }
  }
}