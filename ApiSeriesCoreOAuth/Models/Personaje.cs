using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiSeriesCoreOAuth.Models
{
    [Table("Personajes")]
    public class Personaje
    {
        [Key]
        public int IdPersonaje { get; set; }

        public string Nombre { get; set; }

        public string Imagen { get; set; }

        public int IdSerie { get; set; }

        //public virtual Serie Serie { get; set; }
    }
}
