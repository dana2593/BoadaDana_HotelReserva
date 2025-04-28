namespace BoadaDana_HotelReserva.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Reserva
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime FechaEntrada { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime FechaSalida { get; set; }

        [Range(0, 99999.99)]
        public decimal ValorAPagar { get; set; }

        // FK
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }

}
