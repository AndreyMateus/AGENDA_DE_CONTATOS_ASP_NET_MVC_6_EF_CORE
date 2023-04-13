using Agenda.Models;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Database;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base( options)
    {
    }

    public DbSet<Contato> Contatos { get; set; }
}