using Class02.Entities;

Developer bojan = new Developer("Bojan Damcevski", 25, 123456789, new List<string> { "c#", "HTML", "CSS", "JavaScript" }, 1);

bojan.Greet("Vlade");
bojan.Code();
Console.WriteLine(bojan.GetInfo());
string infoBojan = bojan.GetInfo();
Console.WriteLine(infoBojan);


DevOps zare = new DevOps("Zarko Ilievski", 40, 545615156, true, true);
zare.Greet("Damjan");
Console.WriteLine(zare.CheckInfrastructure(200));
Console.WriteLine(zare.GetInfo());
zare.Code();