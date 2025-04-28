namespace BoadaDana_HotelReserva.Models
{
    using System.ComponentModel.DataAnnotations;

    public class PlanRecompensa
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaInicio { get; set; }

        public int PuntosAcumulados { get; set; }

        [Required]
        public string TipoRecompensa
        {
            get
            {
                return PuntosAcumulados >= 500 ? "GOLD" : "SILVER";
            }
        }
    }

}
