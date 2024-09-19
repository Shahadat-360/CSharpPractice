using Records;

Person person=new Person("Shahadat",25);
Person person2=new Person("Sakib",28);
Person person3 = new Person("Shahadat", 25);

person2 = person;
person2.Name = "Sakib";

Console.WriteLine(person.Name);
Console.WriteLine(person.Age);

person3.Name = "Sakib";
person3.Age = 25;

//Major difference reference not same still output showing same 
if (person == person3)
    Console.WriteLine("Same");
else
    Console.WriteLine("Not Same");