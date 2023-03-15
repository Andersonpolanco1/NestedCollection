namespace PruebaAyu.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
