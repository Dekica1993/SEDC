using Classes.Models;
//constructor -> new
Person personPaul = new Person();
Console.WriteLine(personPaul.FirstName);
personPaul.Age = 20;
Console.WriteLine(personPaul.Age);

//set
personPaul.FirstName = "Paul";
Console.WriteLine(personPaul.FirstName);
//set
personPaul.LastName = "Fischer";
//personPaul.GetDescription();
string description = personPaul.GetDescription();
Console.WriteLine(description);
//constructor with parameters
Person bob = new Person("Bob", "Peterson", 25);
Console.WriteLine(bob.FirstName);
bob.FirstName = "Gil";//get
Console.WriteLine($"Description fot Bob {bob.GetDescription()}"); // set

Product car =new Product();
car.Name = "Honda";
car.Price = 455566.8;
car.Code = 123;

Product pizza = new Product()
{
    Code = 354,
    Price = 300,
    Name = "Margarita"

};
pizza.Buy(200);