using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDVACUNACIONT8.Data
{
    public class Personas
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(11), Required]
        public string? Cedula { get; set; }

        [MaxLength(70), Required]
        public string? Nombre { get; set; }

        [MaxLength(70), Required]
        public string? Apellido { get; set; }

        [MaxLength(10)]
        public string? Telefono { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        [ForeignKey("Provincias"), Required]
        public int IdProvincia { get; set; }
        public Provincias? Provincias { get; set; }

        [ForeignKey("VacunasRecibidas"), Required]
        public int IdVacuna { get; set; }
        public VacunasRecibidas? VacunasRecibidas { get; set; }

        [Required]
        public DateTime Fecha { get; set; }
    }
}
