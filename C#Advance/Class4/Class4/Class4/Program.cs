
using Class4.Entities;

GermanCar bmw = new GermanCar("bmw",FuelType.Petrol,"x5",DateTime.Now,180,350);
GermanCar.PrintMaxSpeed();


FrenchCar reno = new FrenchCar("reno", FuelType.Disel, "cactus", DateTime.Now, 100,true);
FrenchCar.PrintNavigation();
