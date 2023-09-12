// See https://aka.ms/new-console-template for more information







using Exercise1;

Human inputHuman = new Human();
Console.WriteLine("Enter The First name");
inputHuman.FirstName = Console.ReadLine();
Console.WriteLine("Enter the Last name");
inputHuman.LastName = Console.ReadLine();
Console.WriteLine("Input Age");
inputHuman.Age =Convert.ToInt32(Console.ReadLine());
Console.WriteLine(inputHuman.GetPersonStats());

