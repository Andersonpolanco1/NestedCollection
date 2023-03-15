using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaAyu.Models
{
    [Table("Beneficios")]
    public class Beneficio
    {
        private IList<Anexo> _anexos = new List<Anexo>();


        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public double Price { get; set; }

        public IList<Anexo> Anexos

        {

            get { return _anexos;  }

            set { _anexos = value; }

        }
    }
}
