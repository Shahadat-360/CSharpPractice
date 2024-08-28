using ImportantInterface;

People people=new People(1);
people.Add(new Person() { Name = "Shahadat",Age=25 });
foreach(var person in people)
{
    Console.WriteLine(person.Name);
}