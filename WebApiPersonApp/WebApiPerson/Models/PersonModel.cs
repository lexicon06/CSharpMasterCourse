namespace WebApiPerson.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required int Age { get; set; }
    }
}
