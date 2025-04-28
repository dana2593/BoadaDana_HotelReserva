using BoadaDana_HotelReserva.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BoadaDana_HotelReserva.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<PlanRecompensa> PlanesRecompensa { get; set; }
    }
}
