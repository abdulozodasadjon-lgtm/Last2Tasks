List<Person> people = new List<Person>
{
    new Person
    {
        Id = 1,
        FirstName = "Saad",
        LastName = "Abdullozoda",
        Age = 13,
        Gender = GenderEnum.Male,
        Status = StatusEnum.Active
    },
    new Person
    {
        Id = 2,
        FirstName = "Ali",
        LastName = "Rahimov",
        Age = 14,
        Gender = GenderEnum.Male,
        Status = StatusEnum.Active
    },
    new Person
    {
        Id = 3,
        FirstName = "Madina",
        LastName = "Sharipova",
        Age = 15,
        Gender = GenderEnum.Female,
        Status = StatusEnum.InActive
    },
    new Person
    {
        Id = 4,
        FirstName = "Hikmatullo",
        LastName = "Rahmatulloev",
        Age = 17,
        Gender = GenderEnum.Male,
        Status = StatusEnum.Active
    },
    new Person
    {
        Id = 5,
        FirstName = "Fatima",
        LastName = "Karimova",
        Age = 16,
        Gender = GenderEnum.Female,
        Status = StatusEnum.Active
    },
    new Person
    {
        Id = 6,
        FirstName = "Muhammad",
        LastName = "Saidov",
        Age = 18,
        Gender = GenderEnum.Male,
        Status = StatusEnum.InActive
    },
    new Person
    {
        Id = 7,
        FirstName = "Zarina",
        LastName = "Nazarova",
        Age = 14,
        Gender = GenderEnum.Female,
        Status = StatusEnum.Active
    },
    new Person
    {
        Id = 8,
        FirstName = "Islom",
        LastName = "Davlatov",
        Age = 43,
        Gender = GenderEnum.Male,
        Status = StatusEnum.Active
    },
    new Person
    {
        Id = 9,
        FirstName = "Malika",
        LastName = "Usmonova",
        Age = 56,
        Gender = GenderEnum.Female,
        Status = StatusEnum.InActive
    },
    new Person
    {
        Id = 10,
        FirstName = "Amir",
        LastName = "Hassanov",
        Age = 15,
        Gender = GenderEnum.Male,
        Status = StatusEnum.Active
    }
};


// 1

// method syntax

// var names = people.Where(x=>x.Age>30).Select(x=>x.FirstName).ToList();

// query syntax

// var names = (from x in people where x.Age > 30 select x.FirstName).ToList();




// names.ForEach(x=>System.Console.WriteLine(x));



//                          2 

// var names = people
//     .GroupBy(s => s.Age)
//     .Select(g => new
//     {
//         Age = g.Key,
//         Count = g.Count()
//     });

// foreach (var item in names)
// {
//     Console.WriteLine($"Age: {item.Age}, Count: {item.Count}");
// }



//                          3


var names = people.OrderBy(x=>x.Age).ToList();


Console.WriteLine("-----------= _ORDERING BY AGE_ =-----------\n\n\n\n");
names.ForEach(x=>Console.WriteLine($"Name: {x.LastName} {x.FirstName}"));
System.Console.WriteLine($"__________________________________________________");
