// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//int num = 1;
//char letter = 'a';
//bool falsey = false;

//float temp = 37.2f;
//double temp2 = 37.2d;
//decimal temp3 = 37.2m;

string name = "Dejan";


//int a1 = 5;
//int b1 = 10;
//int c1 = a1 + b1;
//Console.WriteLine(c1);

//c1 = c1 + 10;
//Console.WriteLine(c1);

//int d1 = 11;
//int d2 = 4;
//int res1 = d1 / d2;
//int res2 = d1 % d2;
//Console.WriteLine(res1);
//Console.WriteLine(res2);

//string emtystring = "";
//Console.WriteLine(emtystring.Length);

//Console.WriteLine("what is your name?");
//name = Console.ReadLine();

//Console.WriteLine("Hello, nice to meet you" + name );

//string numbString = "9";
//string doubleString = "2.5";

//int parseInt = int.Parse(numbString);
//double parseDouble = double.Parse(doubleString);

//Console.WriteLine(parseInt);
//Console.WriteLine(parseInt.GetType());

//int tryparseconvert;
//string exempletryparse = "12";
//bool successtryparse = int.TryParse(exempletryparse, out tryparseconvert);
//Console.WriteLine(successtryparse);


//if (5 > 3)
//{
//    Console.WriteLine("5 is bigger then 3");
//}

//else
//{
//    Console.WriteLine("5 is not bigger then 3");
//}

//Console.WriteLine("Please enter one number");
//var input1 = Convert.ToInt32(Console.ReadLine());

//if (input1 > 0)
//{
//    Console.WriteLine("You enter positive number");
//}
//if (input1 < 0)
//{
//    Console.WriteLine("You enter negative number");
//}

//else if (input1 == 0 )
//{
//    Console.WriteLine("you enter zero");
//}

//Console.WriteLine("Input the number");
//var trees = Convert.ToInt32(Console.ReadLine());
//int n = 8;
//int m = 5;
//int br = 12;
//int basketNeeded = (trees * (br * n)) / m;
//Console.WriteLine("For" + trees + "trees, you will need" + basketNeeded);

//Console.WriteLine("please enter number");
//var inputs1 = Convert.ToInt32(Console.ReadLine());
//var inputs2 = Convert.ToInt32(Console.ReadLine());

//if (inputs1 % 2 == 0)
//{
//    Console.WriteLine("The input1 is even");
//}
//else
//{
//    Console.WriteLine("in");
//}
//if(inputs2 % 2 == 0)
//{
//    Console.WriteLine("The input2 is odd");
//}
//else
//{
//    Console.WriteLine("wrong number");
//}

Console.WriteLine("Enter tree numbers");
int number1 = Convert.ToInt32(Console.ReadLine());


switch (number1)
{
    case 1:
        Console.WriteLine("You got a new car");
        break;
    case 2:
        Console.WriteLine("You got a new plane");
         break;

    case 3:
        Console.WriteLine("You got a new bike");
         break ;

        default: Console.WriteLine("");
        break;
}                 
