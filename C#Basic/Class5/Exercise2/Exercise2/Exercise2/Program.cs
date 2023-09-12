// See https://aka.ms/new-console-template for more information




using Exercise2;

Dog inputNumber = new Dog();
Console.WriteLine("Give a dog a name");
inputNumber.Name = Console.ReadLine();
Console.WriteLine("Choose ots color");
inputNumber.Color = Console.ReadLine();
Console.WriteLine("Which breed is it?");
inputNumber.Breed = Console.ReadLine();
inputNumber.Command();




