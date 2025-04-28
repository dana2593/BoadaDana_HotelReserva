using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BoadaDana_HotelReserva.Models;

namespace BoadaDana_HotelReserva.Data
{
    public class BoadaDana_HotelReservaContext : DbContext
    {
        public BoadaDana_HotelReservaContext (DbContextOptions<BoadaDana_HotelReservaContext> options)
            : base(options)
        {
        }

        public DbSet<BoadaDana_HotelReserva.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<BoadaDana_HotelReserva.Models.PlanRecompensa> PlanRecompensa { get; set; } = default!;
        public DbSet<BoadaDana_HotelReserva.Models.Reserva> Reserva { get; set; } = default!;
    }
}
