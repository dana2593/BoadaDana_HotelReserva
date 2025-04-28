namespace BoadaDana_HotelReserva.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(20, ErrorMessage = "Máximo 20 caracteres.")]
        public required string Nombre { get; set; }

        [Range(18, 100, ErrorMessage = "Edad debe ser entre 18 y 100.")]
        public int Edad { get; set; }

        [Range(0, 999999.99)]
        public decimal Saldo { get; set; }

        [Required]
        public bool EsVip { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime FechaRegistro { get; set; }

        // Relación
        public int PlanRecompensaId { get; set; }
        [ForeignKey("PlanRecompensaId")]
        public PlanRecompensa? PlanRecompensa { get; set; }
    }

}
