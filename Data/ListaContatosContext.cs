using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ListaContatos.Models;

namespace ListaContatos.Data
{
    public class ListaContatosContext : DbContext
    {
        public ListaContatosContext (DbContextOptions<ListaContatosContext> options)
            : base(options)
        {
            // Recria o banco sempre que inicializado
            Database.EnsureCreated();

        }

        public DbSet<ListaContatos.Models.Contatos> Contatos { get; set; }
    }
}
