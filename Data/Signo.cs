namespace CRUDVACUNACIONT8.Data
{
    public class Signo
    {
        public int Id { get; set; }
        public string? Cedula { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdProvincia { get; set; }
        public Provincias? Provincias { get; set; }
        public int IdVacuna { get; set; }
        public VacunasRecibidas? VacunasRecibidas { get; set; }
        public DateTime Fecha { get; set; }
    }
}
