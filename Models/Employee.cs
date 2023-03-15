using System.ComponentModel.DataAnnotations;

namespace PruebaAyu.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public IEnumerable<Phone> Phones{ get; set; }
    }
}
