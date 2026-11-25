public class Person
{
    public int Id {get; set; }
    public string FirstName {get; set; }=null!;
    public string LastName {get; set; }=null!;
    public int Age {get; set; }
    public GenderEnum Gender {get; set; }
    public StatusEnum Status {get; set; }

}