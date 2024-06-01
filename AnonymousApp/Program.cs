// See https://aka.ms/new-console-template for more information
using AnonymousApp;

Console.WriteLine("Hello, World!");

var person = new { name="vivek",age =25};
Console.WriteLine(person.GetType().FullName);

Account acct = new Account(5000);
Console.WriteLine(acct.addition(5, 6));
var cities = new List<(string Name, int Population)>
        {
            ("Mumbai", 12442373),
            ("Delhi", 11034555),
            ("Bangalore", 8443675),
            ("Hyderabad", 6731790),
            ("Ahmedabad", 5570585),
            ("Chennai", 4681087),
            ("Kolkata", 4486679),
            ("Surat", 4467797),
            ("Pune", 3124458),
            ("Jaipur", 3073350)
            // Add more cities as needed
        };
foreach (var city in cities)
{
    Console.WriteLine($"{city.Name}: {city.Population:NO}");
}