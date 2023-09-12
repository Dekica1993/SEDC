using Class6.Classes;

Animal animal = new Animal();
//Console.WriteLine(animal.id);
//Console.WriteLine(animal._privateProperty);

Dog jecky = new Dog();
Dog boby = new Dog("Boby", "Brown", "Labrador");
Console.WriteLine(boby.Name);
//Console.WriteLine(boby._privateProperty);  //private property
//Console.WriteLine(boby.id) 
boby.PrintId();
boby.PrintBasicInfo();
boby.Eat("MEAT");
boby.Eat();
Cat garfield = new Cat()
{
    Name = "Garfield",
    Color = "Orange",
    IsLazy = true,
};
garfield.PrintBasicInfo();






    


