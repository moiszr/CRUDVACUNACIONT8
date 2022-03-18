using System.ComponentModel.DataAnnotations;


namespace CRUDVACUNACIONT8.Data
{
    public class VacunasRecibidas
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(30), Required]
        public string? Dosis { get; set; }

        [MaxLength(30), Required]
        public string? NombreVacuna { get; set; }
    }
}
