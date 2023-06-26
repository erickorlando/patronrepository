using System.ComponentModel.DataAnnotations;

namespace PatronRepositorio.Entities
{
    public class Cliente
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Nombres { get; set; } = null!;
        
        [StringLength(100)]
        public string Apellidos { get; set; } = null!;
        
        [StringLength(500)]
        public string CorreoElectronico { get; set; } = null!;
    }
}