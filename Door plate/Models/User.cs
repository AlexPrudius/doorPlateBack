namespace Door_plate.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Goals { get; set; }
        public DateTime Date { get; set; }
        public Boolean Deleted { get; set; }
    }
}
