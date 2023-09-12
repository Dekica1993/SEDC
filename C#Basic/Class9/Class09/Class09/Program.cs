#region Initial linq
using Class09;

Console.WriteLine("------------------ Initial list-------------");
List<int> numbers = new List<int>() { 1,2,3,4,5};
numbers.ForEach(numn =>Console.WriteLine(numn));

Console.WriteLine("------------------ Select-------------");
List<int> addOneToNumbers = numbers
                             //.Select((num, Index) => num + 1);
                             .Select(num => num + 1)
                             .ToList();

foreach (int item in addOneToNumbers)
{
    Console.WriteLine(item);
}
addOneToNumbers.ForEach(num =>Console.WriteLine(num));
Console.WriteLine("------------------ Where-------------");
var greaterThenThree = numbers
                              .Where(num => num >= 3)
                              .ToList();
greaterThenThree.ForEach(num =>Console.WriteLine(num));

Console.WriteLine("------------------ First-------------");
int firstElement = numbers
                          .First();
Console.WriteLine(firstElement);

Console.WriteLine("------------------ First-------------");
int lastElement = numbers
                         .Last();
Console.WriteLine(lastElement);
#endregion

#region Chained Linq

List<Dog> dogs = new List<Dog>
{
    new Dog{Name = "Charlie", Age = 2},
    new Dog { Name ="Burch", Age= 1},
    new Dog { Name ="Sia", Age = 2},
    new Dog { Name ="William", Age = 4},
    new Dog { Name ="Pongo", Age = 2},
    new Dog { Name ="Billy", Age = 1},
    new Dog { Name ="Buck", Age = 4},
};

var nameLongerThen3 = dogs
                          .Where(x => x.Name.Length > 3)
                          .ToList();

nameLongerThen3.ForEach(x =>Console.WriteLine(x.Name));

var firstDogOlderThen3 = dogs
//                             .Where((x) => x.Age > 3)
//                             .FirstOrDefault();
                               .FirstOrDefault(x => x.Age > 3);
Console.WriteLine(firstDogOlderThen3.Name);



#endregion