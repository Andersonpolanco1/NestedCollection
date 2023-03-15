using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaAyu.Models
{
    [Table("Anexos")]
    public class Anexo
    {
        public int TipoId { get; set; }
        public IFormFile File { get; set; }
        public TipoAnexo? Tipo { get; set; }

    }
}
