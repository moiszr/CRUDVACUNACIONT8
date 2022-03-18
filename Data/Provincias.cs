using System.ComponentModel.DataAnnotations;

namespace CRUDVACUNACIONT8.Data
{
    public class Provincias
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(70), Required]
        public string? Provincia { get; set; }
    }
}
