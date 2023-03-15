using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaAyu.Models
{
    [Table("TipoAnexo")]
    public class TipoAnexo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
