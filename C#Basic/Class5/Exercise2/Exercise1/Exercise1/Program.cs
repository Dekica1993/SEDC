using Domain.Classes;
using Domain.Enums;

Employee employee = new Employee()
{
    FirstName = "Ed",
    LastName = "Sheeran",
    Role = RoleEnum.Menager
};
Console.WriteLine(employee.GetInfo());

int enumToInt = (int)employee.Role;
Console.WriteLine(enumToInt);

SalesPerson salesPerson = new SalesPerson("Zara", "Larson");
salesPerson.AddSuccessRevenue(400);
Console.WriteLine(salesPerson.GetSalary());

Menager menager = new Menager("Tom", "Cruise", 1200);
Console.WriteLine(menager.GetSalary());
menager.AddBonus(250);
Console.WriteLine(menager.GetSalary());


